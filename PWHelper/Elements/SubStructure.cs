using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using PWHelper.Elements.Versions;

namespace PWHelper.Elements
{
    class SubStructure
    {
        public static readonly Encoding Gbk = Encoding.GetEncoding("GBK");
        public static readonly Encoding Unicode = Encoding.GetEncoding("Unicode");
    }

    [StructLayout(LayoutKind.Sequential)]
    public class Addon
    {
        public int id;
        public float probability;
    }; 
    
    [StructLayout(LayoutKind.Sequential)]
    public class Skill
    {
        public int id;
        public float level;
    };

    [StructLayout(LayoutKind.Sequential)]
    public class PageSell
    {
        public int id;
        public int contrib_cost;
        public int force_contribution_cost;
        public int solo_tower_challenge_score_cost;
    };

    [StructLayout(LayoutKind.Sequential)]
    public class Ids
    {
        public int id;
    };

    [StructLayout(LayoutKind.Sequential)]
    public class TaskMatters
    {
        public int id_task;
        public int id_matter_1;
        public int num_matter_1;
        public int id_matter_2;
        public int num_matter_2;
        public int id_matter_3;
        public int num_matter_3;
        public int id_matter_4;
        public int num_matter_4;
    };

    [StructLayout(LayoutKind.Sequential)]
    public class MakePage
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public byte[] title;
        //public string Title { get => SubUnicode.GetString(title); set => title = BinReader.FillArray(SubUnicode.GetBytes(value), 16); }

       // [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
       // public MakePageItem[] Recipes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class MakePageItem
    {
       [RecipeId] public int id { get; set; }
    }
}