using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reflection;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;
using Elements.Interfaces;
using PropertyChanged;
using PWHelper.Elements;
using ReactiveUI;

namespace Elements.ViewModel.Lists
{
    [AddINotifyPropertyChangedInterface]
    public class DefaultVM : IListPage
    {
        // public DefaultVM(ICollectionView collection, ItemProperty[] itemProperties)
        // {
        //     Items = collection;
        //     Fields = itemProperties;
        //     FieldsView = CollectionViewSource.GetDefaultView(Fields);
        // }

        public DefaultVM(ICollectionView collection, Element.Item[] items)
        {
            ItemsView = collection;
            Items = items;
            //Props = props;
            //Fields = props[0].Properties;

            FieldsView = CollectionViewSource.GetDefaultView(getFields());
        }

        public ItemProperty[] getFields()
        {
            var properties = Items[0].Fields.GetType().GetProperties();
            if (properties != null)
            {
                var props = new ItemProperty[properties.Length];
                for (var j = 0; j < properties.Length; j++)
                {
                    props[j] = new ItemProperty
                    {
                        Name = properties[j].Name,
                        Value = properties[j].GetValue(Items[0].Fields, null),
                        Type = properties[j]
                    };
                }
                ItemProperty.CurrentItem = Items[0].Fields;
                return props;

            }

            return null;

        }

        public ItemProperty SelectItem { get; set; }
        public ICollectionView ItemsView { get; set; }
        public ItemProperty[] Fields { get; set; }
        public Element.Item[] Items { get; set; }
        public ICollectionView FieldsView { get; set; }

        public void ChangeValues(Element.Item[] items, ItemProperty[] fieldsProperties, object value)
        {
            if (fieldsProperties.Length > 0)
            {
                var fieldsName = new string[fieldsProperties.Length];
                for (var i = 0; i < fieldsProperties.Length; i++)
                {
                    fieldsName[i] = fieldsProperties[i].Name;
                        //fieldsProperties[i].Value = value == "" ? fieldsProperties[i].Type.PropertyType.Name == "String" ? "" : "0" : value.ToString();
                }

                foreach (var item in items)
                {
                    PropertyInfo[] propsItem = item.Fields.GetType().GetProperties();

                    foreach (var propertyInfo in propsItem)
                    {
                        if (fieldsName.Contains(propertyInfo.Name))
                        {
                            propertyInfo.SetValue(item.Fields, 
                                ItemProperty.GetTypeValue(propertyInfo.PropertyType.Name, value == "" ? propertyInfo.PropertyType.Name == "String" ? "" : "0" : value.ToString()));
                        }
                    }
                }
            }
        }

        public ICommand ClearField =>
            ReactiveCommand.Create(() =>
            {
                // if (_selectedFields.Length > 0)
                // {
                //     // foreach (var prop in Props)
                //     // {
                //     //     foreach (var field in _selectedFields)
                //     //     {
                //     //         field.Value = field.Type.PropertyType.Name == "String" ? "" : "0";
                //     //     }
                //     // }
                //
                //     var fieldsName = new string[_selectedFields.Length];
                //
                //     for (var i = 0; i < _selectedFields.Length; i++) fieldsName[i] = _selectedFields[i].Name;
                //
                //     foreach (var field in _selectedFields)
                //     {
                //         field.Value = field.Type.PropertyType.Name == "String" ? "" : "0";
                //     }
                //
                //     foreach (var item in Items)
                //     {
                //         //ItemProperty.CurrentItem = item.Fields;
                //         PropertyInfo[] propsItem = item.Fields.GetType().GetProperties();
                //
                //         foreach (var propertyInfo in propsItem)
                //         {
                //             if (fieldsName.Contains(propertyInfo.Name))
                //             {
                //                 propertyInfo.SetValue(item.Fields,
                //                     ItemProperty.GetTypeValue(propertyInfo.PropertyType.Name,
                //                         propertyInfo.PropertyType.Name == "String" ? "" : "0"));
                //             }
                //         }
                //
                //
                //         //field.Value = field.Type.PropertyType.Name == "String" ? "" : "0";
                //     }
                //
                //
                // }

                ChangeValues(Items, _selectedFields, "");

                FieldsView.Refresh();
                ItemsView.Refresh();
            });

        private ItemProperty[] _selectedFields;

        public ReactiveCommand<IList, Unit> SelectedFieldsCommand => ReactiveCommand.Create<IList>(obj =>
        {
            _selectedFields = new ItemProperty[obj.Count];
            for (var i = 0; i < _selectedFields.Length; i++) _selectedFields[i] = (ItemProperty) obj[i];
        });


        public ICommand ChangeItem =>
            ReactiveCommand.Create(() =>
            {
                ItemsView.Refresh();
            });
    }
}