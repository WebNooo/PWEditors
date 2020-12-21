using System;
using System.Diagnostics;
using System.IO;
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
        public static long Load(string fileName)
        {
            var s = new Stopwatch();
            s.Start();

            Icons.LoadIcons();
            Element.UnknownIcon = Icons.GetImage(0);

            BinReader.Clear();
            BinReader.Source = File.ReadAllBytes(fileName);

            Element.Items.Clear();
            ElementInfo.ListInformation.Clear();

            ElementInfo.ReadHeader();

            var version = $"PWHelper.Elements.Versions._{ElementInfo.Version}";
            var configLists = ElementInfo.GetStructureTypes(version);

            ElementInfo.Structure = (IStructure)ElementInfo.GetInstance($"{version}.Structure");

            var index = 0;
            foreach (var value in configLists)
            {
                if (ElementInfo.Structure.ComputerNameIndex == index) ElementInfo.ReadComputerName();
                if (ElementInfo.Structure.HardInfoIndex == index) ElementInfo.ReadHardInfo();
                ElementInfo.RegisterStruct(Type.GetType($"{version}.{value}", false, true), $"{index + 1} - {value}");
                index++;
            }

            s.Stop();

            return s.ElapsedMilliseconds;
        }
    }
}