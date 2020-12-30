using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using DynamicData;
using Elements.Interfaces;
using PropertyChanged;
using PWHelper.Elements;
using ReactiveUI;

namespace Elements.ViewModel.Lists
{
    [AddINotifyPropertyChangedInterface]
    public class NpcMakeVm : IListPage
    {
        public NpcMakeVm()
        {
            // Items = collection;
            // Fields = itemProperties;
           // _currentItem = Fields[0];
          //  LoadFields();
        }


        public ItemProperty[][] ItemProperties { get; set; }

        public ICollectionView PageItems { get; set; }
        public  void SetSelectedItem(IList items)
        {
            // ItemProperties = new ItemProperty[items.Length][];
            //
            // var index = 0;
            // foreach (var item in items)
            // {
            //     var properties = item.Fields.GetType().GetProperties();
            //     ItemProperties[index] = new ItemProperty[properties.Length];
            //     for (var i = 0; i < properties.Length; i++)
            //     {
            //         ItemProperties[index][i] = new ItemProperty
            //         {
            //             Name = properties[i].Name,
            //             Value = properties[i].GetValue(item.Fields)
            //         };
            //     }
            //
            //     index++;
            // }
            //
            // PageItems = CollectionViewSource.GetDefaultView(ItemProperties[0]);
          
        }

        public void SetSelectedField(int index)
        {
            SelectedFieldIndex = index;
        }

        public int SelectedFieldIndex { get; set; }

        //public void SetSelectedItems(Element.Item[] items)
        // {
        //  Console.WriteLine(items);
        //}

        // public ICollectionView Items { get; set; }
        // //public dynamic Fields { get; set; }
        // private Element.Item _currentItem;
        // private int _currentIndex;
        // private object _selectedValue;
        //
        // public int CurrentIndex
        // {
        //     get => _currentIndex;
        //     set { _currentIndex = value; }
        // }
        //
        //
        // public int IdMakeSkill
        // {
        //     get => _currentItem.Fields.id_make_skill;
        //     set => _currentItem.Fields.id_make_skill = value;
        // }
        //
        // public int ProduceType
        // {
        //     get => _currentItem.Fields.produce_type;
        //     set => _currentItem.Fields.produce_type = value;
        // }
        //
        // public static ItemProperty[] Props { get; set; }
        // public ICollectionView PageItems { get; set; }
        //
        // public object SelectedValue
        // {
        //     get => _selectedValue;
        //     set
        //     {
        //         _selectedValue = value;
        //         //PageItems.Refresh();
        //     }
        // }
        //
        // public void LoadFields()
        // {
        //     Props = new ItemProperty[_currentItem.Fields.Pages[CurrentIndex].Recipes.Length];
        //     var i = 0;
        //     var l = 1;
        //     var li = 0;
        //     foreach (var recipe in _currentItem.Fields.Pages[CurrentIndex].Recipes)
        //     {
        //         var wp = new WrapPanel
        //         {
        //             VerticalAlignment = VerticalAlignment.Center,
        //             Background = new SolidColorBrush(Color.FromRgb(50, 200, 150))
        //         };
        //
        //         string name = Element.Recipes.ContainsKey(recipe.id) ? Element.Recipes[recipe.id].Fields.Name : ". . .";
        //
        //         if (name != ". . .")
        //         {
        //             wp.Children.Add(new Image {Width = 20, Height = 20, Source = Element.Essences[Element.Recipes[recipe.id].Fields.targets_1_id_to_make].Icon});
        //         }
        //
        //         wp.Children.Add(new TextBlock
        //         {
        //             Text = name,
        //             Margin = new Thickness(5, 0, 0, 0),
        //             VerticalAlignment = VerticalAlignment.Center
        //         });
        //
        //         Props[i] = new ItemProperty
        //         {
        //             Name = $"Рецепт [{CurrentIndex+1}-{i + 1}, линия {l}]: ",
        //             Value = recipe.id,
        //             Control = wp
        //         };
        //
        //         if (li == 7)
        //         {
        //             l++;
        //             li = 0;
        //         }
        //         else
        //         {
        //             li++;
        //         }
        //
        //         i++;
        //     }
        //
        //     PageItems = CollectionViewSource.GetDefaultView(Props);
        // }
        //
        // public ReactiveCommand<object, Unit> ChangeTabIndex => ReactiveCommand.Create<object>(value =>
        // {
        //     CurrentIndex = Convert.ToInt32(value);
        //     LoadFields();
        // });
        //
        // public string Tab1Name
        // {
        //     get => _currentItem.Fields.Pages[0].Title;
        //     set => _currentItem.Fields.Pages[0].Title = value;
        // }
        //
        // public string Tab2Name
        // {
        //     get => _currentItem.Fields.Pages[1].Title;
        //     set => _currentItem.Fields.Pages[1].Title = value;
        // }
        //
        // public string Tab3Name
        // {
        //     get => _currentItem.Fields.Pages[2].Title;
        //     set => _currentItem.Fields.Pages[2].Title = value;
        // }
        //
        // public string Tab4Name
        // {
        //     get => _currentItem.Fields.Pages[3].Title;
        //     set => _currentItem.Fields.Pages[3].Title = value;
        // }
        //
        // public string Tab5Name
        // {
        //     get => _currentItem.Fields.Pages[4].Title;
        //     set => _currentItem.Fields.Pages[4].Title = value;
        // }
        //
        // public string Tab6Name
        // {
        //     get => _currentItem.Fields.Pages[5].Title;
        //     set => _currentItem.Fields.Pages[5].Title = value;
        // }
        //
        // public string Tab7Name
        // {
        //     get => _currentItem.Fields.Pages[6].Title;
        //     set => _currentItem.Fields.Pages[6].Title = value;
        // }
        //
        // public string Tab8Name
        // {
        //     get => _currentItem.Fields.Pages[7].Title;
        //     set => _currentItem.Fields.Pages[7].Title = value;
        // }

    }
}