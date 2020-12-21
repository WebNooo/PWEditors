using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Elements.ViewModel;
using PWHelper.Elements;

namespace Elements.Interfaces
{
    public interface IListPage
    {
        public ICollectionView ItemsView { get; set; }
        public ItemProperty[] Fields { get; set; }
    }
}
