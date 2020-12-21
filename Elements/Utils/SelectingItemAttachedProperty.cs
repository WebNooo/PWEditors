using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Elements.Utils
{
    public class SelectingItemAttachedProperty
    {
        public static readonly DependencyProperty SelectingItemProperty = DependencyProperty.RegisterAttached(
            "SelectingItem",
            typeof(object),
            typeof(SelectingItemAttachedProperty),
            new PropertyMetadata(default(object), OnSelectingItemChanged));

        public static object GetSelectingItem(DependencyObject target)
        {
            return (object)target.GetValue(SelectingItemProperty);
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
    }
}
