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
        public static Dictionary<int, List<link>> LinksEssence { get; set; } = new Dictionary<int, List<link>>();
        public static Dictionary<int, List<link>> LinksAddon { get; set; } = new Dictionary<int, List<link>>();

        public static long Load(string fileName)
        {
            var s = new Stopwatch();

            Task.Factory.StartNew(Icons.LoadIcons);

            ElementInfo.ListInformation.Clear();
            Element.Addons.Clear();
            Element.Essences.Clear();
            Element.Configs.Clear();
            Element.Faces.Clear();
            Element.Talks.Clear();
            Element.Recipes.Clear();
            Element.Homes.Clear();
            BinReader.Clear();
            BinReader.Source = File.ReadAllBytes(fileName);


            ElementInfo.ReadHeader();

            var version = $"PWHelper.Elements.Versions._{ElementInfo.Version}";
            var configLists = ElementInfo.GetStructureTypes(version);

            ElementInfo.Structure = (IStructure) ElementInfo.GetInstance($"{version}.Structure");

            var index = 0;

            s.Start();
            foreach (var value in configLists)
            {
                if (ElementInfo.Structure.ComputerNameIndex == index) ElementInfo.ReadComputerName();
                if (ElementInfo.Structure.HardInfoIndex == index) ElementInfo.ReadHardInfo();
                ElementInfo.RegisterStruct(Type.GetType($"{version}.{value}", false, true), $"{index + 1} - {value}");
                index++;
            }

            s.Stop();

            Element.UnknownIcon = Icons.GetImage(0);

            new Thread(() =>
            {
                var itemType = typeof(ItemIdAttribute);
                var addonType = typeof(AddonIdAttribute);
                // Element.Items.All(n =>
                // {
                //
                //     if (n.Type.Name == "EQUIPMENT_ADDON")
                //     {
                //         SetLink(n.Fields.GetType().GetProperties(), n, "Аддоны", addonType, LinksAddon);
                //     }
                //
                //     if (n.Type.Name == "RECIPE_ESSENCE")
                //     {
                //         SetLink(n.Fields.GetType().GetProperties(), n, "Рецепт", itemType, LinksEssence);
                //     }
                //
                //     if (n.Type.Name == "NPC_SELL_SERVICE")
                //     {
                //         SetLink(n.Fields.GetType().GetProperties(), n, "Торговля", itemType, LinksEssence);
                //     }
                //
                //     return true;
                // });
            }).Start();


            return s.ElapsedMilliseconds;
        }

        public static void SetLink(PropertyInfo[] fields, Element.Item item, string name, Type attributeType,
            Dictionary<int, List<link>> list)
        {
            fields.All(x =>
            {
                // if (Attribute.GetCustomAttribute(x, typeof(AddonIdAttribute), false) != null)
                // {
                //     Console.WriteLine(x);
                // }

                if (Attribute.GetCustomAttribute(x, attributeType, false) != null)
                {
                    int t = x.GetValue(item.Fields, null);
                    if (t > 0)
                    {
                        if (list.ContainsKey(t))
                        {
                            list[t].Add(new link {item = item, type = name});
                        }
                        else
                        {
                            list.Add(t, new List<link> {new link {item = item, type = name}});
                        }
                    }
                }

                return true;
            });
        }
    }
}