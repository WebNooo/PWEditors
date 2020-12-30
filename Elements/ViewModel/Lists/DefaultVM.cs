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
using Elements.Utils;
using PropertyChanged;
using PWHelper.Elements;
using PWHelper.Elements.Versions;
using ReactiveUI;

namespace Elements.ViewModel.Lists
{
    [AddINotifyPropertyChangedInterface]
    public class DefaultVm : IListPage
    {
        public DefaultVm()
        {
        }

        public class CheckValue
        {
            public string Value;
            public bool Status;
        }

        public ItemProperty[][] ItemProperties { get; set; }
        public IList Items { get; set; }
        public Dictionary<string, CheckValue> Comparison;
        private int _selectedFieldIndex;
        public ICollectionView FieldsView { get; set; }

        public void SetSelectedItem(IList items)
        {
            Items = items;


            if (Element.CheckRows)
            {
                var props = new ItemProperty[items.Count][];
                Comparison = new Dictionary<string, CheckValue>();
                var redBrush = new SolidColorBrush(Color.FromArgb(100, 255, 119, 119));
                var greedBrush = new SolidColorBrush(Color.FromArgb(100, 109, 248, 123));
                var transparentBrush = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));

                for (var index = 0; index < items.Count; index++)
                {
                    var properties = ((dynamic) items[index])?.Value.Fields.GetType().GetProperties();
                    if (properties != null)
                    {
                        props[index] = new ItemProperty[properties.Length];
                        for (var i = 0; i < properties.Length; i++)
                        {
                            var value = properties[i].GetValue(((dynamic) items[index])?.Value.Fields);

                            var bg = transparentBrush;
                            if (items.Count > 1)
                            {
                                if (index == 0)
                                    Comparison.Add(properties[i].Name,
                                        new CheckValue {Value = value.ToString(), Status = true});
                                else
                                {
                                    if (Comparison[properties[i].Name].Status)
                                    {
                                        if (value.ToString() == Comparison[properties[i].Name].Value) bg = greedBrush;
                                        else
                                        {
                                            Comparison[properties[i].Name].Status = false;
                                            bg = redBrush;
                                        }
                                    }
                                    else bg = redBrush;
                                }
                            }


                            props[index][i] = new ItemProperty
                            {
                                Item = (((dynamic) items[index]).Value).Fields,
                                Name = properties[i].Name,
                                Value = value,
                                Type = properties[i]
                            };

                            if (index == items.Count - 1)
                            {
                                props[index][i].Control = new TextBlock
                                {
                                    Padding = new Thickness(2),
                                    Text = value.ToString(),
                                    Background = bg
                                };
                            }
                        }
                    }
                }

                FieldsView = CollectionViewSource.GetDefaultView(props[items.Count - 1]);
            }
            else
            {
                var properties = ((dynamic) items[0])?.Value.Fields.GetType().GetProperties();
                var props = new ItemProperty[properties.Length];
                for (var i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(((dynamic) items[0])?.Value.Fields);

                    props[i] = new ItemProperty
                    {
                        Item = (((dynamic) items[0]).Value).Fields,
                        Name = properties[i].Name,
                        Value = value,
                        Type = properties[i],
                        Control = new TextBlock
                        {
                            Padding = new Thickness(2),
                            Text = value.ToString(),
                        }
                    };
                }
                FieldsView = CollectionViewSource.GetDefaultView(props);
            }


            //ItemProperty.CurrentItem = (((dynamic)items[items.Count - 1]).Value).Fields;
        }


        // public DefaultVm(ICollectionView collection, IList items)
        // {
        //
        //     SetSelectedItem(items);
        //     //ItemsView = collection;
        //     // Items = items;
        //     //Props = props;
        //     //Fields = props[0].Properties;
        //
        //     // FieldsView = CollectionViewSource.GetDefaultView(getFields());
        // }

        public Button PropertyButton(Type type, PropertyInfo property, object value,
            Dictionary<int, Element.Item> collection)
        {
            if (Attribute.GetCustomAttribute(property, type, false) != null)
            {
                return new Button
                {
                    Content = new TextBlock
                    {
                        TextDecorations = new TextDecorationCollection {TextDecorations.Underline},
                        Text = collection.ContainsKey((int) value)
                            ? collection[(int) value].Fields.Name
                            : "пусто",
                    },

                    HorizontalContentAlignment = HorizontalAlignment.Left,
                };
            }

            return null;
        }

        // public ItemProperty[] getFields()
        // {
        // ItemProperty[] props = null;
        //for (int i = 0; i < Items.Length; i++)
        // {
        // var properties = Items[0].Fields.GetType().GetProperties();
        // if (properties != null)
        // {
        //     props = new ItemProperty[properties.Length];
        //     for (var j = 0; j < properties.Length; j++)
        //     {
        //         var value = properties[j].GetValue(Items[0].Fields, null);
        //
        //         var gg = new ItemProperty
        //         {
        //             Name = properties[j].Name,
        //             Value = value,
        //             Type = properties[j],
        //         };
        //
        //         dynamic defaultControl;

        // if (Attribute.GetCustomAttribute(properties[j], typeof(ItemIdAttribute), false) != null)
        // {
        //     var wp = new WrapPanel();
        //     wp.Children.Add(new Image { Source = Element.Essences.ContainsKey((int)value) ? Element.Essences[(int)value].Icon : Element.UnknownIcon });
        //     wp.Children.Add(new TextBlock
        //     {
        //         FontSize = 12,
        //         Foreground = new SolidColorBrush(Color.FromRgb(0, 100, 255)),
        //         Padding = new Thickness(3, 0, 3, 0),
        //         Text = Element.Essences.ContainsKey((int)value)
        //             ? Element.Essences[(int)value].Fields.Name
        //             : "...",
        //     });
        //     var btn = new Button
        //     {
        //         Content = wp,
        //         Background = new SolidColorBrush(Color.FromArgb(0,0,0,0)),
        //         BorderThickness = new Thickness(0),
        //         HorizontalContentAlignment = HorizontalAlignment.Left,
        //     };
        //     btn.Click += (o, e) =>
        //     {
        //         MessageBox.Show(((Button)o).Content.ToString());
        //     };
        //
        //     defaultControl = btn;
        // }
        // else if (Attribute.GetCustomAttribute(properties[j], typeof(AddonIdAttribute), false) != null)
        // {
        //     var wp = new WrapPanel();
        //     //wp.Children.Add(new Image{Source = Element.Addons.ContainsKey((int)value) ? Element.Addons[(int)value].Icon : Element.UnknownIcon});
        //     wp.Children.Add(new TextBlock
        //     {
        //         FontSize = 12,
        //         Foreground = new SolidColorBrush(Color.FromRgb(0, 100, 255)),
        //         Padding = new Thickness(3, 0, 3, 0),
        //         Text = Element.Addons.ContainsKey((int) value)
        //             ? Element.Addons[(int) value].Fields.Name
        //             : "...",
        //     });
        //     var btn = new Button
        //     {
        //         Content = wp,
        //         Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)),
        //         BorderThickness = new Thickness(0),
        //         HorizontalContentAlignment = HorizontalAlignment.Left,
        //     };
        //     btn.Click += (o, e) =>
        //     {
        //         MessageBox.Show(((Button)o).Content.ToString());
        //     };
        //
        //     defaultControl = btn;
        // }
        // else {
        //             var fd = new TextBlock
        //             {
        //                 Text = value.ToString(),
        //                 //VerticalContentAlignment = VerticalAlignment.Center
        //             };
        //
        //             // fd.TextChanged += (o, e) =>
        //             // {
        //             //     gg.Value = ((TextBox) o).Text;
        //             // };
        //          //   fd.LostFocus += (o, e) => { ItemsView.Refresh(); };
        //             defaultControl = fd;
        //       //  }
        //
        //         props[j] = gg;
        //         props[j].Control = defaultControl;
        //     }
        //
        //     ItemProperty.CurrentItem = Items[0].Fields;
        // }
        // //}
        //
        // return props;
        // }

        // public ItemProperty SelectItem { get; set; }
        public ICollectionView ItemsView { get; set; }

        public void ChangeValues(Element.Item[] items, ItemProperty[] fieldsProperties, object value)
        {
            // if (fieldsProperties.Length > 0)
            // {
            //     var fieldsName = new string[fieldsProperties.Length];
            //     for (var i = 0; i < fieldsProperties.Length; i++)
            //     {
            //         fieldsName[i] = fieldsProperties[i].Name;
            //         fieldsProperties[i].Value = value == ""
            //             ? fieldsProperties[i].Type.PropertyType.Name == "String" ? "" : "0"
            //             : value.ToString();
            //     }
            //
            //     foreach (var item in items)
            //     {
            //         PropertyInfo[] propsItem = item.Fields.GetType().GetProperties();
            //
            //         foreach (var propertyInfo in propsItem)
            //         {
            //             if (fieldsName.Contains(propertyInfo.Name))
            //             {
            //                 propertyInfo.SetValue(item.Fields,
            //                     ItemProperty.GetTypeValue(propertyInfo.PropertyType.Name,
            //                         value == ""
            //                             ? propertyInfo.PropertyType.Name == "String" ? "" : "0"
            //                             : value.ToString()));
            //             }
            //         }
            //     }
            // }
        }

        public ICommand ClearField =>
            ReactiveCommand.Create(() =>
            {

                SetValue("");
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

                // ChangeValues(Items, _selectedFields, "");

                // FieldsView.Refresh();
                // ItemsView.Refresh();
            });

        public IList SelectedFields { get; set; }

        public int SelectedFieldIndex
        {
            get => _selectedFieldIndex;
            set
            {
                _selectedFieldIndex = value;
                Settings.App.SelectedFieldIndex = _selectedFieldIndex;
            }
        }

        public bool EditorField { get; set; }

        private dynamic DefaultControl { get; set; }

        private void SetValue(object value)
        {
            for (var index = 0; index < Items.Count; index++)
            {
                var item = (KeyValuePair<int, Element.Item>)Items[index];
                PropertyInfo[] properties = item.Value.Fields.GetType().GetProperties();

                foreach (var property in properties)
                {
                    foreach (var field in SelectedFields)
                    {
                        var prop = (ItemProperty)field;
                        if (prop.Name == property.Name)
                        {
                            var val = ItemProperty.GetTypeValue(property.PropertyType.Name, value);
                            property.SetValue(item.Value.Fields, val);
                            if (index == 0) prop.Control.Text = val.ToString();

                        }
                    }
                }
            }
        }

        public ICommand RowEditEndingEvent => ReactiveCommand.Create(() =>
        {
            var index = 0;
            var field = SelectedFields[0] as ItemProperty;
            foreach (KeyValuePair<int, Element.Item> item in Items)
            {
                PropertyInfo[] props = item.Value.Fields.GetType().GetProperties();

                foreach (var prop in props)
                {

                    if (prop.Name == field.Name)
                    {
                        prop.SetValue(item.Value.Fields, ItemProperty.GetTypeValue(prop.PropertyType.Name, field.Control.Text));
                        if (index == 0)
                        {
                            DefaultControl.Text = field.Control.Text;
                            field.Control = DefaultControl;
                        }
                        break;
                    }

                }
                index++;
            }
        });


        public ICommand BeginningEditEvent => ReactiveCommand.Create(() =>
        {
            if (SelectedFields[0] is ItemProperty property)
            {
                DefaultControl = property.Control;
                property.Control = new TextBox
                {
                    Text = DefaultControl.Text
                };
            }


            //ItemsView.Refresh();
        });

        public void SetSelectedField(int index)
        {
            SelectedFieldIndex = index;
        }


        public string EditingField { get; set; }

        public ICommand EndEdit => ReactiveCommand.Create(() =>
        {
            SetValue(EditingField);
        });

        public ReactiveCommand<IList, Unit> SelectedFieldsCommand => ReactiveCommand.Create<IList>(obj =>
        {
            SelectedFields = obj;
            if (obj != null && obj.Count > 0)
            {
                EditingField = ((ItemProperty) obj[0])?.Value.ToString();
            }

            //  _selectedFields = new ItemProperty[obj.Count];
            // for (var i = 0; i < _selectedFields.Length; i++) _selectedFields[i] = (ItemProperty) obj[i];
        });
    }
}