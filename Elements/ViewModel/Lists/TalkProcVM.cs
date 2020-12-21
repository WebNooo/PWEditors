using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Elements.Interfaces;
using PropertyChanged;
using PWHelper.Elements;

namespace Elements.ViewModel.Lists
{
    [AddINotifyPropertyChangedInterface]
    public class TalkProcVM
    {
        public TalkProcVM(ICollectionView collection, dynamic itemProperties)
        {
            Items = collection;
            Fields = itemProperties;
        }

        public ICollectionView Items { get; set; }
        public dynamic Fields { get; set; }
    }
}
