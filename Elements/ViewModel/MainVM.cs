using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;
using Elements.ViewModel.Lists;
using Elements.Views.Lists;
using PropertyChanged;
using PWHelper;
using PWHelper.Elements;
using PWHelper.Elements.Versions;
using ReactiveUI;
using MessageBox = System.Windows.MessageBox;

namespace Elements.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public MainVM()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Histories.DisableNotify();
        }


        public Page GetListPage()
        {
            if (SelectedList == null) return new Default();

            return SelectedList.Name switch
            {
                "TALK_PROC" => new TalkProc(),
                "NPC_MAKE_SERVICE" => new NpcMake(),
                _ => new Default()
            };
        }

        public void GetItemPage(ICollectionView itemsView, Element.Item[] _selectedItems)
        {
            EditorPage.DataContext = SelectedList.Name switch
            {
                "TALK_PROC" => new TalkProcVM(itemsView, _selectedItems),
                "NPC_MAKE_SERVICE" => new NpcMakeVM(itemsView, _selectedItems),
                _ => new DefaultVM(itemsView, _selectedItems)
            };
        }

        #region Vars
        private Element.Item[] _selectedItems;
        private string _oldSearch = "";
        private int _indexSearch;
        private Type _selectedList;
        private Element.Item _selectedSearchItem;
        private Data.link _selectedLink;
        private KeyValuePair<int, Element.Item> _foundItem;

        public long ReadTime { get; set; }
        public Page EditorPage { get; set; }
        public ICollectionView ItemsView { get; set; }
        public ICollectionView LinksView { get; set; }
        public ICollectionView SearchView { get; set; }
        public List<Element.ListInfo> Lists { get; set; }
        public int SearchItemsCount { get; set; }
        public int SelectItemsCount { get; set; }
        public int ItemsCount { get; set; }
        public int SelectedPanelIndex { get; set; }


        public KeyValuePair<int, Element.Item> FoundItem
        {
            get => _foundItem;
            set
            {
                _foundItem = value;
                if (_foundItem.Value!= null)
                {
                    addHistory(new History {Item = _foundItem, List = _foundItem.Value.Type, Type = HistoryType.CHANGE_ITEM});
                }
            }
        }

        public Element.Item[] SelectedItems
        {
            get => _selectedItems;
            set => _selectedItems = value;
        }

        public string SearchText { get; set; }
        public int LinksCount { get; set; }

        public int IndexSearch
        {
            get => _indexSearch;
            set => _indexSearch = value;
        }

        public int MaxId { get; set; }

        public Type SelectedList
        {
            get => _selectedList;
            set
            {
                _selectedList = value;
                //addHistory(new History { Item = null, List = _selectedList, Type = HistoryType.CHANGE_LIST });
                if (_selectedList == null) return;
                var items = Element.GetItems(_selectedList.Name);
                ItemsView = CollectionViewSource.GetDefaultView(items);
                MaxId = items.Keys.Max();
                ItemsView.Filter = n =>
                {
                    dynamic b = n;
                    if (b.Value is Element.Item item)
                    {
                        if (item.Type == _selectedList)
                        {
                            return true;
                        }
                    }

                    return false;
                };

                EditorPage = GetListPage();
            }
        }

        public Data.link SelectedLink
        {
            get => _selectedLink;
            set
            {
                _selectedLink = value;
                if (_selectedLink != null)
                {
                    SelectedList = _selectedLink.item.Type;
                    // FoundItem = _selectedLink.item;
                    SelectedPanelIndex = 0;
                }
            }
        }

        public enum HistoryType
        {
            ADD,
            REMOVE,
            CHANGE_LIST,
            CHANGE_ITEM,
            SEARCH
        }

        private static int _historyIndex = 0;

        public static int GetHI
        {
            get => _historyIndex;
            set => _historyIndex = value;
        }

        public class History
        {
            public History()
            {
                //
                if (!isHistory)
                {
                    GetHI = Histories.Count;
                }
            }

            public KeyValuePair<int, Element.Item> Item { get; set; }
            public Type List { get; set; }
            public int SelectedItemRow { get; set; }
            public HistoryType Type { get; set; }
        }

        public static RangeObservableCollection<History> Histories = new RangeObservableCollection<History>();

        public static bool isHistory = false;

        public void addHistory(History history)
        {
            if (!isHistory)
            {
                Histories.Add(history);
            }
        }

        public Element.Item SelectedSearchItem
        {
            get => _selectedSearchItem;
            set
            {
                _selectedSearchItem = value;
                if (_selectedSearchItem != null)
                {
                    SelectedList = _selectedSearchItem.Type;
                    // FoundItem = _selectedSearchItem;
                    //addHistory(new History{Item = _selectedSearchItem, List = _selectedSearchItem.Type, Type = HistoryType.SEARCH});
                }
            }
        }

        #endregion

        public ICommand HistoryBack => ReactiveCommand.Create(() =>
        {
            isHistory = true;
            GetHI--;

            if (GetHI < 0)
            {
                GetHI = 0;
            }

            if (Histories.Count > 0)
            {
                var history = Histories[GetHI];
                if (history.Type == HistoryType.CHANGE_ITEM)
                {
                    SelectedList = history.List;
                    FoundItem = history.Item;
                }

                // if (history.Type == HistoryType.CHANGE_LIST)
                // {
                //     SelectedList = history.List;
                //     FoundItem = null;
                // }
            }

            isHistory = false;
        });

        public ICommand HistoryNext => ReactiveCommand.Create(() =>
        {
            isHistory = true;
            GetHI++;
             if (GetHI > Histories.Count)
             {
                 GetHI = Histories.Count;
             }

            if (Histories.Count > 0)
            {
                var history = Histories[GetHI];
                if (history.Type == HistoryType.CHANGE_ITEM)
                {
                    SelectedList = history.List;
                    FoundItem = history.Item;
                }

                // if (history.Type == HistoryType.CHANGE_LIST)
                // {
                //     SelectedList = history.List;
                //     FoundItem = null;
                // }
            }

            isHistory = false;
        });


        #region Commands

        public List<KeyValuePair<int, Element.Item>> DataSearch = new List<KeyValuePair<int, Element.Item>>();

        //SEARCH ITEMS WORK
        public ICommand Search =>
            ReactiveCommand.Create(() =>
            {
                if (SearchText != null && SearchText.Length > 1)
                {
                    if (_oldSearch != SearchText.ToLower())
                    {
                        DataSearch.Clear();
                        SearchView?.Refresh();

                        _oldSearch = SearchText.ToLower();

                        DataSearch.AddRange(Element.Addons.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Essences.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Configs.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Faces.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Recipes.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Talks.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());
                        DataSearch.AddRange(Element.Homes.Where(n =>
                            n.Value.Id.ToString().Contains(SearchText) ||
                            n.Value.Fields.Name.ToLower().Contains(_oldSearch)).ToArray());

                        SearchItemsCount = DataSearch.Count;
                        SearchView = CollectionViewSource.GetDefaultView(DataSearch);

                        _indexSearch = 0;
                    }

                    if (DataSearch != null && DataSearch.Count > _indexSearch)
                    {
                        SelectedList = DataSearch[_indexSearch].Value.Type;
                        FoundItem = DataSearch[_indexSearch];
                        _indexSearch = (DataSearch.Count - 1 == _indexSearch) ? 0 : _historyIndex++;
                    }
                }
            });

        public ICommand AddItem =>
            ReactiveCommand.Create(() =>
            {
                if (_selectedItems.Length > 0)
                {
                    SelectedItems = Data.ElementInfo.Add(_selectedItems);
                    //addHistory(new History { Item = _selectedItems[0], List = _selectedItems[0].Type, Type = HistoryType.ADD });
                    //ItemsCount = Element.Items.Count;
                    ItemsView.Refresh();
                }
                else
                    MessageBox.Show("Вы не выбрали предмет для клонирования");
            });

        public ICommand RemoveItem =>
            ReactiveCommand.Create(() =>
            {
                if (_selectedItems != null && _selectedItems.Length > 0)
                {
                    //Element.Items.RemoveRange(_selectedItems);
                    //addHistory(new History { Item = _selectedItems[0], List = _selectedItems[0].Type, Type = HistoryType.REMOVE });
                   // ItemsCount = Element.Items.Count;
                }
                else
                    MessageBox.Show("Удаление невозможно! Выберете предмет в списке.");
            });

        public ICommand Open => ReactiveCommand.Create(() =>
        {

            var dialog = new OpenFileDialog
            {
                Filter = "Elements.data|*elements*.data|Data files (*.data)|*.data|All Files (*.*)|*.*"
            };
            var dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                ReadTime = Data.Load(dialog.FileName);
                Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
                SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
            }


            
        });

        public ICommand Save => ReactiveCommand.Create(() =>
        {
            Data.Save();
            MessageBox.Show("Save");
        });


        public ReactiveCommand<IList, Unit> SelectedItemsCommand => ReactiveCommand.Create<IList>(obj =>
        {
            if (obj != null && obj.Count > 0)
            {
                _selectedItems = new Element.Item[obj.Count];
                SelectItemsCount = _selectedItems.Length;

                for (var i = 0; i < _selectedItems.Length; i++)
                    _selectedItems[i] = (Element.Item) ((dynamic) obj[i])?.Value;

                //addHistory(new History { Item = _selectedItems[0], List = _selectedItems[0].Type, Type = HistoryType.CHANGE_ITEM });

                if (_selectedItems[0].Space == Element.ID_SPACE.ESSENCE &&
                    Data.LinksEssence.ContainsKey(_selectedItems[0].Id))
                {
                    var items = Data.LinksEssence[_selectedItems[0].Id];
                    LinksCount = items.Count;
                    LinksView = CollectionViewSource.GetDefaultView(items);
                    LinksView?.Refresh();
                }
                else if (_selectedItems[0].Space == Element.ID_SPACE.ADDON &&
                         Data.LinksAddon.ContainsKey(_selectedItems[0].Id))
                {
                    var items = Data.LinksAddon[_selectedItems[0].Id];
                    LinksCount = items.Count;
                    LinksView = CollectionViewSource.GetDefaultView(items);
                    LinksView?.Refresh();
                }
                else
                {
                    LinksCount = 0;
                    LinksView = null;
                }

                GetItemPage(ItemsView, _selectedItems);
               // EditorPage.DataContext = new DefaultVM(ItemsView, _selectedItems);
            }
        });

        #endregion


        public ICommand Opens => ReactiveCommand.Create(() =>
        {
            //ItemsView.Refresh();
            ReadTime = Data.Load("elements70.data");
            //ItemsCount = Element.Items.Count;
            Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
            SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
        });
    }
}