using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PWHelper;
using PWHelper.Tools;
using PWHelper.Tools.Errors;

namespace PWHelper.Element
{
    public class ElementNew
    {

        public short Version { get; set; }
        public short Signature { get; set; }
        public int Timestamp { get; set; }

        private RangeObservableCollection<ElementList> Lists = new();
        private Dictionary<ID_SPACE, ObservableDictionary<int, ElementItem>> Items = new();

        public void Open(string filepath)
        {
            try 
            {
                Binary.ReadFile(null);

            }
            catch(HelperError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Save(string? filepath) 
        {
                
        }

        public void Export()
        {

        }

        public void Import()
        {

        }

        public void Add()
        {

        }

        public void Clone()
        {

        }

        public void Remove()
        {

        }

        public void Search()
        {

        }

        private int ReadItems()
        {
            return 0;
        }
    }
}
