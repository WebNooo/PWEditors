using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
        
        private readonly ElementHeader header = new ElementHeader();
        private readonly ElementComputerName computerName = new ElementComputerName();
        private readonly ElementHardInfo hardInfo = new ElementHardInfo();


        private readonly ObservableCollection<ElementList> Lists = new ObservableCollection<ElementList>();
        private readonly Dictionary<ID_SPACE, Dictionary<int, ElementItem>> Items = 
            new Dictionary<ID_SPACE, Dictionary<int, ElementItem>>();

        public void Open(string filepath)
        {
            try 
            {
                Binary.ReadFile(filepath);
                header.Load();
                LoadLists();

                var nameSpace = $"PWHelper.Element.Versions";

                var lists = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where((x) => x.Namespace == nameSpace && x.Name != $"V{header.Version}")
                    .Select(type => type.Name); 
            }
            catch(HelperError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Save(string? filepath) 
        {
            using BinaryWriter bw = new BinaryWriter(null);
            header.Timestamp = new DateTime().Millisecond;
            header.Save(bw);
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

        private int LoadItems()
        {
            return 0;
        }

        private void LoadLists()
        {
            try
            {
                var count = Binary.ReadInt32();

                //foreach (var list in )
                //{
                //    LoadItems();
                //}

            }
            catch(HelperError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
