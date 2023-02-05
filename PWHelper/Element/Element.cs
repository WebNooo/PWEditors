using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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


        private ObservableCollection<ElementList> Lists;
        private readonly Dictionary<ID_SPACE, Dictionary<int, ElementItem>> Items = 
            new Dictionary<ID_SPACE, Dictionary<int, ElementItem>>();

        public ElementList SelectedList { get; set; }

        public void Open(string filepath)
        {
            try 
            {
                var timer = new Stopwatch();
                timer.Start();
                Binary.ReadFile(filepath);
                header.Load();

                foreach (ID_SPACE space in Enum.GetValues(typeof(ID_SPACE))) {
                    Items.Add(space, null);
                }

                LoadLists();
                timer.Stop();
                MessageBox.Show(timer.ElapsedMilliseconds.ToString());
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

        public void GetList()
        {

        }

        public ObservableCollection<ElementList> GetLists()
        {
            return Lists;
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
                Lists = new ObservableCollection<ElementList>();

                var listIndex = 0;
                foreach (var list in header.GetStructures())
                {
                    if (ElementConstants.ComputerNameIndex == listIndex) computerName.Load();
                    if (ElementConstants.HardInfoIndex == listIndex) hardInfo.Load();

                    var space = ElementConstants.Spaces[list.Name];
                    var elementList = new ElementList() 
                    { 
                        Name = list.Name, 
                        Id = listIndex, 
                        Space = space, 
                        Type = list,
                    };

                    Items[space] = new Dictionary<int, ElementItem>();
                     
                    elementList.Load(Items[space]);
                    Lists.Add(elementList);

                    listIndex++;
                }

            }
            catch(HelperError ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
