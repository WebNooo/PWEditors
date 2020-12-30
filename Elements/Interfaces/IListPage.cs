using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Elements.ViewModel;
using PWHelper.Elements;

namespace Elements.Interfaces
{
    public interface IListPage
    {
        public void SetSelectedItem(IList items);
        //public void SetSelectedField(int index);
        public int SelectedFieldIndex { get; set; }
    }
}
