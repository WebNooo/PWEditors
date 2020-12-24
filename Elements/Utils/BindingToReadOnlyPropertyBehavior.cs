using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Xaml.Behaviors;
using PWHelper.Elements;

namespace Elements.Utils
{
    public class BindingToReadOnlyPropertyBehavior : Behavior<DependencyObject>
    {
        public PropertyPath Property { get => binding.Path; set => binding.Path = value; }

        private readonly Binding binding = new Binding("") { Mode = BindingMode.OneWay };

        protected override void OnAttached()
        {
            binding.Source = AssociatedObject;
            BindingOperations.SetBinding(this, SourceProperty, binding);
        }

        /// <summary>Приватное свойство для получения данных 
        /// по заданной привязке</summary>
        private object Source
        {
            get { return (object)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        private static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(object), typeof(BindingToReadOnlyPropertyBehavior), new PropertyMetadata(null, propertyChangedCallback));

        /// <summary>Метод обратного вызова для передачи полученного значения 
        /// в целевую привязку</summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void propertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
            => ((BindingToReadOnlyPropertyBehavior)d).Target = e.NewValue;

        /// <summary>Целевой объект куда должно передаваться значение</summary>
        public object Target
        {
            get => (object)GetValue(TargetProperty);
            set => SetValue(TargetProperty, value);
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetProperty =
            DependencyProperty.Register("Target", typeof(object), typeof(BindingToReadOnlyPropertyBehavior), new PropertyMetadata(null));

    }

    public class DataGridSelectedItemsBehavior : Behavior<DataGrid>
    {
        protected override void OnAttached()
            => AssociatedObject.SelectionChanged += AssociatedObjectSelectionChanged;

        protected override void OnDetaching()
            => AssociatedObject.SelectionChanged -= AssociatedObjectSelectionChanged;

        private void AssociatedObjectSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DataGrid grid)
            {
                grid.Dispatcher.InvokeAsync(() =>
                {
                    var array = new Element.Item[AssociatedObject.SelectedItems.Count];
                    AssociatedObject.SelectedItems.CopyTo(array, 0);
                    SelectedItems = array;
                    grid.UpdateLayout();
                });
            }
           
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register("SelectedItems", typeof(Element.Item[]), typeof(DataGridSelectedItemsBehavior),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Element.Item[] SelectedItems
        {
            get => (Element.Item[])GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }
    }
}
