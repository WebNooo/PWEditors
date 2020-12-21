using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
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

        private Element.Item _selectItem;

        public Element.Item SelectItem
        {
            get => _selectItem;
            set
            {
                 _selectItem = value;
                // if (_selectItem == null) return;
                // var properties = _selectItem.Fields.GetType().GetProperties();
                // var itemProperties = new ItemProperty[properties.Length];
                // for (var i = 0; i < properties.Length; i++)
                // {
                //     itemProperties[i] = new ItemProperty
                //     {
                //         Name = properties[i].Name,
                //         Value = properties[i].GetValue(_selectItem.Fields, null),
                //         Type = properties[i]
                //     };
                // }

                //ItemProperty.CurrentItem = _selectItem.Fields;
                // EditorPage.DataContext = SetItem(itemProperties);
                //ItemFields = itemProperties;
            }
        }

        public Element.Item[] SelectItems { get; set; }


        public long ReadTime { get; set; }
        public Page EditorPage { get; set; }
        public ICollectionView ItemsView { get; set; } = CollectionViewSource.GetDefaultView(Element.Items);
        public List<Element.ListInfo> Lists { get; set; }

        private Type _selectedList;

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

        private Element.Item[] _selectedItems;


        // public object SetItem(ItemProperty[] itemProperties)
        // {
        //    // if (SelectedList == null)
        //     //    return new DefaultVM(ItemsView, itemProperties);
        //
        //     // return SelectedList.Name switch
        //     // {
        //     //     "TALK_PROC" => new TalkProcVM(ItemsView, SelectItem.Fields),
        //     //     _ => new DefaultVM(ItemsView, itemProperties)
        //     // };
        // }

        public Page GetListPage()
        {
            if (SelectedList == null) return new Default();

            return SelectedList.Name switch
            {
                "TALK_PROC" => new TalkProc(),
                _ => new Default()
            };
        }

        private string _oldSearch = "";
        private int _indexSearch;
        private List<Element.Item> _dataSearch = new List<Element.Item>();
        public string SearchText { get; set; }

        public ICommand Search =>
            ReactiveCommand.Create(() =>
            {
                if (SearchText.Length > 1)
                {
                    if (_oldSearch != SearchText)
                    {
                        _oldSearch = SearchText;
                        _dataSearch.Clear();
                        _dataSearch = Element.Items.Where(n =>
                            n.Fields.id.ToString().Contains(_oldSearch) || n.Fields.Name.Contains(_oldSearch)).ToList();
                        _indexSearch = 0;
                    }

                    if (_dataSearch != null && _dataSearch.Count > _indexSearch)
                    {
                        SelectedList = _dataSearch[_indexSearch].Type;
                        SelectItem = _dataSearch[_indexSearch];
                        if (_dataSearch.Count - 1 == _indexSearch)
                            _indexSearch = 0;
                        else
                            _indexSearch++;
                    }
                }
            });

        public ICommand AddItem =>
            ReactiveCommand.Create(() =>
            {
                if (_selectItem != null)
                {
                    Data.ElementInfo.Add(_selectedList, _selectItem);
                    ItemsView.Refresh();
                }
                else
                    MessageBox.Show("Вы не выбрали предмет для клонирования");
            });

        public ICommand RemoveItem =>
            ReactiveCommand.Create(() =>
            {
                if (_selectedItems.Length > 0)
                {
                    Element.Items.RemoveRange(_selectedItems);
                }
            });

        public ICommand Open => ReactiveCommand.Create(() =>
        {
            ItemsView.Refresh();
            ReadTime = Data.Load("elements.data");
            Lists = new List<Element.ListInfo>(Data.ElementInfo.ListInformation);
            SelectedList = Data.ElementInfo.ListInformation.Count > 0 ? Data.ElementInfo.ListInformation[0].Type : null;
        });

        public ICommand Opens => ReactiveCommand.Create(() =>
        {
            ItemsView.Refresh();
            ReadTime = Data.Load("elements70.data");
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

        public ICommand Save => ReactiveCommand.Create(() =>
        {
            Data.Save();
            MessageBox.Show("Save");
        });


        public ReactiveCommand<IList, Unit> SelectedItemsCommand => ReactiveCommand.Create<IList>(obj =>
        {
            if (obj.Count > 0)
            {
                _selectedItems = new Element.Item[obj.Count];
                for (var i = 0; i < _selectedItems.Length; i++)
                    _selectedItems[i] = (Element.Item) obj[i];
                

                EditorPage.DataContext = new DefaultVM(ItemsView, _selectedItems);
            }
        });
    }
}