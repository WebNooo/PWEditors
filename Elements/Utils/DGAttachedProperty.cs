using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Elements.Utils
{
    public class DgAttachedProperty
    {
        #region ITEM

        public static readonly DependencyProperty SelectingItemProperty = DependencyProperty.RegisterAttached(
            "SelectingItem",
            typeof(object),
            typeof(DgAttachedProperty),
            new PropertyMetadata(default(object), OnSelectingItemChanged));

        public static object GetSelectingItem(DependencyObject target)
        {
            return (object) target.GetValue(SelectingItemProperty);
        }

        public static void SetSelectingItem(DependencyObject target, object value)
        {
            target.SetValue(SelectingItemProperty, value);
        }

        static void OnSelectingItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is DataGrid grid)
            {
                if (grid.SelectedItem != null)
                {
                    grid.Dispatcher.InvokeAsync(() =>
                    {
                        if (grid.SelectedItem != null)
                        {
                            grid.UpdateLayout();
                            grid.ScrollIntoView(grid.SelectedItem, null);
                        }
                    });
                }
            }
        }

        #endregion

        #region ITEMS

        public static readonly DependencyProperty ItemsProperty = DependencyProperty.RegisterAttached(
            "SelectedItems",
            typeof(object),
            typeof(DgAttachedProperty),
            new PropertyMetadata(default, OnSelectItems));


        public static IList GetSelectedItems(DependencyObject target)
        {
            return (IList) target.GetValue(ItemsProperty);
        }

        public static void SetSelectedItems(DependencyObject target, object value)
        {
            target.SetValue(ItemsProperty, value);
        }

        static void OnSelectItems(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is DataGrid grid)
            {
                grid.SelectedItems.Clear();
                var items = GetSelectedItems(sender);
                if (items != null)
                {
                    grid.Dispatcher.InvokeAsync(() =>
                    {
                        if (items.Count > 1000)
                        {
                            grid.SelectedItem = items[0];
                        }
                        else
                        {
                            foreach (var item in items)
                            {
                                grid.SelectedItems.Add(item);
                            }

                        }
                        

                        if (items.Count > 0)
                        {
                            grid.UpdateLayout();
                            grid.ScrollIntoView(items[0] ?? 0, null);
                        }
                    });
                }
            }
        }

        #endregion
    }
}