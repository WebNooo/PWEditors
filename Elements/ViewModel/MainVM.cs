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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using Elements.ViewModel.Lists;
using Elements.Views.Lists;
using PropertyChanged;
using PWHelper.Elements;
using ReactiveUI;

namespace Elements.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainVM
    {
        public MainVM()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }


        public Page GetListPage()
        {
            if (SelectedList == null) return new Default();

            return SelectedList.Name switch
            {
                "TALK_PROC" => new TalkProc(),
                _ => new Default()
            };
        }

        #region Vars

        private Element.Item[] DataSearch { get; set; }
        private Element.Item[] _selectedItems;
        private string _oldSearch = "";
        private int _indexSearch;
        private Type _selectedList;
        private Element.Item _selectedSearchItem;
        private Element.Item _selectedLink;

        public long ReadTime { get; set; }
        public Page EditorPage { get; set; }
        public ICollectionView ItemsView { get; set; } = CollectionViewSource.GetDefaultView(Element.Items);
        public ICollectionView LinksView { get; set; }
        public ICollectionView SearchView { get; set; }
        public List<Element.ListInfo> Lists { get; set; }
        public int SearchItemsCount { get; set; }
        public int SelectItemsCount { get; set; }
        public int ItemsCount { get; set; }
        public Element.Item FoundItem { get; set; }
        public Element.Item[] SelectedItems { get => _selectedItems; set => _selectedItems =value; }
        public string SearchText { get; set; }
        public int LinksCount { get; set; }

        public int IndexSearch { get => _indexSearch; set => _indexSearch = value; }
        public Type SelectedList
        {
            get => _selectedList;
            set
            {
                _selectedList = value;
                if (_selectedList == null) return;
                ItemsView.Filter = n =>
                {
                    if (n is Element.Item item)
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

        public Element.Item SelectedLink
        {
            get => _selectedLink;
            set
            {
                _selectedLink = value;

                if (_selectedLink != null)
                {
                    SelectedList = _selectedLink.Type;
                    FoundItem = _selectedLink;
                }
                
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
                    FoundItem = _selectedSearchItem;
                }

            }
        }

        #endregion


        #region Commands

        public ICommand Search =>
            ReactiveCommand.Create(() =>
            {
                if (SearchText != null && SearchText.Length > 1)
                {
                    if (_oldSearch != SearchText.ToLower())
                    {
                        _oldSearch = SearchText.ToLower();
                        DataSearch = Element.Items.Where(n =>
                            n.Fields.id.ToString().Contains(_oldSearch) ||
                            n.Fields.Name.ToLower().Contains(_oldSearch)).ToArray();
                        SearchItemsCount = DataSearch.Length;
                        SearchView = CollectionViewSource.GetDefaultView(DataSearch);
                        _indexSearch = 0;
                    }

                    if (DataSearch != null && DataSearch.Length > _indexSearch)
                    {
                        SelectedList = DataSearch[_indexSearch].Type;
                        FoundItem = DataSearch[_indexSearch];
                        if (DataSearch.Length - 1 == _indexSearch)
                            _indexSearch = 0;
                        else
                            _indexSearch++;
                    }
                }
            });

        public ICommand AddItem =>
            ReactiveCommand.Create(() =>
            {
                if (_selectedItems.Length > 0)
                {
                    SelectedItems = Data.ElementInfo.Add(_selectedItems);
                    ItemsCount = Element.Items.Count;
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
                    Element.Items.RemoveRange(_selectedItems);
                    ItemsCount = Element.Items.Count;
                }
                else
                    MessageBox.Show("Удаление невозможно! Выберете предмет в списке.");
                
            });

        public ICommand Open => ReactiveCommand.Create(() =>
        {
            ItemsView.Refresh();
            ReadTime = Data.Load("elements.data");
            Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
            SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
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
                    _selectedItems[i] = (Element.Item)obj[i];

                if (_selectedItems[0].Space == Element.ID_SPACE.ESSENCE && Data.Links2.ContainsKey((uint)_selectedItems[0].Id))
                {
                    var items = Data.Links2[(uint) _selectedItems[0].Id];
                    LinksCount = items.Count;
                    LinksView = CollectionViewSource.GetDefaultView(items);
                    LinksView.Refresh();
                }
                else
                {
                    LinksCount = 0;
                    LinksView = null;
                }

                // LinksView.Filter = obj =>
                // {
                //     var b = obj as dynamic;
                //     if (b.Key == _se)
                //     {
                //         
                //     }
                //     // Dictionary<uint, List<Element.Item>> v = obj as Dictionary<uint, List<Element.Item>>;
                //     // if (v.Key)
                //     // {
                //     //     
                //     // }
                //
                //
                //     return false;
                // };

                EditorPage.DataContext = new DefaultVM(ItemsView, _selectedItems);
            }
        });

        #endregion



        public ICommand Opens => ReactiveCommand.Create(() =>
        {
            ItemsView.Refresh();
            ReadTime = Data.Load("elements70.data");
            ItemsCount = Element.Items.Count;
            Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
            SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
        });

        public ICommand OpenSave => ReactiveCommand.Create(() =>
        {
            ItemsView.Refresh();
            ReadTime = Data.Load("elements2.data");
            Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
            SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
        });



       
    }
}