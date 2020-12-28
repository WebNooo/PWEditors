using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Elements.Interfaces;
using PropertyChanged;
using PWHelper.Elements;
using PWHelper.Elements.Versions;
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

        public Button PropertyButton(Type type, PropertyInfo property, object value, Dictionary<int, Element.Item> collection)
        {
            if (Attribute.GetCustomAttribute(property, type, false) != null)
            {
                return new Button
                {
                    Content = new TextBlock
                    {
                        TextDecorations = new TextDecorationCollection { TextDecorations.Underline },
                        Text = collection.ContainsKey((int)value)
                            ? collection[(int)value].Fields.Name
                            : "пусто",
                    },

                    HorizontalContentAlignment = HorizontalAlignment.Left,
                };
            }

            return null;
        }

        public ItemProperty[] getFields()
        {
            ItemProperty[] props = null;
            //for (int i = 0; i < Items.Length; i++)
            // {
            var properties = Items[0].Fields.GetType().GetProperties();
            if (properties != null)
            {
                props = new ItemProperty[properties.Length];
                for (var j = 0; j < properties.Length; j++)
                {
                    var value = properties[j].GetValue(Items[0].Fields, null);

                    var gg = new ItemProperty
                    {
                        Name = properties[j].Name,
                        Value = value,
                        Type = properties[j],
                    };

                    dynamic defaultControl;

                    if (Attribute.GetCustomAttribute(properties[j], typeof(ItemIdAttribute), false) != null)
                    {
                        var wp = new WrapPanel();
                        wp.Children.Add(new Image { Source = Element.Essences.ContainsKey((int)value) ? Element.Essences[(int)value].Icon : Element.UnknownIcon });
                        wp.Children.Add(new TextBlock
                        {
                            TextDecorations = new TextDecorationCollection { TextDecorations.Underline },
                            Foreground = new SolidColorBrush(Color.FromRgb(0, 100, 255)),
                            Padding = new Thickness(3, 0, 3, 0),
                            Text = Element.Essences.ContainsKey((int)value)
                                ? Element.Essences[(int)value].Fields.Name
                                : "пусто",
                        });
                        var btn = new Button
                        {
                            Content = wp,
                            Background = new SolidColorBrush(Color.FromArgb(0,0,0,0)),
                            BorderThickness = new Thickness(0),
                            HorizontalContentAlignment = HorizontalAlignment.Left,
                        };
                        btn.Click += (o, e) =>
                        {
                            MessageBox.Show(((Button)o).Content.ToString());
                        };

                        defaultControl = btn;
                    }
                    else if (Attribute.GetCustomAttribute(properties[j], typeof(AddonIdAttribute), false) != null)
                    {
                        var wp = new WrapPanel();
                        wp.Children.Add(new Image{Source = Element.Addons.ContainsKey((int)value) ? Element.Addons[(int)value].Icon : Element.UnknownIcon});
                        wp.Children.Add(new TextBlock
                        {
                            TextDecorations = new TextDecorationCollection {TextDecorations.Underline},
                            Foreground = new SolidColorBrush(Color.FromRgb(0, 100, 255)),
                            Padding = new Thickness(3, 0, 3, 0),
                            Text = Element.Addons.ContainsKey((int) value)
                                ? Element.Addons[(int) value].Fields.Name
                                : "пусто",
                        });
                        var btn = new Button
                        {
                            Content = wp,
                            Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)),
                            BorderThickness = new Thickness(0),
                            HorizontalContentAlignment = HorizontalAlignment.Left,
                        };
                        btn.Click += (o, e) =>
                        {
                            MessageBox.Show(((Button)o).Content.ToString());
                        };

                        defaultControl = btn;
                    }
                    else {
                        var fd = new TextBlock
                        {
                            Text = value.ToString(),
                            //VerticalContentAlignment = VerticalAlignment.Center
                        };

                        // fd.TextChanged += (o, e) =>
                        // {
                        //     gg.Value = ((TextBox) o).Text;
                        // };
                        fd.LostFocus += (o, e) => { ItemsView.Refresh(); };
                        defaultControl = fd;
                    }

                    props[j] = gg;
                    props[j].Control = defaultControl;
                }

                ItemProperty.CurrentItem = Items[0].Fields;
            }
            //}

            return props;
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
                    fieldsProperties[i].Value = value == ""
                        ? fieldsProperties[i].Type.PropertyType.Name == "String" ? "" : "0"
                        : value.ToString();
                }

                foreach (var item in items)
                {
                    PropertyInfo[] propsItem = item.Fields.GetType().GetProperties();

                    foreach (var propertyInfo in propsItem)
                    {
                        if (fieldsName.Contains(propertyInfo.Name))
                        {
                            propertyInfo.SetValue(item.Fields,
                                ItemProperty.GetTypeValue(propertyInfo.PropertyType.Name,
                                    value == ""
                                        ? propertyInfo.PropertyType.Name == "String" ? "" : "0"
                                        : value.ToString()));
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
            ReactiveCommand.Create(() => { ItemsView.Refresh(); });
    }
}