using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Threading;
using PWHelper.Elements;

namespace PWHelper
{
    public class RangeObservableCollection<T> : ObservableCollection<T>
    {
        public bool SuppressNotification { get; set; } = false;

        public void ResetNotify() =>
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));


        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (!SuppressNotification)
                base.OnCollectionChanged(e);
        }

        public void AddRange(IEnumerable<T> list)
        {
            if (list == null) return;

            SuppressNotification = true;

            foreach (var item in list)
            {
                Add(item);
            }

            SuppressNotification = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void DisableNotify()
        {
            SuppressNotification = true;
        }

        public void EnableNotify()
        {
            SuppressNotification = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void RemoveRange(T[] list)
        {
            SuppressNotification = true;
            foreach (var item in list)
            {
                Remove(item);
            }

            SuppressNotification = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}