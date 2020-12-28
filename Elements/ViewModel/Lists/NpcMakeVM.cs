using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using PropertyChanged;
using PWHelper.Elements;
using ReactiveUI;

namespace Elements.ViewModel.Lists
{
    [AddINotifyPropertyChangedInterface]
    class NpcMakeVM
    {
        public NpcMakeVM(ICollectionView collection, dynamic itemProperties)
        {
            Items = collection;
            Fields = itemProperties;
            _currentItem = Fields[0];
            LoadFields();
        }

        public ICollectionView Items { get; set; }
        public dynamic Fields { get; set; }
        private Element.Item _currentItem;
        private int _currentIndex;

        public int CurrentIndex
        {
            get => _currentIndex;
            set { _currentIndex = value; }
        }


        public int IdMakeSkill
        {
            get => _currentItem.Fields.id_make_skill;
            set => _currentItem.Fields.id_make_skill = value;
        }

        public int ProduceType
        {
            get => _currentItem.Fields.produce_type;
            set => _currentItem.Fields.produce_type = value;
        }

        public static ItemProperty[] Props { get; set; }
        public ICollectionView PageItems { get; set; }

        public void LoadFields()
        {
            Props = new ItemProperty[_currentItem.Fields.Pages[CurrentIndex].Recipes.Length];
            var i = 0;
            foreach (var recipe in _currentItem.Fields.Pages[CurrentIndex].Recipes)
            {
                var wp = new WrapPanel
                {
                    VerticalAlignment = VerticalAlignment.Center
                };

                string name = Element.Recipes.ContainsKey(recipe.id) ? Element.Recipes[recipe.id].Fields.Name : "...";

                if (name != "...")
                {
                    wp.Children.Add(new Image
                    {
                        Width = 20,
                        Height = 20,
                        Source = Element.Essences[Element.Recipes[recipe.id].Fields.targets_1_id_to_make].Icon
                    });
                }

                wp.Children.Add(new TextBlock
                {
                    Text = name,
                    Margin = new Thickness(5, 0, 0, 0)
                });



                Props[i] = new ItemProperty
                {
                    Name = $"Рецепт [{CurrentIndex}-{i + 1}]",
                    Value = recipe.id,
                    Control = wp
                };
                i++;
            }

            PageItems = CollectionViewSource.GetDefaultView(Props);
        }

        public ReactiveCommand<object, Unit> ChangeTabIndex => ReactiveCommand.Create<object>(value =>
        {
            CurrentIndex = Convert.ToInt32(value);
            LoadFields();
        });

        public string Tab1Name
        {
            get => _currentItem.Fields.Pages[0].Title;
            set => _currentItem.Fields.Pages[0].Title = value;
        }

        public string Tab2Name
        {
            get => _currentItem.Fields.Pages[1].Title;
            set => _currentItem.Fields.Pages[1].Title = value;
        }

        public string Tab3Name
        {
            get => _currentItem.Fields.Pages[2].Title;
            set => _currentItem.Fields.Pages[2].Title = value;
        }

        public string Tab4Name
        {
            get => _currentItem.Fields.Pages[3].Title;
            set => _currentItem.Fields.Pages[3].Title = value;
        }

        public string Tab5Name
        {
            get => _currentItem.Fields.Pages[4].Title;
            set => _currentItem.Fields.Pages[4].Title = value;
        }

        public string Tab6Name
        {
            get => _currentItem.Fields.Pages[5].Title;
            set => _currentItem.Fields.Pages[5].Title = value;
        }

        public string Tab7Name
        {
            get => _currentItem.Fields.Pages[6].Title;
            set => _currentItem.Fields.Pages[6].Title = value;
        }

        public string Tab8Name
        {
            get => _currentItem.Fields.Pages[7].Title;
            set => _currentItem.Fields.Pages[7].Title = value;
        }
    }
}