﻿using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Elements.Utils
{
    public class NDataGrid : DataGrid
    {
        public NDataGrid()
        {
            SelectionChanged += CustomDataGrid_SelectionChanged;
        }

        private void CustomDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedItemsList = SelectedItems;
        }

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }

        public static readonly DependencyProperty SelectedItemsListProperty =
            DependencyProperty.Register("SelectedItemsList", typeof(IList), typeof(NDataGrid),
                new PropertyMetadata(null));

    }
}
