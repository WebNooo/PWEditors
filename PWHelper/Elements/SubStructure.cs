using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PWHelper.Elements
{
    class SubStructure
    {
        
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Addon
    {
        public int id;
        public float probability;
    }; 
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Skill
    {
        public int id;
        public float level;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct PageSell
    {
        public int id;
        public int contrib_cost;
        public int force_contribution_cost;
        public int solo_tower_challenge_score_cost;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct Ids
    {
        public int id;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct TaskMatters
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
}