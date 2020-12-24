using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using PWHelper.Elements.Versions;

namespace PWHelper.Elements
{
    public class Data
    {
        public static Element ElementInfo = new Element();

        public static void Save()
        {
            using var stream = new FileStream("elements2.data", FileMode.OpenOrCreate);
            ElementInfo.Bw = new BinaryWriter(stream);

            ElementInfo.WriteHeader(ElementInfo.Bw);

            for (var index = 0; index < ElementInfo.ListInformation.Count; index++)
            {
                if (ElementInfo.Structure.ComputerNameIndex == index) ElementInfo.WriteComputerName(ElementInfo.Bw);
                if (ElementInfo.Structure.HardInfoIndex == index) ElementInfo.WriteHardInfo(ElementInfo.Bw);

                ElementInfo.Serialize(ElementInfo.ListInformation[index].Type);
            }
        }

        public class link
        {
            public string type { get; set; }
            public Element.Item item { get; set; }
        }

        public static RangeObservableCollection<link> Links { get; set; } = new RangeObservableCollection<link>();
        public static Dictionary<uint, List<Element.Item>> Links2 { get; set; } = new Dictionary<uint, List<Element.Item>>();

        public static long Load(string fileName)
        {
            var s = new Stopwatch();
            s.Start();

            Task.Factory.StartNew(Icons.LoadIcons);


            BinReader.Clear();
            BinReader.Source = File.ReadAllBytes(fileName);

            Element.Items.Clear();
            ElementInfo.ListInformation.Clear();

            ElementInfo.ReadHeader();

            var version = $"PWHelper.Elements.Versions._{ElementInfo.Version}";
            var configLists = ElementInfo.GetStructureTypes(version);

            ElementInfo.Structure = (IStructure) ElementInfo.GetInstance($"{version}.Structure");

            var index = 0;
            Element.Items.DisableNotify();
            foreach (var value in configLists)
            {
                if (ElementInfo.Structure.ComputerNameIndex == index) ElementInfo.ReadComputerName();
                if (ElementInfo.Structure.HardInfoIndex == index) ElementInfo.ReadHardInfo();
                ElementInfo.RegisterStruct(Type.GetType($"{version}.{value}", false, true), $"{index + 1} - {value}");
                index++;
            }

            Element.Items.EnableNotify();

            Element.UnknownIcon = Icons.GetImage(0);

            new Thread(() =>
            {
                Element.Items.All(n =>
                {

                    if (n.Type.Name == "RECIPE_ESSENCE" || n.Type.Name == "NPC_SELL_SERVICE")
                    {
                        //fields = ;
                        PropertyInfo[] fields = n.Fields.GetType().GetProperties();
                        fields.All(x =>
                        {
                            if (x.PropertyType.Name == "UInt32")
                            {
                                uint t = x.GetValue(n.Fields, null);
                                if (t > 0)
                                {
                                    if (Links2.ContainsKey(t))
                                    {
                                        Links2[t].Add(n);
                                    }
                                    else
                                    {
                                        Links2.Add(t, new List<Element.Item> { n });
                                    }
                                }
                            }

                            return true;
                        });
                    }

                    return true;
                });


            }).Start();

           
            s.Stop();

            return s.ElapsedMilliseconds;
        }
    }
}