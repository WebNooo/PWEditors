using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PWHelper.Elements.Versions._145
{
    class Structure : IStructure
    {
        public static readonly Encoding Gbk = Encoding.GetEncoding("GBK");

        public int ConversionIndex { get; set; } = 58;
        public int ComputerNameIndex { get; set; } = 20;
        public int HardInfoIndex { get; set; } = 100;
    }


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct EQUIPMENT_ADDON
    {
        public int id { get; set; }
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string name;
        public string Name { get => "145" + name; set { name = value; } }
        public int num_params { get; set; }
        public int param1 { get; set; }
        public int param2 { get; set; }
        public int param3 { get; set; }

    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WEAPON_MAJOR_TYPE
    {
        public int id { get; set; }
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string name;
        public string Name { get => name; set { name = value; } }

    }
}
