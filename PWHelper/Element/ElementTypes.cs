using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PWHelper.Element
{
    public class ElementList
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public ID_SPACE Space { get; set; }

        //public RangeObservableCollection<ElementItem> Items = new();
    }

    public class ElementItem
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public ID_SPACE Space { get; set; }
        public dynamic Fields { get; set; }
        public ImageSource Icon { get; set; }
    }

    public class ElementItems
    {
        public ID_SPACE Space { get; set; }

        private ObservableDictionary<int, ElementItem> Items = new();
    }

    internal class ObservableDictionary<TKey, TValue>
    {
    }

    public class ElementField
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }

    public class ComputerName
    {
        public int Tag;
        public int Length;
        public byte[] Name;
        public int Time;
    }

    public class HardInfo
    {
        public int Tag;
        public int Length;
        public byte[] Buffer;
    }

    internal class ElementType
    {

    }
}
