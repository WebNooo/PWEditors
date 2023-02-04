﻿//using System.Runtime.InteropServices;
//using System.Text;

//namespace PWHelper.Elements.Versions._70
//{
//    class Structure : IStructure
//    {
//        public static readonly Encoding Gbk = Encoding.GetEncoding("GBK");
//        public static readonly Encoding Unicode = Encoding.GetEncoding("Unicode");
//        public int ConversionIndex { get; set; } = 58;
//        public int ComputerNameIndex { get; set; } = 20;
//        public int HardInfoIndex { get; set; } = 100;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class EQUIPMENT_ADDON
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] public byte[] name;

//        public int num_params { get; set; }
//        public int param1 { get; set; }
//        public int param2 { get; set; }
//        public int param3 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEAPON_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEAPON_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitgfx;

//        public string File_hitgfx
//        {
//            get => Structure.Gbk.GetString(file_hitgfx);
//            set { file_hitgfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitsfx;

//        public string File_hitsfx
//        {
//            get => Structure.Gbk.GetString(file_hitsfx);
//            set { file_hitsfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float probability_fastest { get; set; }
//        public float probability_fast { get; set; }
//        public float probability_normal { get; set; }
//        public float probability_slow { get; set; }
//        public float probability_slowest { get; set; }
//        public float attack_speed { get; set; }
//        public float attack_short_range { get; set; }
//        public int action_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEAPON_ESSENCE
//    {
//        public int id;
//        [MajorType] public int id_major_type { get; set; }
//        [SubType] public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int require_projectile { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model_right;

//        public string File_model_right
//        {
//            get => Structure.Gbk.GetString(file_model_right);
//            set { file_model_right = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model_left;

//        public string File_model_left
//        {
//            get => Structure.Gbk.GetString(file_model_left);
//            set { file_model_left = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        [Icon]
//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_strength { get; set; }
//        public int require_agility { get; set; }
//        public int require_energy { get; set; }
//        public int require_tili { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int require_level { get; set; }
//        public int require_reputation { get; set; }
//        public int level { get; set; }
//        [FixedProps] public int fixed_props { get; set; }
//        public int damage_low { get; set; }
//        public int damage_high_min { get; set; }
//        public int damage_high_max { get; set; }
//        public int magic_damage_low { get; set; }
//        public int magic_damage_high_min { get; set; }
//        public int magic_damage_high_max { get; set; }
//        public float attack_range { get; set; }
//        public int short_range_mode { get; set; }
//        public int durability_min { get; set; }
//        public int durability_max { get; set; }
//        [AddonId] public int levelup_addon { get; set; }
//        public int material_need { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int repairfee { get; set; }
//        public float drop_probability_socket0 { get; set; }
//        public float drop_probability_socket1 { get; set; }
//        public float drop_probability_socket2 { get; set; }
//        public float make_probability_socket0 { get; set; }
//        public float make_probability_socket1 { get; set; }
//        public float make_probability_socket2 { get; set; }
//        public float probability_addon_num0 { get; set; }
//        public float probability_addon_num1 { get; set; }
//        public float probability_addon_num2 { get; set; }
//        public float probability_addon_num3 { get; set; }
//        public float probability_addon_num4 { get; set; }
//        public float probability_unique { get; set; }

//        [AddonId] public int addons_1_id_addon { get; set; }
//        public float addons_1_probability_addon { get; set; }
//        [AddonId] public int addons_2_id_addon { get; set; }
//        public float addons_2_probability_addon { get; set; }
//        [AddonId] public int addons_3_id_addon { get; set; }
//        public float addons_3_probability_addon { get; set; }
//        [AddonId] public int addons_4_id_addon { get; set; }
//        public float addons_4_probability_addon { get; set; }
//        [AddonId] public int addons_5_id_addon { get; set; }
//        public float addons_5_probability_addon { get; set; }
//        [AddonId] public int addons_6_id_addon { get; set; }
//        public float addons_6_probability_addon { get; set; }
//        [AddonId] public int addons_7_id_addon { get; set; }
//        public float addons_7_probability_addon { get; set; }
//        [AddonId] public int addons_8_id_addon { get; set; }
//        public float addons_8_probability_addon { get; set; }
//        [AddonId] public int addons_9_id_addon { get; set; }
//        public float addons_9_probability_addon { get; set; }
//        [AddonId] public int addons_10_id_addon { get; set; }
//        public float addons_10_probability_addon { get; set; }
//        [AddonId] public int addons_11_id_addon { get; set; }
//        public float addons_11_probability_addon { get; set; }
//        [AddonId] public int addons_12_id_addon { get; set; }
//        public float addons_12_probability_addon { get; set; }
//        [AddonId] public int addons_13_id_addon { get; set; }
//        public float addons_13_probability_addon { get; set; }
//        [AddonId] public int addons_14_id_addon { get; set; }
//        public float addons_14_probability_addon { get; set; }
//        [AddonId] public int addons_15_id_addon { get; set; }
//        public float addons_15_probability_addon { get; set; }
//        [AddonId] public int addons_16_id_addon { get; set; }
//        public float addons_16_probability_addon { get; set; }
//        [AddonId] public int addons_17_id_addon { get; set; }
//        public float addons_17_probability_addon { get; set; }
//        [AddonId] public int addons_18_id_addon { get; set; }
//        public float addons_18_probability_addon { get; set; }
//        [AddonId] public int addons_19_id_addon { get; set; }
//        public float addons_19_probability_addon { get; set; }
//        [AddonId] public int addons_20_id_addon { get; set; }
//        public float addons_20_probability_addon { get; set; }
//        [AddonId] public int addons_21_id_addon { get; set; }
//        public float addons_21_probability_addon { get; set; }
//        [AddonId] public int addons_22_id_addon { get; set; }
//        public float addons_22_probability_addon { get; set; }
//        [AddonId] public int addons_23_id_addon { get; set; }
//        public float addons_23_probability_addon { get; set; }
//        [AddonId] public int addons_24_id_addon { get; set; }
//        public float addons_24_probability_addon { get; set; }
//        [AddonId] public int addons_25_id_addon { get; set; }
//        public float addons_25_probability_addon { get; set; }
//        [AddonId] public int addons_26_id_addon { get; set; }
//        public float addons_26_probability_addon { get; set; }
//        [AddonId] public int addons_27_id_addon { get; set; }
//        public float addons_27_probability_addon { get; set; }
//        [AddonId] public int addons_28_id_addon { get; set; }
//        public float addons_28_probability_addon { get; set; }
//        [AddonId] public int addons_29_id_addon { get; set; }
//        public float addons_29_probability_addon { get; set; }
//        [AddonId] public int addons_30_id_addon { get; set; }
//        public float addons_30_probability_addon { get; set; }
//        [AddonId] public int addons_31_id_addon { get; set; }
//        public float addons_31_probability_addon { get; set; }
//        [AddonId] public int addons_32_id_addon { get; set; }
//        public float addons_32_probability_addon { get; set; }
//        [AddonId] public int rands_1_id_rand { get; set; }
//        public float rands_1_probability_rand { get; set; }
//        [AddonId] public int rands_2_id_rand { get; set; }
//        public float rands_2_probability_rand { get; set; }
//        [AddonId] public int rands_3_id_rand { get; set; }
//        public float rands_3_probability_rand { get; set; }
//        [AddonId] public int rands_4_id_rand { get; set; }
//        public float rands_4_probability_rand { get; set; }
//        [AddonId] public int rands_5_id_rand { get; set; }
//        public float rands_5_probability_rand { get; set; }
//        [AddonId] public int rands_6_id_rand { get; set; }
//        public float rands_6_probability_rand { get; set; }
//        [AddonId] public int rands_7_id_rand { get; set; }
//        public float rands_7_probability_rand { get; set; }
//        [AddonId] public int rands_8_id_rand { get; set; }
//        public float rands_8_probability_rand { get; set; }
//        [AddonId] public int rands_9_id_rand { get; set; }
//        public float rands_9_probability_rand { get; set; }
//        [AddonId] public int rands_10_id_rand { get; set; }
//        public float rands_10_probability_rand { get; set; }
//        [AddonId] public int rands_11_id_rand { get; set; }
//        public float rands_11_probability_rand { get; set; }
//        [AddonId] public int rands_12_id_rand { get; set; }
//        public float rands_12_probability_rand { get; set; }
//        [AddonId] public int rands_13_id_rand { get; set; }
//        public float rands_13_probability_rand { get; set; }
//        [AddonId] public int rands_14_id_rand { get; set; }
//        public float rands_14_probability_rand { get; set; }
//        [AddonId] public int rands_15_id_rand { get; set; }
//        public float rands_15_probability_rand { get; set; }
//        [AddonId] public int rands_16_id_rand { get; set; }
//        public float rands_16_probability_rand { get; set; }
//        [AddonId] public int rands_17_id_rand { get; set; }
//        public float rands_17_probability_rand { get; set; }
//        [AddonId] public int rands_18_id_rand { get; set; }
//        public float rands_18_probability_rand { get; set; }
//        [AddonId] public int rands_19_id_rand { get; set; }
//        public float rands_19_probability_rand { get; set; }
//        [AddonId] public int rands_20_id_rand { get; set; }
//        public float rands_20_probability_rand { get; set; }
//        [AddonId] public int rands_21_id_rand { get; set; }
//        public float rands_21_probability_rand { get; set; }
//        [AddonId] public int rands_22_id_rand { get; set; }
//        public float rands_22_probability_rand { get; set; }
//        [AddonId] public int rands_23_id_rand { get; set; }
//        public float rands_23_probability_rand { get; set; }
//        [AddonId] public int rands_24_id_rand { get; set; }
//        public float rands_24_probability_rand { get; set; }
//        [AddonId] public int rands_25_id_rand { get; set; }
//        public float rands_25_probability_rand { get; set; }
//        [AddonId] public int rands_26_id_rand { get; set; }
//        public float rands_26_probability_rand { get; set; }
//        [AddonId] public int rands_27_id_rand { get; set; }
//        public float rands_27_probability_rand { get; set; }
//        [AddonId] public int rands_28_id_rand { get; set; }
//        public float rands_28_probability_rand { get; set; }
//        [AddonId] public int rands_29_id_rand { get; set; }
//        public float rands_29_probability_rand { get; set; }
//        [AddonId] public int rands_30_id_rand { get; set; }
//        public float rands_30_probability_rand { get; set; }
//        [AddonId] public int rands_31_id_rand { get; set; }
//        public float rands_31_probability_rand { get; set; }
//        [AddonId] public int rands_32_id_rand { get; set; }
//        public float rands_32_probability_rand { get; set; }
//        [AddonId] public int uniques_1_id_unique { get; set; }
//        public float uniques_1_probability_unique { get; set; }
//        [AddonId] public int uniques_2_id_unique { get; set; }
//        public float uniques_2_probability_unique { get; set; }
//        [AddonId] public int uniques_3_id_unique { get; set; }
//        public float uniques_3_probability_unique { get; set; }
//        [AddonId] public int uniques_4_id_unique { get; set; }
//        public float uniques_4_probability_unique { get; set; }
//        [AddonId] public int uniques_5_id_unique { get; set; }
//        public float uniques_5_probability_unique { get; set; }
//        [AddonId] public int uniques_6_id_unique { get; set; }
//        public float uniques_6_probability_unique { get; set; }
//        [AddonId] public int uniques_7_id_unique { get; set; }
//        public float uniques_7_probability_unique { get; set; }
//        [AddonId] public int uniques_8_id_unique { get; set; }
//        public float uniques_8_probability_unique { get; set; }
//        [AddonId] public int uniques_9_id_unique { get; set; }
//        public float uniques_9_probability_unique { get; set; }
//        [AddonId] public int uniques_10_id_unique { get; set; }
//        public float uniques_10_probability_unique { get; set; }
//        [AddonId] public int uniques_11_id_unique { get; set; }
//        public float uniques_11_probability_unique { get; set; }
//        [AddonId] public int uniques_12_id_unique { get; set; }
//        public float uniques_12_probability_unique { get; set; }
//        [AddonId] public int uniques_13_id_unique { get; set; }
//        public float uniques_13_probability_unique { get; set; }
//        [AddonId] public int uniques_14_id_unique { get; set; }
//        public float uniques_14_probability_unique { get; set; }
//        [AddonId] public int uniques_15_id_unique { get; set; }
//        public float uniques_15_probability_unique { get; set; }
//        [AddonId] public int uniques_16_id_unique { get; set; }
//        public float uniques_16_probability_unique { get; set; }

//        public int durability_drop_min { get; set; }
//        public int durability_drop_max { get; set; }
//        public int decompose_price { get; set; }
//        public int decompose_time { get; set; }
//        public int element_id { get; set; }
//        public int element_num { get; set; }
//        public int id_drop_after_damaged { get; set; }
//        public int num_drop_after_damaged { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ARMOR_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ARMOR_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int equip_mask { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ARMOR_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] realname;

//        public string Realname
//        {
//            get => Structure.Gbk.GetString(realname);
//            set { realname = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int equip_location { get; set; }
//        public int level { get; set; }
//        public int require_strength { get; set; }
//        public int require_agility { get; set; }
//        public int require_energy { get; set; }
//        public int require_tili { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int require_level { get; set; }
//        public int require_reputation { get; set; }
//        [FixedProps] public int fixed_props { get; set; }
//        public int defence_low { get; set; }
//        public int defence_high { get; set; }
//        public int magic_defences_1_low { get; set; }
//        public int magic_defences_1_high { get; set; }
//        public int magic_defences_2_low { get; set; }
//        public int magic_defences_2_high { get; set; }
//        public int magic_defences_3_low { get; set; }
//        public int magic_defences_3_high { get; set; }
//        public int magic_defences_4_low { get; set; }
//        public int magic_defences_4_high { get; set; }
//        public int magic_defences_5_low { get; set; }
//        public int magic_defences_5_high { get; set; }
//        public int mp_enhance_low { get; set; }
//        public int mp_enhance_high { get; set; }
//        public int hp_enhance_low { get; set; }
//        public int hp_enhance_high { get; set; }
//        public int armor_enhance_low { get; set; }
//        public int armor_enhance_high { get; set; }
//        public int durability_min { get; set; }
//        public int durability_max { get; set; }
//        public int levelup_addon { get; set; }
//        public int material_need { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int repairfee { get; set; }
//        public float drop_probability_socket0 { get; set; }
//        public float drop_probability_socket1 { get; set; }
//        public float drop_probability_socket2 { get; set; }
//        public float drop_probability_socket3 { get; set; }
//        public float drop_probability_socket4 { get; set; }
//        public float make_probability_socket0 { get; set; }
//        public float make_probability_socket1 { get; set; }
//        public float make_probability_socket2 { get; set; }
//        public float make_probability_socket3 { get; set; }
//        public float make_probability_socket4 { get; set; }
//        public float probability_addon_num0 { get; set; }
//        public float probability_addon_num1 { get; set; }
//        public float probability_addon_num2 { get; set; }
//        public float probability_addon_num3 { get; set; }
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public Addon[] addons;
//        public int rands_1_id_rand { get; set; }
//        public float rands_1_probability_rand { get; set; }
//        public int rands_2_id_rand { get; set; }
//        public float rands_2_probability_rand { get; set; }
//        public int rands_3_id_rand { get; set; }
//        public float rands_3_probability_rand { get; set; }
//        public int rands_4_id_rand { get; set; }
//        public float rands_4_probability_rand { get; set; }
//        public int rands_5_id_rand { get; set; }
//        public float rands_5_probability_rand { get; set; }
//        public int rands_6_id_rand { get; set; }
//        public float rands_6_probability_rand { get; set; }
//        public int rands_7_id_rand { get; set; }
//        public float rands_7_probability_rand { get; set; }
//        public int rands_8_id_rand { get; set; }
//        public float rands_8_probability_rand { get; set; }
//        public int rands_9_id_rand { get; set; }
//        public float rands_9_probability_rand { get; set; }
//        public int rands_10_id_rand { get; set; }
//        public float rands_10_probability_rand { get; set; }
//        public int rands_11_id_rand { get; set; }
//        public float rands_11_probability_rand { get; set; }
//        public int rands_12_id_rand { get; set; }
//        public float rands_12_probability_rand { get; set; }
//        public int rands_13_id_rand { get; set; }
//        public float rands_13_probability_rand { get; set; }
//        public int rands_14_id_rand { get; set; }
//        public float rands_14_probability_rand { get; set; }
//        public int rands_15_id_rand { get; set; }
//        public float rands_15_probability_rand { get; set; }
//        public int rands_16_id_rand { get; set; }
//        public float rands_16_probability_rand { get; set; }
//        public int rands_17_id_rand { get; set; }
//        public float rands_17_probability_rand { get; set; }
//        public int rands_18_id_rand { get; set; }
//        public float rands_18_probability_rand { get; set; }
//        public int rands_19_id_rand { get; set; }
//        public float rands_19_probability_rand { get; set; }
//        public int rands_20_id_rand { get; set; }
//        public float rands_20_probability_rand { get; set; }
//        public int rands_21_id_rand { get; set; }
//        public float rands_21_probability_rand { get; set; }
//        public int rands_22_id_rand { get; set; }
//        public float rands_22_probability_rand { get; set; }
//        public int rands_23_id_rand { get; set; }
//        public float rands_23_probability_rand { get; set; }
//        public int rands_24_id_rand { get; set; }
//        public float rands_24_probability_rand { get; set; }
//        public int rands_25_id_rand { get; set; }
//        public float rands_25_probability_rand { get; set; }
//        public int rands_26_id_rand { get; set; }
//        public float rands_26_probability_rand { get; set; }
//        public int rands_27_id_rand { get; set; }
//        public float rands_27_probability_rand { get; set; }
//        public int rands_28_id_rand { get; set; }
//        public float rands_28_probability_rand { get; set; }
//        public int rands_29_id_rand { get; set; }
//        public float rands_29_probability_rand { get; set; }
//        public int rands_30_id_rand { get; set; }
//        public float rands_30_probability_rand { get; set; }
//        public int rands_31_id_rand { get; set; }
//        public float rands_31_probability_rand { get; set; }
//        public int rands_32_id_rand { get; set; }
//        public float rands_32_probability_rand { get; set; }
//        public int durability_drop_min { get; set; }
//        public int durability_drop_max { get; set; }
//        public int decompose_price { get; set; }
//        public int decompose_time { get; set; }
//        public int element_id { get; set; }
//        public int element_num { get; set; }
//        public int id_drop_after_damaged { get; set; }
//        public int num_drop_after_damaged { get; set; }
//        public int id_hair { get; set; }
//        public int id_hair_texture { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//        public int force_all_magic_defences { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DECORATION_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DECORATION_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int equip_mask { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DECORATION_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int require_strength { get; set; }
//        public int require_agility { get; set; }
//        public int require_energy { get; set; }
//        public int require_tili { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int require_level { get; set; }
//        public int require_reputation { get; set; }
//        [FixedProps] public int fixed_props { get; set; }
//        public int damage_low { get; set; }
//        public int damage_high { get; set; }
//        public int magic_damage_low { get; set; }
//        public int magic_damage_high { get; set; }
//        public int defence_low { get; set; }
//        public int defence_high { get; set; }
//        public int magic_defences_1_low { get; set; }
//        public int magic_defences_1_high { get; set; }
//        public int magic_defences_2_low { get; set; }
//        public int magic_defences_2_high { get; set; }
//        public int magic_defences_3_low { get; set; }
//        public int magic_defences_3_high { get; set; }
//        public int magic_defences_4_low { get; set; }
//        public int magic_defences_4_high { get; set; }
//        public int magic_defences_5_low { get; set; }
//        public int magic_defences_5_high { get; set; }
//        public int armor_enhance_low { get; set; }
//        public int armor_enhance_high { get; set; }
//        public int durability_min { get; set; }
//        public int durability_max { get; set; }
//        public int levelup_addon { get; set; }
//        public int material_need { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int repairfee { get; set; }
//        public float probability_addon_num0 { get; set; }
//        public float probability_addon_num1 { get; set; }
//        public float probability_addon_num2 { get; set; }
//        public float probability_addon_num3 { get; set; }
//        public int addons_1_id_addon { get; set; }
//        public float addons_1_probability_addon { get; set; }
//        public int addons_2_id_addon { get; set; }
//        public float addons_2_probability_addon { get; set; }
//        public int addons_3_id_addon { get; set; }
//        public float addons_3_probability_addon { get; set; }
//        public int addons_4_id_addon { get; set; }
//        public float addons_4_probability_addon { get; set; }
//        public int addons_5_id_addon { get; set; }
//        public float addons_5_probability_addon { get; set; }
//        public int addons_6_id_addon { get; set; }
//        public float addons_6_probability_addon { get; set; }
//        public int addons_7_id_addon { get; set; }
//        public float addons_7_probability_addon { get; set; }
//        public int addons_8_id_addon { get; set; }
//        public float addons_8_probability_addon { get; set; }
//        public int addons_9_id_addon { get; set; }
//        public float addons_9_probability_addon { get; set; }
//        public int addons_10_id_addon { get; set; }
//        public float addons_10_probability_addon { get; set; }
//        public int addons_11_id_addon { get; set; }
//        public float addons_11_probability_addon { get; set; }
//        public int addons_12_id_addon { get; set; }
//        public float addons_12_probability_addon { get; set; }
//        public int addons_13_id_addon { get; set; }
//        public float addons_13_probability_addon { get; set; }
//        public int addons_14_id_addon { get; set; }
//        public float addons_14_probability_addon { get; set; }
//        public int addons_15_id_addon { get; set; }
//        public float addons_15_probability_addon { get; set; }
//        public int addons_16_id_addon { get; set; }
//        public float addons_16_probability_addon { get; set; }
//        public int addons_17_id_addon { get; set; }
//        public float addons_17_probability_addon { get; set; }
//        public int addons_18_id_addon { get; set; }
//        public float addons_18_probability_addon { get; set; }
//        public int addons_19_id_addon { get; set; }
//        public float addons_19_probability_addon { get; set; }
//        public int addons_20_id_addon { get; set; }
//        public float addons_20_probability_addon { get; set; }
//        public int addons_21_id_addon { get; set; }
//        public float addons_21_probability_addon { get; set; }
//        public int addons_22_id_addon { get; set; }
//        public float addons_22_probability_addon { get; set; }
//        public int addons_23_id_addon { get; set; }
//        public float addons_23_probability_addon { get; set; }
//        public int addons_24_id_addon { get; set; }
//        public float addons_24_probability_addon { get; set; }
//        public int addons_25_id_addon { get; set; }
//        public float addons_25_probability_addon { get; set; }
//        public int addons_26_id_addon { get; set; }
//        public float addons_26_probability_addon { get; set; }
//        public int addons_27_id_addon { get; set; }
//        public float addons_27_probability_addon { get; set; }
//        public int addons_28_id_addon { get; set; }
//        public float addons_28_probability_addon { get; set; }
//        public int addons_29_id_addon { get; set; }
//        public float addons_29_probability_addon { get; set; }
//        public int addons_30_id_addon { get; set; }
//        public float addons_30_probability_addon { get; set; }
//        public int addons_31_id_addon { get; set; }
//        public float addons_31_probability_addon { get; set; }
//        public int addons_32_id_addon { get; set; }
//        public float addons_32_probability_addon { get; set; }
//        public int rands_1_id_rand { get; set; }
//        public float rands_1_probability_rand { get; set; }
//        public int rands_2_id_rand { get; set; }
//        public float rands_2_probability_rand { get; set; }
//        public int rands_3_id_rand { get; set; }
//        public float rands_3_probability_rand { get; set; }
//        public int rands_4_id_rand { get; set; }
//        public float rands_4_probability_rand { get; set; }
//        public int rands_5_id_rand { get; set; }
//        public float rands_5_probability_rand { get; set; }
//        public int rands_6_id_rand { get; set; }
//        public float rands_6_probability_rand { get; set; }
//        public int rands_7_id_rand { get; set; }
//        public float rands_7_probability_rand { get; set; }
//        public int rands_8_id_rand { get; set; }
//        public float rands_8_probability_rand { get; set; }
//        public int rands_9_id_rand { get; set; }
//        public float rands_9_probability_rand { get; set; }
//        public int rands_10_id_rand { get; set; }
//        public float rands_10_probability_rand { get; set; }
//        public int rands_11_id_rand { get; set; }
//        public float rands_11_probability_rand { get; set; }
//        public int rands_12_id_rand { get; set; }
//        public float rands_12_probability_rand { get; set; }
//        public int rands_13_id_rand { get; set; }
//        public float rands_13_probability_rand { get; set; }
//        public int rands_14_id_rand { get; set; }
//        public float rands_14_probability_rand { get; set; }
//        public int rands_15_id_rand { get; set; }
//        public float rands_15_probability_rand { get; set; }
//        public int rands_16_id_rand { get; set; }
//        public float rands_16_probability_rand { get; set; }
//        public int rands_17_id_rand { get; set; }
//        public float rands_17_probability_rand { get; set; }
//        public int rands_18_id_rand { get; set; }
//        public float rands_18_probability_rand { get; set; }
//        public int rands_19_id_rand { get; set; }
//        public float rands_19_probability_rand { get; set; }
//        public int rands_20_id_rand { get; set; }
//        public float rands_20_probability_rand { get; set; }
//        public int rands_21_id_rand { get; set; }
//        public float rands_21_probability_rand { get; set; }
//        public int rands_22_id_rand { get; set; }
//        public float rands_22_probability_rand { get; set; }
//        public int rands_23_id_rand { get; set; }
//        public float rands_23_probability_rand { get; set; }
//        public int rands_24_id_rand { get; set; }
//        public float rands_24_probability_rand { get; set; }
//        public int rands_25_id_rand { get; set; }
//        public float rands_25_probability_rand { get; set; }
//        public int rands_26_id_rand { get; set; }
//        public float rands_26_probability_rand { get; set; }
//        public int rands_27_id_rand { get; set; }
//        public float rands_27_probability_rand { get; set; }
//        public int rands_28_id_rand { get; set; }
//        public float rands_28_probability_rand { get; set; }
//        public int rands_29_id_rand { get; set; }
//        public float rands_29_probability_rand { get; set; }
//        public int rands_30_id_rand { get; set; }
//        public float rands_30_probability_rand { get; set; }
//        public int rands_31_id_rand { get; set; }
//        public float rands_31_probability_rand { get; set; }
//        public int rands_32_id_rand { get; set; }
//        public float rands_32_probability_rand { get; set; }
//        public int durability_drop_min { get; set; }
//        public int durability_drop_max { get; set; }
//        public int decompose_price { get; set; }
//        public int decompose_time { get; set; }
//        public int element_id { get; set; }
//        public int element_num { get; set; }
//        public int id_drop_after_damaged { get; set; }
//        public int num_drop_after_damaged { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MEDICINE_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MEDICINE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MEDICINE_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_level { get; set; }
//        public int cool_time { get; set; }
//        public int hp_add_total { get; set; }
//        public int hp_add_time { get; set; }
//        public int mp_add_total { get; set; }
//        public int mp_add_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MATERIAL_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MATERIAL_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MATERIAL_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int decompose_price { get; set; }
//        public int decompose_time { get; set; }
//        public int element_id { get; set; }
//        public int element_num { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DAMAGERUNE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DAMAGERUNE_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int damage_type { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int require_weapon_level_min { get; set; }
//        public int require_weapon_level_max { get; set; }
//        public int damage_increased { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ARMORRUNE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ARMORRUNE_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_gfx;

//        public string File_gfx
//        {
//            get => Structure.Gbk.GetString(file_gfx);
//            set { file_gfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_sfx;

//        public string File_sfx
//        {
//            get => Structure.Gbk.GetString(file_sfx);
//            set { file_sfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int damage_type { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int require_player_level_min { get; set; }
//        public int require_player_level_max { get; set; }
//        public float damage_reduce_percent { get; set; }
//        public int damage_reduce_time { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SKILLTOME_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SKILLTOME_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FLYSWORD_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int level { get; set; }
//        public int require_player_level_min { get; set; }
//        public float speed_increase_min { get; set; }
//        public float speed_increase_max { get; set; }
//        public float speed_rush_increase_min { get; set; }
//        public float speed_rush_increase_max { get; set; }
//        public float time_max_min { get; set; }
//        public float time_max_max { get; set; }
//        public float time_increase_per_element { get; set; }
//        public int fly_mode { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int id_drop_after_damaged { get; set; }
//        public int num_drop_after_damaged { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WINGMANWING_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int require_player_level_min { get; set; }
//        public float speed_increase { get; set; }
//        public int mp_launch { get; set; }
//        public int mp_per_second { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TOWNSCROLL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float use_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class UNIONSCROLL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float use_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class REVIVESCROLL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float use_time { get; set; }
//        public int cool_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ELEMENT_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TASKMATTER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TOSSMATTER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_firegfx;

//        public string File_firegfx
//        {
//            get => Structure.Gbk.GetString(file_firegfx);
//            set { file_firegfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitgfx;

//        public string File_hitgfx
//        {
//            get => Structure.Gbk.GetString(file_hitgfx);
//            set { file_hitgfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitsfx;

//        public string File_hitsfx
//        {
//            get => Structure.Gbk.GetString(file_hitsfx);
//            set { file_hitsfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_strength { get; set; }
//        public int require_agility { get; set; }
//        public int require_level { get; set; }
//        public int damage_low { get; set; }
//        public int damage_high_min { get; set; }
//        public int damage_high_max { get; set; }
//        public float use_time { get; set; }
//        public float attack_range { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PROJECTILE_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PROJECTILE_ESSENCE
//    {
//        public int id;
//        public int type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_firegfx;

//        public string File_firegfx
//        {
//            get => Structure.Gbk.GetString(file_firegfx);
//            set { file_firegfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitgfx;

//        public string File_hitgfx
//        {
//            get => Structure.Gbk.GetString(file_hitgfx);
//            set { file_hitgfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hitsfx;

//        public string File_hitsfx
//        {
//            get => Structure.Gbk.GetString(file_hitsfx);
//            set { file_hitsfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_weapon_level_min { get; set; }
//        public int require_weapon_level_max { get; set; }
//        public int damage_enhance { get; set; }
//        public int damage_scale_enhance { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int id_addon0 { get; set; }
//        public int id_addon1 { get; set; }
//        public int id_addon2 { get; set; }
//        public int id_addon3 { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class QUIVER_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class QUIVER_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_projectile { get; set; }
//        public int num_min { get; set; }
//        public int num_max { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class STONE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class STONE_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int color { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int install_price { get; set; }
//        public int uninstall_price { get; set; }
//        public int id_addon_damage { get; set; }
//        public int id_addon_defence { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] weapon_desc;

//        public string Weapon_desc
//        {
//            get => Structure.Unicode.GetString(weapon_desc);
//            set { weapon_desc = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] armor_desc;

//        public string Armor_desc
//        {
//            get => Structure.Unicode.GetString(armor_desc);
//            set { armor_desc = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MONSTER_ADDON
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int num_params { get; set; }
//        public int param1 { get; set; }
//        public int param2 { get; set; }
//        public int param3 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MONSTER_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int addons_1_id_addon { get; set; }
//        public float addons_1_probability_addon { get; set; }
//        public int addons_2_id_addon { get; set; }
//        public float addons_2_probability_addon { get; set; }
//        public int addons_3_id_addon { get; set; }
//        public float addons_3_probability_addon { get; set; }
//        public int addons_4_id_addon { get; set; }
//        public float addons_4_probability_addon { get; set; }
//        public int addons_5_id_addon { get; set; }
//        public float addons_5_probability_addon { get; set; }
//        public int addons_6_id_addon { get; set; }
//        public float addons_6_probability_addon { get; set; }
//        public int addons_7_id_addon { get; set; }
//        public float addons_7_probability_addon { get; set; }
//        public int addons_8_id_addon { get; set; }
//        public float addons_8_probability_addon { get; set; }
//        public int addons_9_id_addon { get; set; }
//        public float addons_9_probability_addon { get; set; }
//        public int addons_10_id_addon { get; set; }
//        public float addons_10_probability_addon { get; set; }
//        public int addons_11_id_addon { get; set; }
//        public float addons_11_probability_addon { get; set; }
//        public int addons_12_id_addon { get; set; }
//        public float addons_12_probability_addon { get; set; }
//        public int addons_13_id_addon { get; set; }
//        public float addons_13_probability_addon { get; set; }
//        public int addons_14_id_addon { get; set; }
//        public float addons_14_probability_addon { get; set; }
//        public int addons_15_id_addon { get; set; }
//        public float addons_15_probability_addon { get; set; }
//        public int addons_16_id_addon { get; set; }
//        public float addons_16_probability_addon { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MONSTER_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] prop;

//        public string Prop
//        {
//            get => Structure.Unicode.GetString(prop);
//            set { prop = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] desc;

//        public string Desc
//        {
//            get => Structure.Unicode.GetString(desc);
//            set { desc = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public int faction { get; set; }
//        public int monster_faction { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_gfx_short;

//        public string File_gfx_short
//        {
//            get => Structure.Gbk.GetString(file_gfx_short);
//            set { file_gfx_short = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_gfx_short_hit;

//        public string File_gfx_short_hit
//        {
//            get => Structure.Gbk.GetString(file_gfx_short_hit);
//            set { file_gfx_short_hit = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float size { get; set; }
//        public float damage_delay { get; set; }
//        public int id_strategy { get; set; }
//        public int role_in_war { get; set; }
//        public int level { get; set; }
//        public int show_level { get; set; }
//        public int id_pet_egg_captured { get; set; }
//        public int life { get; set; }
//        public int defence { get; set; }
//        public int magic_defences_1 { get; set; }
//        public int magic_defences_2 { get; set; }
//        public int magic_defences_3 { get; set; }
//        public int magic_defences_4 { get; set; }
//        public int magic_defences_5 { get; set; }
//        public int immune_type { get; set; }
//        public int exp { get; set; }
//        public int skillpoint { get; set; }
//        public int money_average { get; set; }
//        public int money_var { get; set; }
//        public int short_range_mode { get; set; }
//        public int sight_range { get; set; }
//        public int attack { get; set; }
//        public int armor { get; set; }
//        public int damage_min { get; set; }
//        public int damage_max { get; set; }
//        public int magic_damages_ext_1_damage_min { get; set; }
//        public int magic_damages_ext_1_damage_max { get; set; }
//        public int magic_damages_ext_2_damage_min { get; set; }
//        public int magic_damages_ext_2_damage_max { get; set; }
//        public int magic_damages_ext_3_damage_min { get; set; }
//        public int magic_damages_ext_3_damage_max { get; set; }
//        public int magic_damages_ext_4_damage_min { get; set; }
//        public int magic_damages_ext_4_damage_max { get; set; }
//        public int magic_damages_ext_5_damage_min { get; set; }
//        public int magic_damages_ext_5_damage_max { get; set; }
//        public float attack_range { get; set; }
//        public float attack_speed { get; set; }
//        public int magic_damage_min { get; set; }
//        public int magic_damage_max { get; set; }
//        public int id_skill { get; set; }
//        public int skill_level { get; set; }
//        public int hp_regenerate { get; set; }
//        public int aggressive_mode { get; set; }
//        public int monster_faction_ask_help { get; set; }
//        public int monster_faction_can_help { get; set; }
//        public float aggro_range { get; set; }
//        public float aggro_time { get; set; }
//        public int inhabit_type { get; set; }
//        public int patroll_mode { get; set; }
//        public int stand_mode { get; set; }
//        public float walk_speed { get; set; }
//        public float run_speed { get; set; }
//        public float fly_speed { get; set; }
//        public float swim_speed { get; set; }
//        public int attack_degree { get; set; }
//        public int defend_degree { get; set; }
//        public int common_strategy { get; set; }
//        public int aggro_strategy_1_id { get; set; }
//        public float aggro_strategy_1_probability { get; set; }
//        public int aggro_strategy_2_id { get; set; }
//        public float aggro_strategy_2_probability { get; set; }
//        public int aggro_strategy_3_id { get; set; }
//        public float aggro_strategy_3_probability { get; set; }
//        public int aggro_strategy_4_id { get; set; }
//        public float aggro_strategy_4_probability { get; set; }
//        public int skill_hp75_1_id_skill { get; set; }
//        public int skill_hp75_1_level { get; set; }
//        public float skill_hp75_1_probability { get; set; }
//        public int skill_hp75_2_id_skill { get; set; }
//        public int skill_hp75_2_level { get; set; }
//        public float skill_hp75_2_probability { get; set; }
//        public int skill_hp75_3_id_skill { get; set; }
//        public int skill_hp75_3_level { get; set; }
//        public float skill_hp75_3_probability { get; set; }
//        public int skill_hp75_4_id_skill { get; set; }
//        public int skill_hp75_4_level { get; set; }
//        public float skill_hp75_4_probability { get; set; }
//        public int skill_hp75_5_id_skill { get; set; }
//        public int skill_hp75_5_level { get; set; }
//        public float skill_hp75_5_probability { get; set; }
//        public int skill_hp50_1_id_skill { get; set; }
//        public int skill_hp50_1_level { get; set; }
//        public float skill_hp50_1_probability { get; set; }
//        public int skill_hp50_2_id_skill { get; set; }
//        public int skill_hp50_2_level { get; set; }
//        public float skill_hp50_2_probability { get; set; }
//        public int skill_hp50_3_id_skill { get; set; }
//        public int skill_hp50_3_level { get; set; }
//        public float skill_hp50_3_probability { get; set; }
//        public int skill_hp50_4_id_skill { get; set; }
//        public int skill_hp50_4_level { get; set; }
//        public float skill_hp50_4_probability { get; set; }
//        public int skill_hp50_5_id_skill { get; set; }
//        public int skill_hp50_5_level { get; set; }
//        public float skill_hp50_5_probability { get; set; }
//        public int skill_hp25_1_id_skill { get; set; }
//        public int skill_hp25_1_level { get; set; }
//        public float skill_hp25_1_probability { get; set; }
//        public int skill_hp25_2_id_skill { get; set; }
//        public int skill_hp25_2_level { get; set; }
//        public float skill_hp25_2_probability { get; set; }
//        public int skill_hp25_3_id_skill { get; set; }
//        public int skill_hp25_3_level { get; set; }
//        public float skill_hp25_3_probability { get; set; }
//        public int skill_hp25_4_id_skill { get; set; }
//        public int skill_hp25_4_level { get; set; }
//        public float skill_hp25_4_probability { get; set; }
//        public int skill_hp25_5_id_skill { get; set; }
//        public int skill_hp25_5_level { get; set; }
//        public float skill_hp25_5_probability { get; set; }
//        public int after_death { get; set; }
//        public int skills_1_id_skill { get; set; }
//        public int skills_1_level { get; set; }
//        public int skills_2_id_skill { get; set; }
//        public int skills_2_level { get; set; }
//        public int skills_3_id_skill { get; set; }
//        public int skills_3_level { get; set; }
//        public int skills_4_id_skill { get; set; }
//        public int skills_4_level { get; set; }
//        public int skills_5_id_skill { get; set; }
//        public int skills_5_level { get; set; }
//        public int skills_6_id_skill { get; set; }
//        public int skills_6_level { get; set; }
//        public int skills_7_id_skill { get; set; }
//        public int skills_7_level { get; set; }
//        public int skills_8_id_skill { get; set; }
//        public int skills_8_level { get; set; }
//        public int skills_9_id_skill { get; set; }
//        public int skills_9_level { get; set; }
//        public int skills_10_id_skill { get; set; }
//        public int skills_10_level { get; set; }
//        public int skills_11_id_skill { get; set; }
//        public int skills_11_level { get; set; }
//        public int skills_12_id_skill { get; set; }
//        public int skills_12_level { get; set; }
//        public int skills_13_id_skill { get; set; }
//        public int skills_13_level { get; set; }
//        public int skills_14_id_skill { get; set; }
//        public int skills_14_level { get; set; }
//        public int skills_15_id_skill { get; set; }
//        public int skills_15_level { get; set; }
//        public int skills_16_id_skill { get; set; }
//        public int skills_16_level { get; set; }
//        public int skills_17_id_skill { get; set; }
//        public int skills_17_level { get; set; }
//        public int skills_18_id_skill { get; set; }
//        public int skills_18_level { get; set; }
//        public int skills_19_id_skill { get; set; }
//        public int skills_19_level { get; set; }
//        public int skills_20_id_skill { get; set; }
//        public int skills_20_level { get; set; }
//        public int skills_21_id_skill { get; set; }
//        public int skills_21_level { get; set; }
//        public int skills_22_id_skill { get; set; }
//        public int skills_22_level { get; set; }
//        public int skills_23_id_skill { get; set; }
//        public int skills_23_level { get; set; }
//        public int skills_24_id_skill { get; set; }
//        public int skills_24_level { get; set; }
//        public int skills_25_id_skill { get; set; }
//        public int skills_25_level { get; set; }
//        public int skills_26_id_skill { get; set; }
//        public int skills_26_level { get; set; }
//        public int skills_27_id_skill { get; set; }
//        public int skills_27_level { get; set; }
//        public int skills_28_id_skill { get; set; }
//        public int skills_28_level { get; set; }
//        public int skills_29_id_skill { get; set; }
//        public int skills_29_level { get; set; }
//        public int skills_30_id_skill { get; set; }
//        public int skills_30_level { get; set; }
//        public int skills_31_id_skill { get; set; }
//        public int skills_31_level { get; set; }
//        public int skills_32_id_skill { get; set; }
//        public int skills_32_level { get; set; }
//        public float probability_drop_num0 { get; set; }
//        public float probability_drop_num1 { get; set; }
//        public float probability_drop_num2 { get; set; }
//        public float probability_drop_num3 { get; set; }
//        public int drop_times { get; set; }
//        public int drop_protected { get; set; }
//        public int drop_matters_1_id { get; set; }
//        public float drop_matters_1_probability { get; set; }
//        public int drop_matters_2_id { get; set; }
//        public float drop_matters_2_probability { get; set; }
//        public int drop_matters_3_id { get; set; }
//        public float drop_matters_3_probability { get; set; }
//        public int drop_matters_4_id { get; set; }
//        public float drop_matters_4_probability { get; set; }
//        public int drop_matters_5_id { get; set; }
//        public float drop_matters_5_probability { get; set; }
//        public int drop_matters_6_id { get; set; }
//        public float drop_matters_6_probability { get; set; }
//        public int drop_matters_7_id { get; set; }
//        public float drop_matters_7_probability { get; set; }
//        public int drop_matters_8_id { get; set; }
//        public float drop_matters_8_probability { get; set; }
//        public int drop_matters_9_id { get; set; }
//        public float drop_matters_9_probability { get; set; }
//        public int drop_matters_10_id { get; set; }
//        public float drop_matters_10_probability { get; set; }
//        public int drop_matters_11_id { get; set; }
//        public float drop_matters_11_probability { get; set; }
//        public int drop_matters_12_id { get; set; }
//        public float drop_matters_12_probability { get; set; }
//        public int drop_matters_13_id { get; set; }
//        public float drop_matters_13_probability { get; set; }
//        public int drop_matters_14_id { get; set; }
//        public float drop_matters_14_probability { get; set; }
//        public int drop_matters_15_id { get; set; }
//        public float drop_matters_15_probability { get; set; }
//        public int drop_matters_16_id { get; set; }
//        public float drop_matters_16_probability { get; set; }
//        public int drop_matters_17_id { get; set; }
//        public float drop_matters_17_probability { get; set; }
//        public int drop_matters_18_id { get; set; }
//        public float drop_matters_18_probability { get; set; }
//        public int drop_matters_19_id { get; set; }
//        public float drop_matters_19_probability { get; set; }
//        public int drop_matters_20_id { get; set; }
//        public float drop_matters_20_probability { get; set; }
//        public int drop_matters_21_id { get; set; }
//        public float drop_matters_21_probability { get; set; }
//        public int drop_matters_22_id { get; set; }
//        public float drop_matters_22_probability { get; set; }
//        public int drop_matters_23_id { get; set; }
//        public float drop_matters_23_probability { get; set; }
//        public int drop_matters_24_id { get; set; }
//        public float drop_matters_24_probability { get; set; }
//        public int drop_matters_25_id { get; set; }
//        public float drop_matters_25_probability { get; set; }
//        public int drop_matters_26_id { get; set; }
//        public float drop_matters_26_probability { get; set; }
//        public int drop_matters_27_id { get; set; }
//        public float drop_matters_27_probability { get; set; }
//        public int drop_matters_28_id { get; set; }
//        public float drop_matters_28_probability { get; set; }
//        public int drop_matters_29_id { get; set; }
//        public float drop_matters_29_probability { get; set; }
//        public int drop_matters_30_id { get; set; }
//        public float drop_matters_30_probability { get; set; }
//        public int drop_matters_31_id { get; set; }
//        public float drop_matters_31_probability { get; set; }
//        public int drop_matters_32_id { get; set; }
//        public float drop_matters_32_probability { get; set; }
//        public int highest_frequency { get; set; }
//        public int no_accept_player_buff { get; set; }
//        public int invisible_lvl { get; set; }
//        public int uninvisible_lvl { get; set; }
//        public int no_auto_fight { get; set; }
//        public int fixed_direction { get; set; }
//        public int id_building { get; set; }
//        public int combined_switch { get; set; }
//        public int hp_adjust_common_value { get; set; }
//        public int defence_adjust_common_value { get; set; }
//        public int attack_adjust_common_value { get; set; }
//        public float max_move_range { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TALK_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_SELL_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_1_page_title;

//        public string Pages_1_page_title
//        {
//            get => Structure.Unicode.GetString(pages_1_page_title);
//            set { pages_1_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_1_require_contrib { get; set; }
//        public int pages_1_require_force { get; set; }
//        public int pages_1_require_force_reputation { get; set; }
//        [ItemId] public int pages_1_goods_1_id { get; set; }
//        public int pages_1_goods_1_contrib_cost { get; set; }
//        public int pages_1_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_2_id { get; set; }
//        public int pages_1_goods_2_contrib_cost { get; set; }
//        public int pages_1_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_3_id { get; set; }
//        public int pages_1_goods_3_contrib_cost { get; set; }
//        public int pages_1_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_4_id { get; set; }
//        public int pages_1_goods_4_contrib_cost { get; set; }
//        public int pages_1_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_5_id { get; set; }
//        public int pages_1_goods_5_contrib_cost { get; set; }
//        public int pages_1_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_6_id { get; set; }
//        public int pages_1_goods_6_contrib_cost { get; set; }
//        public int pages_1_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_7_id { get; set; }
//        public int pages_1_goods_7_contrib_cost { get; set; }
//        public int pages_1_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_8_id { get; set; }
//        public int pages_1_goods_8_contrib_cost { get; set; }
//        public int pages_1_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_9_id { get; set; }
//        public int pages_1_goods_9_contrib_cost { get; set; }
//        public int pages_1_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_10_id { get; set; }
//        public int pages_1_goods_10_contrib_cost { get; set; }
//        public int pages_1_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_11_id { get; set; }
//        public int pages_1_goods_11_contrib_cost { get; set; }
//        public int pages_1_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_12_id { get; set; }
//        public int pages_1_goods_12_contrib_cost { get; set; }
//        public int pages_1_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_13_id { get; set; }
//        public int pages_1_goods_13_contrib_cost { get; set; }
//        public int pages_1_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_14_id { get; set; }
//        public int pages_1_goods_14_contrib_cost { get; set; }
//        public int pages_1_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_15_id { get; set; }
//        public int pages_1_goods_15_contrib_cost { get; set; }
//        public int pages_1_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_16_id { get; set; }
//        public int pages_1_goods_16_contrib_cost { get; set; }
//        public int pages_1_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_17_id { get; set; }
//        public int pages_1_goods_17_contrib_cost { get; set; }
//        public int pages_1_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_18_id { get; set; }
//        public int pages_1_goods_18_contrib_cost { get; set; }
//        public int pages_1_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_19_id { get; set; }
//        public int pages_1_goods_19_contrib_cost { get; set; }
//        public int pages_1_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_20_id { get; set; }
//        public int pages_1_goods_20_contrib_cost { get; set; }
//        public int pages_1_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_21_id { get; set; }
//        public int pages_1_goods_21_contrib_cost { get; set; }
//        public int pages_1_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_22_id { get; set; }
//        public int pages_1_goods_22_contrib_cost { get; set; }
//        public int pages_1_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_23_id { get; set; }
//        public int pages_1_goods_23_contrib_cost { get; set; }
//        public int pages_1_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_24_id { get; set; }
//        public int pages_1_goods_24_contrib_cost { get; set; }
//        public int pages_1_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_25_id { get; set; }
//        public int pages_1_goods_25_contrib_cost { get; set; }
//        public int pages_1_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_26_id { get; set; }
//        public int pages_1_goods_26_contrib_cost { get; set; }
//        public int pages_1_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_27_id { get; set; }
//        public int pages_1_goods_27_contrib_cost { get; set; }
//        public int pages_1_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_28_id { get; set; }
//        public int pages_1_goods_28_contrib_cost { get; set; }
//        public int pages_1_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_29_id { get; set; }
//        public int pages_1_goods_29_contrib_cost { get; set; }
//        public int pages_1_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_30_id { get; set; }
//        public int pages_1_goods_30_contrib_cost { get; set; }
//        public int pages_1_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_31_id { get; set; }
//        public int pages_1_goods_31_contrib_cost { get; set; }
//        public int pages_1_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_1_goods_32_id { get; set; }
//        public int pages_1_goods_32_contrib_cost { get; set; }
//        public int pages_1_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_2_page_title;

//        public string Pages_2_page_title
//        {
//            get => Structure.Unicode.GetString(pages_2_page_title);
//            set { pages_2_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_2_require_contrib { get; set; }
//        public int pages_2_require_force { get; set; }
//        public int pages_2_require_force_reputation { get; set; }
//        [ItemId] public int pages_2_goods_1_id { get; set; }
//        public int pages_2_goods_1_contrib_cost { get; set; }
//        public int pages_2_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_2_id { get; set; }
//        public int pages_2_goods_2_contrib_cost { get; set; }
//        public int pages_2_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_3_id { get; set; }
//        public int pages_2_goods_3_contrib_cost { get; set; }
//        public int pages_2_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_4_id { get; set; }
//        public int pages_2_goods_4_contrib_cost { get; set; }
//        public int pages_2_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_5_id { get; set; }
//        public int pages_2_goods_5_contrib_cost { get; set; }
//        public int pages_2_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_6_id { get; set; }
//        public int pages_2_goods_6_contrib_cost { get; set; }
//        public int pages_2_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_7_id { get; set; }
//        public int pages_2_goods_7_contrib_cost { get; set; }
//        public int pages_2_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_8_id { get; set; }
//        public int pages_2_goods_8_contrib_cost { get; set; }
//        public int pages_2_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_9_id { get; set; }
//        public int pages_2_goods_9_contrib_cost { get; set; }
//        public int pages_2_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_10_id { get; set; }
//        public int pages_2_goods_10_contrib_cost { get; set; }
//        public int pages_2_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_11_id { get; set; }
//        public int pages_2_goods_11_contrib_cost { get; set; }
//        public int pages_2_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_12_id { get; set; }
//        public int pages_2_goods_12_contrib_cost { get; set; }
//        public int pages_2_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_13_id { get; set; }
//        public int pages_2_goods_13_contrib_cost { get; set; }
//        public int pages_2_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_14_id { get; set; }
//        public int pages_2_goods_14_contrib_cost { get; set; }
//        public int pages_2_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_15_id { get; set; }
//        public int pages_2_goods_15_contrib_cost { get; set; }
//        public int pages_2_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_16_id { get; set; }
//        public int pages_2_goods_16_contrib_cost { get; set; }
//        public int pages_2_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_17_id { get; set; }
//        public int pages_2_goods_17_contrib_cost { get; set; }
//        public int pages_2_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_18_id { get; set; }
//        public int pages_2_goods_18_contrib_cost { get; set; }
//        public int pages_2_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_19_id { get; set; }
//        public int pages_2_goods_19_contrib_cost { get; set; }
//        public int pages_2_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_20_id { get; set; }
//        public int pages_2_goods_20_contrib_cost { get; set; }
//        public int pages_2_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_21_id { get; set; }
//        public int pages_2_goods_21_contrib_cost { get; set; }
//        public int pages_2_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_22_id { get; set; }
//        public int pages_2_goods_22_contrib_cost { get; set; }
//        public int pages_2_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_23_id { get; set; }
//        public int pages_2_goods_23_contrib_cost { get; set; }
//        public int pages_2_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_24_id { get; set; }
//        public int pages_2_goods_24_contrib_cost { get; set; }
//        public int pages_2_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_25_id { get; set; }
//        public int pages_2_goods_25_contrib_cost { get; set; }
//        public int pages_2_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_26_id { get; set; }
//        public int pages_2_goods_26_contrib_cost { get; set; }
//        public int pages_2_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_27_id { get; set; }
//        public int pages_2_goods_27_contrib_cost { get; set; }
//        public int pages_2_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_28_id { get; set; }
//        public int pages_2_goods_28_contrib_cost { get; set; }
//        public int pages_2_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_29_id { get; set; }
//        public int pages_2_goods_29_contrib_cost { get; set; }
//        public int pages_2_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_30_id { get; set; }
//        public int pages_2_goods_30_contrib_cost { get; set; }
//        public int pages_2_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_31_id { get; set; }
//        public int pages_2_goods_31_contrib_cost { get; set; }
//        public int pages_2_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_2_goods_32_id { get; set; }
//        public int pages_2_goods_32_contrib_cost { get; set; }
//        public int pages_2_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_3_page_title;

//        public string Pages_3_page_title
//        {
//            get => Structure.Unicode.GetString(pages_3_page_title);
//            set { pages_3_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_3_require_contrib { get; set; }
//        public int pages_3_require_force { get; set; }
//        public int pages_3_require_force_reputation { get; set; }
//        [ItemId] public int pages_3_goods_1_id { get; set; }
//        public int pages_3_goods_1_contrib_cost { get; set; }
//        public int pages_3_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_2_id { get; set; }
//        public int pages_3_goods_2_contrib_cost { get; set; }
//        public int pages_3_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_3_id { get; set; }
//        public int pages_3_goods_3_contrib_cost { get; set; }
//        public int pages_3_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_4_id { get; set; }
//        public int pages_3_goods_4_contrib_cost { get; set; }
//        public int pages_3_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_5_id { get; set; }
//        public int pages_3_goods_5_contrib_cost { get; set; }
//        public int pages_3_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_6_id { get; set; }
//        public int pages_3_goods_6_contrib_cost { get; set; }
//        public int pages_3_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_7_id { get; set; }
//        public int pages_3_goods_7_contrib_cost { get; set; }
//        public int pages_3_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_8_id { get; set; }
//        public int pages_3_goods_8_contrib_cost { get; set; }
//        public int pages_3_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_9_id { get; set; }
//        public int pages_3_goods_9_contrib_cost { get; set; }
//        public int pages_3_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_10_id { get; set; }
//        public int pages_3_goods_10_contrib_cost { get; set; }
//        public int pages_3_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_11_id { get; set; }
//        public int pages_3_goods_11_contrib_cost { get; set; }
//        public int pages_3_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_12_id { get; set; }
//        public int pages_3_goods_12_contrib_cost { get; set; }
//        public int pages_3_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_13_id { get; set; }
//        public int pages_3_goods_13_contrib_cost { get; set; }
//        public int pages_3_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_14_id { get; set; }
//        public int pages_3_goods_14_contrib_cost { get; set; }
//        public int pages_3_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_15_id { get; set; }
//        public int pages_3_goods_15_contrib_cost { get; set; }
//        public int pages_3_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_16_id { get; set; }
//        public int pages_3_goods_16_contrib_cost { get; set; }
//        public int pages_3_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_17_id { get; set; }
//        public int pages_3_goods_17_contrib_cost { get; set; }
//        public int pages_3_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_18_id { get; set; }
//        public int pages_3_goods_18_contrib_cost { get; set; }
//        public int pages_3_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_19_id { get; set; }
//        public int pages_3_goods_19_contrib_cost { get; set; }
//        public int pages_3_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_20_id { get; set; }
//        public int pages_3_goods_20_contrib_cost { get; set; }
//        public int pages_3_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_21_id { get; set; }
//        public int pages_3_goods_21_contrib_cost { get; set; }
//        public int pages_3_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_22_id { get; set; }
//        public int pages_3_goods_22_contrib_cost { get; set; }
//        public int pages_3_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_23_id { get; set; }
//        public int pages_3_goods_23_contrib_cost { get; set; }
//        public int pages_3_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_24_id { get; set; }
//        public int pages_3_goods_24_contrib_cost { get; set; }
//        public int pages_3_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_25_id { get; set; }
//        public int pages_3_goods_25_contrib_cost { get; set; }
//        public int pages_3_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_26_id { get; set; }
//        public int pages_3_goods_26_contrib_cost { get; set; }
//        public int pages_3_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_27_id { get; set; }
//        public int pages_3_goods_27_contrib_cost { get; set; }
//        public int pages_3_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_28_id { get; set; }
//        public int pages_3_goods_28_contrib_cost { get; set; }
//        public int pages_3_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_29_id { get; set; }
//        public int pages_3_goods_29_contrib_cost { get; set; }
//        public int pages_3_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_30_id { get; set; }
//        public int pages_3_goods_30_contrib_cost { get; set; }
//        public int pages_3_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_31_id { get; set; }
//        public int pages_3_goods_31_contrib_cost { get; set; }
//        public int pages_3_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_3_goods_32_id { get; set; }
//        public int pages_3_goods_32_contrib_cost { get; set; }
//        public int pages_3_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_4_page_title;

//        public string Pages_4_page_title
//        {
//            get => Structure.Unicode.GetString(pages_4_page_title);
//            set { pages_4_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_4_require_contrib { get; set; }
//        public int pages_4_require_force { get; set; }
//        public int pages_4_require_force_reputation { get; set; }
//        [ItemId] public int pages_4_goods_1_id { get; set; }
//        public int pages_4_goods_1_contrib_cost { get; set; }
//        public int pages_4_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_2_id { get; set; }
//        public int pages_4_goods_2_contrib_cost { get; set; }
//        public int pages_4_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_3_id { get; set; }
//        public int pages_4_goods_3_contrib_cost { get; set; }
//        public int pages_4_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_4_id { get; set; }
//        public int pages_4_goods_4_contrib_cost { get; set; }
//        public int pages_4_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_5_id { get; set; }
//        public int pages_4_goods_5_contrib_cost { get; set; }
//        public int pages_4_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_6_id { get; set; }
//        public int pages_4_goods_6_contrib_cost { get; set; }
//        public int pages_4_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_7_id { get; set; }
//        public int pages_4_goods_7_contrib_cost { get; set; }
//        public int pages_4_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_8_id { get; set; }
//        public int pages_4_goods_8_contrib_cost { get; set; }
//        public int pages_4_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_9_id { get; set; }
//        public int pages_4_goods_9_contrib_cost { get; set; }
//        public int pages_4_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_10_id { get; set; }
//        public int pages_4_goods_10_contrib_cost { get; set; }
//        public int pages_4_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_11_id { get; set; }
//        public int pages_4_goods_11_contrib_cost { get; set; }
//        public int pages_4_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_12_id { get; set; }
//        public int pages_4_goods_12_contrib_cost { get; set; }
//        public int pages_4_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_13_id { get; set; }
//        public int pages_4_goods_13_contrib_cost { get; set; }
//        public int pages_4_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_14_id { get; set; }
//        public int pages_4_goods_14_contrib_cost { get; set; }
//        public int pages_4_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_15_id { get; set; }
//        public int pages_4_goods_15_contrib_cost { get; set; }
//        public int pages_4_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_16_id { get; set; }
//        public int pages_4_goods_16_contrib_cost { get; set; }
//        public int pages_4_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_17_id { get; set; }
//        public int pages_4_goods_17_contrib_cost { get; set; }
//        public int pages_4_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_18_id { get; set; }
//        public int pages_4_goods_18_contrib_cost { get; set; }
//        public int pages_4_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_19_id { get; set; }
//        public int pages_4_goods_19_contrib_cost { get; set; }
//        public int pages_4_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_20_id { get; set; }
//        public int pages_4_goods_20_contrib_cost { get; set; }
//        public int pages_4_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_21_id { get; set; }
//        public int pages_4_goods_21_contrib_cost { get; set; }
//        public int pages_4_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_22_id { get; set; }
//        public int pages_4_goods_22_contrib_cost { get; set; }
//        public int pages_4_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_23_id { get; set; }
//        public int pages_4_goods_23_contrib_cost { get; set; }
//        public int pages_4_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_24_id { get; set; }
//        public int pages_4_goods_24_contrib_cost { get; set; }
//        public int pages_4_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_25_id { get; set; }
//        public int pages_4_goods_25_contrib_cost { get; set; }
//        public int pages_4_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_26_id { get; set; }
//        public int pages_4_goods_26_contrib_cost { get; set; }
//        public int pages_4_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_27_id { get; set; }
//        public int pages_4_goods_27_contrib_cost { get; set; }
//        public int pages_4_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_28_id { get; set; }
//        public int pages_4_goods_28_contrib_cost { get; set; }
//        public int pages_4_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_29_id { get; set; }
//        public int pages_4_goods_29_contrib_cost { get; set; }
//        public int pages_4_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_30_id { get; set; }
//        public int pages_4_goods_30_contrib_cost { get; set; }
//        public int pages_4_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_31_id { get; set; }
//        public int pages_4_goods_31_contrib_cost { get; set; }
//        public int pages_4_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_4_goods_32_id { get; set; }
//        public int pages_4_goods_32_contrib_cost { get; set; }
//        public int pages_4_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_5_page_title;

//        public string Pages_5_page_title
//        {
//            get => Structure.Unicode.GetString(pages_5_page_title);
//            set { pages_5_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_5_require_contrib { get; set; }
//        public int pages_5_require_force { get; set; }
//        public int pages_5_require_force_reputation { get; set; }
//        [ItemId] public int pages_5_goods_1_id { get; set; }
//        public int pages_5_goods_1_contrib_cost { get; set; }
//        public int pages_5_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_2_id { get; set; }
//        public int pages_5_goods_2_contrib_cost { get; set; }
//        public int pages_5_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_3_id { get; set; }
//        public int pages_5_goods_3_contrib_cost { get; set; }
//        public int pages_5_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_4_id { get; set; }
//        public int pages_5_goods_4_contrib_cost { get; set; }
//        public int pages_5_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_5_id { get; set; }
//        public int pages_5_goods_5_contrib_cost { get; set; }
//        public int pages_5_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_6_id { get; set; }
//        public int pages_5_goods_6_contrib_cost { get; set; }
//        public int pages_5_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_7_id { get; set; }
//        public int pages_5_goods_7_contrib_cost { get; set; }
//        public int pages_5_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_8_id { get; set; }
//        public int pages_5_goods_8_contrib_cost { get; set; }
//        public int pages_5_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_9_id { get; set; }
//        public int pages_5_goods_9_contrib_cost { get; set; }
//        public int pages_5_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_10_id { get; set; }
//        public int pages_5_goods_10_contrib_cost { get; set; }
//        public int pages_5_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_11_id { get; set; }
//        public int pages_5_goods_11_contrib_cost { get; set; }
//        public int pages_5_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_12_id { get; set; }
//        public int pages_5_goods_12_contrib_cost { get; set; }
//        public int pages_5_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_13_id { get; set; }
//        public int pages_5_goods_13_contrib_cost { get; set; }
//        public int pages_5_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_14_id { get; set; }
//        public int pages_5_goods_14_contrib_cost { get; set; }
//        public int pages_5_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_15_id { get; set; }
//        public int pages_5_goods_15_contrib_cost { get; set; }
//        public int pages_5_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_16_id { get; set; }
//        public int pages_5_goods_16_contrib_cost { get; set; }
//        public int pages_5_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_17_id { get; set; }
//        public int pages_5_goods_17_contrib_cost { get; set; }
//        public int pages_5_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_18_id { get; set; }
//        public int pages_5_goods_18_contrib_cost { get; set; }
//        public int pages_5_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_19_id { get; set; }
//        public int pages_5_goods_19_contrib_cost { get; set; }
//        public int pages_5_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_20_id { get; set; }
//        public int pages_5_goods_20_contrib_cost { get; set; }
//        public int pages_5_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_21_id { get; set; }
//        public int pages_5_goods_21_contrib_cost { get; set; }
//        public int pages_5_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_22_id { get; set; }
//        public int pages_5_goods_22_contrib_cost { get; set; }
//        public int pages_5_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_23_id { get; set; }
//        public int pages_5_goods_23_contrib_cost { get; set; }
//        public int pages_5_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_24_id { get; set; }
//        public int pages_5_goods_24_contrib_cost { get; set; }
//        public int pages_5_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_25_id { get; set; }
//        public int pages_5_goods_25_contrib_cost { get; set; }
//        public int pages_5_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_26_id { get; set; }
//        public int pages_5_goods_26_contrib_cost { get; set; }
//        public int pages_5_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_27_id { get; set; }
//        public int pages_5_goods_27_contrib_cost { get; set; }
//        public int pages_5_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_28_id { get; set; }
//        public int pages_5_goods_28_contrib_cost { get; set; }
//        public int pages_5_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_29_id { get; set; }
//        public int pages_5_goods_29_contrib_cost { get; set; }
//        public int pages_5_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_30_id { get; set; }
//        public int pages_5_goods_30_contrib_cost { get; set; }
//        public int pages_5_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_31_id { get; set; }
//        public int pages_5_goods_31_contrib_cost { get; set; }
//        public int pages_5_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_5_goods_32_id { get; set; }
//        public int pages_5_goods_32_contrib_cost { get; set; }
//        public int pages_5_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_6_page_title;

//        public string Pages_6_page_title
//        {
//            get => Structure.Unicode.GetString(pages_6_page_title);
//            set { pages_6_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_6_require_contrib { get; set; }
//        public int pages_6_require_force { get; set; }
//        public int pages_6_require_force_reputation { get; set; }
//        [ItemId] public int pages_6_goods_1_id { get; set; }
//        public int pages_6_goods_1_contrib_cost { get; set; }
//        public int pages_6_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_2_id { get; set; }
//        public int pages_6_goods_2_contrib_cost { get; set; }
//        public int pages_6_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_3_id { get; set; }
//        public int pages_6_goods_3_contrib_cost { get; set; }
//        public int pages_6_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_4_id { get; set; }
//        public int pages_6_goods_4_contrib_cost { get; set; }
//        public int pages_6_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_5_id { get; set; }
//        public int pages_6_goods_5_contrib_cost { get; set; }
//        public int pages_6_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_6_id { get; set; }
//        public int pages_6_goods_6_contrib_cost { get; set; }
//        public int pages_6_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_7_id { get; set; }
//        public int pages_6_goods_7_contrib_cost { get; set; }
//        public int pages_6_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_8_id { get; set; }
//        public int pages_6_goods_8_contrib_cost { get; set; }
//        public int pages_6_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_9_id { get; set; }
//        public int pages_6_goods_9_contrib_cost { get; set; }
//        public int pages_6_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_10_id { get; set; }
//        public int pages_6_goods_10_contrib_cost { get; set; }
//        public int pages_6_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_11_id { get; set; }
//        public int pages_6_goods_11_contrib_cost { get; set; }
//        public int pages_6_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_12_id { get; set; }
//        public int pages_6_goods_12_contrib_cost { get; set; }
//        public int pages_6_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_13_id { get; set; }
//        public int pages_6_goods_13_contrib_cost { get; set; }
//        public int pages_6_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_14_id { get; set; }
//        public int pages_6_goods_14_contrib_cost { get; set; }
//        public int pages_6_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_15_id { get; set; }
//        public int pages_6_goods_15_contrib_cost { get; set; }
//        public int pages_6_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_16_id { get; set; }
//        public int pages_6_goods_16_contrib_cost { get; set; }
//        public int pages_6_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_17_id { get; set; }
//        public int pages_6_goods_17_contrib_cost { get; set; }
//        public int pages_6_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_18_id { get; set; }
//        public int pages_6_goods_18_contrib_cost { get; set; }
//        public int pages_6_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_19_id { get; set; }
//        public int pages_6_goods_19_contrib_cost { get; set; }
//        public int pages_6_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_20_id { get; set; }
//        public int pages_6_goods_20_contrib_cost { get; set; }
//        public int pages_6_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_21_id { get; set; }
//        public int pages_6_goods_21_contrib_cost { get; set; }
//        public int pages_6_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_22_id { get; set; }
//        public int pages_6_goods_22_contrib_cost { get; set; }
//        public int pages_6_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_23_id { get; set; }
//        public int pages_6_goods_23_contrib_cost { get; set; }
//        public int pages_6_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_24_id { get; set; }
//        public int pages_6_goods_24_contrib_cost { get; set; }
//        public int pages_6_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_25_id { get; set; }
//        public int pages_6_goods_25_contrib_cost { get; set; }
//        public int pages_6_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_26_id { get; set; }
//        public int pages_6_goods_26_contrib_cost { get; set; }
//        public int pages_6_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_27_id { get; set; }
//        public int pages_6_goods_27_contrib_cost { get; set; }
//        public int pages_6_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_28_id { get; set; }
//        public int pages_6_goods_28_contrib_cost { get; set; }
//        public int pages_6_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_29_id { get; set; }
//        public int pages_6_goods_29_contrib_cost { get; set; }
//        public int pages_6_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_30_id { get; set; }
//        public int pages_6_goods_30_contrib_cost { get; set; }
//        public int pages_6_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_31_id { get; set; }
//        public int pages_6_goods_31_contrib_cost { get; set; }
//        public int pages_6_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_6_goods_32_id { get; set; }
//        public int pages_6_goods_32_contrib_cost { get; set; }
//        public int pages_6_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_7_page_title;

//        public string Pages_7_page_title
//        {
//            get => Structure.Unicode.GetString(pages_7_page_title);
//            set { pages_7_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_7_require_contrib { get; set; }
//        public int pages_7_require_force { get; set; }
//        public int pages_7_require_force_reputation { get; set; }
//        [ItemId] public int pages_7_goods_1_id { get; set; }
//        public int pages_7_goods_1_contrib_cost { get; set; }
//        public int pages_7_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_2_id { get; set; }
//        public int pages_7_goods_2_contrib_cost { get; set; }
//        public int pages_7_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_3_id { get; set; }
//        public int pages_7_goods_3_contrib_cost { get; set; }
//        public int pages_7_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_4_id { get; set; }
//        public int pages_7_goods_4_contrib_cost { get; set; }
//        public int pages_7_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_5_id { get; set; }
//        public int pages_7_goods_5_contrib_cost { get; set; }
//        public int pages_7_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_6_id { get; set; }
//        public int pages_7_goods_6_contrib_cost { get; set; }
//        public int pages_7_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_7_id { get; set; }
//        public int pages_7_goods_7_contrib_cost { get; set; }
//        public int pages_7_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_8_id { get; set; }
//        public int pages_7_goods_8_contrib_cost { get; set; }
//        public int pages_7_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_9_id { get; set; }
//        public int pages_7_goods_9_contrib_cost { get; set; }
//        public int pages_7_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_10_id { get; set; }
//        public int pages_7_goods_10_contrib_cost { get; set; }
//        public int pages_7_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_11_id { get; set; }
//        public int pages_7_goods_11_contrib_cost { get; set; }
//        public int pages_7_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_12_id { get; set; }
//        public int pages_7_goods_12_contrib_cost { get; set; }
//        public int pages_7_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_13_id { get; set; }
//        public int pages_7_goods_13_contrib_cost { get; set; }
//        public int pages_7_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_14_id { get; set; }
//        public int pages_7_goods_14_contrib_cost { get; set; }
//        public int pages_7_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_15_id { get; set; }
//        public int pages_7_goods_15_contrib_cost { get; set; }
//        public int pages_7_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_16_id { get; set; }
//        public int pages_7_goods_16_contrib_cost { get; set; }
//        public int pages_7_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_17_id { get; set; }
//        public int pages_7_goods_17_contrib_cost { get; set; }
//        public int pages_7_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_18_id { get; set; }
//        public int pages_7_goods_18_contrib_cost { get; set; }
//        public int pages_7_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_19_id { get; set; }
//        public int pages_7_goods_19_contrib_cost { get; set; }
//        public int pages_7_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_20_id { get; set; }
//        public int pages_7_goods_20_contrib_cost { get; set; }
//        public int pages_7_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_21_id { get; set; }
//        public int pages_7_goods_21_contrib_cost { get; set; }
//        public int pages_7_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_22_id { get; set; }
//        public int pages_7_goods_22_contrib_cost { get; set; }
//        public int pages_7_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_23_id { get; set; }
//        public int pages_7_goods_23_contrib_cost { get; set; }
//        public int pages_7_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_24_id { get; set; }
//        public int pages_7_goods_24_contrib_cost { get; set; }
//        public int pages_7_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_25_id { get; set; }
//        public int pages_7_goods_25_contrib_cost { get; set; }
//        public int pages_7_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_26_id { get; set; }
//        public int pages_7_goods_26_contrib_cost { get; set; }
//        public int pages_7_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_27_id { get; set; }
//        public int pages_7_goods_27_contrib_cost { get; set; }
//        public int pages_7_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_28_id { get; set; }
//        public int pages_7_goods_28_contrib_cost { get; set; }
//        public int pages_7_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_29_id { get; set; }
//        public int pages_7_goods_29_contrib_cost { get; set; }
//        public int pages_7_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_30_id { get; set; }
//        public int pages_7_goods_30_contrib_cost { get; set; }
//        public int pages_7_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_31_id { get; set; }
//        public int pages_7_goods_31_contrib_cost { get; set; }
//        public int pages_7_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_7_goods_32_id { get; set; }
//        public int pages_7_goods_32_contrib_cost { get; set; }
//        public int pages_7_goods_32_force_contribution_cost { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_8_page_title;

//        public string Pages_8_page_title
//        {
//            get => Structure.Unicode.GetString(pages_8_page_title);
//            set { pages_8_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_8_require_contrib { get; set; }
//        public int pages_8_require_force { get; set; }
//        public int pages_8_require_force_reputation { get; set; }
//        [ItemId] public int pages_8_goods_1_id { get; set; }
//        public int pages_8_goods_1_contrib_cost { get; set; }
//        public int pages_8_goods_1_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_2_id { get; set; }
//        public int pages_8_goods_2_contrib_cost { get; set; }
//        public int pages_8_goods_2_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_3_id { get; set; }
//        public int pages_8_goods_3_contrib_cost { get; set; }
//        public int pages_8_goods_3_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_4_id { get; set; }
//        public int pages_8_goods_4_contrib_cost { get; set; }
//        public int pages_8_goods_4_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_5_id { get; set; }
//        public int pages_8_goods_5_contrib_cost { get; set; }
//        public int pages_8_goods_5_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_6_id { get; set; }
//        public int pages_8_goods_6_contrib_cost { get; set; }
//        public int pages_8_goods_6_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_7_id { get; set; }
//        public int pages_8_goods_7_contrib_cost { get; set; }
//        public int pages_8_goods_7_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_8_id { get; set; }
//        public int pages_8_goods_8_contrib_cost { get; set; }
//        public int pages_8_goods_8_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_9_id { get; set; }
//        public int pages_8_goods_9_contrib_cost { get; set; }
//        public int pages_8_goods_9_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_10_id { get; set; }
//        public int pages_8_goods_10_contrib_cost { get; set; }
//        public int pages_8_goods_10_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_11_id { get; set; }
//        public int pages_8_goods_11_contrib_cost { get; set; }
//        public int pages_8_goods_11_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_12_id { get; set; }
//        public int pages_8_goods_12_contrib_cost { get; set; }
//        public int pages_8_goods_12_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_13_id { get; set; }
//        public int pages_8_goods_13_contrib_cost { get; set; }
//        public int pages_8_goods_13_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_14_id { get; set; }
//        public int pages_8_goods_14_contrib_cost { get; set; }
//        public int pages_8_goods_14_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_15_id { get; set; }
//        public int pages_8_goods_15_contrib_cost { get; set; }
//        public int pages_8_goods_15_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_16_id { get; set; }
//        public int pages_8_goods_16_contrib_cost { get; set; }
//        public int pages_8_goods_16_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_17_id { get; set; }
//        public int pages_8_goods_17_contrib_cost { get; set; }
//        public int pages_8_goods_17_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_18_id { get; set; }
//        public int pages_8_goods_18_contrib_cost { get; set; }
//        public int pages_8_goods_18_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_19_id { get; set; }
//        public int pages_8_goods_19_contrib_cost { get; set; }
//        public int pages_8_goods_19_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_20_id { get; set; }
//        public int pages_8_goods_20_contrib_cost { get; set; }
//        public int pages_8_goods_20_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_21_id { get; set; }
//        public int pages_8_goods_21_contrib_cost { get; set; }
//        public int pages_8_goods_21_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_22_id { get; set; }
//        public int pages_8_goods_22_contrib_cost { get; set; }
//        public int pages_8_goods_22_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_23_id { get; set; }
//        public int pages_8_goods_23_contrib_cost { get; set; }
//        public int pages_8_goods_23_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_24_id { get; set; }
//        public int pages_8_goods_24_contrib_cost { get; set; }
//        public int pages_8_goods_24_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_25_id { get; set; }
//        public int pages_8_goods_25_contrib_cost { get; set; }
//        public int pages_8_goods_25_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_26_id { get; set; }
//        public int pages_8_goods_26_contrib_cost { get; set; }
//        public int pages_8_goods_26_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_27_id { get; set; }
//        public int pages_8_goods_27_contrib_cost { get; set; }
//        public int pages_8_goods_27_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_28_id { get; set; }
//        public int pages_8_goods_28_contrib_cost { get; set; }
//        public int pages_8_goods_28_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_29_id { get; set; }
//        public int pages_8_goods_29_contrib_cost { get; set; }
//        public int pages_8_goods_29_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_30_id { get; set; }
//        public int pages_8_goods_30_contrib_cost { get; set; }
//        public int pages_8_goods_30_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_31_id { get; set; }
//        public int pages_8_goods_31_contrib_cost { get; set; }
//        public int pages_8_goods_31_force_contribution_cost { get; set; }
//        [ItemId] public int pages_8_goods_32_id { get; set; }
//        public int pages_8_goods_32_contrib_cost { get; set; }
//        public int pages_8_goods_32_force_contribution_cost { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_BUY_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_REPAIR_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_INSTALL_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_goods_1 { get; set; }
//        public int id_goods_2 { get; set; }
//        public int id_goods_3 { get; set; }
//        public int id_goods_4 { get; set; }
//        public int id_goods_5 { get; set; }
//        public int id_goods_6 { get; set; }
//        public int id_goods_7 { get; set; }
//        public int id_goods_8 { get; set; }
//        public int id_goods_9 { get; set; }
//        public int id_goods_10 { get; set; }
//        public int id_goods_11 { get; set; }
//        public int id_goods_12 { get; set; }
//        public int id_goods_13 { get; set; }
//        public int id_goods_14 { get; set; }
//        public int id_goods_15 { get; set; }
//        public int id_goods_16 { get; set; }
//        public int id_goods_17 { get; set; }
//        public int id_goods_18 { get; set; }
//        public int id_goods_19 { get; set; }
//        public int id_goods_20 { get; set; }
//        public int id_goods_21 { get; set; }
//        public int id_goods_22 { get; set; }
//        public int id_goods_23 { get; set; }
//        public int id_goods_24 { get; set; }
//        public int id_goods_25 { get; set; }
//        public int id_goods_26 { get; set; }
//        public int id_goods_27 { get; set; }
//        public int id_goods_28 { get; set; }
//        public int id_goods_29 { get; set; }
//        public int id_goods_30 { get; set; }
//        public int id_goods_31 { get; set; }
//        public int id_goods_32 { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_UNINSTALL_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_goods_1 { get; set; }
//        public int id_goods_2 { get; set; }
//        public int id_goods_3 { get; set; }
//        public int id_goods_4 { get; set; }
//        public int id_goods_5 { get; set; }
//        public int id_goods_6 { get; set; }
//        public int id_goods_7 { get; set; }
//        public int id_goods_8 { get; set; }
//        public int id_goods_9 { get; set; }
//        public int id_goods_10 { get; set; }
//        public int id_goods_11 { get; set; }
//        public int id_goods_12 { get; set; }
//        public int id_goods_13 { get; set; }
//        public int id_goods_14 { get; set; }
//        public int id_goods_15 { get; set; }
//        public int id_goods_16 { get; set; }
//        public int id_goods_17 { get; set; }
//        public int id_goods_18 { get; set; }
//        public int id_goods_19 { get; set; }
//        public int id_goods_20 { get; set; }
//        public int id_goods_21 { get; set; }
//        public int id_goods_22 { get; set; }
//        public int id_goods_23 { get; set; }
//        public int id_goods_24 { get; set; }
//        public int id_goods_25 { get; set; }
//        public int id_goods_26 { get; set; }
//        public int id_goods_27 { get; set; }
//        public int id_goods_28 { get; set; }
//        public int id_goods_29 { get; set; }
//        public int id_goods_30 { get; set; }
//        public int id_goods_31 { get; set; }
//        public int id_goods_32 { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TASK_IN_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_tasks_1 { get; set; }
//        public int id_tasks_2 { get; set; }
//        public int id_tasks_3 { get; set; }
//        public int id_tasks_4 { get; set; }
//        public int id_tasks_5 { get; set; }
//        public int id_tasks_6 { get; set; }
//        public int id_tasks_7 { get; set; }
//        public int id_tasks_8 { get; set; }
//        public int id_tasks_9 { get; set; }
//        public int id_tasks_10 { get; set; }
//        public int id_tasks_11 { get; set; }
//        public int id_tasks_12 { get; set; }
//        public int id_tasks_13 { get; set; }
//        public int id_tasks_14 { get; set; }
//        public int id_tasks_15 { get; set; }
//        public int id_tasks_16 { get; set; }
//        public int id_tasks_17 { get; set; }
//        public int id_tasks_18 { get; set; }
//        public int id_tasks_19 { get; set; }
//        public int id_tasks_20 { get; set; }
//        public int id_tasks_21 { get; set; }
//        public int id_tasks_22 { get; set; }
//        public int id_tasks_23 { get; set; }
//        public int id_tasks_24 { get; set; }
//        public int id_tasks_25 { get; set; }
//        public int id_tasks_26 { get; set; }
//        public int id_tasks_27 { get; set; }
//        public int id_tasks_28 { get; set; }
//        public int id_tasks_29 { get; set; }
//        public int id_tasks_30 { get; set; }
//        public int id_tasks_31 { get; set; }
//        public int id_tasks_32 { get; set; }
//        public int id_tasks_33 { get; set; }
//        public int id_tasks_34 { get; set; }
//        public int id_tasks_35 { get; set; }
//        public int id_tasks_36 { get; set; }
//        public int id_tasks_37 { get; set; }
//        public int id_tasks_38 { get; set; }
//        public int id_tasks_39 { get; set; }
//        public int id_tasks_40 { get; set; }
//        public int id_tasks_41 { get; set; }
//        public int id_tasks_42 { get; set; }
//        public int id_tasks_43 { get; set; }
//        public int id_tasks_44 { get; set; }
//        public int id_tasks_45 { get; set; }
//        public int id_tasks_46 { get; set; }
//        public int id_tasks_47 { get; set; }
//        public int id_tasks_48 { get; set; }
//        public int id_tasks_49 { get; set; }
//        public int id_tasks_50 { get; set; }
//        public int id_tasks_51 { get; set; }
//        public int id_tasks_52 { get; set; }
//        public int id_tasks_53 { get; set; }
//        public int id_tasks_54 { get; set; }
//        public int id_tasks_55 { get; set; }
//        public int id_tasks_56 { get; set; }
//        public int id_tasks_57 { get; set; }
//        public int id_tasks_58 { get; set; }
//        public int id_tasks_59 { get; set; }
//        public int id_tasks_60 { get; set; }
//        public int id_tasks_61 { get; set; }
//        public int id_tasks_62 { get; set; }
//        public int id_tasks_63 { get; set; }
//        public int id_tasks_64 { get; set; }
//        public int id_tasks_65 { get; set; }
//        public int id_tasks_66 { get; set; }
//        public int id_tasks_67 { get; set; }
//        public int id_tasks_68 { get; set; }
//        public int id_tasks_69 { get; set; }
//        public int id_tasks_70 { get; set; }
//        public int id_tasks_71 { get; set; }
//        public int id_tasks_72 { get; set; }
//        public int id_tasks_73 { get; set; }
//        public int id_tasks_74 { get; set; }
//        public int id_tasks_75 { get; set; }
//        public int id_tasks_76 { get; set; }
//        public int id_tasks_77 { get; set; }
//        public int id_tasks_78 { get; set; }
//        public int id_tasks_79 { get; set; }
//        public int id_tasks_80 { get; set; }
//        public int id_tasks_81 { get; set; }
//        public int id_tasks_82 { get; set; }
//        public int id_tasks_83 { get; set; }
//        public int id_tasks_84 { get; set; }
//        public int id_tasks_85 { get; set; }
//        public int id_tasks_86 { get; set; }
//        public int id_tasks_87 { get; set; }
//        public int id_tasks_88 { get; set; }
//        public int id_tasks_89 { get; set; }
//        public int id_tasks_90 { get; set; }
//        public int id_tasks_91 { get; set; }
//        public int id_tasks_92 { get; set; }
//        public int id_tasks_93 { get; set; }
//        public int id_tasks_94 { get; set; }
//        public int id_tasks_95 { get; set; }
//        public int id_tasks_96 { get; set; }
//        public int id_tasks_97 { get; set; }
//        public int id_tasks_98 { get; set; }
//        public int id_tasks_99 { get; set; }
//        public int id_tasks_100 { get; set; }
//        public int id_tasks_101 { get; set; }
//        public int id_tasks_102 { get; set; }
//        public int id_tasks_103 { get; set; }
//        public int id_tasks_104 { get; set; }
//        public int id_tasks_105 { get; set; }
//        public int id_tasks_106 { get; set; }
//        public int id_tasks_107 { get; set; }
//        public int id_tasks_108 { get; set; }
//        public int id_tasks_109 { get; set; }
//        public int id_tasks_110 { get; set; }
//        public int id_tasks_111 { get; set; }
//        public int id_tasks_112 { get; set; }
//        public int id_tasks_113 { get; set; }
//        public int id_tasks_114 { get; set; }
//        public int id_tasks_115 { get; set; }
//        public int id_tasks_116 { get; set; }
//        public int id_tasks_117 { get; set; }
//        public int id_tasks_118 { get; set; }
//        public int id_tasks_119 { get; set; }
//        public int id_tasks_120 { get; set; }
//        public int id_tasks_121 { get; set; }
//        public int id_tasks_122 { get; set; }
//        public int id_tasks_123 { get; set; }
//        public int id_tasks_124 { get; set; }
//        public int id_tasks_125 { get; set; }
//        public int id_tasks_126 { get; set; }
//        public int id_tasks_127 { get; set; }
//        public int id_tasks_128 { get; set; }
//        public int id_tasks_129 { get; set; }
//        public int id_tasks_130 { get; set; }
//        public int id_tasks_131 { get; set; }
//        public int id_tasks_132 { get; set; }
//        public int id_tasks_133 { get; set; }
//        public int id_tasks_134 { get; set; }
//        public int id_tasks_135 { get; set; }
//        public int id_tasks_136 { get; set; }
//        public int id_tasks_137 { get; set; }
//        public int id_tasks_138 { get; set; }
//        public int id_tasks_139 { get; set; }
//        public int id_tasks_140 { get; set; }
//        public int id_tasks_141 { get; set; }
//        public int id_tasks_142 { get; set; }
//        public int id_tasks_143 { get; set; }
//        public int id_tasks_144 { get; set; }
//        public int id_tasks_145 { get; set; }
//        public int id_tasks_146 { get; set; }
//        public int id_tasks_147 { get; set; }
//        public int id_tasks_148 { get; set; }
//        public int id_tasks_149 { get; set; }
//        public int id_tasks_150 { get; set; }
//        public int id_tasks_151 { get; set; }
//        public int id_tasks_152 { get; set; }
//        public int id_tasks_153 { get; set; }
//        public int id_tasks_154 { get; set; }
//        public int id_tasks_155 { get; set; }
//        public int id_tasks_156 { get; set; }
//        public int id_tasks_157 { get; set; }
//        public int id_tasks_158 { get; set; }
//        public int id_tasks_159 { get; set; }
//        public int id_tasks_160 { get; set; }
//        public int id_tasks_161 { get; set; }
//        public int id_tasks_162 { get; set; }
//        public int id_tasks_163 { get; set; }
//        public int id_tasks_164 { get; set; }
//        public int id_tasks_165 { get; set; }
//        public int id_tasks_166 { get; set; }
//        public int id_tasks_167 { get; set; }
//        public int id_tasks_168 { get; set; }
//        public int id_tasks_169 { get; set; }
//        public int id_tasks_170 { get; set; }
//        public int id_tasks_171 { get; set; }
//        public int id_tasks_172 { get; set; }
//        public int id_tasks_173 { get; set; }
//        public int id_tasks_174 { get; set; }
//        public int id_tasks_175 { get; set; }
//        public int id_tasks_176 { get; set; }
//        public int id_tasks_177 { get; set; }
//        public int id_tasks_178 { get; set; }
//        public int id_tasks_179 { get; set; }
//        public int id_tasks_180 { get; set; }
//        public int id_tasks_181 { get; set; }
//        public int id_tasks_182 { get; set; }
//        public int id_tasks_183 { get; set; }
//        public int id_tasks_184 { get; set; }
//        public int id_tasks_185 { get; set; }
//        public int id_tasks_186 { get; set; }
//        public int id_tasks_187 { get; set; }
//        public int id_tasks_188 { get; set; }
//        public int id_tasks_189 { get; set; }
//        public int id_tasks_190 { get; set; }
//        public int id_tasks_191 { get; set; }
//        public int id_tasks_192 { get; set; }
//        public int id_tasks_193 { get; set; }
//        public int id_tasks_194 { get; set; }
//        public int id_tasks_195 { get; set; }
//        public int id_tasks_196 { get; set; }
//        public int id_tasks_197 { get; set; }
//        public int id_tasks_198 { get; set; }
//        public int id_tasks_199 { get; set; }
//        public int id_tasks_200 { get; set; }
//        public int id_tasks_201 { get; set; }
//        public int id_tasks_202 { get; set; }
//        public int id_tasks_203 { get; set; }
//        public int id_tasks_204 { get; set; }
//        public int id_tasks_205 { get; set; }
//        public int id_tasks_206 { get; set; }
//        public int id_tasks_207 { get; set; }
//        public int id_tasks_208 { get; set; }
//        public int id_tasks_209 { get; set; }
//        public int id_tasks_210 { get; set; }
//        public int id_tasks_211 { get; set; }
//        public int id_tasks_212 { get; set; }
//        public int id_tasks_213 { get; set; }
//        public int id_tasks_214 { get; set; }
//        public int id_tasks_215 { get; set; }
//        public int id_tasks_216 { get; set; }
//        public int id_tasks_217 { get; set; }
//        public int id_tasks_218 { get; set; }
//        public int id_tasks_219 { get; set; }
//        public int id_tasks_220 { get; set; }
//        public int id_tasks_221 { get; set; }
//        public int id_tasks_222 { get; set; }
//        public int id_tasks_223 { get; set; }
//        public int id_tasks_224 { get; set; }
//        public int id_tasks_225 { get; set; }
//        public int id_tasks_226 { get; set; }
//        public int id_tasks_227 { get; set; }
//        public int id_tasks_228 { get; set; }
//        public int id_tasks_229 { get; set; }
//        public int id_tasks_230 { get; set; }
//        public int id_tasks_231 { get; set; }
//        public int id_tasks_232 { get; set; }
//        public int id_tasks_233 { get; set; }
//        public int id_tasks_234 { get; set; }
//        public int id_tasks_235 { get; set; }
//        public int id_tasks_236 { get; set; }
//        public int id_tasks_237 { get; set; }
//        public int id_tasks_238 { get; set; }
//        public int id_tasks_239 { get; set; }
//        public int id_tasks_240 { get; set; }
//        public int id_tasks_241 { get; set; }
//        public int id_tasks_242 { get; set; }
//        public int id_tasks_243 { get; set; }
//        public int id_tasks_244 { get; set; }
//        public int id_tasks_245 { get; set; }
//        public int id_tasks_246 { get; set; }
//        public int id_tasks_247 { get; set; }
//        public int id_tasks_248 { get; set; }
//        public int id_tasks_249 { get; set; }
//        public int id_tasks_250 { get; set; }
//        public int id_tasks_251 { get; set; }
//        public int id_tasks_252 { get; set; }
//        public int id_tasks_253 { get; set; }
//        public int id_tasks_254 { get; set; }
//        public int id_tasks_255 { get; set; }
//        public int id_tasks_256 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TASK_OUT_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int storage_id { get; set; }
//        public int storage_open_item { get; set; }
//        public int storage_refresh_item { get; set; }
//        public int storage_refresh_per_day { get; set; }
//        public int storage_refresh_count_min { get; set; }
//        public int storage_refresh_count_max { get; set; }
//        public int storage_deliver_per_day { get; set; }
//        public int id_tasks_1 { get; set; }
//        public int id_tasks_2 { get; set; }
//        public int id_tasks_3 { get; set; }
//        public int id_tasks_4 { get; set; }
//        public int id_tasks_5 { get; set; }
//        public int id_tasks_6 { get; set; }
//        public int id_tasks_7 { get; set; }
//        public int id_tasks_8 { get; set; }
//        public int id_tasks_9 { get; set; }
//        public int id_tasks_10 { get; set; }
//        public int id_tasks_11 { get; set; }
//        public int id_tasks_12 { get; set; }
//        public int id_tasks_13 { get; set; }
//        public int id_tasks_14 { get; set; }
//        public int id_tasks_15 { get; set; }
//        public int id_tasks_16 { get; set; }
//        public int id_tasks_17 { get; set; }
//        public int id_tasks_18 { get; set; }
//        public int id_tasks_19 { get; set; }
//        public int id_tasks_20 { get; set; }
//        public int id_tasks_21 { get; set; }
//        public int id_tasks_22 { get; set; }
//        public int id_tasks_23 { get; set; }
//        public int id_tasks_24 { get; set; }
//        public int id_tasks_25 { get; set; }
//        public int id_tasks_26 { get; set; }
//        public int id_tasks_27 { get; set; }
//        public int id_tasks_28 { get; set; }
//        public int id_tasks_29 { get; set; }
//        public int id_tasks_30 { get; set; }
//        public int id_tasks_31 { get; set; }
//        public int id_tasks_32 { get; set; }
//        public int id_tasks_33 { get; set; }
//        public int id_tasks_34 { get; set; }
//        public int id_tasks_35 { get; set; }
//        public int id_tasks_36 { get; set; }
//        public int id_tasks_37 { get; set; }
//        public int id_tasks_38 { get; set; }
//        public int id_tasks_39 { get; set; }
//        public int id_tasks_40 { get; set; }
//        public int id_tasks_41 { get; set; }
//        public int id_tasks_42 { get; set; }
//        public int id_tasks_43 { get; set; }
//        public int id_tasks_44 { get; set; }
//        public int id_tasks_45 { get; set; }
//        public int id_tasks_46 { get; set; }
//        public int id_tasks_47 { get; set; }
//        public int id_tasks_48 { get; set; }
//        public int id_tasks_49 { get; set; }
//        public int id_tasks_50 { get; set; }
//        public int id_tasks_51 { get; set; }
//        public int id_tasks_52 { get; set; }
//        public int id_tasks_53 { get; set; }
//        public int id_tasks_54 { get; set; }
//        public int id_tasks_55 { get; set; }
//        public int id_tasks_56 { get; set; }
//        public int id_tasks_57 { get; set; }
//        public int id_tasks_58 { get; set; }
//        public int id_tasks_59 { get; set; }
//        public int id_tasks_60 { get; set; }
//        public int id_tasks_61 { get; set; }
//        public int id_tasks_62 { get; set; }
//        public int id_tasks_63 { get; set; }
//        public int id_tasks_64 { get; set; }
//        public int id_tasks_65 { get; set; }
//        public int id_tasks_66 { get; set; }
//        public int id_tasks_67 { get; set; }
//        public int id_tasks_68 { get; set; }
//        public int id_tasks_69 { get; set; }
//        public int id_tasks_70 { get; set; }
//        public int id_tasks_71 { get; set; }
//        public int id_tasks_72 { get; set; }
//        public int id_tasks_73 { get; set; }
//        public int id_tasks_74 { get; set; }
//        public int id_tasks_75 { get; set; }
//        public int id_tasks_76 { get; set; }
//        public int id_tasks_77 { get; set; }
//        public int id_tasks_78 { get; set; }
//        public int id_tasks_79 { get; set; }
//        public int id_tasks_80 { get; set; }
//        public int id_tasks_81 { get; set; }
//        public int id_tasks_82 { get; set; }
//        public int id_tasks_83 { get; set; }
//        public int id_tasks_84 { get; set; }
//        public int id_tasks_85 { get; set; }
//        public int id_tasks_86 { get; set; }
//        public int id_tasks_87 { get; set; }
//        public int id_tasks_88 { get; set; }
//        public int id_tasks_89 { get; set; }
//        public int id_tasks_90 { get; set; }
//        public int id_tasks_91 { get; set; }
//        public int id_tasks_92 { get; set; }
//        public int id_tasks_93 { get; set; }
//        public int id_tasks_94 { get; set; }
//        public int id_tasks_95 { get; set; }
//        public int id_tasks_96 { get; set; }
//        public int id_tasks_97 { get; set; }
//        public int id_tasks_98 { get; set; }
//        public int id_tasks_99 { get; set; }
//        public int id_tasks_100 { get; set; }
//        public int id_tasks_101 { get; set; }
//        public int id_tasks_102 { get; set; }
//        public int id_tasks_103 { get; set; }
//        public int id_tasks_104 { get; set; }
//        public int id_tasks_105 { get; set; }
//        public int id_tasks_106 { get; set; }
//        public int id_tasks_107 { get; set; }
//        public int id_tasks_108 { get; set; }
//        public int id_tasks_109 { get; set; }
//        public int id_tasks_110 { get; set; }
//        public int id_tasks_111 { get; set; }
//        public int id_tasks_112 { get; set; }
//        public int id_tasks_113 { get; set; }
//        public int id_tasks_114 { get; set; }
//        public int id_tasks_115 { get; set; }
//        public int id_tasks_116 { get; set; }
//        public int id_tasks_117 { get; set; }
//        public int id_tasks_118 { get; set; }
//        public int id_tasks_119 { get; set; }
//        public int id_tasks_120 { get; set; }
//        public int id_tasks_121 { get; set; }
//        public int id_tasks_122 { get; set; }
//        public int id_tasks_123 { get; set; }
//        public int id_tasks_124 { get; set; }
//        public int id_tasks_125 { get; set; }
//        public int id_tasks_126 { get; set; }
//        public int id_tasks_127 { get; set; }
//        public int id_tasks_128 { get; set; }
//        public int id_tasks_129 { get; set; }
//        public int id_tasks_130 { get; set; }
//        public int id_tasks_131 { get; set; }
//        public int id_tasks_132 { get; set; }
//        public int id_tasks_133 { get; set; }
//        public int id_tasks_134 { get; set; }
//        public int id_tasks_135 { get; set; }
//        public int id_tasks_136 { get; set; }
//        public int id_tasks_137 { get; set; }
//        public int id_tasks_138 { get; set; }
//        public int id_tasks_139 { get; set; }
//        public int id_tasks_140 { get; set; }
//        public int id_tasks_141 { get; set; }
//        public int id_tasks_142 { get; set; }
//        public int id_tasks_143 { get; set; }
//        public int id_tasks_144 { get; set; }
//        public int id_tasks_145 { get; set; }
//        public int id_tasks_146 { get; set; }
//        public int id_tasks_147 { get; set; }
//        public int id_tasks_148 { get; set; }
//        public int id_tasks_149 { get; set; }
//        public int id_tasks_150 { get; set; }
//        public int id_tasks_151 { get; set; }
//        public int id_tasks_152 { get; set; }
//        public int id_tasks_153 { get; set; }
//        public int id_tasks_154 { get; set; }
//        public int id_tasks_155 { get; set; }
//        public int id_tasks_156 { get; set; }
//        public int id_tasks_157 { get; set; }
//        public int id_tasks_158 { get; set; }
//        public int id_tasks_159 { get; set; }
//        public int id_tasks_160 { get; set; }
//        public int id_tasks_161 { get; set; }
//        public int id_tasks_162 { get; set; }
//        public int id_tasks_163 { get; set; }
//        public int id_tasks_164 { get; set; }
//        public int id_tasks_165 { get; set; }
//        public int id_tasks_166 { get; set; }
//        public int id_tasks_167 { get; set; }
//        public int id_tasks_168 { get; set; }
//        public int id_tasks_169 { get; set; }
//        public int id_tasks_170 { get; set; }
//        public int id_tasks_171 { get; set; }
//        public int id_tasks_172 { get; set; }
//        public int id_tasks_173 { get; set; }
//        public int id_tasks_174 { get; set; }
//        public int id_tasks_175 { get; set; }
//        public int id_tasks_176 { get; set; }
//        public int id_tasks_177 { get; set; }
//        public int id_tasks_178 { get; set; }
//        public int id_tasks_179 { get; set; }
//        public int id_tasks_180 { get; set; }
//        public int id_tasks_181 { get; set; }
//        public int id_tasks_182 { get; set; }
//        public int id_tasks_183 { get; set; }
//        public int id_tasks_184 { get; set; }
//        public int id_tasks_185 { get; set; }
//        public int id_tasks_186 { get; set; }
//        public int id_tasks_187 { get; set; }
//        public int id_tasks_188 { get; set; }
//        public int id_tasks_189 { get; set; }
//        public int id_tasks_190 { get; set; }
//        public int id_tasks_191 { get; set; }
//        public int id_tasks_192 { get; set; }
//        public int id_tasks_193 { get; set; }
//        public int id_tasks_194 { get; set; }
//        public int id_tasks_195 { get; set; }
//        public int id_tasks_196 { get; set; }
//        public int id_tasks_197 { get; set; }
//        public int id_tasks_198 { get; set; }
//        public int id_tasks_199 { get; set; }
//        public int id_tasks_200 { get; set; }
//        public int id_tasks_201 { get; set; }
//        public int id_tasks_202 { get; set; }
//        public int id_tasks_203 { get; set; }
//        public int id_tasks_204 { get; set; }
//        public int id_tasks_205 { get; set; }
//        public int id_tasks_206 { get; set; }
//        public int id_tasks_207 { get; set; }
//        public int id_tasks_208 { get; set; }
//        public int id_tasks_209 { get; set; }
//        public int id_tasks_210 { get; set; }
//        public int id_tasks_211 { get; set; }
//        public int id_tasks_212 { get; set; }
//        public int id_tasks_213 { get; set; }
//        public int id_tasks_214 { get; set; }
//        public int id_tasks_215 { get; set; }
//        public int id_tasks_216 { get; set; }
//        public int id_tasks_217 { get; set; }
//        public int id_tasks_218 { get; set; }
//        public int id_tasks_219 { get; set; }
//        public int id_tasks_220 { get; set; }
//        public int id_tasks_221 { get; set; }
//        public int id_tasks_222 { get; set; }
//        public int id_tasks_223 { get; set; }
//        public int id_tasks_224 { get; set; }
//        public int id_tasks_225 { get; set; }
//        public int id_tasks_226 { get; set; }
//        public int id_tasks_227 { get; set; }
//        public int id_tasks_228 { get; set; }
//        public int id_tasks_229 { get; set; }
//        public int id_tasks_230 { get; set; }
//        public int id_tasks_231 { get; set; }
//        public int id_tasks_232 { get; set; }
//        public int id_tasks_233 { get; set; }
//        public int id_tasks_234 { get; set; }
//        public int id_tasks_235 { get; set; }
//        public int id_tasks_236 { get; set; }
//        public int id_tasks_237 { get; set; }
//        public int id_tasks_238 { get; set; }
//        public int id_tasks_239 { get; set; }
//        public int id_tasks_240 { get; set; }
//        public int id_tasks_241 { get; set; }
//        public int id_tasks_242 { get; set; }
//        public int id_tasks_243 { get; set; }
//        public int id_tasks_244 { get; set; }
//        public int id_tasks_245 { get; set; }
//        public int id_tasks_246 { get; set; }
//        public int id_tasks_247 { get; set; }
//        public int id_tasks_248 { get; set; }
//        public int id_tasks_249 { get; set; }
//        public int id_tasks_250 { get; set; }
//        public int id_tasks_251 { get; set; }
//        public int id_tasks_252 { get; set; }
//        public int id_tasks_253 { get; set; }
//        public int id_tasks_254 { get; set; }
//        public int id_tasks_255 { get; set; }
//        public int id_tasks_256 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TASK_MATTER_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int tasks_1_id_task { get; set; }
//        public int tasks_1_taks_matters_1_id_matter { get; set; }
//        public int tasks_1_taks_matters_1_num_matter { get; set; }
//        public int tasks_1_taks_matters_2_id_matter { get; set; }
//        public int tasks_1_taks_matters_2_num_matter { get; set; }
//        public int tasks_1_taks_matters_3_id_matter { get; set; }
//        public int tasks_1_taks_matters_3_num_matter { get; set; }
//        public int tasks_1_taks_matters_4_id_matter { get; set; }
//        public int tasks_1_taks_matters_4_num_matter { get; set; }
//        public int tasks_2_id_task { get; set; }
//        public int tasks_2_taks_matters_1_id_matter { get; set; }
//        public int tasks_2_taks_matters_1_num_matter { get; set; }
//        public int tasks_2_taks_matters_2_id_matter { get; set; }
//        public int tasks_2_taks_matters_2_num_matter { get; set; }
//        public int tasks_2_taks_matters_3_id_matter { get; set; }
//        public int tasks_2_taks_matters_3_num_matter { get; set; }
//        public int tasks_2_taks_matters_4_id_matter { get; set; }
//        public int tasks_2_taks_matters_4_num_matter { get; set; }
//        public int tasks_3_id_task { get; set; }
//        public int tasks_3_taks_matters_1_id_matter { get; set; }
//        public int tasks_3_taks_matters_1_num_matter { get; set; }
//        public int tasks_3_taks_matters_2_id_matter { get; set; }
//        public int tasks_3_taks_matters_2_num_matter { get; set; }
//        public int tasks_3_taks_matters_3_id_matter { get; set; }
//        public int tasks_3_taks_matters_3_num_matter { get; set; }
//        public int tasks_3_taks_matters_4_id_matter { get; set; }
//        public int tasks_3_taks_matters_4_num_matter { get; set; }
//        public int tasks_4_id_task { get; set; }
//        public int tasks_4_taks_matters_1_id_matter { get; set; }
//        public int tasks_4_taks_matters_1_num_matter { get; set; }
//        public int tasks_4_taks_matters_2_id_matter { get; set; }
//        public int tasks_4_taks_matters_2_num_matter { get; set; }
//        public int tasks_4_taks_matters_3_id_matter { get; set; }
//        public int tasks_4_taks_matters_3_num_matter { get; set; }
//        public int tasks_4_taks_matters_4_id_matter { get; set; }
//        public int tasks_4_taks_matters_4_num_matter { get; set; }
//        public int tasks_5_id_task { get; set; }
//        public int tasks_5_taks_matters_1_id_matter { get; set; }
//        public int tasks_5_taks_matters_1_num_matter { get; set; }
//        public int tasks_5_taks_matters_2_id_matter { get; set; }
//        public int tasks_5_taks_matters_2_num_matter { get; set; }
//        public int tasks_5_taks_matters_3_id_matter { get; set; }
//        public int tasks_5_taks_matters_3_num_matter { get; set; }
//        public int tasks_5_taks_matters_4_id_matter { get; set; }
//        public int tasks_5_taks_matters_4_num_matter { get; set; }
//        public int tasks_6_id_task { get; set; }
//        public int tasks_6_taks_matters_1_id_matter { get; set; }
//        public int tasks_6_taks_matters_1_num_matter { get; set; }
//        public int tasks_6_taks_matters_2_id_matter { get; set; }
//        public int tasks_6_taks_matters_2_num_matter { get; set; }
//        public int tasks_6_taks_matters_3_id_matter { get; set; }
//        public int tasks_6_taks_matters_3_num_matter { get; set; }
//        public int tasks_6_taks_matters_4_id_matter { get; set; }
//        public int tasks_6_taks_matters_4_num_matter { get; set; }
//        public int tasks_7_id_task { get; set; }
//        public int tasks_7_taks_matters_1_id_matter { get; set; }
//        public int tasks_7_taks_matters_1_num_matter { get; set; }
//        public int tasks_7_taks_matters_2_id_matter { get; set; }
//        public int tasks_7_taks_matters_2_num_matter { get; set; }
//        public int tasks_7_taks_matters_3_id_matter { get; set; }
//        public int tasks_7_taks_matters_3_num_matter { get; set; }
//        public int tasks_7_taks_matters_4_id_matter { get; set; }
//        public int tasks_7_taks_matters_4_num_matter { get; set; }
//        public int tasks_8_id_task { get; set; }
//        public int tasks_8_taks_matters_1_id_matter { get; set; }
//        public int tasks_8_taks_matters_1_num_matter { get; set; }
//        public int tasks_8_taks_matters_2_id_matter { get; set; }
//        public int tasks_8_taks_matters_2_num_matter { get; set; }
//        public int tasks_8_taks_matters_3_id_matter { get; set; }
//        public int tasks_8_taks_matters_3_num_matter { get; set; }
//        public int tasks_8_taks_matters_4_id_matter { get; set; }
//        public int tasks_8_taks_matters_4_num_matter { get; set; }
//        public int tasks_9_id_task { get; set; }
//        public int tasks_9_taks_matters_1_id_matter { get; set; }
//        public int tasks_9_taks_matters_1_num_matter { get; set; }
//        public int tasks_9_taks_matters_2_id_matter { get; set; }
//        public int tasks_9_taks_matters_2_num_matter { get; set; }
//        public int tasks_9_taks_matters_3_id_matter { get; set; }
//        public int tasks_9_taks_matters_3_num_matter { get; set; }
//        public int tasks_9_taks_matters_4_id_matter { get; set; }
//        public int tasks_9_taks_matters_4_num_matter { get; set; }
//        public int tasks_10_id_task { get; set; }
//        public int tasks_10_taks_matters_1_id_matter { get; set; }
//        public int tasks_10_taks_matters_1_num_matter { get; set; }
//        public int tasks_10_taks_matters_2_id_matter { get; set; }
//        public int tasks_10_taks_matters_2_num_matter { get; set; }
//        public int tasks_10_taks_matters_3_id_matter { get; set; }
//        public int tasks_10_taks_matters_3_num_matter { get; set; }
//        public int tasks_10_taks_matters_4_id_matter { get; set; }
//        public int tasks_10_taks_matters_4_num_matter { get; set; }
//        public int tasks_11_id_task { get; set; }
//        public int tasks_11_taks_matters_1_id_matter { get; set; }
//        public int tasks_11_taks_matters_1_num_matter { get; set; }
//        public int tasks_11_taks_matters_2_id_matter { get; set; }
//        public int tasks_11_taks_matters_2_num_matter { get; set; }
//        public int tasks_11_taks_matters_3_id_matter { get; set; }
//        public int tasks_11_taks_matters_3_num_matter { get; set; }
//        public int tasks_11_taks_matters_4_id_matter { get; set; }
//        public int tasks_11_taks_matters_4_num_matter { get; set; }
//        public int tasks_12_id_task { get; set; }
//        public int tasks_12_taks_matters_1_id_matter { get; set; }
//        public int tasks_12_taks_matters_1_num_matter { get; set; }
//        public int tasks_12_taks_matters_2_id_matter { get; set; }
//        public int tasks_12_taks_matters_2_num_matter { get; set; }
//        public int tasks_12_taks_matters_3_id_matter { get; set; }
//        public int tasks_12_taks_matters_3_num_matter { get; set; }
//        public int tasks_12_taks_matters_4_id_matter { get; set; }
//        public int tasks_12_taks_matters_4_num_matter { get; set; }
//        public int tasks_13_id_task { get; set; }
//        public int tasks_13_taks_matters_1_id_matter { get; set; }
//        public int tasks_13_taks_matters_1_num_matter { get; set; }
//        public int tasks_13_taks_matters_2_id_matter { get; set; }
//        public int tasks_13_taks_matters_2_num_matter { get; set; }
//        public int tasks_13_taks_matters_3_id_matter { get; set; }
//        public int tasks_13_taks_matters_3_num_matter { get; set; }
//        public int tasks_13_taks_matters_4_id_matter { get; set; }
//        public int tasks_13_taks_matters_4_num_matter { get; set; }
//        public int tasks_14_id_task { get; set; }
//        public int tasks_14_taks_matters_1_id_matter { get; set; }
//        public int tasks_14_taks_matters_1_num_matter { get; set; }
//        public int tasks_14_taks_matters_2_id_matter { get; set; }
//        public int tasks_14_taks_matters_2_num_matter { get; set; }
//        public int tasks_14_taks_matters_3_id_matter { get; set; }
//        public int tasks_14_taks_matters_3_num_matter { get; set; }
//        public int tasks_14_taks_matters_4_id_matter { get; set; }
//        public int tasks_14_taks_matters_4_num_matter { get; set; }
//        public int tasks_15_id_task { get; set; }
//        public int tasks_15_taks_matters_1_id_matter { get; set; }
//        public int tasks_15_taks_matters_1_num_matter { get; set; }
//        public int tasks_15_taks_matters_2_id_matter { get; set; }
//        public int tasks_15_taks_matters_2_num_matter { get; set; }
//        public int tasks_15_taks_matters_3_id_matter { get; set; }
//        public int tasks_15_taks_matters_3_num_matter { get; set; }
//        public int tasks_15_taks_matters_4_id_matter { get; set; }
//        public int tasks_15_taks_matters_4_num_matter { get; set; }
//        public int tasks_16_id_task { get; set; }
//        public int tasks_16_taks_matters_1_id_matter { get; set; }
//        public int tasks_16_taks_matters_1_num_matter { get; set; }
//        public int tasks_16_taks_matters_2_id_matter { get; set; }
//        public int tasks_16_taks_matters_2_num_matter { get; set; }
//        public int tasks_16_taks_matters_3_id_matter { get; set; }
//        public int tasks_16_taks_matters_3_num_matter { get; set; }
//        public int tasks_16_taks_matters_4_id_matter { get; set; }
//        public int tasks_16_taks_matters_4_num_matter { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_SKILL_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_skills_1 { get; set; }
//        public int id_skills_2 { get; set; }
//        public int id_skills_3 { get; set; }
//        public int id_skills_4 { get; set; }
//        public int id_skills_5 { get; set; }
//        public int id_skills_6 { get; set; }
//        public int id_skills_7 { get; set; }
//        public int id_skills_8 { get; set; }
//        public int id_skills_9 { get; set; }
//        public int id_skills_10 { get; set; }
//        public int id_skills_11 { get; set; }
//        public int id_skills_12 { get; set; }
//        public int id_skills_13 { get; set; }
//        public int id_skills_14 { get; set; }
//        public int id_skills_15 { get; set; }
//        public int id_skills_16 { get; set; }
//        public int id_skills_17 { get; set; }
//        public int id_skills_18 { get; set; }
//        public int id_skills_19 { get; set; }
//        public int id_skills_20 { get; set; }
//        public int id_skills_21 { get; set; }
//        public int id_skills_22 { get; set; }
//        public int id_skills_23 { get; set; }
//        public int id_skills_24 { get; set; }
//        public int id_skills_25 { get; set; }
//        public int id_skills_26 { get; set; }
//        public int id_skills_27 { get; set; }
//        public int id_skills_28 { get; set; }
//        public int id_skills_29 { get; set; }
//        public int id_skills_30 { get; set; }
//        public int id_skills_31 { get; set; }
//        public int id_skills_32 { get; set; }
//        public int id_skills_33 { get; set; }
//        public int id_skills_34 { get; set; }
//        public int id_skills_35 { get; set; }
//        public int id_skills_36 { get; set; }
//        public int id_skills_37 { get; set; }
//        public int id_skills_38 { get; set; }
//        public int id_skills_39 { get; set; }
//        public int id_skills_40 { get; set; }
//        public int id_skills_41 { get; set; }
//        public int id_skills_42 { get; set; }
//        public int id_skills_43 { get; set; }
//        public int id_skills_44 { get; set; }
//        public int id_skills_45 { get; set; }
//        public int id_skills_46 { get; set; }
//        public int id_skills_47 { get; set; }
//        public int id_skills_48 { get; set; }
//        public int id_skills_49 { get; set; }
//        public int id_skills_50 { get; set; }
//        public int id_skills_51 { get; set; }
//        public int id_skills_52 { get; set; }
//        public int id_skills_53 { get; set; }
//        public int id_skills_54 { get; set; }
//        public int id_skills_55 { get; set; }
//        public int id_skills_56 { get; set; }
//        public int id_skills_57 { get; set; }
//        public int id_skills_58 { get; set; }
//        public int id_skills_59 { get; set; }
//        public int id_skills_60 { get; set; }
//        public int id_skills_61 { get; set; }
//        public int id_skills_62 { get; set; }
//        public int id_skills_63 { get; set; }
//        public int id_skills_64 { get; set; }
//        public int id_skills_65 { get; set; }
//        public int id_skills_66 { get; set; }
//        public int id_skills_67 { get; set; }
//        public int id_skills_68 { get; set; }
//        public int id_skills_69 { get; set; }
//        public int id_skills_70 { get; set; }
//        public int id_skills_71 { get; set; }
//        public int id_skills_72 { get; set; }
//        public int id_skills_73 { get; set; }
//        public int id_skills_74 { get; set; }
//        public int id_skills_75 { get; set; }
//        public int id_skills_76 { get; set; }
//        public int id_skills_77 { get; set; }
//        public int id_skills_78 { get; set; }
//        public int id_skills_79 { get; set; }
//        public int id_skills_80 { get; set; }
//        public int id_skills_81 { get; set; }
//        public int id_skills_82 { get; set; }
//        public int id_skills_83 { get; set; }
//        public int id_skills_84 { get; set; }
//        public int id_skills_85 { get; set; }
//        public int id_skills_86 { get; set; }
//        public int id_skills_87 { get; set; }
//        public int id_skills_88 { get; set; }
//        public int id_skills_89 { get; set; }
//        public int id_skills_90 { get; set; }
//        public int id_skills_91 { get; set; }
//        public int id_skills_92 { get; set; }
//        public int id_skills_93 { get; set; }
//        public int id_skills_94 { get; set; }
//        public int id_skills_95 { get; set; }
//        public int id_skills_96 { get; set; }
//        public int id_skills_97 { get; set; }
//        public int id_skills_98 { get; set; }
//        public int id_skills_99 { get; set; }
//        public int id_skills_100 { get; set; }
//        public int id_skills_101 { get; set; }
//        public int id_skills_102 { get; set; }
//        public int id_skills_103 { get; set; }
//        public int id_skills_104 { get; set; }
//        public int id_skills_105 { get; set; }
//        public int id_skills_106 { get; set; }
//        public int id_skills_107 { get; set; }
//        public int id_skills_108 { get; set; }
//        public int id_skills_109 { get; set; }
//        public int id_skills_110 { get; set; }
//        public int id_skills_111 { get; set; }
//        public int id_skills_112 { get; set; }
//        public int id_skills_113 { get; set; }
//        public int id_skills_114 { get; set; }
//        public int id_skills_115 { get; set; }
//        public int id_skills_116 { get; set; }
//        public int id_skills_117 { get; set; }
//        public int id_skills_118 { get; set; }
//        public int id_skills_119 { get; set; }
//        public int id_skills_120 { get; set; }
//        public int id_skills_121 { get; set; }
//        public int id_skills_122 { get; set; }
//        public int id_skills_123 { get; set; }
//        public int id_skills_124 { get; set; }
//        public int id_skills_125 { get; set; }
//        public int id_skills_126 { get; set; }
//        public int id_skills_127 { get; set; }
//        public int id_skills_128 { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_HEAL_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TRANSMIT_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int num_targets { get; set; }
//        public int targets_1_idtarget { get; set; }
//        public int targets_1_fee { get; set; }
//        public int targets_1_required_level { get; set; }
//        public int targets_2_idtarget { get; set; }
//        public int targets_2_fee { get; set; }
//        public int targets_2_required_level { get; set; }
//        public int targets_3_idtarget { get; set; }
//        public int targets_3_fee { get; set; }
//        public int targets_3_required_level { get; set; }
//        public int targets_4_idtarget { get; set; }
//        public int targets_4_fee { get; set; }
//        public int targets_4_required_level { get; set; }
//        public int targets_5_idtarget { get; set; }
//        public int targets_5_fee { get; set; }
//        public int targets_5_required_level { get; set; }
//        public int targets_6_idtarget { get; set; }
//        public int targets_6_fee { get; set; }
//        public int targets_6_required_level { get; set; }
//        public int targets_7_idtarget { get; set; }
//        public int targets_7_fee { get; set; }
//        public int targets_7_required_level { get; set; }
//        public int targets_8_idtarget { get; set; }
//        public int targets_8_fee { get; set; }
//        public int targets_8_required_level { get; set; }
//        public int targets_9_idtarget { get; set; }
//        public int targets_9_fee { get; set; }
//        public int targets_9_required_level { get; set; }
//        public int targets_10_idtarget { get; set; }
//        public int targets_10_fee { get; set; }
//        public int targets_10_required_level { get; set; }
//        public int targets_11_idtarget { get; set; }
//        public int targets_11_fee { get; set; }
//        public int targets_11_required_level { get; set; }
//        public int targets_12_idtarget { get; set; }
//        public int targets_12_fee { get; set; }
//        public int targets_12_required_level { get; set; }
//        public int targets_13_idtarget { get; set; }
//        public int targets_13_fee { get; set; }
//        public int targets_13_required_level { get; set; }
//        public int targets_14_idtarget { get; set; }
//        public int targets_14_fee { get; set; }
//        public int targets_14_required_level { get; set; }
//        public int targets_15_idtarget { get; set; }
//        public int targets_15_fee { get; set; }
//        public int targets_15_required_level { get; set; }
//        public int targets_16_idtarget { get; set; }
//        public int targets_16_fee { get; set; }
//        public int targets_16_required_level { get; set; }
//        public int targets_17_idtarget { get; set; }
//        public int targets_17_fee { get; set; }
//        public int targets_17_required_level { get; set; }
//        public int targets_18_idtarget { get; set; }
//        public int targets_18_fee { get; set; }
//        public int targets_18_required_level { get; set; }
//        public int targets_19_idtarget { get; set; }
//        public int targets_19_fee { get; set; }
//        public int targets_19_required_level { get; set; }
//        public int targets_20_idtarget { get; set; }
//        public int targets_20_fee { get; set; }
//        public int targets_20_required_level { get; set; }
//        public int targets_21_idtarget { get; set; }
//        public int targets_21_fee { get; set; }
//        public int targets_21_required_level { get; set; }
//        public int targets_22_idtarget { get; set; }
//        public int targets_22_fee { get; set; }
//        public int targets_22_required_level { get; set; }
//        public int targets_23_idtarget { get; set; }
//        public int targets_23_fee { get; set; }
//        public int targets_23_required_level { get; set; }
//        public int targets_24_idtarget { get; set; }
//        public int targets_24_fee { get; set; }
//        public int targets_24_required_level { get; set; }
//        public int targets_25_idtarget { get; set; }
//        public int targets_25_fee { get; set; }
//        public int targets_25_required_level { get; set; }
//        public int targets_26_idtarget { get; set; }
//        public int targets_26_fee { get; set; }
//        public int targets_26_required_level { get; set; }
//        public int targets_27_idtarget { get; set; }
//        public int targets_27_fee { get; set; }
//        public int targets_27_required_level { get; set; }
//        public int targets_28_idtarget { get; set; }
//        public int targets_28_fee { get; set; }
//        public int targets_28_required_level { get; set; }
//        public int targets_29_idtarget { get; set; }
//        public int targets_29_fee { get; set; }
//        public int targets_29_required_level { get; set; }
//        public int targets_30_idtarget { get; set; }
//        public int targets_30_fee { get; set; }
//        public int targets_30_required_level { get; set; }
//        public int targets_31_idtarget { get; set; }
//        public int targets_31_fee { get; set; }
//        public int targets_31_required_level { get; set; }
//        public int targets_32_idtarget { get; set; }
//        public int targets_32_fee { get; set; }
//        public int targets_32_required_level { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TRANSPORT_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int routes_1_id { get; set; }
//        public int routes_1_fee { get; set; }
//        public int routes_2_id { get; set; }
//        public int routes_2_fee { get; set; }
//        public int routes_3_id { get; set; }
//        public int routes_3_fee { get; set; }
//        public int routes_4_id { get; set; }
//        public int routes_4_fee { get; set; }
//        public int routes_5_id { get; set; }
//        public int routes_5_fee { get; set; }
//        public int routes_6_id { get; set; }
//        public int routes_6_fee { get; set; }
//        public int routes_7_id { get; set; }
//        public int routes_7_fee { get; set; }
//        public int routes_8_id { get; set; }
//        public int routes_8_fee { get; set; }
//        public int routes_9_id { get; set; }
//        public int routes_9_fee { get; set; }
//        public int routes_10_id { get; set; }
//        public int routes_10_fee { get; set; }
//        public int routes_11_id { get; set; }
//        public int routes_11_fee { get; set; }
//        public int routes_12_id { get; set; }
//        public int routes_12_fee { get; set; }
//        public int routes_13_id { get; set; }
//        public int routes_13_fee { get; set; }
//        public int routes_14_id { get; set; }
//        public int routes_14_fee { get; set; }
//        public int routes_15_id { get; set; }
//        public int routes_15_fee { get; set; }
//        public int routes_16_id { get; set; }
//        public int routes_16_fee { get; set; }
//        public int routes_17_id { get; set; }
//        public int routes_17_fee { get; set; }
//        public int routes_18_id { get; set; }
//        public int routes_18_fee { get; set; }
//        public int routes_19_id { get; set; }
//        public int routes_19_fee { get; set; }
//        public int routes_20_id { get; set; }
//        public int routes_20_fee { get; set; }
//        public int routes_21_id { get; set; }
//        public int routes_21_fee { get; set; }
//        public int routes_22_id { get; set; }
//        public int routes_22_fee { get; set; }
//        public int routes_23_id { get; set; }
//        public int routes_23_fee { get; set; }
//        public int routes_24_id { get; set; }
//        public int routes_24_fee { get; set; }
//        public int routes_25_id { get; set; }
//        public int routes_25_fee { get; set; }
//        public int routes_26_id { get; set; }
//        public int routes_26_fee { get; set; }
//        public int routes_27_id { get; set; }
//        public int routes_27_fee { get; set; }
//        public int routes_28_id { get; set; }
//        public int routes_28_fee { get; set; }
//        public int routes_29_id { get; set; }
//        public int routes_29_fee { get; set; }
//        public int routes_30_id { get; set; }
//        public int routes_30_fee { get; set; }
//        public int routes_31_id { get; set; }
//        public int routes_31_fee { get; set; }
//        public int routes_32_id { get; set; }
//        public int routes_32_fee { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_PROXY_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_STORAGE_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_MAKE_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_make_skill { get; set; }
//        public int produce_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public MakePage[] Pages;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_DECOMPOSE_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_decompose_skill { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_TYPE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_ESSENCE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_type { get; set; }
//        public float refresh_time { get; set; }
//        public int attack_rule { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float tax_rate { get; set; }
//        public int id_src_monster { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
//        public byte[] hello_msg;

//        public string Hello_msg
//        {
//            get => Structure.Unicode.GetString(hello_msg);
//            set { hello_msg = BinReader.FillArray(Structure.Unicode.GetBytes(value), 512); }
//        }

//        public int id_to_discover { get; set; }
//        public int domain_related { get; set; }
//        public int id_talk_service { get; set; }
//        public int id_sell_service { get; set; }
//        public int id_buy_service { get; set; }
//        public int id_repair_service { get; set; }
//        public int id_install_service { get; set; }
//        public int id_uninstall_service { get; set; }
//        public int id_task_out_service { get; set; }
//        public int id_task_in_service { get; set; }
//        public int id_task_matter_service { get; set; }
//        public int id_skill_service { get; set; }
//        public int id_heal_service { get; set; }
//        public int id_transmit_service { get; set; }
//        public int id_transport_service { get; set; }
//        public int id_proxy_service { get; set; }
//        public int id_storage_service { get; set; }
//        public int id_make_service { get; set; }
//        public int id_decompose_service { get; set; }
//        public int id_identify_service { get; set; }
//        public int id_war_towerbuild_service { get; set; }
//        public int id_resetprop_service { get; set; }
//        public int id_petname_service { get; set; }
//        public int id_petlearnskill_service { get; set; }
//        public int id_petforgetskill_service { get; set; }
//        public int id_equipbind_service { get; set; }
//        public int id_equipdestroy_service { get; set; }
//        public int id_equipundestroy_service { get; set; }
//        public int id_goblin_skill_service { get; set; }
//        public int combined_services { get; set; }
//        public int id_mine { get; set; }
//        public int no_collision { get; set; }
//        public int id_engrave_service { get; set; }
//        public int id_randprop_service { get; set; }
//        public int combined_services2 { get; set; }
//        public int id_force_service { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TALK_PROC
//    {
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_TEXTURE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_base_tex;

//        public string File_base_tex
//        {
//            get => Structure.Gbk.GetString(file_base_tex);
//            set { file_base_tex = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_high_tex;

//        public string File_high_tex
//        {
//            get => Structure.Gbk.GetString(file_high_tex);
//            set { file_high_tex = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int tex_part_id { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int visualize_id { get; set; }
//        public int user_data { get; set; }
//        public int facepill_only { get; set; }
//        public int fashion_head_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_SHAPE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_shape;

//        public string File_shape
//        {
//            get => Structure.Gbk.GetString(file_shape);
//            set { file_shape = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int shape_part_id { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int visualize_id { get; set; }
//        public int user_data { get; set; }
//        public int facepill_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_EMOTION_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_EXPRESSION_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_expression;

//        public string File_expression
//        {
//            get => Structure.Gbk.GetString(file_expression);
//            set { file_expression = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int emotion_id { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_HAIR_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hair_skin;

//        public string File_hair_skin
//        {
//            get => Structure.Gbk.GetString(file_hair_skin);
//            set { file_hair_skin = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_hair_model;

//        public string File_hair_model
//        {
//            get => Structure.Gbk.GetString(file_hair_model);
//            set { file_hair_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int visualize_id { get; set; }
//        public int facepill_only { get; set; }
//        public int fashion_head_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_MOUSTACHE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_moustache_skin;

//        public string File_moustache_skin
//        {
//            get => Structure.Gbk.GetString(file_moustache_skin);
//            set { file_moustache_skin = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int visualize_id { get; set; }
//        public int facepill_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class COLORPICKER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_colorpicker;

//        public string File_colorpicker
//        {
//            get => Structure.Gbk.GetString(file_colorpicker);
//            set { file_colorpicker = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int color_part_id { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class CUSTOMIZEDATA_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_data;

//        public string File_data
//        {
//            get => Structure.Gbk.GetString(file_data);
//            set { file_data = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class RECIPE_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class RECIPE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class RECIPE_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int recipe_level { get; set; }
//        public int id_skill { get; set; }
//        public int skill_level { get; set; }
//        public int bind_type { get; set; }
//        [ItemId] public int targets_1_id_to_make { get; set; }
//        public float targets_1_probability { get; set; }
//        [ItemId] public int targets_2_id_to_make { get; set; }
//        public float targets_2_probability { get; set; }
//        [ItemId] public int targets_3_id_to_make { get; set; }
//        public float targets_3_probability { get; set; }
//        [ItemId] public int targets_4_id_to_make { get; set; }
//        public float targets_4_probability { get; set; }
//        public float fail_probability { get; set; }
//        public int num_to_make { get; set; }
//        public int price { get; set; }
//        public float duration { get; set; }
//        public int exp { get; set; }
//        public int skillpoint { get; set; }

//        [ItemId] public int materials_id_1 { get; set; }
//        public int materials_1_num { get; set; }
//        [ItemId] public int materials_id_2 { get; set; }
//        public int materials_2_num { get; set; }
//        [ItemId] public int materials_id_3 { get; set; }
//        public int materials_3_num { get; set; }
//        [ItemId] public int materials_id_4 { get; set; }
//        public int materials_4_num { get; set; }
//        [ItemId] public int materials_id_5 { get; set; }
//        public int materials_5_num { get; set; }
//        [ItemId] public int materials_id_6 { get; set; }
//        public int materials_6_num { get; set; }
//        [ItemId] public int materials_id_7 { get; set; }
//        public int materials_7_num { get; set; }
//        [ItemId] public int materials_id_8 { get; set; }
//        public int materials_8_num { get; set; }
//        [ItemId] public int materials_id_9 { get; set; }
//        public int materials_9_num { get; set; }
//        [ItemId] public int materials_id_10 { get; set; }
//        public int materials_10_num { get; set; }
//        [ItemId] public int materials_id_11 { get; set; }
//        public int materials_11_num { get; set; }
//        [ItemId] public int materials_id_12 { get; set; }
//        public int materials_12_num { get; set; }
//        [ItemId] public int materials_id_13 { get; set; }
//        public int materials_13_num { get; set; }
//        [ItemId] public int materials_id_14 { get; set; }
//        public int materials_14_num { get; set; }
//        [ItemId] public int materials_id_15 { get; set; }
//        public int materials_15_num { get; set; }
//        [ItemId] public int materials_id_16 { get; set; }
//        public int materials_16_num { get; set; }
//        [ItemId] public int materials_id_17 { get; set; }
//        public int materials_17_num { get; set; }
//        [ItemId] public int materials_id_18 { get; set; }
//        public int materials_18_num { get; set; }
//        [ItemId] public int materials_id_19 { get; set; }
//        public int materials_19_num { get; set; }
//        [ItemId] public int materials_id_20 { get; set; }
//        public int materials_20_num { get; set; }
//        [ItemId] public int materials_id_21 { get; set; }
//        public int materials_21_num { get; set; }
//        [ItemId] public int materials_id_22 { get; set; }
//        public int materials_22_num { get; set; }
//        [ItemId] public int materials_id_23 { get; set; }
//        public int materials_23_num { get; set; }
//        [ItemId] public int materials_id_24 { get; set; }
//        public int materials_24_num { get; set; }
//        [ItemId] public int materials_id_25 { get; set; }
//        public int materials_25_num { get; set; }
//        [ItemId] public int materials_id_26 { get; set; }
//        public int materials_26_num { get; set; }
//        [ItemId] public int materials_id_27 { get; set; }
//        public int materials_27_num { get; set; }
//        [ItemId] public int materials_id_28 { get; set; }
//        public int materials_28_num { get; set; }
//        [ItemId] public int materials_id_29 { get; set; }
//        public int materials_29_num { get; set; }
//        [ItemId] public int materials_id_30 { get; set; }
//        public int materials_30_num { get; set; }
//        [ItemId] public int materials_id_31 { get; set; }
//        public int materials_31_num { get; set; }
//        [ItemId] public int materials_id_32 { get; set; }
//        public int materials_32_num { get; set; }
//        public int id_upgrade_equip { get; set; }
//        public float upgrade_rate { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ENEMY_FACTION_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int enemy_factions_1 { get; set; }
//        public int enemy_factions_2 { get; set; }
//        public int enemy_factions_3 { get; set; }
//        public int enemy_factions_4 { get; set; }
//        public int enemy_factions_5 { get; set; }
//        public int enemy_factions_6 { get; set; }
//        public int enemy_factions_7 { get; set; }
//        public int enemy_factions_8 { get; set; }
//        public int enemy_factions_9 { get; set; }
//        public int enemy_factions_10 { get; set; }
//        public int enemy_factions_11 { get; set; }
//        public int enemy_factions_12 { get; set; }
//        public int enemy_factions_13 { get; set; }
//        public int enemy_factions_14 { get; set; }
//        public int enemy_factions_15 { get; set; }
//        public int enemy_factions_16 { get; set; }
//        public int enemy_factions_17 { get; set; }
//        public int enemy_factions_18 { get; set; }
//        public int enemy_factions_19 { get; set; }
//        public int enemy_factions_20 { get; set; }
//        public int enemy_factions_21 { get; set; }
//        public int enemy_factions_22 { get; set; }
//        public int enemy_factions_23 { get; set; }
//        public int enemy_factions_24 { get; set; }
//        public int enemy_factions_25 { get; set; }
//        public int enemy_factions_26 { get; set; }
//        public int enemy_factions_27 { get; set; }
//        public int enemy_factions_28 { get; set; }
//        public int enemy_factions_29 { get; set; }
//        public int enemy_factions_30 { get; set; }
//        public int enemy_factions_31 { get; set; }
//        public int enemy_factions_32 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class CHARRACTER_CLASS_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int character_class_id { get; set; }
//        public int faction { get; set; }
//        public int enemy_faction { get; set; }
//        public float attack_speed { get; set; }
//        public float attack_range { get; set; }
//        public int hp_gen { get; set; }
//        public int mp_gen { get; set; }
//        public float walk_speed { get; set; }
//        public float run_speed { get; set; }
//        public float swim_speed { get; set; }
//        public float fly_speed { get; set; }
//        public int crit_rate { get; set; }
//        public int vit_hp { get; set; }
//        public int eng_mp { get; set; }
//        public int agi_attack { get; set; }
//        public int agi_armor { get; set; }
//        public int lvlup_hp { get; set; }
//        public int lvlup_mp { get; set; }
//        public float lvlup_dmg { get; set; }
//        public float lvlup_magic { get; set; }
//        public float lvlup_defense { get; set; }
//        public float lvlup_magicdefence { get; set; }
//        public int angro_increase { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PARAM_ADJUST_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int level_diff_adjust_1_level_diff { get; set; }
//        public float level_diff_adjust_1_adjust_exp { get; set; }
//        public float level_diff_adjust_1_adjust_sp { get; set; }
//        public float level_diff_adjust_1_adjust_money { get; set; }
//        public float level_diff_adjust_1_adjust_matter { get; set; }
//        public float level_diff_adjust_1_adjust_attack { get; set; }
//        public int level_diff_adjust_2_level_diff { get; set; }
//        public float level_diff_adjust_2_adjust_exp { get; set; }
//        public float level_diff_adjust_2_adjust_sp { get; set; }
//        public float level_diff_adjust_2_adjust_money { get; set; }
//        public float level_diff_adjust_2_adjust_matter { get; set; }
//        public float level_diff_adjust_2_adjust_attack { get; set; }
//        public int level_diff_adjust_3_level_diff { get; set; }
//        public float level_diff_adjust_3_adjust_exp { get; set; }
//        public float level_diff_adjust_3_adjust_sp { get; set; }
//        public float level_diff_adjust_3_adjust_money { get; set; }
//        public float level_diff_adjust_3_adjust_matter { get; set; }
//        public float level_diff_adjust_3_adjust_attack { get; set; }
//        public int level_diff_adjust_4_level_diff { get; set; }
//        public float level_diff_adjust_4_adjust_exp { get; set; }
//        public float level_diff_adjust_4_adjust_sp { get; set; }
//        public float level_diff_adjust_4_adjust_money { get; set; }
//        public float level_diff_adjust_4_adjust_matter { get; set; }
//        public float level_diff_adjust_4_adjust_attack { get; set; }
//        public int level_diff_adjust_5_level_diff { get; set; }
//        public float level_diff_adjust_5_adjust_exp { get; set; }
//        public float level_diff_adjust_5_adjust_sp { get; set; }
//        public float level_diff_adjust_5_adjust_money { get; set; }
//        public float level_diff_adjust_5_adjust_matter { get; set; }
//        public float level_diff_adjust_5_adjust_attack { get; set; }
//        public int level_diff_adjust_6_level_diff { get; set; }
//        public float level_diff_adjust_6_adjust_exp { get; set; }
//        public float level_diff_adjust_6_adjust_sp { get; set; }
//        public float level_diff_adjust_6_adjust_money { get; set; }
//        public float level_diff_adjust_6_adjust_matter { get; set; }
//        public float level_diff_adjust_6_adjust_attack { get; set; }
//        public int level_diff_adjust_7_level_diff { get; set; }
//        public float level_diff_adjust_7_adjust_exp { get; set; }
//        public float level_diff_adjust_7_adjust_sp { get; set; }
//        public float level_diff_adjust_7_adjust_money { get; set; }
//        public float level_diff_adjust_7_adjust_matter { get; set; }
//        public float level_diff_adjust_7_adjust_attack { get; set; }
//        public int level_diff_adjust_8_level_diff { get; set; }
//        public float level_diff_adjust_8_adjust_exp { get; set; }
//        public float level_diff_adjust_8_adjust_sp { get; set; }
//        public float level_diff_adjust_8_adjust_money { get; set; }
//        public float level_diff_adjust_8_adjust_matter { get; set; }
//        public float level_diff_adjust_8_adjust_attack { get; set; }
//        public int level_diff_adjust_9_level_diff { get; set; }
//        public float level_diff_adjust_9_adjust_exp { get; set; }
//        public float level_diff_adjust_9_adjust_sp { get; set; }
//        public float level_diff_adjust_9_adjust_money { get; set; }
//        public float level_diff_adjust_9_adjust_matter { get; set; }
//        public float level_diff_adjust_9_adjust_attack { get; set; }
//        public int level_diff_adjust_10_level_diff { get; set; }
//        public float level_diff_adjust_10_adjust_exp { get; set; }
//        public float level_diff_adjust_10_adjust_sp { get; set; }
//        public float level_diff_adjust_10_adjust_money { get; set; }
//        public float level_diff_adjust_10_adjust_matter { get; set; }
//        public float level_diff_adjust_10_adjust_attack { get; set; }
//        public int level_diff_adjust_11_level_diff { get; set; }
//        public float level_diff_adjust_11_adjust_exp { get; set; }
//        public float level_diff_adjust_11_adjust_sp { get; set; }
//        public float level_diff_adjust_11_adjust_money { get; set; }
//        public float level_diff_adjust_11_adjust_matter { get; set; }
//        public float level_diff_adjust_11_adjust_attack { get; set; }
//        public int level_diff_adjust_12_level_diff { get; set; }
//        public float level_diff_adjust_12_adjust_exp { get; set; }
//        public float level_diff_adjust_12_adjust_sp { get; set; }
//        public float level_diff_adjust_12_adjust_money { get; set; }
//        public float level_diff_adjust_12_adjust_matter { get; set; }
//        public float level_diff_adjust_12_adjust_attack { get; set; }
//        public int level_diff_adjust_13_level_diff { get; set; }
//        public float level_diff_adjust_13_adjust_exp { get; set; }
//        public float level_diff_adjust_13_adjust_sp { get; set; }
//        public float level_diff_adjust_13_adjust_money { get; set; }
//        public float level_diff_adjust_13_adjust_matter { get; set; }
//        public float level_diff_adjust_13_adjust_attack { get; set; }
//        public int level_diff_adjust_14_level_diff { get; set; }
//        public float level_diff_adjust_14_adjust_exp { get; set; }
//        public float level_diff_adjust_14_adjust_sp { get; set; }
//        public float level_diff_adjust_14_adjust_money { get; set; }
//        public float level_diff_adjust_14_adjust_matter { get; set; }
//        public float level_diff_adjust_14_adjust_attack { get; set; }
//        public int level_diff_adjust_15_level_diff { get; set; }
//        public float level_diff_adjust_15_adjust_exp { get; set; }
//        public float level_diff_adjust_15_adjust_sp { get; set; }
//        public float level_diff_adjust_15_adjust_money { get; set; }
//        public float level_diff_adjust_15_adjust_matter { get; set; }
//        public float level_diff_adjust_15_adjust_attack { get; set; }
//        public int level_diff_adjust_16_level_diff { get; set; }
//        public float level_diff_adjust_16_adjust_exp { get; set; }
//        public float level_diff_adjust_16_adjust_sp { get; set; }
//        public float level_diff_adjust_16_adjust_money { get; set; }
//        public float level_diff_adjust_16_adjust_matter { get; set; }
//        public float level_diff_adjust_16_adjust_attack { get; set; }
//        public float team_adjust_1_adjust_exp { get; set; }
//        public float team_adjust_1_adjust_sp { get; set; }
//        public float team_adjust_2_adjust_exp { get; set; }
//        public float team_adjust_2_adjust_sp { get; set; }
//        public float team_adjust_3_adjust_exp { get; set; }
//        public float team_adjust_3_adjust_sp { get; set; }
//        public float team_adjust_4_adjust_exp { get; set; }
//        public float team_adjust_4_adjust_sp { get; set; }
//        public float team_adjust_5_adjust_exp { get; set; }
//        public float team_adjust_5_adjust_sp { get; set; }
//        public float team_adjust_6_adjust_exp { get; set; }
//        public float team_adjust_6_adjust_sp { get; set; }
//        public float team_adjust_7_adjust_exp { get; set; }
//        public float team_adjust_7_adjust_sp { get; set; }
//        public float team_adjust_8_adjust_exp { get; set; }
//        public float team_adjust_8_adjust_sp { get; set; }
//        public float team_adjust_9_adjust_exp { get; set; }
//        public float team_adjust_9_adjust_sp { get; set; }
//        public float team_adjust_10_adjust_exp { get; set; }
//        public float team_adjust_10_adjust_sp { get; set; }
//        public float team_adjust_11_adjust_exp { get; set; }
//        public float team_adjust_11_adjust_sp { get; set; }
//        public float team_profession_adjust_1_adjust_exp { get; set; }
//        public float team_profession_adjust_1_adjust_sp { get; set; }
//        public float team_profession_adjust_2_adjust_exp { get; set; }
//        public float team_profession_adjust_2_adjust_sp { get; set; }
//        public float team_profession_adjust_3_adjust_exp { get; set; }
//        public float team_profession_adjust_3_adjust_sp { get; set; }
//        public float team_profession_adjust_4_adjust_exp { get; set; }
//        public float team_profession_adjust_4_adjust_sp { get; set; }
//        public float team_profession_adjust_5_adjust_exp { get; set; }
//        public float team_profession_adjust_5_adjust_sp { get; set; }
//        public float team_profession_adjust_6_adjust_exp { get; set; }
//        public float team_profession_adjust_6_adjust_sp { get; set; }
//        public float team_profession_adjust_7_adjust_exp { get; set; }
//        public float team_profession_adjust_7_adjust_sp { get; set; }
//        public float team_profession_adjust_8_adjust_exp { get; set; }
//        public float team_profession_adjust_8_adjust_sp { get; set; }
//        public float team_profession_adjust_9_adjust_exp { get; set; }
//        public float team_profession_adjust_9_adjust_sp { get; set; }
//        public float team_profession_adjust_10_adjust_exp { get; set; }
//        public float team_profession_adjust_10_adjust_sp { get; set; }
//        public float team_profession_adjust_11_adjust_exp { get; set; }
//        public float team_profession_adjust_11_adjust_sp { get; set; }
//        public float dmg_adj_to_spec_atk_speed { get; set; }
//        public float atk_rate_adj_to_spec_atk_speed { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PLAYER_ACTION_INFO_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_name;

//        public string Action_name
//        {
//            get => Structure.Gbk.GetString(action_name);
//            set { action_name = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_prefix;

//        public string Action_prefix
//        {
//            get => Structure.Gbk.GetString(action_prefix);
//            set { action_prefix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_1_suffix;

//        public string Action_weapon_suffix_1_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_1_suffix);
//            set { action_weapon_suffix_1_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_2_suffix;

//        public string Action_weapon_suffix_2_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_2_suffix);
//            set { action_weapon_suffix_2_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_3_suffix;

//        public string Action_weapon_suffix_3_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_3_suffix);
//            set { action_weapon_suffix_3_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_4_suffix;

//        public string Action_weapon_suffix_4_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_4_suffix);
//            set { action_weapon_suffix_4_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_5_suffix;

//        public string Action_weapon_suffix_5_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_5_suffix);
//            set { action_weapon_suffix_5_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_6_suffix;

//        public string Action_weapon_suffix_6_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_6_suffix);
//            set { action_weapon_suffix_6_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_7_suffix;

//        public string Action_weapon_suffix_7_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_7_suffix);
//            set { action_weapon_suffix_7_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_8_suffix;

//        public string Action_weapon_suffix_8_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_8_suffix);
//            set { action_weapon_suffix_8_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_9_suffix;

//        public string Action_weapon_suffix_9_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_9_suffix);
//            set { action_weapon_suffix_9_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_10_suffix;

//        public string Action_weapon_suffix_10_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_10_suffix);
//            set { action_weapon_suffix_10_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_11_suffix;

//        public string Action_weapon_suffix_11_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_11_suffix);
//            set { action_weapon_suffix_11_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_12_suffix;

//        public string Action_weapon_suffix_12_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_12_suffix);
//            set { action_weapon_suffix_12_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] action_weapon_suffix_13_suffix;

//        public string Action_weapon_suffix_13_suffix
//        {
//            get => Structure.Gbk.GetString(action_weapon_suffix_13_suffix);
//            set { action_weapon_suffix_13_suffix = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        public int hide_weapon { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TASKDICE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int task_lists_1_id { get; set; }
//        public float task_lists_1_probability { get; set; }
//        public int task_lists_2_id { get; set; }
//        public float task_lists_2_probability { get; set; }
//        public int task_lists_3_id { get; set; }
//        public float task_lists_3_probability { get; set; }
//        public int task_lists_4_id { get; set; }
//        public float task_lists_4_probability { get; set; }
//        public int task_lists_5_id { get; set; }
//        public float task_lists_5_probability { get; set; }
//        public int task_lists_6_id { get; set; }
//        public float task_lists_6_probability { get; set; }
//        public int task_lists_7_id { get; set; }
//        public float task_lists_7_probability { get; set; }
//        public int task_lists_8_id { get; set; }
//        public float task_lists_8_probability { get; set; }
//        public int task_lists_9_id { get; set; }
//        public float task_lists_9_probability { get; set; }
//        public int task_lists_10_id { get; set; }
//        public float task_lists_10_probability { get; set; }
//        public int task_lists_11_id { get; set; }
//        public float task_lists_11_probability { get; set; }
//        public int task_lists_12_id { get; set; }
//        public float task_lists_12_probability { get; set; }
//        public int task_lists_13_id { get; set; }
//        public float task_lists_13_probability { get; set; }
//        public int task_lists_14_id { get; set; }
//        public float task_lists_14_probability { get; set; }
//        public int task_lists_15_id { get; set; }
//        public float task_lists_15_probability { get; set; }
//        public int task_lists_16_id { get; set; }
//        public float task_lists_16_probability { get; set; }
//        public int task_lists_17_id { get; set; }
//        public float task_lists_17_probability { get; set; }
//        public int task_lists_18_id { get; set; }
//        public float task_lists_18_probability { get; set; }
//        public int task_lists_19_id { get; set; }
//        public float task_lists_19_probability { get; set; }
//        public int task_lists_20_id { get; set; }
//        public float task_lists_20_probability { get; set; }
//        public int use_on_pick { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//        public int no_use_in_combat { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TASKNORMALMATTER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_FALING_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_faling_skin;

//        public string File_faling_skin
//        {
//            get => Structure.Gbk.GetString(file_faling_skin);
//            set { file_faling_skin = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int visualize_id { get; set; }
//        public int facepill_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PLAYER_LEVELEXP_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int exp_1 { get; set; }
//        public int exp_2 { get; set; }
//        public int exp_3 { get; set; }
//        public int exp_4 { get; set; }
//        public int exp_5 { get; set; }
//        public int exp_6 { get; set; }
//        public int exp_7 { get; set; }
//        public int exp_8 { get; set; }
//        public int exp_9 { get; set; }
//        public int exp_10 { get; set; }
//        public int exp_11 { get; set; }
//        public int exp_12 { get; set; }
//        public int exp_13 { get; set; }
//        public int exp_14 { get; set; }
//        public int exp_15 { get; set; }
//        public int exp_16 { get; set; }
//        public int exp_17 { get; set; }
//        public int exp_18 { get; set; }
//        public int exp_19 { get; set; }
//        public int exp_20 { get; set; }
//        public int exp_21 { get; set; }
//        public int exp_22 { get; set; }
//        public int exp_23 { get; set; }
//        public int exp_24 { get; set; }
//        public int exp_25 { get; set; }
//        public int exp_26 { get; set; }
//        public int exp_27 { get; set; }
//        public int exp_28 { get; set; }
//        public int exp_29 { get; set; }
//        public int exp_30 { get; set; }
//        public int exp_31 { get; set; }
//        public int exp_32 { get; set; }
//        public int exp_33 { get; set; }
//        public int exp_34 { get; set; }
//        public int exp_35 { get; set; }
//        public int exp_36 { get; set; }
//        public int exp_37 { get; set; }
//        public int exp_38 { get; set; }
//        public int exp_39 { get; set; }
//        public int exp_40 { get; set; }
//        public int exp_41 { get; set; }
//        public int exp_42 { get; set; }
//        public int exp_43 { get; set; }
//        public int exp_44 { get; set; }
//        public int exp_45 { get; set; }
//        public int exp_46 { get; set; }
//        public int exp_47 { get; set; }
//        public int exp_48 { get; set; }
//        public int exp_49 { get; set; }
//        public int exp_50 { get; set; }
//        public int exp_51 { get; set; }
//        public int exp_52 { get; set; }
//        public int exp_53 { get; set; }
//        public int exp_54 { get; set; }
//        public int exp_55 { get; set; }
//        public int exp_56 { get; set; }
//        public int exp_57 { get; set; }
//        public int exp_58 { get; set; }
//        public int exp_59 { get; set; }
//        public int exp_60 { get; set; }
//        public int exp_61 { get; set; }
//        public int exp_62 { get; set; }
//        public int exp_63 { get; set; }
//        public int exp_64 { get; set; }
//        public int exp_65 { get; set; }
//        public int exp_66 { get; set; }
//        public int exp_67 { get; set; }
//        public int exp_68 { get; set; }
//        public int exp_69 { get; set; }
//        public int exp_70 { get; set; }
//        public int exp_71 { get; set; }
//        public int exp_72 { get; set; }
//        public int exp_73 { get; set; }
//        public int exp_74 { get; set; }
//        public int exp_75 { get; set; }
//        public int exp_76 { get; set; }
//        public int exp_77 { get; set; }
//        public int exp_78 { get; set; }
//        public int exp_79 { get; set; }
//        public int exp_80 { get; set; }
//        public int exp_81 { get; set; }
//        public int exp_82 { get; set; }
//        public int exp_83 { get; set; }
//        public int exp_84 { get; set; }
//        public int exp_85 { get; set; }
//        public int exp_86 { get; set; }
//        public int exp_87 { get; set; }
//        public int exp_88 { get; set; }
//        public int exp_89 { get; set; }
//        public int exp_90 { get; set; }
//        public int exp_91 { get; set; }
//        public int exp_92 { get; set; }
//        public int exp_93 { get; set; }
//        public int exp_94 { get; set; }
//        public int exp_95 { get; set; }
//        public int exp_96 { get; set; }
//        public int exp_97 { get; set; }
//        public int exp_98 { get; set; }
//        public int exp_99 { get; set; }
//        public int exp_100 { get; set; }
//        public int exp_101 { get; set; }
//        public int exp_102 { get; set; }
//        public int exp_103 { get; set; }
//        public int exp_104 { get; set; }
//        public int exp_105 { get; set; }
//        public int exp_106 { get; set; }
//        public int exp_107 { get; set; }
//        public int exp_108 { get; set; }
//        public int exp_109 { get; set; }
//        public int exp_110 { get; set; }
//        public int exp_111 { get; set; }
//        public int exp_112 { get; set; }
//        public int exp_113 { get; set; }
//        public int exp_114 { get; set; }
//        public int exp_115 { get; set; }
//        public int exp_116 { get; set; }
//        public int exp_117 { get; set; }
//        public int exp_118 { get; set; }
//        public int exp_119 { get; set; }
//        public int exp_120 { get; set; }
//        public int exp_121 { get; set; }
//        public int exp_122 { get; set; }
//        public int exp_123 { get; set; }
//        public int exp_124 { get; set; }
//        public int exp_125 { get; set; }
//        public int exp_126 { get; set; }
//        public int exp_127 { get; set; }
//        public int exp_128 { get; set; }
//        public int exp_129 { get; set; }
//        public int exp_130 { get; set; }
//        public int exp_131 { get; set; }
//        public int exp_132 { get; set; }
//        public int exp_133 { get; set; }
//        public int exp_134 { get; set; }
//        public int exp_135 { get; set; }
//        public int exp_136 { get; set; }
//        public int exp_137 { get; set; }
//        public int exp_138 { get; set; }
//        public int exp_139 { get; set; }
//        public int exp_140 { get; set; }
//        public int exp_141 { get; set; }
//        public int exp_142 { get; set; }
//        public int exp_143 { get; set; }
//        public int exp_144 { get; set; }
//        public int exp_145 { get; set; }
//        public int exp_146 { get; set; }
//        public int exp_147 { get; set; }
//        public int exp_148 { get; set; }
//        public int exp_149 { get; set; }
//        public int exp_150 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MINE_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MINE_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int level { get; set; }
//        public int level_required { get; set; }
//        public int id_equipment_required { get; set; }
//        public int eliminate_tool { get; set; }
//        public int time_min { get; set; }
//        public int time_max { get; set; }
//        public int exp { get; set; }
//        public int skillpoint { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int materials_1_id { get; set; }
//        public float materials_1_probability { get; set; }
//        public int materials_2_id { get; set; }
//        public float materials_2_probability { get; set; }
//        public int materials_3_id { get; set; }
//        public float materials_3_probability { get; set; }
//        public int materials_4_id { get; set; }
//        public float materials_4_probability { get; set; }
//        public int materials_5_id { get; set; }
//        public float materials_5_probability { get; set; }
//        public int materials_6_id { get; set; }
//        public float materials_6_probability { get; set; }
//        public int materials_7_id { get; set; }
//        public float materials_7_probability { get; set; }
//        public int materials_8_id { get; set; }
//        public float materials_8_probability { get; set; }
//        public int materials_9_id { get; set; }
//        public float materials_9_probability { get; set; }
//        public int materials_10_id { get; set; }
//        public float materials_10_probability { get; set; }
//        public int materials_11_id { get; set; }
//        public float materials_11_probability { get; set; }
//        public int materials_12_id { get; set; }
//        public float materials_12_probability { get; set; }
//        public int materials_13_id { get; set; }
//        public float materials_13_probability { get; set; }
//        public int materials_14_id { get; set; }
//        public float materials_14_probability { get; set; }
//        public int materials_15_id { get; set; }
//        public float materials_15_probability { get; set; }
//        public int materials_16_id { get; set; }
//        public float materials_16_probability { get; set; }
//        public int num1 { get; set; }
//        public float probability1 { get; set; }
//        public int num2 { get; set; }
//        public float probability2 { get; set; }
//        public int task_in { get; set; }
//        public int task_out { get; set; }
//        public int uninterruptable { get; set; }
//        public int npcgen_1_id_monster { get; set; }
//        public int npcgen_1_num { get; set; }
//        public float npcgen_1_radius { get; set; }
//        public int npcgen_1_life_time { get; set; }
//        public int npcgen_2_id_monster { get; set; }
//        public int npcgen_2_num { get; set; }
//        public float npcgen_2_radius { get; set; }
//        public int npcgen_2_life_time { get; set; }
//        public int npcgen_3_id_monster { get; set; }
//        public int npcgen_3_num { get; set; }
//        public float npcgen_3_radius { get; set; }
//        public int npcgen_3_life_time { get; set; }
//        public float npcgen_4_id_monster { get; set; }
//        public int npcgen_4_num { get; set; }
//        public float npcgen_4_radius { get; set; }
//        public int npcgen_4_life_time { get; set; }
//        public int aggros_1_monster_faction { get; set; }
//        public float aggros_1_radius { get; set; }
//        public int aggros_1_num { get; set; }
//        public int permenent { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_IDENTIFY_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int fee { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FASHION_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FASHION_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int equip_fashion_mask { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FASHION_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] realname;

//        public string Realname
//        {
//            get => Structure.Gbk.GetString(realname);
//            set { realname = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int equip_location { get; set; }
//        public int level { get; set; }
//        public int require_level { get; set; }
//        public int require_dye_count { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int gender { get; set; }
//        public int id_hair { get; set; }
//        public int id_hair_texture { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wear_action;

//        public string Wear_action
//        {
//            get => Structure.Gbk.GetString(wear_action);
//            set { wear_action = BinReader.FillArray(Structure.Gbk.GetBytes(value), 32); }
//        }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACETICKET_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACETICKET_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACETICKET_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_level { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] bound_file;

//        public string Bound_file
//        {
//            get => Structure.Gbk.GetString(bound_file);
//            set { bound_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int unsymmetrical { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACEPILL_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACEPILL_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACEPILL_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;
//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int duration { get; set; }
//        public float camera_scale { get; set; }
//        [CharacterCombo] public int character_combo_id { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_1_file;

//        public string Pllfiles_1_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_1_file);
//            set { pllfiles_1_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_2_file;

//        public string Pllfiles_2_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_2_file);
//            set { pllfiles_2_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_3_file;

//        public string Pllfiles_3_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_3_file);
//            set { pllfiles_3_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_4_file;

//        public string Pllfiles_4_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_4_file);
//            set { pllfiles_4_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_5_file;

//        public string Pllfiles_5_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_5_file);
//            set { pllfiles_5_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_6_file;

//        public string Pllfiles_6_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_6_file);
//            set { pllfiles_6_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_7_file;

//        public string Pllfiles_7_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_7_file);
//            set { pllfiles_7_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_8_file;

//        public string Pllfiles_8_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_8_file);
//            set { pllfiles_8_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_9_file;

//        public string Pllfiles_9_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_9_file);
//            set { pllfiles_9_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_10_file;

//        public string Pllfiles_10_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_10_file);
//            set { pllfiles_10_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_11_file;

//        public string Pllfiles_11_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_11_file);
//            set { pllfiles_11_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_12_file;

//        public string Pllfiles_12_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_12_file);
//            set { pllfiles_12_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_13_file;

//        public string Pllfiles_13_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_13_file);
//            set { pllfiles_13_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_14_file;

//        public string Pllfiles_14_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_14_file);
//            set { pllfiles_14_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_15_file;

//        public string Pllfiles_15_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_15_file);
//            set { pllfiles_15_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_16_file;

//        public string Pllfiles_16_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_16_file);
//            set { pllfiles_16_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_17_file;

//        public string Pllfiles_17_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_17_file);
//            set { pllfiles_17_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_18_file;

//        public string Pllfiles_18_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_18_file);
//            set { pllfiles_18_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_19_file;

//        public string Pllfiles_19_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_19_file);
//            set { pllfiles_19_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] pllfiles_20_file;

//        public string Pllfiles_20_file
//        {
//            get => Structure.Gbk.GetString(pllfiles_20_file);
//            set { pllfiles_20_file = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SUITE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int max_equips { get; set; }
//        [ItemId] public int equipments_1_id { get; set; }
//        [ItemId] public int equipments_2_id { get; set; }
//        [ItemId] public int equipments_3_id { get; set; }
//        [ItemId] public int equipments_4_id { get; set; }
//        [ItemId] public int equipments_5_id { get; set; }
//        [ItemId] public int equipments_6_id { get; set; }
//        [ItemId] public int equipments_7_id { get; set; }
//        [ItemId] public int equipments_8_id { get; set; }
//        [ItemId] public int equipments_9_id { get; set; }
//        [ItemId] public int equipments_10_id { get; set; }
//        [ItemId] public int equipments_11_id { get; set; }
//        [ItemId] public int equipments_12_id { get; set; }
//        [AddonId] public int addons_1_id { get; set; }
//        [AddonId] public int addons_2_id { get; set; }
//        [AddonId] public int addons_3_id { get; set; }
//        [AddonId] public int addons_4_id { get; set; }
//        [AddonId] public int addons_5_id { get; set; }
//        [AddonId] public int addons_6_id { get; set; }
//        [AddonId] public int addons_7_id { get; set; }
//        [AddonId] public int addons_8_id { get; set; }
//        [AddonId] public int addons_9_id { get; set; }
//        [AddonId] public int addons_10_id { get; set; }
//        [AddonId] public int addons_11_id { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_gfx;

//        public string File_gfx
//        {
//            get => Structure.Gbk.GetString(file_gfx);
//            set { file_gfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GM_GENERATOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GM_GENERATOR_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_object { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PET_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PET_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int level_max { get; set; }
//        public int level_require { get; set; }
//        public int pet_snd_type { get; set; }
//        public float hp_a { get; set; }
//        public float hp_b { get; set; }
//        public float hp_c { get; set; }
//        public float hp_gen_a { get; set; }
//        public float hp_gen_b { get; set; }
//        public float hp_gen_c { get; set; }
//        public float damage_a { get; set; }
//        public float damage_b { get; set; }
//        public float damage_c { get; set; }
//        public float damage_d { get; set; }
//        public float speed_a { get; set; }
//        public float speed_b { get; set; }
//        public float attack_a { get; set; }
//        public float attack_b { get; set; }
//        public float attack_c { get; set; }
//        public float armor_a { get; set; }
//        public float armor_b { get; set; }
//        public float armor_c { get; set; }
//        public float physic_defence_a { get; set; }
//        public float physic_defence_b { get; set; }
//        public float physic_defence_c { get; set; }
//        public float physic_defence_d { get; set; }
//        public float magic_defence_a { get; set; }
//        public float magic_defence_b { get; set; }
//        public float magic_defence_c { get; set; }
//        public float magic_defence_d { get; set; }
//        public float mp_a { get; set; }
//        public float mp_gen_a { get; set; }
//        public float attack_degree_a { get; set; }
//        public float defence_degree_a { get; set; }
//        public float size { get; set; }
//        public float damage_delay { get; set; }
//        public float attack_range { get; set; }
//        public float attack_speed { get; set; }
//        public int sight_range { get; set; }
//        public int food_mask { get; set; }
//        public int inhabit_type { get; set; }
//        public int stand_mode { get; set; }
//        public int plant_group { get; set; }
//        public int group_limit { get; set; }
//        public int immune_type { get; set; }
//        public int player_gain_skill { get; set; }
//        public int require_dye_count { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PET_EGG_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_pet { get; set; }
//        public int money_hatched { get; set; }
//        public int money_restored { get; set; }
//        public int honor_point { get; set; }
//        public int level { get; set; }
//        public int exp { get; set; }
//        public int skill_point { get; set; }
//        public int skills_1_id_skill { get; set; }
//        public int skills_1_level { get; set; }
//        public int skills_2_id_skill { get; set; }
//        public int skills_2_level { get; set; }
//        public int skills_3_id_skill { get; set; }
//        public int skills_3_level { get; set; }
//        public int skills_4_id_skill { get; set; }
//        public int skills_4_level { get; set; }
//        public int skills_5_id_skill { get; set; }
//        public int skills_5_level { get; set; }
//        public int skills_6_id_skill { get; set; }
//        public int skills_6_level { get; set; }
//        public int skills_7_id_skill { get; set; }
//        public int skills_7_level { get; set; }
//        public int skills_8_id_skill { get; set; }
//        public int skills_8_level { get; set; }
//        public int skills_9_id_skill { get; set; }
//        public int skills_9_level { get; set; }
//        public int skills_10_id_skill { get; set; }
//        public int skills_10_level { get; set; }
//        public int skills_11_id_skill { get; set; }
//        public int skills_11_level { get; set; }
//        public int skills_12_id_skill { get; set; }
//        public int skills_12_level { get; set; }
//        public int skills_13_id_skill { get; set; }
//        public int skills_13_level { get; set; }
//        public int skills_14_id_skill { get; set; }
//        public int skills_14_level { get; set; }
//        public int skills_15_id_skill { get; set; }
//        public int skills_15_level { get; set; }
//        public int skills_16_id_skill { get; set; }
//        public int skills_16_level { get; set; }
//        public int skills_17_id_skill { get; set; }
//        public int skills_17_level { get; set; }
//        public int skills_18_id_skill { get; set; }
//        public int skills_18_level { get; set; }
//        public int skills_19_id_skill { get; set; }
//        public int skills_19_level { get; set; }
//        public int skills_20_id_skill { get; set; }
//        public int skills_20_level { get; set; }
//        public int skills_21_id_skill { get; set; }
//        public int skills_21_level { get; set; }
//        public int skills_22_id_skill { get; set; }
//        public int skills_22_level { get; set; }
//        public int skills_23_id_skill { get; set; }
//        public int skills_23_level { get; set; }
//        public int skills_24_id_skill { get; set; }
//        public int skills_24_level { get; set; }
//        public int skills_25_id_skill { get; set; }
//        public int skills_25_level { get; set; }
//        public int skills_26_id_skill { get; set; }
//        public int skills_26_level { get; set; }
//        public int skills_27_id_skill { get; set; }
//        public int skills_27_level { get; set; }
//        public int skills_28_id_skill { get; set; }
//        public int skills_28_level { get; set; }
//        public int skills_29_id_skill { get; set; }
//        public int skills_29_level { get; set; }
//        public int skills_30_id_skill { get; set; }
//        public int skills_30_level { get; set; }
//        public int skills_31_id_skill { get; set; }
//        public int skills_31_level { get; set; }
//        public int skills_32_id_skill { get; set; }
//        public int skills_32_level { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PET_FOOD_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int hornor { get; set; }
//        public int exp { get; set; }
//        public int food_type { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PET_FACETICKET_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FIREWORKS_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_fw;

//        public string File_fw
//        {
//            get => Structure.Gbk.GetString(file_fw);
//            set { file_fw = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int time_to_fire { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WAR_TANKCALLIN_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_WAR_TOWERBUILD_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int build_info_1_id_in_build { get; set; }
//        public int build_info_1_id_buildup { get; set; }
//        public int build_info_1_id_object_need { get; set; }
//        public int build_info_1_time_use { get; set; }
//        public int build_info_1_fee { get; set; }
//        public int build_info_2_id_in_build { get; set; }
//        public int build_info_2_id_buildup { get; set; }
//        public int build_info_2_id_object_need { get; set; }
//        public int build_info_2_time_use { get; set; }
//        public int build_info_2_fee { get; set; }
//        public int build_info_3_id_in_build { get; set; }
//        public int build_info_3_id_buildup { get; set; }
//        public int build_info_3_id_object_need { get; set; }
//        public int build_info_3_time_use { get; set; }
//        public int build_info_3_fee { get; set; }
//        public int build_info_4_id_in_build { get; set; }
//        public int build_info_4_id_buildup { get; set; }
//        public int build_info_4_id_object_need { get; set; }
//        public int build_info_4_time_use { get; set; }
//        public int build_info_4_fee { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PLAYER_SECONDLEVEL_CONFIG
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public float exp_lost_1 { get; set; }
//        public float exp_lost_2 { get; set; }
//        public float exp_lost_3 { get; set; }
//        public float exp_lost_4 { get; set; }
//        public float exp_lost_5 { get; set; }
//        public float exp_lost_6 { get; set; }
//        public float exp_lost_7 { get; set; }
//        public float exp_lost_8 { get; set; }
//        public float exp_lost_9 { get; set; }
//        public float exp_lost_10 { get; set; }
//        public float exp_lost_11 { get; set; }
//        public float exp_lost_12 { get; set; }
//        public float exp_lost_13 { get; set; }
//        public float exp_lost_14 { get; set; }
//        public float exp_lost_15 { get; set; }
//        public float exp_lost_16 { get; set; }
//        public float exp_lost_17 { get; set; }
//        public float exp_lost_18 { get; set; }
//        public float exp_lost_19 { get; set; }
//        public float exp_lost_20 { get; set; }
//        public float exp_lost_21 { get; set; }
//        public float exp_lost_22 { get; set; }
//        public float exp_lost_23 { get; set; }
//        public float exp_lost_24 { get; set; }
//        public float exp_lost_25 { get; set; }
//        public float exp_lost_26 { get; set; }
//        public float exp_lost_27 { get; set; }
//        public float exp_lost_28 { get; set; }
//        public float exp_lost_29 { get; set; }
//        public float exp_lost_30 { get; set; }
//        public float exp_lost_31 { get; set; }
//        public float exp_lost_32 { get; set; }
//        public float exp_lost_33 { get; set; }
//        public float exp_lost_34 { get; set; }
//        public float exp_lost_35 { get; set; }
//        public float exp_lost_36 { get; set; }
//        public float exp_lost_37 { get; set; }
//        public float exp_lost_38 { get; set; }
//        public float exp_lost_39 { get; set; }
//        public float exp_lost_40 { get; set; }
//        public float exp_lost_41 { get; set; }
//        public float exp_lost_42 { get; set; }
//        public float exp_lost_43 { get; set; }
//        public float exp_lost_44 { get; set; }
//        public float exp_lost_45 { get; set; }
//        public float exp_lost_46 { get; set; }
//        public float exp_lost_47 { get; set; }
//        public float exp_lost_48 { get; set; }
//        public float exp_lost_49 { get; set; }
//        public float exp_lost_50 { get; set; }
//        public float exp_lost_51 { get; set; }
//        public float exp_lost_52 { get; set; }
//        public float exp_lost_53 { get; set; }
//        public float exp_lost_54 { get; set; }
//        public float exp_lost_55 { get; set; }
//        public float exp_lost_56 { get; set; }
//        public float exp_lost_57 { get; set; }
//        public float exp_lost_58 { get; set; }
//        public float exp_lost_59 { get; set; }
//        public float exp_lost_60 { get; set; }
//        public float exp_lost_61 { get; set; }
//        public float exp_lost_62 { get; set; }
//        public float exp_lost_63 { get; set; }
//        public float exp_lost_64 { get; set; }
//        public float exp_lost_65 { get; set; }
//        public float exp_lost_66 { get; set; }
//        public float exp_lost_67 { get; set; }
//        public float exp_lost_68 { get; set; }
//        public float exp_lost_69 { get; set; }
//        public float exp_lost_70 { get; set; }
//        public float exp_lost_71 { get; set; }
//        public float exp_lost_72 { get; set; }
//        public float exp_lost_73 { get; set; }
//        public float exp_lost_74 { get; set; }
//        public float exp_lost_75 { get; set; }
//        public float exp_lost_76 { get; set; }
//        public float exp_lost_77 { get; set; }
//        public float exp_lost_78 { get; set; }
//        public float exp_lost_79 { get; set; }
//        public float exp_lost_80 { get; set; }
//        public float exp_lost_81 { get; set; }
//        public float exp_lost_82 { get; set; }
//        public float exp_lost_83 { get; set; }
//        public float exp_lost_84 { get; set; }
//        public float exp_lost_85 { get; set; }
//        public float exp_lost_86 { get; set; }
//        public float exp_lost_87 { get; set; }
//        public float exp_lost_88 { get; set; }
//        public float exp_lost_89 { get; set; }
//        public float exp_lost_90 { get; set; }
//        public float exp_lost_91 { get; set; }
//        public float exp_lost_92 { get; set; }
//        public float exp_lost_93 { get; set; }
//        public float exp_lost_94 { get; set; }
//        public float exp_lost_95 { get; set; }
//        public float exp_lost_96 { get; set; }
//        public float exp_lost_97 { get; set; }
//        public float exp_lost_98 { get; set; }
//        public float exp_lost_99 { get; set; }
//        public float exp_lost_100 { get; set; }
//        public float exp_lost_101 { get; set; }
//        public float exp_lost_102 { get; set; }
//        public float exp_lost_103 { get; set; }
//        public float exp_lost_104 { get; set; }
//        public float exp_lost_105 { get; set; }
//        public float exp_lost_106 { get; set; }
//        public float exp_lost_107 { get; set; }
//        public float exp_lost_108 { get; set; }
//        public float exp_lost_109 { get; set; }
//        public float exp_lost_110 { get; set; }
//        public float exp_lost_111 { get; set; }
//        public float exp_lost_112 { get; set; }
//        public float exp_lost_113 { get; set; }
//        public float exp_lost_114 { get; set; }
//        public float exp_lost_115 { get; set; }
//        public float exp_lost_116 { get; set; }
//        public float exp_lost_117 { get; set; }
//        public float exp_lost_118 { get; set; }
//        public float exp_lost_119 { get; set; }
//        public float exp_lost_120 { get; set; }
//        public float exp_lost_121 { get; set; }
//        public float exp_lost_122 { get; set; }
//        public float exp_lost_123 { get; set; }
//        public float exp_lost_124 { get; set; }
//        public float exp_lost_125 { get; set; }
//        public float exp_lost_126 { get; set; }
//        public float exp_lost_127 { get; set; }
//        public float exp_lost_128 { get; set; }
//        public float exp_lost_129 { get; set; }
//        public float exp_lost_130 { get; set; }
//        public float exp_lost_131 { get; set; }
//        public float exp_lost_132 { get; set; }
//        public float exp_lost_133 { get; set; }
//        public float exp_lost_134 { get; set; }
//        public float exp_lost_135 { get; set; }
//        public float exp_lost_136 { get; set; }
//        public float exp_lost_137 { get; set; }
//        public float exp_lost_138 { get; set; }
//        public float exp_lost_139 { get; set; }
//        public float exp_lost_140 { get; set; }
//        public float exp_lost_141 { get; set; }
//        public float exp_lost_142 { get; set; }
//        public float exp_lost_143 { get; set; }
//        public float exp_lost_144 { get; set; }
//        public float exp_lost_145 { get; set; }
//        public float exp_lost_146 { get; set; }
//        public float exp_lost_147 { get; set; }
//        public float exp_lost_148 { get; set; }
//        public float exp_lost_149 { get; set; }
//        public float exp_lost_150 { get; set; }
//        public float exp_lost_151 { get; set; }
//        public float exp_lost_152 { get; set; }
//        public float exp_lost_153 { get; set; }
//        public float exp_lost_154 { get; set; }
//        public float exp_lost_155 { get; set; }
//        public float exp_lost_156 { get; set; }
//        public float exp_lost_157 { get; set; }
//        public float exp_lost_158 { get; set; }
//        public float exp_lost_159 { get; set; }
//        public float exp_lost_160 { get; set; }
//        public float exp_lost_161 { get; set; }
//        public float exp_lost_162 { get; set; }
//        public float exp_lost_163 { get; set; }
//        public float exp_lost_164 { get; set; }
//        public float exp_lost_165 { get; set; }
//        public float exp_lost_166 { get; set; }
//        public float exp_lost_167 { get; set; }
//        public float exp_lost_168 { get; set; }
//        public float exp_lost_169 { get; set; }
//        public float exp_lost_170 { get; set; }
//        public float exp_lost_171 { get; set; }
//        public float exp_lost_172 { get; set; }
//        public float exp_lost_173 { get; set; }
//        public float exp_lost_174 { get; set; }
//        public float exp_lost_175 { get; set; }
//        public float exp_lost_176 { get; set; }
//        public float exp_lost_177 { get; set; }
//        public float exp_lost_178 { get; set; }
//        public float exp_lost_179 { get; set; }
//        public float exp_lost_180 { get; set; }
//        public float exp_lost_181 { get; set; }
//        public float exp_lost_182 { get; set; }
//        public float exp_lost_183 { get; set; }
//        public float exp_lost_184 { get; set; }
//        public float exp_lost_185 { get; set; }
//        public float exp_lost_186 { get; set; }
//        public float exp_lost_187 { get; set; }
//        public float exp_lost_188 { get; set; }
//        public float exp_lost_189 { get; set; }
//        public float exp_lost_190 { get; set; }
//        public float exp_lost_191 { get; set; }
//        public float exp_lost_192 { get; set; }
//        public float exp_lost_193 { get; set; }
//        public float exp_lost_194 { get; set; }
//        public float exp_lost_195 { get; set; }
//        public float exp_lost_196 { get; set; }
//        public float exp_lost_197 { get; set; }
//        public float exp_lost_198 { get; set; }
//        public float exp_lost_199 { get; set; }
//        public float exp_lost_200 { get; set; }
//        public float exp_lost_201 { get; set; }
//        public float exp_lost_202 { get; set; }
//        public float exp_lost_203 { get; set; }
//        public float exp_lost_204 { get; set; }
//        public float exp_lost_205 { get; set; }
//        public float exp_lost_206 { get; set; }
//        public float exp_lost_207 { get; set; }
//        public float exp_lost_208 { get; set; }
//        public float exp_lost_209 { get; set; }
//        public float exp_lost_210 { get; set; }
//        public float exp_lost_211 { get; set; }
//        public float exp_lost_212 { get; set; }
//        public float exp_lost_213 { get; set; }
//        public float exp_lost_214 { get; set; }
//        public float exp_lost_215 { get; set; }
//        public float exp_lost_216 { get; set; }
//        public float exp_lost_217 { get; set; }
//        public float exp_lost_218 { get; set; }
//        public float exp_lost_219 { get; set; }
//        public float exp_lost_220 { get; set; }
//        public float exp_lost_221 { get; set; }
//        public float exp_lost_222 { get; set; }
//        public float exp_lost_223 { get; set; }
//        public float exp_lost_224 { get; set; }
//        public float exp_lost_225 { get; set; }
//        public float exp_lost_226 { get; set; }
//        public float exp_lost_227 { get; set; }
//        public float exp_lost_228 { get; set; }
//        public float exp_lost_229 { get; set; }
//        public float exp_lost_230 { get; set; }
//        public float exp_lost_231 { get; set; }
//        public float exp_lost_232 { get; set; }
//        public float exp_lost_233 { get; set; }
//        public float exp_lost_234 { get; set; }
//        public float exp_lost_235 { get; set; }
//        public float exp_lost_236 { get; set; }
//        public float exp_lost_237 { get; set; }
//        public float exp_lost_238 { get; set; }
//        public float exp_lost_239 { get; set; }
//        public float exp_lost_240 { get; set; }
//        public float exp_lost_241 { get; set; }
//        public float exp_lost_242 { get; set; }
//        public float exp_lost_243 { get; set; }
//        public float exp_lost_244 { get; set; }
//        public float exp_lost_245 { get; set; }
//        public float exp_lost_246 { get; set; }
//        public float exp_lost_247 { get; set; }
//        public float exp_lost_248 { get; set; }
//        public float exp_lost_249 { get; set; }
//        public float exp_lost_250 { get; set; }
//        public float exp_lost_251 { get; set; }
//        public float exp_lost_252 { get; set; }
//        public float exp_lost_253 { get; set; }
//        public float exp_lost_254 { get; set; }
//        public float exp_lost_255 { get; set; }
//        public float exp_lost_256 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_RESETPROP_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int prop_entry_1_id_object_need { get; set; }
//        public int prop_entry_1_strength_delta { get; set; }
//        public int prop_entry_1_agility_delta { get; set; }
//        public int prop_entry_1_vital_delta { get; set; }
//        public int prop_entry_1_energy_delta { get; set; }
//        public int prop_entry_2_id_object_need { get; set; }
//        public int prop_entry_2_strength_delta { get; set; }
//        public int prop_entry_2_agility_delta { get; set; }
//        public int prop_entry_2_vital_delta { get; set; }
//        public int prop_entry_2_energy_delta { get; set; }
//        public int prop_entry_3_id_object_need { get; set; }
//        public int prop_entry_3_strength_delta { get; set; }
//        public int prop_entry_3_agility_delta { get; set; }
//        public int prop_entry_3_vital_delta { get; set; }
//        public int prop_entry_3_energy_delta { get; set; }
//        public int prop_entry_4_id_object_need { get; set; }
//        public int prop_entry_4_strength_delta { get; set; }
//        public int prop_entry_4_agility_delta { get; set; }
//        public int prop_entry_4_vital_delta { get; set; }
//        public int prop_entry_4_energy_delta { get; set; }
//        public int prop_entry_5_id_object_need { get; set; }
//        public int prop_entry_5_strength_delta { get; set; }
//        public int prop_entry_5_agility_delta { get; set; }
//        public int prop_entry_5_vital_delta { get; set; }
//        public int prop_entry_5_energy_delta { get; set; }
//        public int prop_entry_6_id_object_need { get; set; }
//        public int prop_entry_6_strength_delta { get; set; }
//        public int prop_entry_6_agility_delta { get; set; }
//        public int prop_entry_6_vital_delta { get; set; }
//        public int prop_entry_6_energy_delta { get; set; }
//        public int prop_entry_7_id_object_need { get; set; }
//        public int prop_entry_7_strength_delta { get; set; }
//        public int prop_entry_7_agility_delta { get; set; }
//        public int prop_entry_7_vital_delta { get; set; }
//        public int prop_entry_7_energy_delta { get; set; }
//        public int prop_entry_8_id_object_need { get; set; }
//        public int prop_entry_8_strength_delta { get; set; }
//        public int prop_entry_8_agility_delta { get; set; }
//        public int prop_entry_8_vital_delta { get; set; }
//        public int prop_entry_8_energy_delta { get; set; }
//        public int prop_entry_9_id_object_need { get; set; }
//        public int prop_entry_9_strength_delta { get; set; }
//        public int prop_entry_9_agility_delta { get; set; }
//        public int prop_entry_9_vital_delta { get; set; }
//        public int prop_entry_9_energy_delta { get; set; }
//        public int prop_entry_10_id_object_need { get; set; }
//        public int prop_entry_10_strength_delta { get; set; }
//        public int prop_entry_10_agility_delta { get; set; }
//        public int prop_entry_10_vital_delta { get; set; }
//        public int prop_entry_10_energy_delta { get; set; }
//        public int prop_entry_11_id_object_need { get; set; }
//        public int prop_entry_11_strength_delta { get; set; }
//        public int prop_entry_11_agility_delta { get; set; }
//        public int prop_entry_11_vital_delta { get; set; }
//        public int prop_entry_11_energy_delta { get; set; }
//        public int prop_entry_12_id_object_need { get; set; }
//        public int prop_entry_12_strength_delta { get; set; }
//        public int prop_entry_12_agility_delta { get; set; }
//        public int prop_entry_12_vital_delta { get; set; }
//        public int prop_entry_12_energy_delta { get; set; }
//        public int prop_entry_13_id_object_need { get; set; }
//        public int prop_entry_13_strength_delta { get; set; }
//        public int prop_entry_13_agility_delta { get; set; }
//        public int prop_entry_13_vital_delta { get; set; }
//        public int prop_entry_13_energy_delta { get; set; }
//        public int prop_entry_14_id_object_need { get; set; }
//        public int prop_entry_14_strength_delta { get; set; }
//        public int prop_entry_14_agility_delta { get; set; }
//        public int prop_entry_14_vital_delta { get; set; }
//        public int prop_entry_14_energy_delta { get; set; }
//        public int prop_entry_15_id_object_need { get; set; }
//        public int prop_entry_15_strength_delta { get; set; }
//        public int prop_entry_15_agility_delta { get; set; }
//        public int prop_entry_15_vital_delta { get; set; }
//        public int prop_entry_15_energy_delta { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_PETNAME_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_object_need { get; set; }
//        public int price { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_PETLEARNSKILL_SERVICE
//    {
//        public int id;
//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;
//        public int id_skills_1 { get; set; }
//        public int id_skills_2 { get; set; }
//        public int id_skills_3 { get; set; }
//        public int id_skills_4 { get; set; }
//        public int id_skills_5 { get; set; }
//        public int id_skills_6 { get; set; }
//        public int id_skills_7 { get; set; }
//        public int id_skills_8 { get; set; }
//        public int id_skills_9 { get; set; }
//        public int id_skills_10 { get; set; }
//        public int id_skills_11 { get; set; }
//        public int id_skills_12 { get; set; }
//        public int id_skills_13 { get; set; }
//        public int id_skills_14 { get; set; }
//        public int id_skills_15 { get; set; }
//        public int id_skills_16 { get; set; }
//        public int id_skills_17 { get; set; }
//        public int id_skills_18 { get; set; }
//        public int id_skills_19 { get; set; }
//        public int id_skills_20 { get; set; }
//        public int id_skills_21 { get; set; }
//        public int id_skills_22 { get; set; }
//        public int id_skills_23 { get; set; }
//        public int id_skills_24 { get; set; }
//        public int id_skills_25 { get; set; }
//        public int id_skills_26 { get; set; }
//        public int id_skills_27 { get; set; }
//        public int id_skills_28 { get; set; }
//        public int id_skills_29 { get; set; }
//        public int id_skills_30 { get; set; }
//        public int id_skills_31 { get; set; }
//        public int id_skills_32 { get; set; }
//        public int id_skills_33 { get; set; }
//        public int id_skills_34 { get; set; }
//        public int id_skills_35 { get; set; }
//        public int id_skills_36 { get; set; }
//        public int id_skills_37 { get; set; }
//        public int id_skills_38 { get; set; }
//        public int id_skills_39 { get; set; }
//        public int id_skills_40 { get; set; }
//        public int id_skills_41 { get; set; }
//        public int id_skills_42 { get; set; }
//        public int id_skills_43 { get; set; }
//        public int id_skills_44 { get; set; }
//        public int id_skills_45 { get; set; }
//        public int id_skills_46 { get; set; }
//        public int id_skills_47 { get; set; }
//        public int id_skills_48 { get; set; }
//        public int id_skills_49 { get; set; }
//        public int id_skills_50 { get; set; }
//        public int id_skills_51 { get; set; }
//        public int id_skills_52 { get; set; }
//        public int id_skills_53 { get; set; }
//        public int id_skills_54 { get; set; }
//        public int id_skills_55 { get; set; }
//        public int id_skills_56 { get; set; }
//        public int id_skills_57 { get; set; }
//        public int id_skills_58 { get; set; }
//        public int id_skills_59 { get; set; }
//        public int id_skills_60 { get; set; }
//        public int id_skills_61 { get; set; }
//        public int id_skills_62 { get; set; }
//        public int id_skills_63 { get; set; }
//        public int id_skills_64 { get; set; }
//        public int id_skills_65 { get; set; }
//        public int id_skills_66 { get; set; }
//        public int id_skills_67 { get; set; }
//        public int id_skills_68 { get; set; }
//        public int id_skills_69 { get; set; }
//        public int id_skills_70 { get; set; }
//        public int id_skills_71 { get; set; }
//        public int id_skills_72 { get; set; }
//        public int id_skills_73 { get; set; }
//        public int id_skills_74 { get; set; }
//        public int id_skills_75 { get; set; }
//        public int id_skills_76 { get; set; }
//        public int id_skills_77 { get; set; }
//        public int id_skills_78 { get; set; }
//        public int id_skills_79 { get; set; }
//        public int id_skills_80 { get; set; }
//        public int id_skills_81 { get; set; }
//        public int id_skills_82 { get; set; }
//        public int id_skills_83 { get; set; }
//        public int id_skills_84 { get; set; }
//        public int id_skills_85 { get; set; }
//        public int id_skills_86 { get; set; }
//        public int id_skills_87 { get; set; }
//        public int id_skills_88 { get; set; }
//        public int id_skills_89 { get; set; }
//        public int id_skills_90 { get; set; }
//        public int id_skills_91 { get; set; }
//        public int id_skills_92 { get; set; }
//        public int id_skills_93 { get; set; }
//        public int id_skills_94 { get; set; }
//        public int id_skills_95 { get; set; }
//        public int id_skills_96 { get; set; }
//        public int id_skills_97 { get; set; }
//        public int id_skills_98 { get; set; }
//        public int id_skills_99 { get; set; }
//        public int id_skills_100 { get; set; }
//        public int id_skills_101 { get; set; }
//        public int id_skills_102 { get; set; }
//        public int id_skills_103 { get; set; }
//        public int id_skills_104 { get; set; }
//        public int id_skills_105 { get; set; }
//        public int id_skills_106 { get; set; }
//        public int id_skills_107 { get; set; }
//        public int id_skills_108 { get; set; }
//        public int id_skills_109 { get; set; }
//        public int id_skills_110 { get; set; }
//        public int id_skills_111 { get; set; }
//        public int id_skills_112 { get; set; }
//        public int id_skills_113 { get; set; }
//        public int id_skills_114 { get; set; }
//        public int id_skills_115 { get; set; }
//        public int id_skills_116 { get; set; }
//        public int id_skills_117 { get; set; }
//        public int id_skills_118 { get; set; }
//        public int id_skills_119 { get; set; }
//        public int id_skills_120 { get; set; }
//        public int id_skills_121 { get; set; }
//        public int id_skills_122 { get; set; }
//        public int id_skills_123 { get; set; }
//        public int id_skills_124 { get; set; }
//        public int id_skills_125 { get; set; }
//        public int id_skills_126 { get; set; }
//        public int id_skills_127 { get; set; }
//        public int id_skills_128 { get; set; }
//        public int id_dialog { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_PETFORGETSKILL_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_object_need { get; set; }
//        public int price { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SKILLMATTER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level_required { get; set; }
//        public int id_skill { get; set; }
//        public int level_skill { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class REFINE_TICKET_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] desc;

//        public string Desc
//        {
//            get => Structure.Unicode.GetString(desc);
//            set { desc = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float ext_reserved_prob { get; set; }
//        public float ext_succeed_prob { get; set; }
//        public int fail_reserve_level { get; set; }
//        public float fail_ext_succeed_prob_1 { get; set; }
//        public float fail_ext_succeed_prob_2 { get; set; }
//        public float fail_ext_succeed_prob_3 { get; set; }
//        public float fail_ext_succeed_prob_4 { get; set; }
//        public float fail_ext_succeed_prob_5 { get; set; }
//        public float fail_ext_succeed_prob_6 { get; set; }
//        public float fail_ext_succeed_prob_7 { get; set; }
//        public float fail_ext_succeed_prob_8 { get; set; }
//        public float fail_ext_succeed_prob_9 { get; set; }
//        public float fail_ext_succeed_prob_10 { get; set; }
//        public float fail_ext_succeed_prob_11 { get; set; }
//        public float fail_ext_succeed_prob_12 { get; set; }
//        public int binding_only { get; set; }
//        public int require_level_max { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DESTROYING_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_EQUIPBIND_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_object_need_1 { get; set; }
//        public int id_object_need_2 { get; set; }
//        public int id_object_need_3 { get; set; }
//        public int id_object_need_4 { get; set; }
//        public int price { get; set; }
//        public int bind_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_EQUIPDESTROY_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_object_need { get; set; }
//        public int price { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_EQUIPUNDESTROY_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_object_need { get; set; }
//        public int price { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class BIBLE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_addons_1 { get; set; }
//        public int id_addons_2 { get; set; }
//        public int id_addons_3 { get; set; }
//        public int id_addons_4 { get; set; }
//        public int id_addons_5 { get; set; }
//        public int id_addons_6 { get; set; }
//        public int id_addons_7 { get; set; }
//        public int id_addons_8 { get; set; }
//        public int id_addons_9 { get; set; }
//        public int id_addons_10 { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int id_drop_after_damaged { get; set; }
//        public int num_drop_after_damaged { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SPEAKER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_icon_set { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class AUTOHP_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int total_hp { get; set; }
//        public float trigger_amount { get; set; }
//        public int cool_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class AUTOMP_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int total_mp { get; set; }
//        public float trigger_amount { get; set; }
//        public int cool_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DOUBLE_EXP_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int double_exp_time { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TRANSMITSCROLL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DYE_TICKET_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float h_min { get; set; }
//        public float h_max { get; set; }
//        public float s_min { get; set; }
//        public float s_max { get; set; }
//        public float v_min { get; set; }
//        public float v_max { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GOBLIN_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model1;

//        public string File_model1
//        {
//            get => Structure.Gbk.GetString(file_model1);
//            set { file_model1 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model2;

//        public string File_model2
//        {
//            get => Structure.Gbk.GetString(file_model2);
//            set { file_model2 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model3;

//        public string File_model3
//        {
//            get => Structure.Gbk.GetString(file_model3);
//            set { file_model3 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model4;

//        public string File_model4
//        {
//            get => Structure.Gbk.GetString(file_model4);
//            set { file_model4 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon1;

//        public string File_icon1
//        {
//            get => Structure.Gbk.GetString(file_icon1);
//            set { file_icon1 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon2;

//        public string File_icon2
//        {
//            get => Structure.Gbk.GetString(file_icon2);
//            set { file_icon2 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon3;

//        public string File_icon3
//        {
//            get => Structure.Gbk.GetString(file_icon3);
//            set { file_icon3 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon4;

//        public string File_icon4
//        {
//            get => Structure.Gbk.GetString(file_icon4);
//            set { file_icon4 = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public float exp_factor { get; set; }
//        public int init_strength { get; set; }
//        public int init_agility { get; set; }
//        public int init_energy { get; set; }
//        public int init_tili { get; set; }
//        public int max_refine_lvl { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int default_skill1 { get; set; }
//        public int default_skill2 { get; set; }
//        public int default_skill3 { get; set; }
//        public int rand_prop_1_rand_num { get; set; }
//        public float rand_prop_1_rand_rate { get; set; }
//        public int rand_prop_2_rand_num { get; set; }
//        public float rand_prop_2_rand_rate { get; set; }
//        public int rand_prop_3_rand_num { get; set; }
//        public float rand_prop_3_rand_rate { get; set; }
//        public int rand_prop_4_rand_num { get; set; }
//        public float rand_prop_4_rand_rate { get; set; }
//        public int rand_prop_5_rand_num { get; set; }
//        public float rand_prop_5_rand_rate { get; set; }
//        public int rand_prop_6_rand_num { get; set; }
//        public float rand_prop_6_rand_rate { get; set; }
//        public int rand_prop_7_rand_num { get; set; }
//        public float rand_prop_7_rand_rate { get; set; }
//        public int rand_prop_8_rand_num { get; set; }
//        public float rand_prop_8_rand_rate { get; set; }
//        public int rand_prop_9_rand_num { get; set; }
//        public float rand_prop_9_rand_rate { get; set; }
//        public int rand_prop_10_rand_num { get; set; }
//        public float rand_prop_10_rand_rate { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GOBLIN_EQUIP_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GOBLIN_EQUIP_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_model;

//        public string File_model
//        {
//            get => Structure.Gbk.GetString(file_model);
//            set { file_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int equip_type { get; set; }
//        public int req_goblin_level { get; set; }
//        public int strength { get; set; }
//        public int agility { get; set; }
//        public int energy { get; set; }
//        public int tili { get; set; }
//        public int magic_1 { get; set; }
//        public int magic_2 { get; set; }
//        public int magic_3 { get; set; }
//        public int magic_4 { get; set; }
//        public int magic_5 { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GOBLIN_EXPPILL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int exp { get; set; }
//        public int level { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SELL_CERTIFICATE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] show_model;

//        public string Show_model
//        {
//            get => Structure.Gbk.GetString(show_model);
//            set { show_model = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int num_sell_item { get; set; }
//        public int num_buy_item { get; set; }
//        public int max_name_length { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class TARGET_ITEM_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int num_use_pertime { get; set; }
//        public int num_area { get; set; }
//        public int area_id_1 { get; set; }
//        public int area_id_2 { get; set; }
//        public int area_id_3 { get; set; }
//        public int area_id_4 { get; set; }
//        public int area_id_5 { get; set; }
//        public int area_id_6 { get; set; }
//        public int area_id_7 { get; set; }
//        public int area_id_8 { get; set; }
//        public int area_id_9 { get; set; }
//        public int area_id_10 { get; set; }
//        public int id_skill { get; set; }
//        public int skill_level { get; set; }
//        public int use_in_combat { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class LOOK_INFO_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class UPGRADE_PRODUCTION_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int num_refine_1 { get; set; }
//        public int num_refine_2 { get; set; }
//        public int num_refine_3 { get; set; }
//        public int num_refine_4 { get; set; }
//        public int num_refine_5 { get; set; }
//        public int num_refine_6 { get; set; }
//        public int num_refine_7 { get; set; }
//        public int num_refine_8 { get; set; }
//        public int num_refine_9 { get; set; }
//        public int num_refine_10 { get; set; }
//        public int num_refine_11 { get; set; }
//        public int num_refine_12 { get; set; }
//        public int num_weapon_1_1 { get; set; }
//        public int num_weapon_1_2 { get; set; }
//        public int num_weapon_1_3 { get; set; }
//        public int num_weapon_1_4 { get; set; }
//        public int num_weapon_1_5 { get; set; }
//        public int num_weapon_1_6 { get; set; }
//        public int num_weapon_1_7 { get; set; }
//        public int num_weapon_1_8 { get; set; }
//        public int num_weapon_1_9 { get; set; }
//        public int num_weapon_1_10 { get; set; }
//        public int num_weapon_1_11 { get; set; }
//        public int num_weapon_1_12 { get; set; }
//        public int num_weapon_1_13 { get; set; }
//        public int num_weapon_1_14 { get; set; }
//        public int num_weapon_1_15 { get; set; }
//        public int num_weapon_1_16 { get; set; }
//        public int num_weapon_1_17 { get; set; }
//        public int num_weapon_1_18 { get; set; }
//        public int num_weapon_1_19 { get; set; }
//        public int num_weapon_1_20 { get; set; }
//        public int num_weapon_2_1 { get; set; }
//        public int num_weapon_2_2 { get; set; }
//        public int num_weapon_2_3 { get; set; }
//        public int num_weapon_2_4 { get; set; }
//        public int num_weapon_2_5 { get; set; }
//        public int num_weapon_2_6 { get; set; }
//        public int num_weapon_2_7 { get; set; }
//        public int num_weapon_2_8 { get; set; }
//        public int num_weapon_2_9 { get; set; }
//        public int num_weapon_2_10 { get; set; }
//        public int num_weapon_2_11 { get; set; }
//        public int num_weapon_2_12 { get; set; }
//        public int num_weapon_2_13 { get; set; }
//        public int num_weapon_2_14 { get; set; }
//        public int num_weapon_2_15 { get; set; }
//        public int num_weapon_2_16 { get; set; }
//        public int num_weapon_2_17 { get; set; }
//        public int num_weapon_2_18 { get; set; }
//        public int num_weapon_2_19 { get; set; }
//        public int num_weapon_2_20 { get; set; }
//        public int num_armor_1_1 { get; set; }
//        public int num_armor_1_2 { get; set; }
//        public int num_armor_1_3 { get; set; }
//        public int num_armor_1_4 { get; set; }
//        public int num_armor_1_5 { get; set; }
//        public int num_armor_1_6 { get; set; }
//        public int num_armor_1_7 { get; set; }
//        public int num_armor_1_8 { get; set; }
//        public int num_armor_1_9 { get; set; }
//        public int num_armor_1_10 { get; set; }
//        public int num_armor_1_11 { get; set; }
//        public int num_armor_1_12 { get; set; }
//        public int num_armor_1_13 { get; set; }
//        public int num_armor_1_14 { get; set; }
//        public int num_armor_1_15 { get; set; }
//        public int num_armor_1_16 { get; set; }
//        public int num_armor_1_17 { get; set; }
//        public int num_armor_1_18 { get; set; }
//        public int num_armor_1_19 { get; set; }
//        public int num_armor_1_20 { get; set; }
//        public int num_armor_2_1 { get; set; }
//        public int num_armor_2_2 { get; set; }
//        public int num_armor_2_3 { get; set; }
//        public int num_armor_2_4 { get; set; }
//        public int num_armor_2_5 { get; set; }
//        public int num_armor_2_6 { get; set; }
//        public int num_armor_2_7 { get; set; }
//        public int num_armor_2_8 { get; set; }
//        public int num_armor_2_9 { get; set; }
//        public int num_armor_2_10 { get; set; }
//        public int num_armor_2_11 { get; set; }
//        public int num_armor_2_12 { get; set; }
//        public int num_armor_2_13 { get; set; }
//        public int num_armor_2_14 { get; set; }
//        public int num_armor_2_15 { get; set; }
//        public int num_armor_2_16 { get; set; }
//        public int num_armor_2_17 { get; set; }
//        public int num_armor_2_18 { get; set; }
//        public int num_armor_2_19 { get; set; }
//        public int num_armor_2_20 { get; set; }
//        public int num_armor_3_1 { get; set; }
//        public int num_armor_3_2 { get; set; }
//        public int num_armor_3_3 { get; set; }
//        public int num_armor_3_4 { get; set; }
//        public int num_armor_3_5 { get; set; }
//        public int num_armor_3_6 { get; set; }
//        public int num_armor_3_7 { get; set; }
//        public int num_armor_3_8 { get; set; }
//        public int num_armor_3_9 { get; set; }
//        public int num_armor_3_10 { get; set; }
//        public int num_armor_3_11 { get; set; }
//        public int num_armor_3_12 { get; set; }
//        public int num_armor_3_13 { get; set; }
//        public int num_armor_3_14 { get; set; }
//        public int num_armor_3_15 { get; set; }
//        public int num_armor_3_16 { get; set; }
//        public int num_armor_3_17 { get; set; }
//        public int num_armor_3_18 { get; set; }
//        public int num_armor_3_19 { get; set; }
//        public int num_armor_3_20 { get; set; }
//        public int num_armor_4_1 { get; set; }
//        public int num_armor_4_2 { get; set; }
//        public int num_armor_4_3 { get; set; }
//        public int num_armor_4_4 { get; set; }
//        public int num_armor_4_5 { get; set; }
//        public int num_armor_4_6 { get; set; }
//        public int num_armor_4_7 { get; set; }
//        public int num_armor_4_8 { get; set; }
//        public int num_armor_4_9 { get; set; }
//        public int num_armor_4_10 { get; set; }
//        public int num_armor_4_11 { get; set; }
//        public int num_armor_4_12 { get; set; }
//        public int num_armor_4_13 { get; set; }
//        public int num_armor_4_14 { get; set; }
//        public int num_armor_4_15 { get; set; }
//        public int num_armor_4_16 { get; set; }
//        public int num_armor_4_17 { get; set; }
//        public int num_armor_4_18 { get; set; }
//        public int num_armor_4_19 { get; set; }
//        public int num_armor_4_20 { get; set; }
//        public int num_stone_1 { get; set; }
//        public int num_stone_2 { get; set; }
//        public int num_stone_3 { get; set; }
//        public int num_stone_4 { get; set; }
//        public int num_stone_5 { get; set; }
//        public int num_stone_6 { get; set; }
//        public int num_stone_7 { get; set; }
//        public int num_stone_8 { get; set; }
//        public int num_stone_9 { get; set; }
//        public int num_stone_10 { get; set; }
//        public int num_stone_11 { get; set; }
//        public int num_stone_12 { get; set; }
//        public int num_stone_13 { get; set; }
//        public int num_stone_14 { get; set; }
//        public int num_stone_15 { get; set; }
//        public int num_stone_16 { get; set; }
//        public int num_stone_17 { get; set; }
//        public int num_stone_18 { get; set; }
//        public int num_stone_19 { get; set; }
//        public int num_stone_20 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ACC_STORAGE_BLACKLIST_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int blacklist_1 { get; set; }
//        public int blacklist_2 { get; set; }
//        public int blacklist_3 { get; set; }
//        public int blacklist_4 { get; set; }
//        public int blacklist_5 { get; set; }
//        public int blacklist_6 { get; set; }
//        public int blacklist_7 { get; set; }
//        public int blacklist_8 { get; set; }
//        public int blacklist_9 { get; set; }
//        public int blacklist_10 { get; set; }
//        public int blacklist_11 { get; set; }
//        public int blacklist_12 { get; set; }
//        public int blacklist_13 { get; set; }
//        public int blacklist_14 { get; set; }
//        public int blacklist_15 { get; set; }
//        public int blacklist_16 { get; set; }
//        public int blacklist_17 { get; set; }
//        public int blacklist_18 { get; set; }
//        public int blacklist_19 { get; set; }
//        public int blacklist_20 { get; set; }
//        public int blacklist_21 { get; set; }
//        public int blacklist_22 { get; set; }
//        public int blacklist_23 { get; set; }
//        public int blacklist_24 { get; set; }
//        public int blacklist_25 { get; set; }
//        public int blacklist_26 { get; set; }
//        public int blacklist_27 { get; set; }
//        public int blacklist_28 { get; set; }
//        public int blacklist_29 { get; set; }
//        public int blacklist_30 { get; set; }
//        public int blacklist_31 { get; set; }
//        public int blacklist_32 { get; set; }
//        public int blacklist_33 { get; set; }
//        public int blacklist_34 { get; set; }
//        public int blacklist_35 { get; set; }
//        public int blacklist_36 { get; set; }
//        public int blacklist_37 { get; set; }
//        public int blacklist_38 { get; set; }
//        public int blacklist_39 { get; set; }
//        public int blacklist_40 { get; set; }
//        public int blacklist_41 { get; set; }
//        public int blacklist_42 { get; set; }
//        public int blacklist_43 { get; set; }
//        public int blacklist_44 { get; set; }
//        public int blacklist_45 { get; set; }
//        public int blacklist_46 { get; set; }
//        public int blacklist_47 { get; set; }
//        public int blacklist_48 { get; set; }
//        public int blacklist_49 { get; set; }
//        public int blacklist_50 { get; set; }
//        public int blacklist_51 { get; set; }
//        public int blacklist_52 { get; set; }
//        public int blacklist_53 { get; set; }
//        public int blacklist_54 { get; set; }
//        public int blacklist_55 { get; set; }
//        public int blacklist_56 { get; set; }
//        public int blacklist_57 { get; set; }
//        public int blacklist_58 { get; set; }
//        public int blacklist_59 { get; set; }
//        public int blacklist_60 { get; set; }
//        public int blacklist_61 { get; set; }
//        public int blacklist_62 { get; set; }
//        public int blacklist_63 { get; set; }
//        public int blacklist_64 { get; set; }
//        public int blacklist_65 { get; set; }
//        public int blacklist_66 { get; set; }
//        public int blacklist_67 { get; set; }
//        public int blacklist_68 { get; set; }
//        public int blacklist_69 { get; set; }
//        public int blacklist_70 { get; set; }
//        public int blacklist_71 { get; set; }
//        public int blacklist_72 { get; set; }
//        public int blacklist_73 { get; set; }
//        public int blacklist_74 { get; set; }
//        public int blacklist_75 { get; set; }
//        public int blacklist_76 { get; set; }
//        public int blacklist_77 { get; set; }
//        public int blacklist_78 { get; set; }
//        public int blacklist_79 { get; set; }
//        public int blacklist_80 { get; set; }
//        public int blacklist_81 { get; set; }
//        public int blacklist_82 { get; set; }
//        public int blacklist_83 { get; set; }
//        public int blacklist_84 { get; set; }
//        public int blacklist_85 { get; set; }
//        public int blacklist_86 { get; set; }
//        public int blacklist_87 { get; set; }
//        public int blacklist_88 { get; set; }
//        public int blacklist_89 { get; set; }
//        public int blacklist_90 { get; set; }
//        public int blacklist_91 { get; set; }
//        public int blacklist_92 { get; set; }
//        public int blacklist_93 { get; set; }
//        public int blacklist_94 { get; set; }
//        public int blacklist_95 { get; set; }
//        public int blacklist_96 { get; set; }
//        public int blacklist_97 { get; set; }
//        public int blacklist_98 { get; set; }
//        public int blacklist_99 { get; set; }
//        public int blacklist_100 { get; set; }
//        public int blacklist_101 { get; set; }
//        public int blacklist_102 { get; set; }
//        public int blacklist_103 { get; set; }
//        public int blacklist_104 { get; set; }
//        public int blacklist_105 { get; set; }
//        public int blacklist_106 { get; set; }
//        public int blacklist_107 { get; set; }
//        public int blacklist_108 { get; set; }
//        public int blacklist_109 { get; set; }
//        public int blacklist_110 { get; set; }
//        public int blacklist_111 { get; set; }
//        public int blacklist_112 { get; set; }
//        public int blacklist_113 { get; set; }
//        public int blacklist_114 { get; set; }
//        public int blacklist_115 { get; set; }
//        public int blacklist_116 { get; set; }
//        public int blacklist_117 { get; set; }
//        public int blacklist_118 { get; set; }
//        public int blacklist_119 { get; set; }
//        public int blacklist_120 { get; set; }
//        public int blacklist_121 { get; set; }
//        public int blacklist_122 { get; set; }
//        public int blacklist_123 { get; set; }
//        public int blacklist_124 { get; set; }
//        public int blacklist_125 { get; set; }
//        public int blacklist_126 { get; set; }
//        public int blacklist_127 { get; set; }
//        public int blacklist_128 { get; set; }
//        public int blacklist_129 { get; set; }
//        public int blacklist_130 { get; set; }
//        public int blacklist_131 { get; set; }
//        public int blacklist_132 { get; set; }
//        public int blacklist_133 { get; set; }
//        public int blacklist_134 { get; set; }
//        public int blacklist_135 { get; set; }
//        public int blacklist_136 { get; set; }
//        public int blacklist_137 { get; set; }
//        public int blacklist_138 { get; set; }
//        public int blacklist_139 { get; set; }
//        public int blacklist_140 { get; set; }
//        public int blacklist_141 { get; set; }
//        public int blacklist_142 { get; set; }
//        public int blacklist_143 { get; set; }
//        public int blacklist_144 { get; set; }
//        public int blacklist_145 { get; set; }
//        public int blacklist_146 { get; set; }
//        public int blacklist_147 { get; set; }
//        public int blacklist_148 { get; set; }
//        public int blacklist_149 { get; set; }
//        public int blacklist_150 { get; set; }
//        public int blacklist_151 { get; set; }
//        public int blacklist_152 { get; set; }
//        public int blacklist_153 { get; set; }
//        public int blacklist_154 { get; set; }
//        public int blacklist_155 { get; set; }
//        public int blacklist_156 { get; set; }
//        public int blacklist_157 { get; set; }
//        public int blacklist_158 { get; set; }
//        public int blacklist_159 { get; set; }
//        public int blacklist_160 { get; set; }
//        public int blacklist_161 { get; set; }
//        public int blacklist_162 { get; set; }
//        public int blacklist_163 { get; set; }
//        public int blacklist_164 { get; set; }
//        public int blacklist_165 { get; set; }
//        public int blacklist_166 { get; set; }
//        public int blacklist_167 { get; set; }
//        public int blacklist_168 { get; set; }
//        public int blacklist_169 { get; set; }
//        public int blacklist_170 { get; set; }
//        public int blacklist_171 { get; set; }
//        public int blacklist_172 { get; set; }
//        public int blacklist_173 { get; set; }
//        public int blacklist_174 { get; set; }
//        public int blacklist_175 { get; set; }
//        public int blacklist_176 { get; set; }
//        public int blacklist_177 { get; set; }
//        public int blacklist_178 { get; set; }
//        public int blacklist_179 { get; set; }
//        public int blacklist_180 { get; set; }
//        public int blacklist_181 { get; set; }
//        public int blacklist_182 { get; set; }
//        public int blacklist_183 { get; set; }
//        public int blacklist_184 { get; set; }
//        public int blacklist_185 { get; set; }
//        public int blacklist_186 { get; set; }
//        public int blacklist_187 { get; set; }
//        public int blacklist_188 { get; set; }
//        public int blacklist_189 { get; set; }
//        public int blacklist_190 { get; set; }
//        public int blacklist_191 { get; set; }
//        public int blacklist_192 { get; set; }
//        public int blacklist_193 { get; set; }
//        public int blacklist_194 { get; set; }
//        public int blacklist_195 { get; set; }
//        public int blacklist_196 { get; set; }
//        public int blacklist_197 { get; set; }
//        public int blacklist_198 { get; set; }
//        public int blacklist_199 { get; set; }
//        public int blacklist_200 { get; set; }
//        public int blacklist_201 { get; set; }
//        public int blacklist_202 { get; set; }
//        public int blacklist_203 { get; set; }
//        public int blacklist_204 { get; set; }
//        public int blacklist_205 { get; set; }
//        public int blacklist_206 { get; set; }
//        public int blacklist_207 { get; set; }
//        public int blacklist_208 { get; set; }
//        public int blacklist_209 { get; set; }
//        public int blacklist_210 { get; set; }
//        public int blacklist_211 { get; set; }
//        public int blacklist_212 { get; set; }
//        public int blacklist_213 { get; set; }
//        public int blacklist_214 { get; set; }
//        public int blacklist_215 { get; set; }
//        public int blacklist_216 { get; set; }
//        public int blacklist_217 { get; set; }
//        public int blacklist_218 { get; set; }
//        public int blacklist_219 { get; set; }
//        public int blacklist_220 { get; set; }
//        public int blacklist_221 { get; set; }
//        public int blacklist_222 { get; set; }
//        public int blacklist_223 { get; set; }
//        public int blacklist_224 { get; set; }
//        public int blacklist_225 { get; set; }
//        public int blacklist_226 { get; set; }
//        public int blacklist_227 { get; set; }
//        public int blacklist_228 { get; set; }
//        public int blacklist_229 { get; set; }
//        public int blacklist_230 { get; set; }
//        public int blacklist_231 { get; set; }
//        public int blacklist_232 { get; set; }
//        public int blacklist_233 { get; set; }
//        public int blacklist_234 { get; set; }
//        public int blacklist_235 { get; set; }
//        public int blacklist_236 { get; set; }
//        public int blacklist_237 { get; set; }
//        public int blacklist_238 { get; set; }
//        public int blacklist_239 { get; set; }
//        public int blacklist_240 { get; set; }
//        public int blacklist_241 { get; set; }
//        public int blacklist_242 { get; set; }
//        public int blacklist_243 { get; set; }
//        public int blacklist_244 { get; set; }
//        public int blacklist_245 { get; set; }
//        public int blacklist_246 { get; set; }
//        public int blacklist_247 { get; set; }
//        public int blacklist_248 { get; set; }
//        public int blacklist_249 { get; set; }
//        public int blacklist_250 { get; set; }
//        public int blacklist_251 { get; set; }
//        public int blacklist_252 { get; set; }
//        public int blacklist_253 { get; set; }
//        public int blacklist_254 { get; set; }
//        public int blacklist_255 { get; set; }
//        public int blacklist_256 { get; set; }
//        public int blacklist_257 { get; set; }
//        public int blacklist_258 { get; set; }
//        public int blacklist_259 { get; set; }
//        public int blacklist_260 { get; set; }
//        public int blacklist_261 { get; set; }
//        public int blacklist_262 { get; set; }
//        public int blacklist_263 { get; set; }
//        public int blacklist_264 { get; set; }
//        public int blacklist_265 { get; set; }
//        public int blacklist_266 { get; set; }
//        public int blacklist_267 { get; set; }
//        public int blacklist_268 { get; set; }
//        public int blacklist_269 { get; set; }
//        public int blacklist_270 { get; set; }
//        public int blacklist_271 { get; set; }
//        public int blacklist_272 { get; set; }
//        public int blacklist_273 { get; set; }
//        public int blacklist_274 { get; set; }
//        public int blacklist_275 { get; set; }
//        public int blacklist_276 { get; set; }
//        public int blacklist_277 { get; set; }
//        public int blacklist_278 { get; set; }
//        public int blacklist_279 { get; set; }
//        public int blacklist_280 { get; set; }
//        public int blacklist_281 { get; set; }
//        public int blacklist_282 { get; set; }
//        public int blacklist_283 { get; set; }
//        public int blacklist_284 { get; set; }
//        public int blacklist_285 { get; set; }
//        public int blacklist_286 { get; set; }
//        public int blacklist_287 { get; set; }
//        public int blacklist_288 { get; set; }
//        public int blacklist_289 { get; set; }
//        public int blacklist_290 { get; set; }
//        public int blacklist_291 { get; set; }
//        public int blacklist_292 { get; set; }
//        public int blacklist_293 { get; set; }
//        public int blacklist_294 { get; set; }
//        public int blacklist_295 { get; set; }
//        public int blacklist_296 { get; set; }
//        public int blacklist_297 { get; set; }
//        public int blacklist_298 { get; set; }
//        public int blacklist_299 { get; set; }
//        public int blacklist_300 { get; set; }
//        public int blacklist_301 { get; set; }
//        public int blacklist_302 { get; set; }
//        public int blacklist_303 { get; set; }
//        public int blacklist_304 { get; set; }
//        public int blacklist_305 { get; set; }
//        public int blacklist_306 { get; set; }
//        public int blacklist_307 { get; set; }
//        public int blacklist_308 { get; set; }
//        public int blacklist_309 { get; set; }
//        public int blacklist_310 { get; set; }
//        public int blacklist_311 { get; set; }
//        public int blacklist_312 { get; set; }
//        public int blacklist_313 { get; set; }
//        public int blacklist_314 { get; set; }
//        public int blacklist_315 { get; set; }
//        public int blacklist_316 { get; set; }
//        public int blacklist_317 { get; set; }
//        public int blacklist_318 { get; set; }
//        public int blacklist_319 { get; set; }
//        public int blacklist_320 { get; set; }
//        public int blacklist_321 { get; set; }
//        public int blacklist_322 { get; set; }
//        public int blacklist_323 { get; set; }
//        public int blacklist_324 { get; set; }
//        public int blacklist_325 { get; set; }
//        public int blacklist_326 { get; set; }
//        public int blacklist_327 { get; set; }
//        public int blacklist_328 { get; set; }
//        public int blacklist_329 { get; set; }
//        public int blacklist_330 { get; set; }
//        public int blacklist_331 { get; set; }
//        public int blacklist_332 { get; set; }
//        public int blacklist_333 { get; set; }
//        public int blacklist_334 { get; set; }
//        public int blacklist_335 { get; set; }
//        public int blacklist_336 { get; set; }
//        public int blacklist_337 { get; set; }
//        public int blacklist_338 { get; set; }
//        public int blacklist_339 { get; set; }
//        public int blacklist_340 { get; set; }
//        public int blacklist_341 { get; set; }
//        public int blacklist_342 { get; set; }
//        public int blacklist_343 { get; set; }
//        public int blacklist_344 { get; set; }
//        public int blacklist_345 { get; set; }
//        public int blacklist_346 { get; set; }
//        public int blacklist_347 { get; set; }
//        public int blacklist_348 { get; set; }
//        public int blacklist_349 { get; set; }
//        public int blacklist_350 { get; set; }
//        public int blacklist_351 { get; set; }
//        public int blacklist_352 { get; set; }
//        public int blacklist_353 { get; set; }
//        public int blacklist_354 { get; set; }
//        public int blacklist_355 { get; set; }
//        public int blacklist_356 { get; set; }
//        public int blacklist_357 { get; set; }
//        public int blacklist_358 { get; set; }
//        public int blacklist_359 { get; set; }
//        public int blacklist_360 { get; set; }
//        public int blacklist_361 { get; set; }
//        public int blacklist_362 { get; set; }
//        public int blacklist_363 { get; set; }
//        public int blacklist_364 { get; set; }
//        public int blacklist_365 { get; set; }
//        public int blacklist_366 { get; set; }
//        public int blacklist_367 { get; set; }
//        public int blacklist_368 { get; set; }
//        public int blacklist_369 { get; set; }
//        public int blacklist_370 { get; set; }
//        public int blacklist_371 { get; set; }
//        public int blacklist_372 { get; set; }
//        public int blacklist_373 { get; set; }
//        public int blacklist_374 { get; set; }
//        public int blacklist_375 { get; set; }
//        public int blacklist_376 { get; set; }
//        public int blacklist_377 { get; set; }
//        public int blacklist_378 { get; set; }
//        public int blacklist_379 { get; set; }
//        public int blacklist_380 { get; set; }
//        public int blacklist_381 { get; set; }
//        public int blacklist_382 { get; set; }
//        public int blacklist_383 { get; set; }
//        public int blacklist_384 { get; set; }
//        public int blacklist_385 { get; set; }
//        public int blacklist_386 { get; set; }
//        public int blacklist_387 { get; set; }
//        public int blacklist_388 { get; set; }
//        public int blacklist_389 { get; set; }
//        public int blacklist_390 { get; set; }
//        public int blacklist_391 { get; set; }
//        public int blacklist_392 { get; set; }
//        public int blacklist_393 { get; set; }
//        public int blacklist_394 { get; set; }
//        public int blacklist_395 { get; set; }
//        public int blacklist_396 { get; set; }
//        public int blacklist_397 { get; set; }
//        public int blacklist_398 { get; set; }
//        public int blacklist_399 { get; set; }
//        public int blacklist_400 { get; set; }
//        public int blacklist_401 { get; set; }
//        public int blacklist_402 { get; set; }
//        public int blacklist_403 { get; set; }
//        public int blacklist_404 { get; set; }
//        public int blacklist_405 { get; set; }
//        public int blacklist_406 { get; set; }
//        public int blacklist_407 { get; set; }
//        public int blacklist_408 { get; set; }
//        public int blacklist_409 { get; set; }
//        public int blacklist_410 { get; set; }
//        public int blacklist_411 { get; set; }
//        public int blacklist_412 { get; set; }
//        public int blacklist_413 { get; set; }
//        public int blacklist_414 { get; set; }
//        public int blacklist_415 { get; set; }
//        public int blacklist_416 { get; set; }
//        public int blacklist_417 { get; set; }
//        public int blacklist_418 { get; set; }
//        public int blacklist_419 { get; set; }
//        public int blacklist_420 { get; set; }
//        public int blacklist_421 { get; set; }
//        public int blacklist_422 { get; set; }
//        public int blacklist_423 { get; set; }
//        public int blacklist_424 { get; set; }
//        public int blacklist_425 { get; set; }
//        public int blacklist_426 { get; set; }
//        public int blacklist_427 { get; set; }
//        public int blacklist_428 { get; set; }
//        public int blacklist_429 { get; set; }
//        public int blacklist_430 { get; set; }
//        public int blacklist_431 { get; set; }
//        public int blacklist_432 { get; set; }
//        public int blacklist_433 { get; set; }
//        public int blacklist_434 { get; set; }
//        public int blacklist_435 { get; set; }
//        public int blacklist_436 { get; set; }
//        public int blacklist_437 { get; set; }
//        public int blacklist_438 { get; set; }
//        public int blacklist_439 { get; set; }
//        public int blacklist_440 { get; set; }
//        public int blacklist_441 { get; set; }
//        public int blacklist_442 { get; set; }
//        public int blacklist_443 { get; set; }
//        public int blacklist_444 { get; set; }
//        public int blacklist_445 { get; set; }
//        public int blacklist_446 { get; set; }
//        public int blacklist_447 { get; set; }
//        public int blacklist_448 { get; set; }
//        public int blacklist_449 { get; set; }
//        public int blacklist_450 { get; set; }
//        public int blacklist_451 { get; set; }
//        public int blacklist_452 { get; set; }
//        public int blacklist_453 { get; set; }
//        public int blacklist_454 { get; set; }
//        public int blacklist_455 { get; set; }
//        public int blacklist_456 { get; set; }
//        public int blacklist_457 { get; set; }
//        public int blacklist_458 { get; set; }
//        public int blacklist_459 { get; set; }
//        public int blacklist_460 { get; set; }
//        public int blacklist_461 { get; set; }
//        public int blacklist_462 { get; set; }
//        public int blacklist_463 { get; set; }
//        public int blacklist_464 { get; set; }
//        public int blacklist_465 { get; set; }
//        public int blacklist_466 { get; set; }
//        public int blacklist_467 { get; set; }
//        public int blacklist_468 { get; set; }
//        public int blacklist_469 { get; set; }
//        public int blacklist_470 { get; set; }
//        public int blacklist_471 { get; set; }
//        public int blacklist_472 { get; set; }
//        public int blacklist_473 { get; set; }
//        public int blacklist_474 { get; set; }
//        public int blacklist_475 { get; set; }
//        public int blacklist_476 { get; set; }
//        public int blacklist_477 { get; set; }
//        public int blacklist_478 { get; set; }
//        public int blacklist_479 { get; set; }
//        public int blacklist_480 { get; set; }
//        public int blacklist_481 { get; set; }
//        public int blacklist_482 { get; set; }
//        public int blacklist_483 { get; set; }
//        public int blacklist_484 { get; set; }
//        public int blacklist_485 { get; set; }
//        public int blacklist_486 { get; set; }
//        public int blacklist_487 { get; set; }
//        public int blacklist_488 { get; set; }
//        public int blacklist_489 { get; set; }
//        public int blacklist_490 { get; set; }
//        public int blacklist_491 { get; set; }
//        public int blacklist_492 { get; set; }
//        public int blacklist_493 { get; set; }
//        public int blacklist_494 { get; set; }
//        public int blacklist_495 { get; set; }
//        public int blacklist_496 { get; set; }
//        public int blacklist_497 { get; set; }
//        public int blacklist_498 { get; set; }
//        public int blacklist_499 { get; set; }
//        public int blacklist_500 { get; set; }
//        public int blacklist_501 { get; set; }
//        public int blacklist_502 { get; set; }
//        public int blacklist_503 { get; set; }
//        public int blacklist_504 { get; set; }
//        public int blacklist_505 { get; set; }
//        public int blacklist_506 { get; set; }
//        public int blacklist_507 { get; set; }
//        public int blacklist_508 { get; set; }
//        public int blacklist_509 { get; set; }
//        public int blacklist_510 { get; set; }
//        public int blacklist_511 { get; set; }
//        public int blacklist_512 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_HAIR_TEXTURE_MAP
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int hair_texture_map_1_model_id { get; set; }
//        public int hair_texture_map_1_texture_id { get; set; }
//        public int hair_texture_map_2_model_id { get; set; }
//        public int hair_texture_map_2_texture_id { get; set; }
//        public int hair_texture_map_3_model_id { get; set; }
//        public int hair_texture_map_3_texture_id { get; set; }
//        public int hair_texture_map_4_model_id { get; set; }
//        public int hair_texture_map_4_texture_id { get; set; }
//        public int hair_texture_map_5_model_id { get; set; }
//        public int hair_texture_map_5_texture_id { get; set; }
//        public int hair_texture_map_6_model_id { get; set; }
//        public int hair_texture_map_6_texture_id { get; set; }
//        public int hair_texture_map_7_model_id { get; set; }
//        public int hair_texture_map_7_texture_id { get; set; }
//        public int hair_texture_map_8_model_id { get; set; }
//        public int hair_texture_map_8_texture_id { get; set; }
//        public int hair_texture_map_9_model_id { get; set; }
//        public int hair_texture_map_9_texture_id { get; set; }
//        public int hair_texture_map_10_model_id { get; set; }
//        public int hair_texture_map_10_texture_id { get; set; }
//        public int hair_texture_map_11_model_id { get; set; }
//        public int hair_texture_map_11_texture_id { get; set; }
//        public int hair_texture_map_12_model_id { get; set; }
//        public int hair_texture_map_12_texture_id { get; set; }
//        public int hair_texture_map_13_model_id { get; set; }
//        public int hair_texture_map_13_texture_id { get; set; }
//        public int hair_texture_map_14_model_id { get; set; }
//        public int hair_texture_map_14_texture_id { get; set; }
//        public int hair_texture_map_15_model_id { get; set; }
//        public int hair_texture_map_15_texture_id { get; set; }
//        public int hair_texture_map_16_model_id { get; set; }
//        public int hair_texture_map_16_texture_id { get; set; }
//        public int hair_texture_map_17_model_id { get; set; }
//        public int hair_texture_map_17_texture_id { get; set; }
//        public int hair_texture_map_18_model_id { get; set; }
//        public int hair_texture_map_18_texture_id { get; set; }
//        public int hair_texture_map_19_model_id { get; set; }
//        public int hair_texture_map_19_texture_id { get; set; }
//        public int hair_texture_map_20_model_id { get; set; }
//        public int hair_texture_map_20_texture_id { get; set; }
//        public int hair_texture_map_21_model_id { get; set; }
//        public int hair_texture_map_21_texture_id { get; set; }
//        public int hair_texture_map_22_model_id { get; set; }
//        public int hair_texture_map_22_texture_id { get; set; }
//        public int hair_texture_map_23_model_id { get; set; }
//        public int hair_texture_map_23_texture_id { get; set; }
//        public int hair_texture_map_24_model_id { get; set; }
//        public int hair_texture_map_24_texture_id { get; set; }
//        public int hair_texture_map_25_model_id { get; set; }
//        public int hair_texture_map_25_texture_id { get; set; }
//        public int hair_texture_map_26_model_id { get; set; }
//        public int hair_texture_map_26_texture_id { get; set; }
//        public int hair_texture_map_27_model_id { get; set; }
//        public int hair_texture_map_27_texture_id { get; set; }
//        public int hair_texture_map_28_model_id { get; set; }
//        public int hair_texture_map_28_texture_id { get; set; }
//        public int hair_texture_map_29_model_id { get; set; }
//        public int hair_texture_map_29_texture_id { get; set; }
//        public int hair_texture_map_30_model_id { get; set; }
//        public int hair_texture_map_30_texture_id { get; set; }
//        public int hair_texture_map_31_model_id { get; set; }
//        public int hair_texture_map_31_texture_id { get; set; }
//        public int hair_texture_map_32_model_id { get; set; }
//        public int hair_texture_map_32_texture_id { get; set; }
//        public int hair_texture_map_33_model_id { get; set; }
//        public int hair_texture_map_33_texture_id { get; set; }
//        public int hair_texture_map_34_model_id { get; set; }
//        public int hair_texture_map_34_texture_id { get; set; }
//        public int hair_texture_map_35_model_id { get; set; }
//        public int hair_texture_map_35_texture_id { get; set; }
//        public int hair_texture_map_36_model_id { get; set; }
//        public int hair_texture_map_36_texture_id { get; set; }
//        public int hair_texture_map_37_model_id { get; set; }
//        public int hair_texture_map_37_texture_id { get; set; }
//        public int hair_texture_map_38_model_id { get; set; }
//        public int hair_texture_map_38_texture_id { get; set; }
//        public int hair_texture_map_39_model_id { get; set; }
//        public int hair_texture_map_39_texture_id { get; set; }
//        public int hair_texture_map_40_model_id { get; set; }
//        public int hair_texture_map_40_texture_id { get; set; }
//        public int hair_texture_map_41_model_id { get; set; }
//        public int hair_texture_map_41_texture_id { get; set; }
//        public int hair_texture_map_42_model_id { get; set; }
//        public int hair_texture_map_42_texture_id { get; set; }
//        public int hair_texture_map_43_model_id { get; set; }
//        public int hair_texture_map_43_texture_id { get; set; }
//        public int hair_texture_map_44_model_id { get; set; }
//        public int hair_texture_map_44_texture_id { get; set; }
//        public int hair_texture_map_45_model_id { get; set; }
//        public int hair_texture_map_45_texture_id { get; set; }
//        public int hair_texture_map_46_model_id { get; set; }
//        public int hair_texture_map_46_texture_id { get; set; }
//        public int hair_texture_map_47_model_id { get; set; }
//        public int hair_texture_map_47_texture_id { get; set; }
//        public int hair_texture_map_48_model_id { get; set; }
//        public int hair_texture_map_48_texture_id { get; set; }
//        public int hair_texture_map_49_model_id { get; set; }
//        public int hair_texture_map_49_texture_id { get; set; }
//        public int hair_texture_map_50_model_id { get; set; }
//        public int hair_texture_map_50_texture_id { get; set; }
//        public int hair_texture_map_51_model_id { get; set; }
//        public int hair_texture_map_51_texture_id { get; set; }
//        public int hair_texture_map_52_model_id { get; set; }
//        public int hair_texture_map_52_texture_id { get; set; }
//        public int hair_texture_map_53_model_id { get; set; }
//        public int hair_texture_map_53_texture_id { get; set; }
//        public int hair_texture_map_54_model_id { get; set; }
//        public int hair_texture_map_54_texture_id { get; set; }
//        public int hair_texture_map_55_model_id { get; set; }
//        public int hair_texture_map_55_texture_id { get; set; }
//        public int hair_texture_map_56_model_id { get; set; }
//        public int hair_texture_map_56_texture_id { get; set; }
//        public int hair_texture_map_57_model_id { get; set; }
//        public int hair_texture_map_57_texture_id { get; set; }
//        public int hair_texture_map_58_model_id { get; set; }
//        public int hair_texture_map_58_texture_id { get; set; }
//        public int hair_texture_map_59_model_id { get; set; }
//        public int hair_texture_map_59_texture_id { get; set; }
//        public int hair_texture_map_60_model_id { get; set; }
//        public int hair_texture_map_60_texture_id { get; set; }
//        public int hair_texture_map_61_model_id { get; set; }
//        public int hair_texture_map_61_texture_id { get; set; }
//        public int hair_texture_map_62_model_id { get; set; }
//        public int hair_texture_map_62_texture_id { get; set; }
//        public int hair_texture_map_63_model_id { get; set; }
//        public int hair_texture_map_63_texture_id { get; set; }
//        public int hair_texture_map_64_model_id { get; set; }
//        public int hair_texture_map_64_texture_id { get; set; }
//        public int hair_texture_map_65_model_id { get; set; }
//        public int hair_texture_map_65_texture_id { get; set; }
//        public int hair_texture_map_66_model_id { get; set; }
//        public int hair_texture_map_66_texture_id { get; set; }
//        public int hair_texture_map_67_model_id { get; set; }
//        public int hair_texture_map_67_texture_id { get; set; }
//        public int hair_texture_map_68_model_id { get; set; }
//        public int hair_texture_map_68_texture_id { get; set; }
//        public int hair_texture_map_69_model_id { get; set; }
//        public int hair_texture_map_69_texture_id { get; set; }
//        public int hair_texture_map_70_model_id { get; set; }
//        public int hair_texture_map_70_texture_id { get; set; }
//        public int hair_texture_map_71_model_id { get; set; }
//        public int hair_texture_map_71_texture_id { get; set; }
//        public int hair_texture_map_72_model_id { get; set; }
//        public int hair_texture_map_72_texture_id { get; set; }
//        public int hair_texture_map_73_model_id { get; set; }
//        public int hair_texture_map_73_texture_id { get; set; }
//        public int hair_texture_map_74_model_id { get; set; }
//        public int hair_texture_map_74_texture_id { get; set; }
//        public int hair_texture_map_75_model_id { get; set; }
//        public int hair_texture_map_75_texture_id { get; set; }
//        public int hair_texture_map_76_model_id { get; set; }
//        public int hair_texture_map_76_texture_id { get; set; }
//        public int hair_texture_map_77_model_id { get; set; }
//        public int hair_texture_map_77_texture_id { get; set; }
//        public int hair_texture_map_78_model_id { get; set; }
//        public int hair_texture_map_78_texture_id { get; set; }
//        public int hair_texture_map_79_model_id { get; set; }
//        public int hair_texture_map_79_texture_id { get; set; }
//        public int hair_texture_map_80_model_id { get; set; }
//        public int hair_texture_map_80_texture_id { get; set; }
//        public int hair_texture_map_81_model_id { get; set; }
//        public int hair_texture_map_81_texture_id { get; set; }
//        public int hair_texture_map_82_model_id { get; set; }
//        public int hair_texture_map_82_texture_id { get; set; }
//        public int hair_texture_map_83_model_id { get; set; }
//        public int hair_texture_map_83_texture_id { get; set; }
//        public int hair_texture_map_84_model_id { get; set; }
//        public int hair_texture_map_84_texture_id { get; set; }
//        public int hair_texture_map_85_model_id { get; set; }
//        public int hair_texture_map_85_texture_id { get; set; }
//        public int hair_texture_map_86_model_id { get; set; }
//        public int hair_texture_map_86_texture_id { get; set; }
//        public int hair_texture_map_87_model_id { get; set; }
//        public int hair_texture_map_87_texture_id { get; set; }
//        public int hair_texture_map_88_model_id { get; set; }
//        public int hair_texture_map_88_texture_id { get; set; }
//        public int hair_texture_map_89_model_id { get; set; }
//        public int hair_texture_map_89_texture_id { get; set; }
//        public int hair_texture_map_90_model_id { get; set; }
//        public int hair_texture_map_90_texture_id { get; set; }
//        public int hair_texture_map_91_model_id { get; set; }
//        public int hair_texture_map_91_texture_id { get; set; }
//        public int hair_texture_map_92_model_id { get; set; }
//        public int hair_texture_map_92_texture_id { get; set; }
//        public int hair_texture_map_93_model_id { get; set; }
//        public int hair_texture_map_93_texture_id { get; set; }
//        public int hair_texture_map_94_model_id { get; set; }
//        public int hair_texture_map_94_texture_id { get; set; }
//        public int hair_texture_map_95_model_id { get; set; }
//        public int hair_texture_map_95_texture_id { get; set; }
//        public int hair_texture_map_96_model_id { get; set; }
//        public int hair_texture_map_96_texture_id { get; set; }
//        public int hair_texture_map_97_model_id { get; set; }
//        public int hair_texture_map_97_texture_id { get; set; }
//        public int hair_texture_map_98_model_id { get; set; }
//        public int hair_texture_map_98_texture_id { get; set; }
//        public int hair_texture_map_99_model_id { get; set; }
//        public int hair_texture_map_99_texture_id { get; set; }
//        public int hair_texture_map_100_model_id { get; set; }
//        public int hair_texture_map_100_texture_id { get; set; }
//        public int hair_texture_map_101_model_id { get; set; }
//        public int hair_texture_map_101_texture_id { get; set; }
//        public int hair_texture_map_102_model_id { get; set; }
//        public int hair_texture_map_102_texture_id { get; set; }
//        public int hair_texture_map_103_model_id { get; set; }
//        public int hair_texture_map_103_texture_id { get; set; }
//        public int hair_texture_map_104_model_id { get; set; }
//        public int hair_texture_map_104_texture_id { get; set; }
//        public int hair_texture_map_105_model_id { get; set; }
//        public int hair_texture_map_105_texture_id { get; set; }
//        public int hair_texture_map_106_model_id { get; set; }
//        public int hair_texture_map_106_texture_id { get; set; }
//        public int hair_texture_map_107_model_id { get; set; }
//        public int hair_texture_map_107_texture_id { get; set; }
//        public int hair_texture_map_108_model_id { get; set; }
//        public int hair_texture_map_108_texture_id { get; set; }
//        public int hair_texture_map_109_model_id { get; set; }
//        public int hair_texture_map_109_texture_id { get; set; }
//        public int hair_texture_map_110_model_id { get; set; }
//        public int hair_texture_map_110_texture_id { get; set; }
//        public int hair_texture_map_111_model_id { get; set; }
//        public int hair_texture_map_111_texture_id { get; set; }
//        public int hair_texture_map_112_model_id { get; set; }
//        public int hair_texture_map_112_texture_id { get; set; }
//        public int hair_texture_map_113_model_id { get; set; }
//        public int hair_texture_map_113_texture_id { get; set; }
//        public int hair_texture_map_114_model_id { get; set; }
//        public int hair_texture_map_114_texture_id { get; set; }
//        public int hair_texture_map_115_model_id { get; set; }
//        public int hair_texture_map_115_texture_id { get; set; }
//        public int hair_texture_map_116_model_id { get; set; }
//        public int hair_texture_map_116_texture_id { get; set; }
//        public int hair_texture_map_117_model_id { get; set; }
//        public int hair_texture_map_117_texture_id { get; set; }
//        public int hair_texture_map_118_model_id { get; set; }
//        public int hair_texture_map_118_texture_id { get; set; }
//        public int hair_texture_map_119_model_id { get; set; }
//        public int hair_texture_map_119_texture_id { get; set; }
//        public int hair_texture_map_120_model_id { get; set; }
//        public int hair_texture_map_120_texture_id { get; set; }
//        public int hair_texture_map_121_model_id { get; set; }
//        public int hair_texture_map_121_texture_id { get; set; }
//        public int hair_texture_map_122_model_id { get; set; }
//        public int hair_texture_map_122_texture_id { get; set; }
//        public int hair_texture_map_123_model_id { get; set; }
//        public int hair_texture_map_123_texture_id { get; set; }
//        public int hair_texture_map_124_model_id { get; set; }
//        public int hair_texture_map_124_texture_id { get; set; }
//        public int hair_texture_map_125_model_id { get; set; }
//        public int hair_texture_map_125_texture_id { get; set; }
//        public int hair_texture_map_126_model_id { get; set; }
//        public int hair_texture_map_126_texture_id { get; set; }
//        public int hair_texture_map_127_model_id { get; set; }
//        public int hair_texture_map_127_texture_id { get; set; }
//        public int hair_texture_map_128_model_id { get; set; }
//        public int hair_texture_map_128_texture_id { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class MULTI_EXP_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int choice_1_multi_time { get; set; }
//        public float choice_1_rate { get; set; }
//        public int choice_1_item_count { get; set; }
//        public int choice_1_demulti_wait_time { get; set; }
//        public int choice_1_demulti_time { get; set; }
//        public int choice_2_multi_time { get; set; }
//        public float choice_2_rate { get; set; }
//        public int choice_2_item_count { get; set; }
//        public int choice_2_demulti_wait_time { get; set; }
//        public int choice_2_demulti_time { get; set; }
//        public int choice_3_multi_time { get; set; }
//        public float choice_3_rate { get; set; }
//        public int choice_3_item_count { get; set; }
//        public int choice_3_demulti_wait_time { get; set; }
//        public int choice_3_demulti_time { get; set; }
//        public int choice_4_multi_time { get; set; }
//        public float choice_4_rate { get; set; }
//        public int choice_4_item_count { get; set; }
//        public int choice_4_demulti_wait_time { get; set; }
//        public int choice_4_demulti_time { get; set; }
//        public int choice_5_multi_time { get; set; }
//        public float choice_5_rate { get; set; }
//        public int choice_5_item_count { get; set; }
//        public int choice_5_demulti_wait_time { get; set; }
//        public int choice_5_demulti_time { get; set; }
//        public int choice_6_multi_time { get; set; }
//        public float choice_6_rate { get; set; }
//        public int choice_6_item_count { get; set; }
//        public int choice_6_demulti_wait_time { get; set; }
//        public int choice_6_demulti_time { get; set; }
//        public int choice_7_multi_time { get; set; }
//        public float choice_7_rate { get; set; }
//        public int choice_7_item_count { get; set; }
//        public int choice_7_demulti_wait_time { get; set; }
//        public int choice_7_demulti_time { get; set; }
//        public int choice_8_multi_time { get; set; }
//        public float choice_8_rate { get; set; }
//        public int choice_8_item_count { get; set; }
//        public int choice_8_demulti_wait_time { get; set; }
//        public int choice_8_demulti_time { get; set; }
//        public int choice_9_multi_time { get; set; }
//        public float choice_9_rate { get; set; }
//        public int choice_9_item_count { get; set; }
//        public int choice_9_demulti_wait_time { get; set; }
//        public int choice_9_demulti_time { get; set; }
//        public int choice_10_multi_time { get; set; }
//        public float choice_10_rate { get; set; }
//        public int choice_10_item_count { get; set; }
//        public int choice_10_demulti_wait_time { get; set; }
//        public int choice_10_demulti_time { get; set; }
//        public int choice_11_multi_time { get; set; }
//        public float choice_11_rate { get; set; }
//        public int choice_11_item_count { get; set; }
//        public int choice_11_demulti_wait_time { get; set; }
//        public int choice_11_demulti_time { get; set; }
//        public int choice_12_multi_time { get; set; }
//        public float choice_12_rate { get; set; }
//        public int choice_12_item_count { get; set; }
//        public int choice_12_demulti_wait_time { get; set; }
//        public int choice_12_demulti_time { get; set; }
//        public int choice_13_multi_time { get; set; }
//        public float choice_13_rate { get; set; }
//        public int choice_13_item_count { get; set; }
//        public int choice_13_demulti_wait_time { get; set; }
//        public int choice_13_demulti_time { get; set; }
//        public int choice_14_multi_time { get; set; }
//        public float choice_14_rate { get; set; }
//        public int choice_14_item_count { get; set; }
//        public int choice_14_demulti_wait_time { get; set; }
//        public int choice_14_demulti_time { get; set; }
//        public int choice_15_multi_time { get; set; }
//        public float choice_15_rate { get; set; }
//        public int choice_15_item_count { get; set; }
//        public int choice_15_demulti_wait_time { get; set; }
//        public int choice_15_demulti_time { get; set; }
//        public int choice_16_multi_time { get; set; }
//        public float choice_16_rate { get; set; }
//        public int choice_16_item_count { get; set; }
//        public int choice_16_demulti_wait_time { get; set; }
//        public int choice_16_demulti_time { get; set; }
//        public int choice_17_multi_time { get; set; }
//        public float choice_17_rate { get; set; }
//        public int choice_17_item_count { get; set; }
//        public int choice_17_demulti_wait_time { get; set; }
//        public int choice_17_demulti_time { get; set; }
//        public int choice_18_multi_time { get; set; }
//        public float choice_18_rate { get; set; }
//        public int choice_18_item_count { get; set; }
//        public int choice_18_demulti_wait_time { get; set; }
//        public int choice_18_demulti_time { get; set; }
//        public int choice_19_multi_time { get; set; }
//        public float choice_19_rate { get; set; }
//        public int choice_19_item_count { get; set; }
//        public int choice_19_demulti_wait_time { get; set; }
//        public int choice_19_demulti_time { get; set; }
//        public int choice_20_multi_time { get; set; }
//        public float choice_20_rate { get; set; }
//        public int choice_20_item_count { get; set; }
//        public int choice_20_demulti_wait_time { get; set; }
//        public int choice_20_demulti_time { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class INC_SKILL_ABILITY_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_skill { get; set; }
//        public int level_required { get; set; }
//        public float inc_ratio { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class GOD_EVIL_CONVERT_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int skill_map_1_1 { get; set; }
//        public int skill_map_1_2 { get; set; }
//        public int skill_map_2_1 { get; set; }
//        public int skill_map_2_2 { get; set; }
//        public int skill_map_3_1 { get; set; }
//        public int skill_map_3_2 { get; set; }
//        public int skill_map_4_1 { get; set; }
//        public int skill_map_4_2 { get; set; }
//        public int skill_map_5_1 { get; set; }
//        public int skill_map_5_2 { get; set; }
//        public int skill_map_6_1 { get; set; }
//        public int skill_map_6_2 { get; set; }
//        public int skill_map_7_1 { get; set; }
//        public int skill_map_7_2 { get; set; }
//        public int skill_map_8_1 { get; set; }
//        public int skill_map_8_2 { get; set; }
//        public int skill_map_9_1 { get; set; }
//        public int skill_map_9_2 { get; set; }
//        public int skill_map_10_1 { get; set; }
//        public int skill_map_10_2 { get; set; }
//        public int skill_map_11_1 { get; set; }
//        public int skill_map_11_2 { get; set; }
//        public int skill_map_12_1 { get; set; }
//        public int skill_map_12_2 { get; set; }
//        public int skill_map_13_1 { get; set; }
//        public int skill_map_13_2 { get; set; }
//        public int skill_map_14_1 { get; set; }
//        public int skill_map_14_2 { get; set; }
//        public int skill_map_15_1 { get; set; }
//        public int skill_map_15_2 { get; set; }
//        public int skill_map_16_1 { get; set; }
//        public int skill_map_16_2 { get; set; }
//        public int skill_map_17_1 { get; set; }
//        public int skill_map_17_2 { get; set; }
//        public int skill_map_18_1 { get; set; }
//        public int skill_map_18_2 { get; set; }
//        public int skill_map_19_1 { get; set; }
//        public int skill_map_19_2 { get; set; }
//        public int skill_map_20_1 { get; set; }
//        public int skill_map_20_2 { get; set; }
//        public int skill_map_21_1 { get; set; }
//        public int skill_map_21_2 { get; set; }
//        public int skill_map_22_1 { get; set; }
//        public int skill_map_22_2 { get; set; }
//        public int skill_map_23_1 { get; set; }
//        public int skill_map_23_2 { get; set; }
//        public int skill_map_24_1 { get; set; }
//        public int skill_map_24_2 { get; set; }
//        public int skill_map_25_1 { get; set; }
//        public int skill_map_25_2 { get; set; }
//        public int skill_map_26_1 { get; set; }
//        public int skill_map_26_2 { get; set; }
//        public int skill_map_27_1 { get; set; }
//        public int skill_map_27_2 { get; set; }
//        public int skill_map_28_1 { get; set; }
//        public int skill_map_28_2 { get; set; }
//        public int skill_map_29_1 { get; set; }
//        public int skill_map_29_2 { get; set; }
//        public int skill_map_30_1 { get; set; }
//        public int skill_map_30_2 { get; set; }
//        public int skill_map_31_1 { get; set; }
//        public int skill_map_31_2 { get; set; }
//        public int skill_map_32_1 { get; set; }
//        public int skill_map_32_2 { get; set; }
//        public int skill_map_33_1 { get; set; }
//        public int skill_map_33_2 { get; set; }
//        public int skill_map_34_1 { get; set; }
//        public int skill_map_34_2 { get; set; }
//        public int skill_map_35_1 { get; set; }
//        public int skill_map_35_2 { get; set; }
//        public int skill_map_36_1 { get; set; }
//        public int skill_map_36_2 { get; set; }
//        public int skill_map_37_1 { get; set; }
//        public int skill_map_37_2 { get; set; }
//        public int skill_map_38_1 { get; set; }
//        public int skill_map_38_2 { get; set; }
//        public int skill_map_39_1 { get; set; }
//        public int skill_map_39_2 { get; set; }
//        public int skill_map_40_1 { get; set; }
//        public int skill_map_40_2 { get; set; }
//        public int skill_map_41_1 { get; set; }
//        public int skill_map_41_2 { get; set; }
//        public int skill_map_42_1 { get; set; }
//        public int skill_map_42_2 { get; set; }
//        public int skill_map_43_1 { get; set; }
//        public int skill_map_43_2 { get; set; }
//        public int skill_map_44_1 { get; set; }
//        public int skill_map_44_2 { get; set; }
//        public int skill_map_45_1 { get; set; }
//        public int skill_map_45_2 { get; set; }
//        public int skill_map_46_1 { get; set; }
//        public int skill_map_46_2 { get; set; }
//        public int skill_map_47_1 { get; set; }
//        public int skill_map_47_2 { get; set; }
//        public int skill_map_48_1 { get; set; }
//        public int skill_map_48_2 { get; set; }
//        public int skill_map_49_1 { get; set; }
//        public int skill_map_49_2 { get; set; }
//        public int skill_map_50_1 { get; set; }
//        public int skill_map_50_2 { get; set; }
//        public int skill_map_51_1 { get; set; }
//        public int skill_map_51_2 { get; set; }
//        public int skill_map_52_1 { get; set; }
//        public int skill_map_52_2 { get; set; }
//        public int skill_map_53_1 { get; set; }
//        public int skill_map_53_2 { get; set; }
//        public int skill_map_54_1 { get; set; }
//        public int skill_map_54_2 { get; set; }
//        public int skill_map_55_1 { get; set; }
//        public int skill_map_55_2 { get; set; }
//        public int skill_map_56_1 { get; set; }
//        public int skill_map_56_2 { get; set; }
//        public int skill_map_57_1 { get; set; }
//        public int skill_map_57_2 { get; set; }
//        public int skill_map_58_1 { get; set; }
//        public int skill_map_58_2 { get; set; }
//        public int skill_map_59_1 { get; set; }
//        public int skill_map_59_2 { get; set; }
//        public int skill_map_60_1 { get; set; }
//        public int skill_map_60_2 { get; set; }
//        public int skill_map_61_1 { get; set; }
//        public int skill_map_61_2 { get; set; }
//        public int skill_map_62_1 { get; set; }
//        public int skill_map_62_2 { get; set; }
//        public int skill_map_63_1 { get; set; }
//        public int skill_map_63_2 { get; set; }
//        public int skill_map_64_1 { get; set; }
//        public int skill_map_64_2 { get; set; }
//        public int skill_map_65_1 { get; set; }
//        public int skill_map_65_2 { get; set; }
//        public int skill_map_66_1 { get; set; }
//        public int skill_map_66_2 { get; set; }
//        public int skill_map_67_1 { get; set; }
//        public int skill_map_67_2 { get; set; }
//        public int skill_map_68_1 { get; set; }
//        public int skill_map_68_2 { get; set; }
//        public int skill_map_69_1 { get; set; }
//        public int skill_map_69_2 { get; set; }
//        public int skill_map_70_1 { get; set; }
//        public int skill_map_70_2 { get; set; }
//        public int skill_map_71_1 { get; set; }
//        public int skill_map_71_2 { get; set; }
//        public int skill_map_72_1 { get; set; }
//        public int skill_map_72_2 { get; set; }
//        public int skill_map_73_1 { get; set; }
//        public int skill_map_73_2 { get; set; }
//        public int skill_map_74_1 { get; set; }
//        public int skill_map_74_2 { get; set; }
//        public int skill_map_75_1 { get; set; }
//        public int skill_map_75_2 { get; set; }
//        public int skill_map_76_1 { get; set; }
//        public int skill_map_76_2 { get; set; }
//        public int skill_map_77_1 { get; set; }
//        public int skill_map_77_2 { get; set; }
//        public int skill_map_78_1 { get; set; }
//        public int skill_map_78_2 { get; set; }
//        public int skill_map_79_1 { get; set; }
//        public int skill_map_79_2 { get; set; }
//        public int skill_map_80_1 { get; set; }
//        public int skill_map_80_2 { get; set; }
//        public int skill_map_81_1 { get; set; }
//        public int skill_map_81_2 { get; set; }
//        public int skill_map_82_1 { get; set; }
//        public int skill_map_82_2 { get; set; }
//        public int skill_map_83_1 { get; set; }
//        public int skill_map_83_2 { get; set; }
//        public int skill_map_84_1 { get; set; }
//        public int skill_map_84_2 { get; set; }
//        public int skill_map_85_1 { get; set; }
//        public int skill_map_85_2 { get; set; }
//        public int skill_map_86_1 { get; set; }
//        public int skill_map_86_2 { get; set; }
//        public int skill_map_87_1 { get; set; }
//        public int skill_map_87_2 { get; set; }
//        public int skill_map_88_1 { get; set; }
//        public int skill_map_88_2 { get; set; }
//        public int skill_map_89_1 { get; set; }
//        public int skill_map_89_2 { get; set; }
//        public int skill_map_90_1 { get; set; }
//        public int skill_map_90_2 { get; set; }
//        public int skill_map_91_1 { get; set; }
//        public int skill_map_91_2 { get; set; }
//        public int skill_map_92_1 { get; set; }
//        public int skill_map_92_2 { get; set; }
//        public int skill_map_93_1 { get; set; }
//        public int skill_map_93_2 { get; set; }
//        public int skill_map_94_1 { get; set; }
//        public int skill_map_94_2 { get; set; }
//        public int skill_map_95_1 { get; set; }
//        public int skill_map_95_2 { get; set; }
//        public int skill_map_96_1 { get; set; }
//        public int skill_map_96_2 { get; set; }
//        public int skill_map_97_1 { get; set; }
//        public int skill_map_97_2 { get; set; }
//        public int skill_map_98_1 { get; set; }
//        public int skill_map_98_2 { get; set; }
//        public int skill_map_99_1 { get; set; }
//        public int skill_map_99_2 { get; set; }
//        public int skill_map_100_1 { get; set; }
//        public int skill_map_100_2 { get; set; }
//        public int skill_map_101_1 { get; set; }
//        public int skill_map_101_2 { get; set; }
//        public int skill_map_102_1 { get; set; }
//        public int skill_map_102_2 { get; set; }
//        public int skill_map_103_1 { get; set; }
//        public int skill_map_103_2 { get; set; }
//        public int skill_map_104_1 { get; set; }
//        public int skill_map_104_2 { get; set; }
//        public int skill_map_105_1 { get; set; }
//        public int skill_map_105_2 { get; set; }
//        public int skill_map_106_1 { get; set; }
//        public int skill_map_106_2 { get; set; }
//        public int skill_map_107_1 { get; set; }
//        public int skill_map_107_2 { get; set; }
//        public int skill_map_108_1 { get; set; }
//        public int skill_map_108_2 { get; set; }
//        public int skill_map_109_1 { get; set; }
//        public int skill_map_109_2 { get; set; }
//        public int skill_map_110_1 { get; set; }
//        public int skill_map_110_2 { get; set; }
//        public int skill_map_111_1 { get; set; }
//        public int skill_map_111_2 { get; set; }
//        public int skill_map_112_1 { get; set; }
//        public int skill_map_112_2 { get; set; }
//        public int skill_map_113_1 { get; set; }
//        public int skill_map_113_2 { get; set; }
//        public int skill_map_114_1 { get; set; }
//        public int skill_map_114_2 { get; set; }
//        public int skill_map_115_1 { get; set; }
//        public int skill_map_115_2 { get; set; }
//        public int skill_map_116_1 { get; set; }
//        public int skill_map_116_2 { get; set; }
//        public int skill_map_117_1 { get; set; }
//        public int skill_map_117_2 { get; set; }
//        public int skill_map_118_1 { get; set; }
//        public int skill_map_118_2 { get; set; }
//        public int skill_map_119_1 { get; set; }
//        public int skill_map_119_2 { get; set; }
//        public int skill_map_120_1 { get; set; }
//        public int skill_map_120_2 { get; set; }
//        public int skill_map_121_1 { get; set; }
//        public int skill_map_121_2 { get; set; }
//        public int skill_map_122_1 { get; set; }
//        public int skill_map_122_2 { get; set; }
//        public int skill_map_123_1 { get; set; }
//        public int skill_map_123_2 { get; set; }
//        public int skill_map_124_1 { get; set; }
//        public int skill_map_124_2 { get; set; }
//        public int skill_map_125_1 { get; set; }
//        public int skill_map_125_2 { get; set; }
//        public int skill_map_126_1 { get; set; }
//        public int skill_map_126_2 { get; set; }
//        public int skill_map_127_1 { get; set; }
//        public int skill_map_127_2 { get; set; }
//        public int skill_map_128_1 { get; set; }
//        public int skill_map_128_2 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEDDING_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int wedding_session_1_start_hour { get; set; }
//        public int wedding_session_1_start_min { get; set; }
//        public int wedding_session_1_end_hour { get; set; }
//        public int wedding_session_1_end_min { get; set; }
//        public int wedding_session_2_start_hour { get; set; }
//        public int wedding_session_2_start_min { get; set; }
//        public int wedding_session_2_end_hour { get; set; }
//        public int wedding_session_2_end_min { get; set; }
//        public int wedding_session_3_start_hour { get; set; }
//        public int wedding_session_3_start_min { get; set; }
//        public int wedding_session_3_end_hour { get; set; }
//        public int wedding_session_3_end_min { get; set; }
//        public int wedding_session_4_start_hour { get; set; }
//        public int wedding_session_4_start_min { get; set; }
//        public int wedding_session_4_end_hour { get; set; }
//        public int wedding_session_4_end_min { get; set; }
//        public int wedding_session_5_start_hour { get; set; }
//        public int wedding_session_5_start_min { get; set; }
//        public int wedding_session_5_end_hour { get; set; }
//        public int wedding_session_5_end_min { get; set; }
//        public int wedding_session_6_start_hour { get; set; }
//        public int wedding_session_6_start_min { get; set; }
//        public int wedding_session_6_end_hour { get; set; }
//        public int wedding_session_6_end_min { get; set; }
//        public int wedding_session_7_start_hour { get; set; }
//        public int wedding_session_7_start_min { get; set; }
//        public int wedding_session_7_end_hour { get; set; }
//        public int wedding_session_7_end_min { get; set; }
//        public int wedding_session_8_start_hour { get; set; }
//        public int wedding_session_8_start_min { get; set; }
//        public int wedding_session_8_end_hour { get; set; }
//        public int wedding_session_8_end_min { get; set; }
//        public int wedding_session_9_start_hour { get; set; }
//        public int wedding_session_9_start_min { get; set; }
//        public int wedding_session_9_end_hour { get; set; }
//        public int wedding_session_9_end_min { get; set; }
//        public int wedding_session_10_start_hour { get; set; }
//        public int wedding_session_10_start_min { get; set; }
//        public int wedding_session_10_end_hour { get; set; }
//        public int wedding_session_10_end_min { get; set; }
//        public int reserved_day_1_year { get; set; }
//        public int reserved_day_1_month { get; set; }
//        public int reserved_day_1_day { get; set; }
//        public int reserved_day_2_year { get; set; }
//        public int reserved_day_2_month { get; set; }
//        public int reserved_day_2_day { get; set; }
//        public int reserved_day_3_year { get; set; }
//        public int reserved_day_3_month { get; set; }
//        public int reserved_day_3_day { get; set; }
//        public int reserved_day_4_year { get; set; }
//        public int reserved_day_4_month { get; set; }
//        public int reserved_day_4_day { get; set; }
//        public int reserved_day_5_year { get; set; }
//        public int reserved_day_5_month { get; set; }
//        public int reserved_day_5_day { get; set; }
//        public int reserved_day_6_year { get; set; }
//        public int reserved_day_6_month { get; set; }
//        public int reserved_day_6_day { get; set; }
//        public int reserved_day_7_year { get; set; }
//        public int reserved_day_7_month { get; set; }
//        public int reserved_day_7_day { get; set; }
//        public int reserved_day_8_year { get; set; }
//        public int reserved_day_8_month { get; set; }
//        public int reserved_day_8_day { get; set; }
//        public int reserved_day_9_year { get; set; }
//        public int reserved_day_9_month { get; set; }
//        public int reserved_day_9_day { get; set; }
//        public int reserved_day_10_year { get; set; }
//        public int reserved_day_10_month { get; set; }
//        public int reserved_day_10_day { get; set; }
//        public int reserved_day_11_year { get; set; }
//        public int reserved_day_11_month { get; set; }
//        public int reserved_day_11_day { get; set; }
//        public int reserved_day_12_year { get; set; }
//        public int reserved_day_12_month { get; set; }
//        public int reserved_day_12_day { get; set; }
//        public int reserved_day_13_year { get; set; }
//        public int reserved_day_13_month { get; set; }
//        public int reserved_day_13_day { get; set; }
//        public int reserved_day_14_year { get; set; }
//        public int reserved_day_14_month { get; set; }
//        public int reserved_day_14_day { get; set; }
//        public int reserved_day_15_year { get; set; }
//        public int reserved_day_15_month { get; set; }
//        public int reserved_day_15_day { get; set; }
//        public int reserved_day_16_year { get; set; }
//        public int reserved_day_16_month { get; set; }
//        public int reserved_day_16_day { get; set; }
//        public int reserved_day_17_year { get; set; }
//        public int reserved_day_17_month { get; set; }
//        public int reserved_day_17_day { get; set; }
//        public int reserved_day_18_year { get; set; }
//        public int reserved_day_18_month { get; set; }
//        public int reserved_day_18_day { get; set; }
//        public int reserved_day_19_year { get; set; }
//        public int reserved_day_19_month { get; set; }
//        public int reserved_day_19_day { get; set; }
//        public int reserved_day_20_year { get; set; }
//        public int reserved_day_20_month { get; set; }
//        public int reserved_day_20_day { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_1_name;

//        public string Wedding_scene_1_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_1_name);
//            set { wedding_scene_1_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_1_pos_1 { get; set; }
//        public float wedding_scene_1_pos_2 { get; set; }
//        public float wedding_scene_1_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_2_name;

//        public string Wedding_scene_2_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_2_name);
//            set { wedding_scene_2_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_2_pos_1 { get; set; }
//        public float wedding_scene_2_pos_2 { get; set; }
//        public float wedding_scene_2_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_3_name;

//        public string Wedding_scene_3_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_3_name);
//            set { wedding_scene_3_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_3_pos_1 { get; set; }
//        public float wedding_scene_3_pos_2 { get; set; }
//        public float wedding_scene_3_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_4_name;

//        public string Wedding_scene_4_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_4_name);
//            set { wedding_scene_4_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_4_pos_1 { get; set; }
//        public float wedding_scene_4_pos_2 { get; set; }
//        public float wedding_scene_4_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_5_name;

//        public string Wedding_scene_5_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_5_name);
//            set { wedding_scene_5_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_5_pos_1 { get; set; }
//        public float wedding_scene_5_pos_2 { get; set; }
//        public float wedding_scene_5_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_6_name;

//        public string Wedding_scene_6_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_6_name);
//            set { wedding_scene_6_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_6_pos_1 { get; set; }
//        public float wedding_scene_6_pos_2 { get; set; }
//        public float wedding_scene_6_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_7_name;

//        public string Wedding_scene_7_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_7_name);
//            set { wedding_scene_7_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_7_pos_1 { get; set; }
//        public float wedding_scene_7_pos_2 { get; set; }
//        public float wedding_scene_7_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_8_name;

//        public string Wedding_scene_8_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_8_name);
//            set { wedding_scene_8_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_8_pos_1 { get; set; }
//        public float wedding_scene_8_pos_2 { get; set; }
//        public float wedding_scene_8_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_9_name;

//        public string Wedding_scene_9_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_9_name);
//            set { wedding_scene_9_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_9_pos_1 { get; set; }
//        public float wedding_scene_9_pos_2 { get; set; }
//        public float wedding_scene_9_pos_3 { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
//        public byte[] wedding_scene_10_name;

//        public string Wedding_scene_10_name
//        {
//            get => Structure.Unicode.GetString(wedding_scene_10_name);
//            set { wedding_scene_10_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 32); }
//        }

//        public float wedding_scene_10_pos_1 { get; set; }
//        public float wedding_scene_10_pos_2 { get; set; }
//        public float wedding_scene_10_pos_3 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEDDING_BOOKCARD_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int year { get; set; }
//        public int month { get; set; }
//        public int day { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WEDDING_INVITECARD_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class SHARPENER_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int equip_mask { get; set; }
//        public int addon_1 { get; set; }
//        public int addon_2 { get; set; }
//        public int addon_3 { get; set; }
//        public int addon_time { get; set; }
//        public int gfx_index { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACE_THIRDEYE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_gfx;

//        public string File_gfx
//        {
//            get => Structure.Gbk.GetString(file_gfx);
//            set { file_gfx = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [CharacterCombo] public int character_combo_id { get; set; }
//        public int gender_id { get; set; }
//        public int facepill_only { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACTION_FORTRESS_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int require_level { get; set; }
//        public int require_item_1_id { get; set; }
//        public int require_item_1_count { get; set; }
//        public int require_item_2_id { get; set; }
//        public int require_item_2_count { get; set; }
//        public int require_item_3_id { get; set; }
//        public int require_item_3_count { get; set; }
//        public int require_item_4_id { get; set; }
//        public int require_item_4_count { get; set; }
//        public int require_item_5_id { get; set; }
//        public int require_item_5_count { get; set; }
//        public int require_item_6_id { get; set; }
//        public int require_item_6_count { get; set; }
//        public int require_item_7_id { get; set; }
//        public int require_item_7_count { get; set; }
//        public int require_item_8_id { get; set; }
//        public int require_item_8_count { get; set; }
//        public int level_1_exp { get; set; }
//        public int level_1_tech_point { get; set; }
//        public int level_2_exp { get; set; }
//        public int level_2_tech_point { get; set; }
//        public int level_3_exp { get; set; }
//        public int level_3_tech_point { get; set; }
//        public int level_4_exp { get; set; }
//        public int level_4_tech_point { get; set; }
//        public int level_5_exp { get; set; }
//        public int level_5_tech_point { get; set; }
//        public int level_6_exp { get; set; }
//        public int level_6_tech_point { get; set; }
//        public int level_7_exp { get; set; }
//        public int level_7_tech_point { get; set; }
//        public int level_8_exp { get; set; }
//        public int level_8_tech_point { get; set; }
//        public int level_9_exp { get; set; }
//        public int level_9_tech_point { get; set; }
//        public int level_10_exp { get; set; }
//        public int level_10_tech_point { get; set; }
//        public int level_11_exp { get; set; }
//        public int level_11_tech_point { get; set; }
//        public int level_12_exp { get; set; }
//        public int level_12_tech_point { get; set; }
//        public int level_13_exp { get; set; }
//        public int level_13_tech_point { get; set; }
//        public int level_14_exp { get; set; }
//        public int level_14_tech_point { get; set; }
//        public int level_15_exp { get; set; }
//        public int level_15_tech_point { get; set; }
//        public int level_16_exp { get; set; }
//        public int level_16_tech_point { get; set; }
//        public int level_17_exp { get; set; }
//        public int level_17_tech_point { get; set; }
//        public int level_18_exp { get; set; }
//        public int level_18_tech_point { get; set; }
//        public int level_19_exp { get; set; }
//        public int level_19_tech_point { get; set; }
//        public int level_20_exp { get; set; }
//        public int level_20_tech_point { get; set; }
//        public int level_21_exp { get; set; }
//        public int level_21_tech_point { get; set; }
//        public int level_22_exp { get; set; }
//        public int level_22_tech_point { get; set; }
//        public int level_23_exp { get; set; }
//        public int level_23_tech_point { get; set; }
//        public int level_24_exp { get; set; }
//        public int level_24_tech_point { get; set; }
//        public int level_25_exp { get; set; }
//        public int level_25_tech_point { get; set; }
//        public int level_26_exp { get; set; }
//        public int level_26_tech_point { get; set; }
//        public int level_27_exp { get; set; }
//        public int level_27_tech_point { get; set; }
//        public int level_28_exp { get; set; }
//        public int level_28_tech_point { get; set; }
//        public int level_29_exp { get; set; }
//        public int level_29_tech_point { get; set; }
//        public int level_30_exp { get; set; }
//        public int level_30_tech_point { get; set; }
//        public int level_31_exp { get; set; }
//        public int level_31_tech_point { get; set; }
//        public int level_32_exp { get; set; }
//        public int level_32_tech_point { get; set; }
//        public int level_33_exp { get; set; }
//        public int level_33_tech_point { get; set; }
//        public int level_34_exp { get; set; }
//        public int level_34_tech_point { get; set; }
//        public int level_35_exp { get; set; }
//        public int level_35_tech_point { get; set; }
//        public int level_36_exp { get; set; }
//        public int level_36_tech_point { get; set; }
//        public int level_37_exp { get; set; }
//        public int level_37_tech_point { get; set; }
//        public int level_38_exp { get; set; }
//        public int level_38_tech_point { get; set; }
//        public int level_39_exp { get; set; }
//        public int level_39_tech_point { get; set; }
//        public int level_40_exp { get; set; }
//        public int level_40_tech_point { get; set; }
//        public int level_41_exp { get; set; }
//        public int level_41_tech_point { get; set; }
//        public int level_42_exp { get; set; }
//        public int level_42_tech_point { get; set; }
//        public int level_43_exp { get; set; }
//        public int level_43_tech_point { get; set; }
//        public int level_44_exp { get; set; }
//        public int level_44_tech_point { get; set; }
//        public int level_45_exp { get; set; }
//        public int level_45_tech_point { get; set; }
//        public int level_46_exp { get; set; }
//        public int level_46_tech_point { get; set; }
//        public int level_47_exp { get; set; }
//        public int level_47_tech_point { get; set; }
//        public int level_48_exp { get; set; }
//        public int level_48_tech_point { get; set; }
//        public int level_49_exp { get; set; }
//        public int level_49_tech_point { get; set; }
//        public int level_50_exp { get; set; }
//        public int level_50_tech_point { get; set; }
//        public int tech_point_cost_1_1 { get; set; }
//        public int tech_point_cost_1_2 { get; set; }
//        public int tech_point_cost_1_3 { get; set; }
//        public int tech_point_cost_1_4 { get; set; }
//        public int tech_point_cost_1_5 { get; set; }
//        public int tech_point_cost_1_6 { get; set; }
//        public int tech_point_cost_1_7 { get; set; }
//        public int tech_point_cost_2_1 { get; set; }
//        public int tech_point_cost_2_2 { get; set; }
//        public int tech_point_cost_2_3 { get; set; }
//        public int tech_point_cost_2_4 { get; set; }
//        public int tech_point_cost_2_5 { get; set; }
//        public int tech_point_cost_2_6 { get; set; }
//        public int tech_point_cost_2_7 { get; set; }
//        public int tech_point_cost_3_1 { get; set; }
//        public int tech_point_cost_3_2 { get; set; }
//        public int tech_point_cost_3_3 { get; set; }
//        public int tech_point_cost_3_4 { get; set; }
//        public int tech_point_cost_3_5 { get; set; }
//        public int tech_point_cost_3_6 { get; set; }
//        public int tech_point_cost_3_7 { get; set; }
//        public int tech_point_cost_4_1 { get; set; }
//        public int tech_point_cost_4_2 { get; set; }
//        public int tech_point_cost_4_3 { get; set; }
//        public int tech_point_cost_4_4 { get; set; }
//        public int tech_point_cost_4_5 { get; set; }
//        public int tech_point_cost_4_6 { get; set; }
//        public int tech_point_cost_4_7 { get; set; }
//        public int tech_point_cost_5_1 { get; set; }
//        public int tech_point_cost_5_2 { get; set; }
//        public int tech_point_cost_5_3 { get; set; }
//        public int tech_point_cost_5_4 { get; set; }
//        public int tech_point_cost_5_5 { get; set; }
//        public int tech_point_cost_5_6 { get; set; }
//        public int tech_point_cost_5_7 { get; set; }
//        public int init_building_1 { get; set; }
//        public int init_building_2 { get; set; }
//        public int init_building_3 { get; set; }
//        public int init_building_4 { get; set; }
//        public int init_building_5 { get; set; }
//        public int init_building_6 { get; set; }
//        public int init_building_7 { get; set; }
//        public int init_building_8 { get; set; }
//        public int init_building_9 { get; set; }
//        public int init_building_10 { get; set; }
//        public int init_building_11 { get; set; }
//        public int init_building_12 { get; set; }
//        public int init_building_13 { get; set; }
//        public int init_building_14 { get; set; }
//        public int init_building_15 { get; set; }
//        public int init_building_16 { get; set; }
//        public int init_building_17 { get; set; }
//        public int init_building_18 { get; set; }
//        public int init_building_19 { get; set; }
//        public int init_building_20 { get; set; }
//        public int controller_id_1 { get; set; }
//        public int controller_id_2 { get; set; }
//        public int controller_id_3 { get; set; }
//        public int controller_id_4 { get; set; }
//        public int controller_id_5 { get; set; }
//        public int controller_id_6 { get; set; }
//        public int controller_id_7 { get; set; }
//        public int controller_id_8 { get; set; }
//        public int controller_id_9 { get; set; }
//        public int controller_id_10 { get; set; }
//        public int controller_id_11 { get; set; }
//        public int controller_id_12 { get; set; }
//        public int controller_id_13 { get; set; }
//        public int controller_id_14 { get; set; }
//        public int controller_id_15 { get; set; }
//        public int controller_id_16 { get; set; }
//        public int controller_id_17 { get; set; }
//        public int controller_id_18 { get; set; }
//        public int controller_id_19 { get; set; }
//        public int controller_id_20 { get; set; }
//        public int controller_id_21 { get; set; }
//        public int controller_id_22 { get; set; }
//        public int controller_id_23 { get; set; }
//        public int controller_id_24 { get; set; }
//        public int controller_id_25 { get; set; }
//        public int controller_id_26 { get; set; }
//        public int controller_id_27 { get; set; }
//        public int controller_id_28 { get; set; }
//        public int controller_id_29 { get; set; }
//        public int controller_id_30 { get; set; }
//        public int controller_id_31 { get; set; }
//        public int controller_id_32 { get; set; }
//        public int controller_id_33 { get; set; }
//        public int controller_id_34 { get; set; }
//        public int controller_id_35 { get; set; }
//        public int controller_id_36 { get; set; }
//        public int controller_id_37 { get; set; }
//        public int controller_id_38 { get; set; }
//        public int controller_id_39 { get; set; }
//        public int controller_id_40 { get; set; }
//        public int controller_id_41 { get; set; }
//        public int controller_id_42 { get; set; }
//        public int controller_id_43 { get; set; }
//        public int controller_id_44 { get; set; }
//        public int controller_id_45 { get; set; }
//        public int controller_id_46 { get; set; }
//        public int controller_id_47 { get; set; }
//        public int controller_id_48 { get; set; }
//        public int controller_id_49 { get; set; }
//        public int controller_id_50 { get; set; }
//        public int controller_id_51 { get; set; }
//        public int controller_id_52 { get; set; }
//        public int controller_id_53 { get; set; }
//        public int controller_id_54 { get; set; }
//        public int controller_id_55 { get; set; }
//        public int controller_id_56 { get; set; }
//        public int controller_id_57 { get; set; }
//        public int controller_id_58 { get; set; }
//        public int controller_id_59 { get; set; }
//        public int controller_id_60 { get; set; }
//        public int controller_id_61 { get; set; }
//        public int controller_id_62 { get; set; }
//        public int controller_id_63 { get; set; }
//        public int controller_id_64 { get; set; }
//        public int controller_id_65 { get; set; }
//        public int controller_id_66 { get; set; }
//        public int controller_id_67 { get; set; }
//        public int controller_id_68 { get; set; }
//        public int controller_id_69 { get; set; }
//        public int controller_id_70 { get; set; }
//        public int controller_id_71 { get; set; }
//        public int controller_id_72 { get; set; }
//        public int controller_id_73 { get; set; }
//        public int controller_id_74 { get; set; }
//        public int controller_id_75 { get; set; }
//        public int controller_id_76 { get; set; }
//        public int controller_id_77 { get; set; }
//        public int controller_id_78 { get; set; }
//        public int controller_id_79 { get; set; }
//        public int controller_id_80 { get; set; }
//        public int controller_id_81 { get; set; }
//        public int controller_id_82 { get; set; }
//        public int controller_id_83 { get; set; }
//        public int controller_id_84 { get; set; }
//        public int controller_id_85 { get; set; }
//        public int controller_id_86 { get; set; }
//        public int controller_id_87 { get; set; }
//        public int controller_id_88 { get; set; }
//        public int controller_id_89 { get; set; }
//        public int controller_id_90 { get; set; }
//        public int controller_id_91 { get; set; }
//        public int controller_id_92 { get; set; }
//        public int controller_id_93 { get; set; }
//        public int controller_id_94 { get; set; }
//        public int controller_id_95 { get; set; }
//        public int controller_id_96 { get; set; }
//        public int controller_id_97 { get; set; }
//        public int controller_id_98 { get; set; }
//        public int controller_id_99 { get; set; }
//        public int controller_id_100 { get; set; }
//        public int common_value_1_id { get; set; }
//        public int common_value_1_value { get; set; }
//        public int common_value_2_id { get; set; }
//        public int common_value_2_value { get; set; }
//        public int common_value_3_id { get; set; }
//        public int common_value_3_value { get; set; }
//        public int common_value_4_id { get; set; }
//        public int common_value_4_value { get; set; }
//        public int common_value_5_id { get; set; }
//        public int common_value_5_value { get; set; }
//        public int common_value_6_id { get; set; }
//        public int common_value_6_value { get; set; }
//        public int common_value_7_id { get; set; }
//        public int common_value_7_value { get; set; }
//        public int common_value_8_id { get; set; }
//        public int common_value_8_value { get; set; }
//        public int common_value_9_id { get; set; }
//        public int common_value_9_value { get; set; }
//        public int common_value_10_id { get; set; }
//        public int common_value_10_value { get; set; }
//        public int common_value_11_id { get; set; }
//        public int common_value_11_value { get; set; }
//        public int common_value_12_id { get; set; }
//        public int common_value_12_value { get; set; }
//        public int common_value_13_id { get; set; }
//        public int common_value_13_value { get; set; }
//        public int common_value_14_id { get; set; }
//        public int common_value_14_value { get; set; }
//        public int common_value_15_id { get; set; }
//        public int common_value_15_value { get; set; }
//        public int common_value_16_id { get; set; }
//        public int common_value_16_value { get; set; }
//        public int common_value_17_id { get; set; }
//        public int common_value_17_value { get; set; }
//        public int common_value_18_id { get; set; }
//        public int common_value_18_value { get; set; }
//        public int common_value_19_id { get; set; }
//        public int common_value_19_value { get; set; }
//        public int common_value_20_id { get; set; }
//        public int common_value_20_value { get; set; }
//        public int common_value_21_id { get; set; }
//        public int common_value_21_value { get; set; }
//        public int common_value_22_id { get; set; }
//        public int common_value_22_value { get; set; }
//        public int common_value_23_id { get; set; }
//        public int common_value_23_value { get; set; }
//        public int common_value_24_id { get; set; }
//        public int common_value_24_value { get; set; }
//        public int common_value_25_id { get; set; }
//        public int common_value_25_value { get; set; }
//        public int common_value_26_id { get; set; }
//        public int common_value_26_value { get; set; }
//        public int common_value_27_id { get; set; }
//        public int common_value_27_value { get; set; }
//        public int common_value_28_id { get; set; }
//        public int common_value_28_value { get; set; }
//        public int common_value_29_id { get; set; }
//        public int common_value_29_value { get; set; }
//        public int common_value_30_id { get; set; }
//        public int common_value_30_value { get; set; }
//        public int common_value_31_id { get; set; }
//        public int common_value_31_value { get; set; }
//        public int common_value_32_id { get; set; }
//        public int common_value_32_value { get; set; }
//        public int common_value_33_id { get; set; }
//        public int common_value_33_value { get; set; }
//        public int common_value_34_id { get; set; }
//        public int common_value_34_value { get; set; }
//        public int common_value_35_id { get; set; }
//        public int common_value_35_value { get; set; }
//        public int common_value_36_id { get; set; }
//        public int common_value_36_value { get; set; }
//        public int common_value_37_id { get; set; }
//        public int common_value_37_value { get; set; }
//        public int common_value_38_id { get; set; }
//        public int common_value_38_value { get; set; }
//        public int common_value_39_id { get; set; }
//        public int common_value_39_value { get; set; }
//        public int common_value_40_id { get; set; }
//        public int common_value_40_value { get; set; }
//        public int common_value_41_id { get; set; }
//        public int common_value_41_value { get; set; }
//        public int common_value_42_id { get; set; }
//        public int common_value_42_value { get; set; }
//        public int common_value_43_id { get; set; }
//        public int common_value_43_value { get; set; }
//        public int common_value_44_id { get; set; }
//        public int common_value_44_value { get; set; }
//        public int common_value_45_id { get; set; }
//        public int common_value_45_value { get; set; }
//        public int common_value_46_id { get; set; }
//        public int common_value_46_value { get; set; }
//        public int common_value_47_id { get; set; }
//        public int common_value_47_value { get; set; }
//        public int common_value_48_id { get; set; }
//        public int common_value_48_value { get; set; }
//        public int common_value_49_id { get; set; }
//        public int common_value_49_value { get; set; }
//        public int common_value_50_id { get; set; }
//        public int common_value_50_value { get; set; }
//        public int common_value_51_id { get; set; }
//        public int common_value_51_value { get; set; }
//        public int common_value_52_id { get; set; }
//        public int common_value_52_value { get; set; }
//        public int common_value_53_id { get; set; }
//        public int common_value_53_value { get; set; }
//        public int common_value_54_id { get; set; }
//        public int common_value_54_value { get; set; }
//        public int common_value_55_id { get; set; }
//        public int common_value_55_value { get; set; }
//        public int common_value_56_id { get; set; }
//        public int common_value_56_value { get; set; }
//        public int common_value_57_id { get; set; }
//        public int common_value_57_value { get; set; }
//        public int common_value_58_id { get; set; }
//        public int common_value_58_value { get; set; }
//        public int common_value_59_id { get; set; }
//        public int common_value_59_value { get; set; }
//        public int common_value_60_id { get; set; }
//        public int common_value_60_value { get; set; }
//        public int common_value_61_id { get; set; }
//        public int common_value_61_value { get; set; }
//        public int common_value_62_id { get; set; }
//        public int common_value_62_value { get; set; }
//        public int common_value_63_id { get; set; }
//        public int common_value_63_value { get; set; }
//        public int common_value_64_id { get; set; }
//        public int common_value_64_value { get; set; }
//        public int common_value_65_id { get; set; }
//        public int common_value_65_value { get; set; }
//        public int common_value_66_id { get; set; }
//        public int common_value_66_value { get; set; }
//        public int common_value_67_id { get; set; }
//        public int common_value_67_value { get; set; }
//        public int common_value_68_id { get; set; }
//        public int common_value_68_value { get; set; }
//        public int common_value_69_id { get; set; }
//        public int common_value_69_value { get; set; }
//        public int common_value_70_id { get; set; }
//        public int common_value_70_value { get; set; }
//        public int common_value_71_id { get; set; }
//        public int common_value_71_value { get; set; }
//        public int common_value_72_id { get; set; }
//        public int common_value_72_value { get; set; }
//        public int common_value_73_id { get; set; }
//        public int common_value_73_value { get; set; }
//        public int common_value_74_id { get; set; }
//        public int common_value_74_value { get; set; }
//        public int common_value_75_id { get; set; }
//        public int common_value_75_value { get; set; }
//        public int common_value_76_id { get; set; }
//        public int common_value_76_value { get; set; }
//        public int common_value_77_id { get; set; }
//        public int common_value_77_value { get; set; }
//        public int common_value_78_id { get; set; }
//        public int common_value_78_value { get; set; }
//        public int common_value_79_id { get; set; }
//        public int common_value_79_value { get; set; }
//        public int common_value_80_id { get; set; }
//        public int common_value_80_value { get; set; }
//        public int common_value_81_id { get; set; }
//        public int common_value_81_value { get; set; }
//        public int common_value_82_id { get; set; }
//        public int common_value_82_value { get; set; }
//        public int common_value_83_id { get; set; }
//        public int common_value_83_value { get; set; }
//        public int common_value_84_id { get; set; }
//        public int common_value_84_value { get; set; }
//        public int common_value_85_id { get; set; }
//        public int common_value_85_value { get; set; }
//        public int common_value_86_id { get; set; }
//        public int common_value_86_value { get; set; }
//        public int common_value_87_id { get; set; }
//        public int common_value_87_value { get; set; }
//        public int common_value_88_id { get; set; }
//        public int common_value_88_value { get; set; }
//        public int common_value_89_id { get; set; }
//        public int common_value_89_value { get; set; }
//        public int common_value_90_id { get; set; }
//        public int common_value_90_value { get; set; }
//        public int common_value_91_id { get; set; }
//        public int common_value_91_value { get; set; }
//        public int common_value_92_id { get; set; }
//        public int common_value_92_value { get; set; }
//        public int common_value_93_id { get; set; }
//        public int common_value_93_value { get; set; }
//        public int common_value_94_id { get; set; }
//        public int common_value_94_value { get; set; }
//        public int common_value_95_id { get; set; }
//        public int common_value_95_value { get; set; }
//        public int common_value_96_id { get; set; }
//        public int common_value_96_value { get; set; }
//        public int common_value_97_id { get; set; }
//        public int common_value_97_value { get; set; }
//        public int common_value_98_id { get; set; }
//        public int common_value_98_value { get; set; }
//        public int common_value_99_id { get; set; }
//        public int common_value_99_value { get; set; }
//        public int common_value_100_id { get; set; }
//        public int common_value_100_value { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACTION_BUILDING_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACTION_BUILDING_ESSENCE
//    {
//        public int id;
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int require_level { get; set; }
//        public int technology_1 { get; set; }
//        public int technology_2 { get; set; }
//        public int technology_3 { get; set; }
//        public int technology_4 { get; set; }
//        public int technology_5 { get; set; }
//        public int money { get; set; }
//        public int material_1 { get; set; }
//        public int material_2 { get; set; }
//        public int material_3 { get; set; }
//        public int material_4 { get; set; }
//        public int material_5 { get; set; }
//        public int material_6 { get; set; }
//        public int material_7 { get; set; }
//        public int material_8 { get; set; }
//        public int base_time { get; set; }
//        public int delta_time { get; set; }
//        public int controller_id0 { get; set; }
//        public int controller_id1 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FACTION_MATERIAL_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int material_count_1 { get; set; }
//        public int material_count_2 { get; set; }
//        public int material_count_3 { get; set; }
//        public int material_count_4 { get; set; }
//        public int material_count_5 { get; set; }
//        public int material_count_6 { get; set; }
//        public int material_count_7 { get; set; }
//        public int material_count_8 { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class CONGREGATE_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int congregate_type { get; set; }
//        public int area_1_id { get; set; }
//        public int area_1_require_level { get; set; }
//        public int area_1_require_reply_level { get; set; }
//        public int area_1_require_reply_level2 { get; set; }
//        public int area_2_id { get; set; }
//        public int area_2_require_level { get; set; }
//        public int area_2_require_reply_level { get; set; }
//        public int area_2_require_reply_level2 { get; set; }
//        public int area_3_id { get; set; }
//        public int area_3_require_level { get; set; }
//        public int area_3_require_reply_level { get; set; }
//        public int area_3_require_reply_level2 { get; set; }
//        public int area_4_id { get; set; }
//        public int area_4_require_level { get; set; }
//        public int area_4_require_reply_level { get; set; }
//        public int area_4_require_reply_level2 { get; set; }
//        public int area_5_id { get; set; }
//        public int area_5_require_level { get; set; }
//        public int area_5_require_reply_level { get; set; }
//        public int area_5_require_reply_level2 { get; set; }
//        public int area_6_id { get; set; }
//        public int area_6_require_level { get; set; }
//        public int area_6_require_reply_level { get; set; }
//        public int area_6_require_reply_level2 { get; set; }
//        public int area_7_id { get; set; }
//        public int area_7_require_level { get; set; }
//        public int area_7_require_reply_level { get; set; }
//        public int area_7_require_reply_level2 { get; set; }
//        public int area_8_id { get; set; }
//        public int area_8_require_level { get; set; }
//        public int area_8_require_reply_level { get; set; }
//        public int area_8_require_reply_level2 { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ENGRAVE_MAJOR_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ENGRAVE_SUB_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ENGRAVE_ESSENCE
//    {
//        public int id;
//        public int id_major_type { get; set; }
//        public int id_sub_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int level { get; set; }
//        public int equip_mask { get; set; }
//        public int require_level_min { get; set; }
//        public int require_level_max { get; set; }
//        public int duration { get; set; }
//        public int materials_1_id { get; set; }
//        public int materials_1_num { get; set; }
//        public int materials_2_id { get; set; }
//        public int materials_2_num { get; set; }
//        public int materials_3_id { get; set; }
//        public int materials_3_num { get; set; }
//        public int materials_4_id { get; set; }
//        public int materials_4_num { get; set; }
//        public int materials_5_id { get; set; }
//        public int materials_5_num { get; set; }
//        public int materials_6_id { get; set; }
//        public int materials_6_num { get; set; }
//        public int materials_7_id { get; set; }
//        public int materials_7_num { get; set; }
//        public int materials_8_id { get; set; }
//        public int materials_8_num { get; set; }
//        public float probability_addon_num_1 { get; set; }
//        public float probability_addon_num_2 { get; set; }
//        public float probability_addon_num_3 { get; set; }
//        public float probability_addon_num_4 { get; set; }
//        public int addons_1_id { get; set; }
//        public float addons_1_probability { get; set; }
//        public int addons_2_id { get; set; }
//        public float addons_2_probability { get; set; }
//        public int addons_3_id { get; set; }
//        public float addons_3_probability { get; set; }
//        public int addons_4_id { get; set; }
//        public float addons_4_probability { get; set; }
//        public int addons_5_id { get; set; }
//        public float addons_5_probability { get; set; }
//        public int addons_6_id { get; set; }
//        public float addons_6_probability { get; set; }
//        public int addons_7_id { get; set; }
//        public float addons_7_probability { get; set; }
//        public int addons_8_id { get; set; }
//        public float addons_8_probability { get; set; }
//        public int addons_9_id { get; set; }
//        public float addons_9_probability { get; set; }
//        public int addons_10_id { get; set; }
//        public float addons_10_probability { get; set; }
//        public int addons_11_id { get; set; }
//        public float addons_11_probability { get; set; }
//        public int addons_12_id { get; set; }
//        public float addons_12_probability { get; set; }
//        public int addons_13_id { get; set; }
//        public float addons_13_probability { get; set; }
//        public int addons_14_id { get; set; }
//        public float addons_14_probability { get; set; }
//        public int addons_15_id { get; set; }
//        public float addons_15_probability { get; set; }
//        public int addons_16_id { get; set; }
//        public float addons_16_probability { get; set; }
//        public int addons_17_id { get; set; }
//        public float addons_17_probability { get; set; }
//        public int addons_18_id { get; set; }
//        public float addons_18_probability { get; set; }
//        public int addons_19_id { get; set; }
//        public float addons_19_probability { get; set; }
//        public int addons_20_id { get; set; }
//        public float addons_20_probability { get; set; }
//        public int addons_21_id { get; set; }
//        public float addons_21_probability { get; set; }
//        public int addons_22_id { get; set; }
//        public float addons_22_probability { get; set; }
//        public int addons_23_id { get; set; }
//        public float addons_23_probability { get; set; }
//        public int addons_24_id { get; set; }
//        public float addons_24_probability { get; set; }
//        public int addons_25_id { get; set; }
//        public float addons_25_probability { get; set; }
//        public int addons_26_id { get; set; }
//        public float addons_26_probability { get; set; }
//        public int addons_27_id { get; set; }
//        public float addons_27_probability { get; set; }
//        public int addons_28_id { get; set; }
//        public float addons_28_probability { get; set; }
//        public int addons_29_id { get; set; }
//        public float addons_29_probability { get; set; }
//        public int addons_30_id { get; set; }
//        public float addons_30_probability { get; set; }
//        public int addons_31_id { get; set; }
//        public float addons_31_probability { get; set; }
//        public int addons_32_id { get; set; }
//        public float addons_32_probability { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_ENGRAVE_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_engrave_1 { get; set; }
//        public int id_engrave_2 { get; set; }
//        public int id_engrave_3 { get; set; }
//        public int id_engrave_4 { get; set; }
//        public int id_engrave_5 { get; set; }
//        public int id_engrave_6 { get; set; }
//        public int id_engrave_7 { get; set; }
//        public int id_engrave_8 { get; set; }
//        public int id_engrave_9 { get; set; }
//        public int id_engrave_10 { get; set; }
//        public int id_engrave_11 { get; set; }
//        public int id_engrave_12 { get; set; }
//        public int id_engrave_13 { get; set; }
//        public int id_engrave_14 { get; set; }
//        public int id_engrave_15 { get; set; }
//        public int id_engrave_16 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_RANDPROP_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_1_page_title;

//        public string Pages_1_page_title
//        {
//            get => Structure.Unicode.GetString(pages_1_page_title);
//            set { pages_1_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_1_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_2_page_title;

//        public string Pages_2_page_title
//        {
//            get => Structure.Unicode.GetString(pages_2_page_title);
//            set { pages_2_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_2_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_3_page_title;

//        public string Pages_3_page_title
//        {
//            get => Structure.Unicode.GetString(pages_3_page_title);
//            set { pages_3_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_3_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_4_page_title;

//        public string Pages_4_page_title
//        {
//            get => Structure.Unicode.GetString(pages_4_page_title);
//            set { pages_4_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_4_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_5_page_title;

//        public string Pages_5_page_title
//        {
//            get => Structure.Unicode.GetString(pages_5_page_title);
//            set { pages_5_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_5_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_6_page_title;

//        public string Pages_6_page_title
//        {
//            get => Structure.Unicode.GetString(pages_6_page_title);
//            set { pages_6_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_6_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_7_page_title;

//        public string Pages_7_page_title
//        {
//            get => Structure.Unicode.GetString(pages_7_page_title);
//            set { pages_7_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_7_id_recipe { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
//        public byte[] pages_8_page_title;

//        public string Pages_8_page_title
//        {
//            get => Structure.Unicode.GetString(pages_8_page_title);
//            set { pages_8_page_title = BinReader.FillArray(Structure.Unicode.GetBytes(value), 16); }
//        }

//        public int pages_8_id_recipe { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class RANDPROP_TYPE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;


//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class RANDPROP_ESSENCE
//    {
//        public int id;
//        public int id_type { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int id_skill { get; set; }
//        public int skill_level { get; set; }
//        public int money { get; set; }
//        public int duration { get; set; }
//        public int equip_id_1 { get; set; }
//        public int equip_id_2 { get; set; }
//        public int equip_id_3 { get; set; }
//        public int equip_id_4 { get; set; }
//        public int equip_id_5 { get; set; }
//        public int equip_id_6 { get; set; }
//        public int equip_id_7 { get; set; }
//        public int equip_id_8 { get; set; }
//        public int equip_id_9 { get; set; }
//        public int equip_id_10 { get; set; }
//        public int equip_id_11 { get; set; }
//        public int equip_id_12 { get; set; }
//        public int equip_id_13 { get; set; }
//        public int equip_id_14 { get; set; }
//        public int equip_id_15 { get; set; }
//        public int equip_id_16 { get; set; }
//        public int equip_id_17 { get; set; }
//        public int equip_id_18 { get; set; }
//        public int equip_id_19 { get; set; }
//        public int equip_id_20 { get; set; }
//        public int equip_id_21 { get; set; }
//        public int equip_id_22 { get; set; }
//        public int equip_id_23 { get; set; }
//        public int equip_id_24 { get; set; }
//        public int equip_id_25 { get; set; }
//        public int equip_id_26 { get; set; }
//        public int equip_id_27 { get; set; }
//        public int equip_id_28 { get; set; }
//        public int equip_id_29 { get; set; }
//        public int equip_id_30 { get; set; }
//        public int equip_id_31 { get; set; }
//        public int equip_id_32 { get; set; }
//        public int materials_1_id { get; set; }
//        public int materials_1_num { get; set; }
//        public int materials_2_id { get; set; }
//        public int materials_2_num { get; set; }
//        public int materials_3_id { get; set; }
//        public int materials_3_num { get; set; }
//        public int materials_4_id { get; set; }
//        public int materials_4_num { get; set; }
//        public int materials_5_id { get; set; }
//        public int materials_5_num { get; set; }
//        public int materials_6_id { get; set; }
//        public int materials_6_num { get; set; }
//        public int materials_7_id { get; set; }
//        public int materials_7_num { get; set; }
//        public int materials_8_id { get; set; }
//        public int materials_8_num { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class WIKI_TABOO_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int essence_1 { get; set; }
//        public int essence_2 { get; set; }
//        public int essence_3 { get; set; }
//        public int essence_4 { get; set; }
//        public int essence_5 { get; set; }
//        public int essence_6 { get; set; }
//        public int essence_7 { get; set; }
//        public int essence_8 { get; set; }
//        public int essence_9 { get; set; }
//        public int essence_10 { get; set; }
//        public int essence_11 { get; set; }
//        public int essence_12 { get; set; }
//        public int essence_13 { get; set; }
//        public int essence_14 { get; set; }
//        public int essence_15 { get; set; }
//        public int essence_16 { get; set; }
//        public int essence_17 { get; set; }
//        public int essence_18 { get; set; }
//        public int essence_19 { get; set; }
//        public int essence_20 { get; set; }
//        public int essence_21 { get; set; }
//        public int essence_22 { get; set; }
//        public int essence_23 { get; set; }
//        public int essence_24 { get; set; }
//        public int essence_25 { get; set; }
//        public int essence_26 { get; set; }
//        public int essence_27 { get; set; }
//        public int essence_28 { get; set; }
//        public int essence_29 { get; set; }
//        public int essence_30 { get; set; }
//        public int essence_31 { get; set; }
//        public int essence_32 { get; set; }
//        public int essence_33 { get; set; }
//        public int essence_34 { get; set; }
//        public int essence_35 { get; set; }
//        public int essence_36 { get; set; }
//        public int essence_37 { get; set; }
//        public int essence_38 { get; set; }
//        public int essence_39 { get; set; }
//        public int essence_40 { get; set; }
//        public int essence_41 { get; set; }
//        public int essence_42 { get; set; }
//        public int essence_43 { get; set; }
//        public int essence_44 { get; set; }
//        public int essence_45 { get; set; }
//        public int essence_46 { get; set; }
//        public int essence_47 { get; set; }
//        public int essence_48 { get; set; }
//        public int essence_49 { get; set; }
//        public int essence_50 { get; set; }
//        public int essence_51 { get; set; }
//        public int essence_52 { get; set; }
//        public int essence_53 { get; set; }
//        public int essence_54 { get; set; }
//        public int essence_55 { get; set; }
//        public int essence_56 { get; set; }
//        public int essence_57 { get; set; }
//        public int essence_58 { get; set; }
//        public int essence_59 { get; set; }
//        public int essence_60 { get; set; }
//        public int essence_61 { get; set; }
//        public int essence_62 { get; set; }
//        public int essence_63 { get; set; }
//        public int essence_64 { get; set; }
//        public int essence_65 { get; set; }
//        public int essence_66 { get; set; }
//        public int essence_67 { get; set; }
//        public int essence_68 { get; set; }
//        public int essence_69 { get; set; }
//        public int essence_70 { get; set; }
//        public int essence_71 { get; set; }
//        public int essence_72 { get; set; }
//        public int essence_73 { get; set; }
//        public int essence_74 { get; set; }
//        public int essence_75 { get; set; }
//        public int essence_76 { get; set; }
//        public int essence_77 { get; set; }
//        public int essence_78 { get; set; }
//        public int essence_79 { get; set; }
//        public int essence_80 { get; set; }
//        public int essence_81 { get; set; }
//        public int essence_82 { get; set; }
//        public int essence_83 { get; set; }
//        public int essence_84 { get; set; }
//        public int essence_85 { get; set; }
//        public int essence_86 { get; set; }
//        public int essence_87 { get; set; }
//        public int essence_88 { get; set; }
//        public int essence_89 { get; set; }
//        public int essence_90 { get; set; }
//        public int essence_91 { get; set; }
//        public int essence_92 { get; set; }
//        public int essence_93 { get; set; }
//        public int essence_94 { get; set; }
//        public int essence_95 { get; set; }
//        public int essence_96 { get; set; }
//        public int essence_97 { get; set; }
//        public int essence_98 { get; set; }
//        public int essence_99 { get; set; }
//        public int essence_100 { get; set; }
//        public int essence_101 { get; set; }
//        public int essence_102 { get; set; }
//        public int essence_103 { get; set; }
//        public int essence_104 { get; set; }
//        public int essence_105 { get; set; }
//        public int essence_106 { get; set; }
//        public int essence_107 { get; set; }
//        public int essence_108 { get; set; }
//        public int essence_109 { get; set; }
//        public int essence_110 { get; set; }
//        public int essence_111 { get; set; }
//        public int essence_112 { get; set; }
//        public int essence_113 { get; set; }
//        public int essence_114 { get; set; }
//        public int essence_115 { get; set; }
//        public int essence_116 { get; set; }
//        public int essence_117 { get; set; }
//        public int essence_118 { get; set; }
//        public int essence_119 { get; set; }
//        public int essence_120 { get; set; }
//        public int essence_121 { get; set; }
//        public int essence_122 { get; set; }
//        public int essence_123 { get; set; }
//        public int essence_124 { get; set; }
//        public int essence_125 { get; set; }
//        public int essence_126 { get; set; }
//        public int essence_127 { get; set; }
//        public int essence_128 { get; set; }
//        public int essence_129 { get; set; }
//        public int essence_130 { get; set; }
//        public int essence_131 { get; set; }
//        public int essence_132 { get; set; }
//        public int essence_133 { get; set; }
//        public int essence_134 { get; set; }
//        public int essence_135 { get; set; }
//        public int essence_136 { get; set; }
//        public int essence_137 { get; set; }
//        public int essence_138 { get; set; }
//        public int essence_139 { get; set; }
//        public int essence_140 { get; set; }
//        public int essence_141 { get; set; }
//        public int essence_142 { get; set; }
//        public int essence_143 { get; set; }
//        public int essence_144 { get; set; }
//        public int essence_145 { get; set; }
//        public int essence_146 { get; set; }
//        public int essence_147 { get; set; }
//        public int essence_148 { get; set; }
//        public int essence_149 { get; set; }
//        public int essence_150 { get; set; }
//        public int essence_151 { get; set; }
//        public int essence_152 { get; set; }
//        public int essence_153 { get; set; }
//        public int essence_154 { get; set; }
//        public int essence_155 { get; set; }
//        public int essence_156 { get; set; }
//        public int essence_157 { get; set; }
//        public int essence_158 { get; set; }
//        public int essence_159 { get; set; }
//        public int essence_160 { get; set; }
//        public int essence_161 { get; set; }
//        public int essence_162 { get; set; }
//        public int essence_163 { get; set; }
//        public int essence_164 { get; set; }
//        public int essence_165 { get; set; }
//        public int essence_166 { get; set; }
//        public int essence_167 { get; set; }
//        public int essence_168 { get; set; }
//        public int essence_169 { get; set; }
//        public int essence_170 { get; set; }
//        public int essence_171 { get; set; }
//        public int essence_172 { get; set; }
//        public int essence_173 { get; set; }
//        public int essence_174 { get; set; }
//        public int essence_175 { get; set; }
//        public int essence_176 { get; set; }
//        public int essence_177 { get; set; }
//        public int essence_178 { get; set; }
//        public int essence_179 { get; set; }
//        public int essence_180 { get; set; }
//        public int essence_181 { get; set; }
//        public int essence_182 { get; set; }
//        public int essence_183 { get; set; }
//        public int essence_184 { get; set; }
//        public int essence_185 { get; set; }
//        public int essence_186 { get; set; }
//        public int essence_187 { get; set; }
//        public int essence_188 { get; set; }
//        public int essence_189 { get; set; }
//        public int essence_190 { get; set; }
//        public int essence_191 { get; set; }
//        public int essence_192 { get; set; }
//        public int essence_193 { get; set; }
//        public int essence_194 { get; set; }
//        public int essence_195 { get; set; }
//        public int essence_196 { get; set; }
//        public int essence_197 { get; set; }
//        public int essence_198 { get; set; }
//        public int essence_199 { get; set; }
//        public int essence_200 { get; set; }
//        public int essence_201 { get; set; }
//        public int essence_202 { get; set; }
//        public int essence_203 { get; set; }
//        public int essence_204 { get; set; }
//        public int essence_205 { get; set; }
//        public int essence_206 { get; set; }
//        public int essence_207 { get; set; }
//        public int essence_208 { get; set; }
//        public int essence_209 { get; set; }
//        public int essence_210 { get; set; }
//        public int essence_211 { get; set; }
//        public int essence_212 { get; set; }
//        public int essence_213 { get; set; }
//        public int essence_214 { get; set; }
//        public int essence_215 { get; set; }
//        public int essence_216 { get; set; }
//        public int essence_217 { get; set; }
//        public int essence_218 { get; set; }
//        public int essence_219 { get; set; }
//        public int essence_220 { get; set; }
//        public int essence_221 { get; set; }
//        public int essence_222 { get; set; }
//        public int essence_223 { get; set; }
//        public int essence_224 { get; set; }
//        public int essence_225 { get; set; }
//        public int essence_226 { get; set; }
//        public int essence_227 { get; set; }
//        public int essence_228 { get; set; }
//        public int essence_229 { get; set; }
//        public int essence_230 { get; set; }
//        public int essence_231 { get; set; }
//        public int essence_232 { get; set; }
//        public int essence_233 { get; set; }
//        public int essence_234 { get; set; }
//        public int essence_235 { get; set; }
//        public int essence_236 { get; set; }
//        public int essence_237 { get; set; }
//        public int essence_238 { get; set; }
//        public int essence_239 { get; set; }
//        public int essence_240 { get; set; }
//        public int essence_241 { get; set; }
//        public int essence_242 { get; set; }
//        public int essence_243 { get; set; }
//        public int essence_244 { get; set; }
//        public int essence_245 { get; set; }
//        public int essence_246 { get; set; }
//        public int essence_247 { get; set; }
//        public int essence_248 { get; set; }
//        public int essence_249 { get; set; }
//        public int essence_250 { get; set; }
//        public int essence_251 { get; set; }
//        public int essence_252 { get; set; }
//        public int essence_253 { get; set; }
//        public int essence_254 { get; set; }
//        public int essence_255 { get; set; }
//        public int essence_256 { get; set; }
//        public int essence_257 { get; set; }
//        public int essence_258 { get; set; }
//        public int essence_259 { get; set; }
//        public int essence_260 { get; set; }
//        public int essence_261 { get; set; }
//        public int essence_262 { get; set; }
//        public int essence_263 { get; set; }
//        public int essence_264 { get; set; }
//        public int essence_265 { get; set; }
//        public int essence_266 { get; set; }
//        public int essence_267 { get; set; }
//        public int essence_268 { get; set; }
//        public int essence_269 { get; set; }
//        public int essence_270 { get; set; }
//        public int essence_271 { get; set; }
//        public int essence_272 { get; set; }
//        public int essence_273 { get; set; }
//        public int essence_274 { get; set; }
//        public int essence_275 { get; set; }
//        public int essence_276 { get; set; }
//        public int essence_277 { get; set; }
//        public int essence_278 { get; set; }
//        public int essence_279 { get; set; }
//        public int essence_280 { get; set; }
//        public int essence_281 { get; set; }
//        public int essence_282 { get; set; }
//        public int essence_283 { get; set; }
//        public int essence_284 { get; set; }
//        public int essence_285 { get; set; }
//        public int essence_286 { get; set; }
//        public int essence_287 { get; set; }
//        public int essence_288 { get; set; }
//        public int essence_289 { get; set; }
//        public int essence_290 { get; set; }
//        public int essence_291 { get; set; }
//        public int essence_292 { get; set; }
//        public int essence_293 { get; set; }
//        public int essence_294 { get; set; }
//        public int essence_295 { get; set; }
//        public int essence_296 { get; set; }
//        public int essence_297 { get; set; }
//        public int essence_298 { get; set; }
//        public int essence_299 { get; set; }
//        public int essence_300 { get; set; }
//        public int essence_301 { get; set; }
//        public int essence_302 { get; set; }
//        public int essence_303 { get; set; }
//        public int essence_304 { get; set; }
//        public int essence_305 { get; set; }
//        public int essence_306 { get; set; }
//        public int essence_307 { get; set; }
//        public int essence_308 { get; set; }
//        public int essence_309 { get; set; }
//        public int essence_310 { get; set; }
//        public int essence_311 { get; set; }
//        public int essence_312 { get; set; }
//        public int essence_313 { get; set; }
//        public int essence_314 { get; set; }
//        public int essence_315 { get; set; }
//        public int essence_316 { get; set; }
//        public int essence_317 { get; set; }
//        public int essence_318 { get; set; }
//        public int essence_319 { get; set; }
//        public int essence_320 { get; set; }
//        public int essence_321 { get; set; }
//        public int essence_322 { get; set; }
//        public int essence_323 { get; set; }
//        public int essence_324 { get; set; }
//        public int essence_325 { get; set; }
//        public int essence_326 { get; set; }
//        public int essence_327 { get; set; }
//        public int essence_328 { get; set; }
//        public int essence_329 { get; set; }
//        public int essence_330 { get; set; }
//        public int essence_331 { get; set; }
//        public int essence_332 { get; set; }
//        public int essence_333 { get; set; }
//        public int essence_334 { get; set; }
//        public int essence_335 { get; set; }
//        public int essence_336 { get; set; }
//        public int essence_337 { get; set; }
//        public int essence_338 { get; set; }
//        public int essence_339 { get; set; }
//        public int essence_340 { get; set; }
//        public int essence_341 { get; set; }
//        public int essence_342 { get; set; }
//        public int essence_343 { get; set; }
//        public int essence_344 { get; set; }
//        public int essence_345 { get; set; }
//        public int essence_346 { get; set; }
//        public int essence_347 { get; set; }
//        public int essence_348 { get; set; }
//        public int essence_349 { get; set; }
//        public int essence_350 { get; set; }
//        public int essence_351 { get; set; }
//        public int essence_352 { get; set; }
//        public int essence_353 { get; set; }
//        public int essence_354 { get; set; }
//        public int essence_355 { get; set; }
//        public int essence_356 { get; set; }
//        public int essence_357 { get; set; }
//        public int essence_358 { get; set; }
//        public int essence_359 { get; set; }
//        public int essence_360 { get; set; }
//        public int essence_361 { get; set; }
//        public int essence_362 { get; set; }
//        public int essence_363 { get; set; }
//        public int essence_364 { get; set; }
//        public int essence_365 { get; set; }
//        public int essence_366 { get; set; }
//        public int essence_367 { get; set; }
//        public int essence_368 { get; set; }
//        public int essence_369 { get; set; }
//        public int essence_370 { get; set; }
//        public int essence_371 { get; set; }
//        public int essence_372 { get; set; }
//        public int essence_373 { get; set; }
//        public int essence_374 { get; set; }
//        public int essence_375 { get; set; }
//        public int essence_376 { get; set; }
//        public int essence_377 { get; set; }
//        public int essence_378 { get; set; }
//        public int essence_379 { get; set; }
//        public int essence_380 { get; set; }
//        public int essence_381 { get; set; }
//        public int essence_382 { get; set; }
//        public int essence_383 { get; set; }
//        public int essence_384 { get; set; }
//        public int essence_385 { get; set; }
//        public int essence_386 { get; set; }
//        public int essence_387 { get; set; }
//        public int essence_388 { get; set; }
//        public int essence_389 { get; set; }
//        public int essence_390 { get; set; }
//        public int essence_391 { get; set; }
//        public int essence_392 { get; set; }
//        public int essence_393 { get; set; }
//        public int essence_394 { get; set; }
//        public int essence_395 { get; set; }
//        public int essence_396 { get; set; }
//        public int essence_397 { get; set; }
//        public int essence_398 { get; set; }
//        public int essence_399 { get; set; }
//        public int essence_400 { get; set; }
//        public int essence_401 { get; set; }
//        public int essence_402 { get; set; }
//        public int essence_403 { get; set; }
//        public int essence_404 { get; set; }
//        public int essence_405 { get; set; }
//        public int essence_406 { get; set; }
//        public int essence_407 { get; set; }
//        public int essence_408 { get; set; }
//        public int essence_409 { get; set; }
//        public int essence_410 { get; set; }
//        public int essence_411 { get; set; }
//        public int essence_412 { get; set; }
//        public int essence_413 { get; set; }
//        public int essence_414 { get; set; }
//        public int essence_415 { get; set; }
//        public int essence_416 { get; set; }
//        public int essence_417 { get; set; }
//        public int essence_418 { get; set; }
//        public int essence_419 { get; set; }
//        public int essence_420 { get; set; }
//        public int essence_421 { get; set; }
//        public int essence_422 { get; set; }
//        public int essence_423 { get; set; }
//        public int essence_424 { get; set; }
//        public int essence_425 { get; set; }
//        public int essence_426 { get; set; }
//        public int essence_427 { get; set; }
//        public int essence_428 { get; set; }
//        public int essence_429 { get; set; }
//        public int essence_430 { get; set; }
//        public int essence_431 { get; set; }
//        public int essence_432 { get; set; }
//        public int essence_433 { get; set; }
//        public int essence_434 { get; set; }
//        public int essence_435 { get; set; }
//        public int essence_436 { get; set; }
//        public int essence_437 { get; set; }
//        public int essence_438 { get; set; }
//        public int essence_439 { get; set; }
//        public int essence_440 { get; set; }
//        public int essence_441 { get; set; }
//        public int essence_442 { get; set; }
//        public int essence_443 { get; set; }
//        public int essence_444 { get; set; }
//        public int essence_445 { get; set; }
//        public int essence_446 { get; set; }
//        public int essence_447 { get; set; }
//        public int essence_448 { get; set; }
//        public int essence_449 { get; set; }
//        public int essence_450 { get; set; }
//        public int essence_451 { get; set; }
//        public int essence_452 { get; set; }
//        public int essence_453 { get; set; }
//        public int essence_454 { get; set; }
//        public int essence_455 { get; set; }
//        public int essence_456 { get; set; }
//        public int essence_457 { get; set; }
//        public int essence_458 { get; set; }
//        public int essence_459 { get; set; }
//        public int essence_460 { get; set; }
//        public int essence_461 { get; set; }
//        public int essence_462 { get; set; }
//        public int essence_463 { get; set; }
//        public int essence_464 { get; set; }
//        public int essence_465 { get; set; }
//        public int essence_466 { get; set; }
//        public int essence_467 { get; set; }
//        public int essence_468 { get; set; }
//        public int essence_469 { get; set; }
//        public int essence_470 { get; set; }
//        public int essence_471 { get; set; }
//        public int essence_472 { get; set; }
//        public int essence_473 { get; set; }
//        public int essence_474 { get; set; }
//        public int essence_475 { get; set; }
//        public int essence_476 { get; set; }
//        public int essence_477 { get; set; }
//        public int essence_478 { get; set; }
//        public int essence_479 { get; set; }
//        public int essence_480 { get; set; }
//        public int essence_481 { get; set; }
//        public int essence_482 { get; set; }
//        public int essence_483 { get; set; }
//        public int essence_484 { get; set; }
//        public int essence_485 { get; set; }
//        public int essence_486 { get; set; }
//        public int essence_487 { get; set; }
//        public int essence_488 { get; set; }
//        public int essence_489 { get; set; }
//        public int essence_490 { get; set; }
//        public int essence_491 { get; set; }
//        public int essence_492 { get; set; }
//        public int essence_493 { get; set; }
//        public int essence_494 { get; set; }
//        public int essence_495 { get; set; }
//        public int essence_496 { get; set; }
//        public int essence_497 { get; set; }
//        public int essence_498 { get; set; }
//        public int essence_499 { get; set; }
//        public int essence_500 { get; set; }
//        public int essence_501 { get; set; }
//        public int essence_502 { get; set; }
//        public int essence_503 { get; set; }
//        public int essence_504 { get; set; }
//        public int essence_505 { get; set; }
//        public int essence_506 { get; set; }
//        public int essence_507 { get; set; }
//        public int essence_508 { get; set; }
//        public int essence_509 { get; set; }
//        public int essence_510 { get; set; }
//        public int essence_511 { get; set; }
//        public int essence_512 { get; set; }
//        public int recipe_1 { get; set; }
//        public int recipe_2 { get; set; }
//        public int recipe_3 { get; set; }
//        public int recipe_4 { get; set; }
//        public int recipe_5 { get; set; }
//        public int recipe_6 { get; set; }
//        public int recipe_7 { get; set; }
//        public int recipe_8 { get; set; }
//        public int recipe_9 { get; set; }
//        public int recipe_10 { get; set; }
//        public int recipe_11 { get; set; }
//        public int recipe_12 { get; set; }
//        public int recipe_13 { get; set; }
//        public int recipe_14 { get; set; }
//        public int recipe_15 { get; set; }
//        public int recipe_16 { get; set; }
//        public int recipe_17 { get; set; }
//        public int recipe_18 { get; set; }
//        public int recipe_19 { get; set; }
//        public int recipe_20 { get; set; }
//        public int recipe_21 { get; set; }
//        public int recipe_22 { get; set; }
//        public int recipe_23 { get; set; }
//        public int recipe_24 { get; set; }
//        public int recipe_25 { get; set; }
//        public int recipe_26 { get; set; }
//        public int recipe_27 { get; set; }
//        public int recipe_28 { get; set; }
//        public int recipe_29 { get; set; }
//        public int recipe_30 { get; set; }
//        public int recipe_31 { get; set; }
//        public int recipe_32 { get; set; }
//        public int recipe_33 { get; set; }
//        public int recipe_34 { get; set; }
//        public int recipe_35 { get; set; }
//        public int recipe_36 { get; set; }
//        public int recipe_37 { get; set; }
//        public int recipe_38 { get; set; }
//        public int recipe_39 { get; set; }
//        public int recipe_40 { get; set; }
//        public int recipe_41 { get; set; }
//        public int recipe_42 { get; set; }
//        public int recipe_43 { get; set; }
//        public int recipe_44 { get; set; }
//        public int recipe_45 { get; set; }
//        public int recipe_46 { get; set; }
//        public int recipe_47 { get; set; }
//        public int recipe_48 { get; set; }
//        public int recipe_49 { get; set; }
//        public int recipe_50 { get; set; }
//        public int recipe_51 { get; set; }
//        public int recipe_52 { get; set; }
//        public int recipe_53 { get; set; }
//        public int recipe_54 { get; set; }
//        public int recipe_55 { get; set; }
//        public int recipe_56 { get; set; }
//        public int recipe_57 { get; set; }
//        public int recipe_58 { get; set; }
//        public int recipe_59 { get; set; }
//        public int recipe_60 { get; set; }
//        public int recipe_61 { get; set; }
//        public int recipe_62 { get; set; }
//        public int recipe_63 { get; set; }
//        public int recipe_64 { get; set; }
//        public int recipe_65 { get; set; }
//        public int recipe_66 { get; set; }
//        public int recipe_67 { get; set; }
//        public int recipe_68 { get; set; }
//        public int recipe_69 { get; set; }
//        public int recipe_70 { get; set; }
//        public int recipe_71 { get; set; }
//        public int recipe_72 { get; set; }
//        public int recipe_73 { get; set; }
//        public int recipe_74 { get; set; }
//        public int recipe_75 { get; set; }
//        public int recipe_76 { get; set; }
//        public int recipe_77 { get; set; }
//        public int recipe_78 { get; set; }
//        public int recipe_79 { get; set; }
//        public int recipe_80 { get; set; }
//        public int recipe_81 { get; set; }
//        public int recipe_82 { get; set; }
//        public int recipe_83 { get; set; }
//        public int recipe_84 { get; set; }
//        public int recipe_85 { get; set; }
//        public int recipe_86 { get; set; }
//        public int recipe_87 { get; set; }
//        public int recipe_88 { get; set; }
//        public int recipe_89 { get; set; }
//        public int recipe_90 { get; set; }
//        public int recipe_91 { get; set; }
//        public int recipe_92 { get; set; }
//        public int recipe_93 { get; set; }
//        public int recipe_94 { get; set; }
//        public int recipe_95 { get; set; }
//        public int recipe_96 { get; set; }
//        public int recipe_97 { get; set; }
//        public int recipe_98 { get; set; }
//        public int recipe_99 { get; set; }
//        public int recipe_100 { get; set; }
//        public int recipe_101 { get; set; }
//        public int recipe_102 { get; set; }
//        public int recipe_103 { get; set; }
//        public int recipe_104 { get; set; }
//        public int recipe_105 { get; set; }
//        public int recipe_106 { get; set; }
//        public int recipe_107 { get; set; }
//        public int recipe_108 { get; set; }
//        public int recipe_109 { get; set; }
//        public int recipe_110 { get; set; }
//        public int recipe_111 { get; set; }
//        public int recipe_112 { get; set; }
//        public int recipe_113 { get; set; }
//        public int recipe_114 { get; set; }
//        public int recipe_115 { get; set; }
//        public int recipe_116 { get; set; }
//        public int recipe_117 { get; set; }
//        public int recipe_118 { get; set; }
//        public int recipe_119 { get; set; }
//        public int recipe_120 { get; set; }
//        public int recipe_121 { get; set; }
//        public int recipe_122 { get; set; }
//        public int recipe_123 { get; set; }
//        public int recipe_124 { get; set; }
//        public int recipe_125 { get; set; }
//        public int recipe_126 { get; set; }
//        public int recipe_127 { get; set; }
//        public int recipe_128 { get; set; }
//        public int task_1 { get; set; }
//        public int task_2 { get; set; }
//        public int task_3 { get; set; }
//        public int task_4 { get; set; }
//        public int task_5 { get; set; }
//        public int task_6 { get; set; }
//        public int task_7 { get; set; }
//        public int task_8 { get; set; }
//        public int task_9 { get; set; }
//        public int task_10 { get; set; }
//        public int task_11 { get; set; }
//        public int task_12 { get; set; }
//        public int task_13 { get; set; }
//        public int task_14 { get; set; }
//        public int task_15 { get; set; }
//        public int task_16 { get; set; }
//        public int task_17 { get; set; }
//        public int task_18 { get; set; }
//        public int task_19 { get; set; }
//        public int task_20 { get; set; }
//        public int task_21 { get; set; }
//        public int task_22 { get; set; }
//        public int task_23 { get; set; }
//        public int task_24 { get; set; }
//        public int task_25 { get; set; }
//        public int task_26 { get; set; }
//        public int task_27 { get; set; }
//        public int task_28 { get; set; }
//        public int task_29 { get; set; }
//        public int task_30 { get; set; }
//        public int task_31 { get; set; }
//        public int task_32 { get; set; }
//        public int task_33 { get; set; }
//        public int task_34 { get; set; }
//        public int task_35 { get; set; }
//        public int task_36 { get; set; }
//        public int task_37 { get; set; }
//        public int task_38 { get; set; }
//        public int task_39 { get; set; }
//        public int task_40 { get; set; }
//        public int task_41 { get; set; }
//        public int task_42 { get; set; }
//        public int task_43 { get; set; }
//        public int task_44 { get; set; }
//        public int task_45 { get; set; }
//        public int task_46 { get; set; }
//        public int task_47 { get; set; }
//        public int task_48 { get; set; }
//        public int task_49 { get; set; }
//        public int task_50 { get; set; }
//        public int task_51 { get; set; }
//        public int task_52 { get; set; }
//        public int task_53 { get; set; }
//        public int task_54 { get; set; }
//        public int task_55 { get; set; }
//        public int task_56 { get; set; }
//        public int task_57 { get; set; }
//        public int task_58 { get; set; }
//        public int task_59 { get; set; }
//        public int task_60 { get; set; }
//        public int task_61 { get; set; }
//        public int task_62 { get; set; }
//        public int task_63 { get; set; }
//        public int task_64 { get; set; }
//        public int task_65 { get; set; }
//        public int task_66 { get; set; }
//        public int task_67 { get; set; }
//        public int task_68 { get; set; }
//        public int task_69 { get; set; }
//        public int task_70 { get; set; }
//        public int task_71 { get; set; }
//        public int task_72 { get; set; }
//        public int task_73 { get; set; }
//        public int task_74 { get; set; }
//        public int task_75 { get; set; }
//        public int task_76 { get; set; }
//        public int task_77 { get; set; }
//        public int task_78 { get; set; }
//        public int task_79 { get; set; }
//        public int task_80 { get; set; }
//        public int task_81 { get; set; }
//        public int task_82 { get; set; }
//        public int task_83 { get; set; }
//        public int task_84 { get; set; }
//        public int task_85 { get; set; }
//        public int task_86 { get; set; }
//        public int task_87 { get; set; }
//        public int task_88 { get; set; }
//        public int task_89 { get; set; }
//        public int task_90 { get; set; }
//        public int task_91 { get; set; }
//        public int task_92 { get; set; }
//        public int task_93 { get; set; }
//        public int task_94 { get; set; }
//        public int task_95 { get; set; }
//        public int task_96 { get; set; }
//        public int task_97 { get; set; }
//        public int task_98 { get; set; }
//        public int task_99 { get; set; }
//        public int task_100 { get; set; }
//        public int task_101 { get; set; }
//        public int task_102 { get; set; }
//        public int task_103 { get; set; }
//        public int task_104 { get; set; }
//        public int task_105 { get; set; }
//        public int task_106 { get; set; }
//        public int task_107 { get; set; }
//        public int task_108 { get; set; }
//        public int task_109 { get; set; }
//        public int task_110 { get; set; }
//        public int task_111 { get; set; }
//        public int task_112 { get; set; }
//        public int task_113 { get; set; }
//        public int task_114 { get; set; }
//        public int task_115 { get; set; }
//        public int task_116 { get; set; }
//        public int task_117 { get; set; }
//        public int task_118 { get; set; }
//        public int task_119 { get; set; }
//        public int task_120 { get; set; }
//        public int task_121 { get; set; }
//        public int task_122 { get; set; }
//        public int task_123 { get; set; }
//        public int task_124 { get; set; }
//        public int task_125 { get; set; }
//        public int task_126 { get; set; }
//        public int task_127 { get; set; }
//        public int task_128 { get; set; }
//        public int task_129 { get; set; }
//        public int task_130 { get; set; }
//        public int task_131 { get; set; }
//        public int task_132 { get; set; }
//        public int task_133 { get; set; }
//        public int task_134 { get; set; }
//        public int task_135 { get; set; }
//        public int task_136 { get; set; }
//        public int task_137 { get; set; }
//        public int task_138 { get; set; }
//        public int task_139 { get; set; }
//        public int task_140 { get; set; }
//        public int task_141 { get; set; }
//        public int task_142 { get; set; }
//        public int task_143 { get; set; }
//        public int task_144 { get; set; }
//        public int task_145 { get; set; }
//        public int task_146 { get; set; }
//        public int task_147 { get; set; }
//        public int task_148 { get; set; }
//        public int task_149 { get; set; }
//        public int task_150 { get; set; }
//        public int task_151 { get; set; }
//        public int task_152 { get; set; }
//        public int task_153 { get; set; }
//        public int task_154 { get; set; }
//        public int task_155 { get; set; }
//        public int task_156 { get; set; }
//        public int task_157 { get; set; }
//        public int task_158 { get; set; }
//        public int task_159 { get; set; }
//        public int task_160 { get; set; }
//        public int task_161 { get; set; }
//        public int task_162 { get; set; }
//        public int task_163 { get; set; }
//        public int task_164 { get; set; }
//        public int task_165 { get; set; }
//        public int task_166 { get; set; }
//        public int task_167 { get; set; }
//        public int task_168 { get; set; }
//        public int task_169 { get; set; }
//        public int task_170 { get; set; }
//        public int task_171 { get; set; }
//        public int task_172 { get; set; }
//        public int task_173 { get; set; }
//        public int task_174 { get; set; }
//        public int task_175 { get; set; }
//        public int task_176 { get; set; }
//        public int task_177 { get; set; }
//        public int task_178 { get; set; }
//        public int task_179 { get; set; }
//        public int task_180 { get; set; }
//        public int task_181 { get; set; }
//        public int task_182 { get; set; }
//        public int task_183 { get; set; }
//        public int task_184 { get; set; }
//        public int task_185 { get; set; }
//        public int task_186 { get; set; }
//        public int task_187 { get; set; }
//        public int task_188 { get; set; }
//        public int task_189 { get; set; }
//        public int task_190 { get; set; }
//        public int task_191 { get; set; }
//        public int task_192 { get; set; }
//        public int task_193 { get; set; }
//        public int task_194 { get; set; }
//        public int task_195 { get; set; }
//        public int task_196 { get; set; }
//        public int task_197 { get; set; }
//        public int task_198 { get; set; }
//        public int task_199 { get; set; }
//        public int task_200 { get; set; }
//        public int task_201 { get; set; }
//        public int task_202 { get; set; }
//        public int task_203 { get; set; }
//        public int task_204 { get; set; }
//        public int task_205 { get; set; }
//        public int task_206 { get; set; }
//        public int task_207 { get; set; }
//        public int task_208 { get; set; }
//        public int task_209 { get; set; }
//        public int task_210 { get; set; }
//        public int task_211 { get; set; }
//        public int task_212 { get; set; }
//        public int task_213 { get; set; }
//        public int task_214 { get; set; }
//        public int task_215 { get; set; }
//        public int task_216 { get; set; }
//        public int task_217 { get; set; }
//        public int task_218 { get; set; }
//        public int task_219 { get; set; }
//        public int task_220 { get; set; }
//        public int task_221 { get; set; }
//        public int task_222 { get; set; }
//        public int task_223 { get; set; }
//        public int task_224 { get; set; }
//        public int task_225 { get; set; }
//        public int task_226 { get; set; }
//        public int task_227 { get; set; }
//        public int task_228 { get; set; }
//        public int task_229 { get; set; }
//        public int task_230 { get; set; }
//        public int task_231 { get; set; }
//        public int task_232 { get; set; }
//        public int task_233 { get; set; }
//        public int task_234 { get; set; }
//        public int task_235 { get; set; }
//        public int task_236 { get; set; }
//        public int task_237 { get; set; }
//        public int task_238 { get; set; }
//        public int task_239 { get; set; }
//        public int task_240 { get; set; }
//        public int task_241 { get; set; }
//        public int task_242 { get; set; }
//        public int task_243 { get; set; }
//        public int task_244 { get; set; }
//        public int task_245 { get; set; }
//        public int task_246 { get; set; }
//        public int task_247 { get; set; }
//        public int task_248 { get; set; }
//        public int task_249 { get; set; }
//        public int task_250 { get; set; }
//        public int task_251 { get; set; }
//        public int task_252 { get; set; }
//        public int task_253 { get; set; }
//        public int task_254 { get; set; }
//        public int task_255 { get; set; }
//        public int task_256 { get; set; }
//        public int task_257 { get; set; }
//        public int task_258 { get; set; }
//        public int task_259 { get; set; }
//        public int task_260 { get; set; }
//        public int task_261 { get; set; }
//        public int task_262 { get; set; }
//        public int task_263 { get; set; }
//        public int task_264 { get; set; }
//        public int task_265 { get; set; }
//        public int task_266 { get; set; }
//        public int task_267 { get; set; }
//        public int task_268 { get; set; }
//        public int task_269 { get; set; }
//        public int task_270 { get; set; }
//        public int task_271 { get; set; }
//        public int task_272 { get; set; }
//        public int task_273 { get; set; }
//        public int task_274 { get; set; }
//        public int task_275 { get; set; }
//        public int task_276 { get; set; }
//        public int task_277 { get; set; }
//        public int task_278 { get; set; }
//        public int task_279 { get; set; }
//        public int task_280 { get; set; }
//        public int task_281 { get; set; }
//        public int task_282 { get; set; }
//        public int task_283 { get; set; }
//        public int task_284 { get; set; }
//        public int task_285 { get; set; }
//        public int task_286 { get; set; }
//        public int task_287 { get; set; }
//        public int task_288 { get; set; }
//        public int task_289 { get; set; }
//        public int task_290 { get; set; }
//        public int task_291 { get; set; }
//        public int task_292 { get; set; }
//        public int task_293 { get; set; }
//        public int task_294 { get; set; }
//        public int task_295 { get; set; }
//        public int task_296 { get; set; }
//        public int task_297 { get; set; }
//        public int task_298 { get; set; }
//        public int task_299 { get; set; }
//        public int task_300 { get; set; }
//        public int task_301 { get; set; }
//        public int task_302 { get; set; }
//        public int task_303 { get; set; }
//        public int task_304 { get; set; }
//        public int task_305 { get; set; }
//        public int task_306 { get; set; }
//        public int task_307 { get; set; }
//        public int task_308 { get; set; }
//        public int task_309 { get; set; }
//        public int task_310 { get; set; }
//        public int task_311 { get; set; }
//        public int task_312 { get; set; }
//        public int task_313 { get; set; }
//        public int task_314 { get; set; }
//        public int task_315 { get; set; }
//        public int task_316 { get; set; }
//        public int task_317 { get; set; }
//        public int task_318 { get; set; }
//        public int task_319 { get; set; }
//        public int task_320 { get; set; }
//        public int task_321 { get; set; }
//        public int task_322 { get; set; }
//        public int task_323 { get; set; }
//        public int task_324 { get; set; }
//        public int task_325 { get; set; }
//        public int task_326 { get; set; }
//        public int task_327 { get; set; }
//        public int task_328 { get; set; }
//        public int task_329 { get; set; }
//        public int task_330 { get; set; }
//        public int task_331 { get; set; }
//        public int task_332 { get; set; }
//        public int task_333 { get; set; }
//        public int task_334 { get; set; }
//        public int task_335 { get; set; }
//        public int task_336 { get; set; }
//        public int task_337 { get; set; }
//        public int task_338 { get; set; }
//        public int task_339 { get; set; }
//        public int task_340 { get; set; }
//        public int task_341 { get; set; }
//        public int task_342 { get; set; }
//        public int task_343 { get; set; }
//        public int task_344 { get; set; }
//        public int task_345 { get; set; }
//        public int task_346 { get; set; }
//        public int task_347 { get; set; }
//        public int task_348 { get; set; }
//        public int task_349 { get; set; }
//        public int task_350 { get; set; }
//        public int task_351 { get; set; }
//        public int task_352 { get; set; }
//        public int task_353 { get; set; }
//        public int task_354 { get; set; }
//        public int task_355 { get; set; }
//        public int task_356 { get; set; }
//        public int task_357 { get; set; }
//        public int task_358 { get; set; }
//        public int task_359 { get; set; }
//        public int task_360 { get; set; }
//        public int task_361 { get; set; }
//        public int task_362 { get; set; }
//        public int task_363 { get; set; }
//        public int task_364 { get; set; }
//        public int task_365 { get; set; }
//        public int task_366 { get; set; }
//        public int task_367 { get; set; }
//        public int task_368 { get; set; }
//        public int task_369 { get; set; }
//        public int task_370 { get; set; }
//        public int task_371 { get; set; }
//        public int task_372 { get; set; }
//        public int task_373 { get; set; }
//        public int task_374 { get; set; }
//        public int task_375 { get; set; }
//        public int task_376 { get; set; }
//        public int task_377 { get; set; }
//        public int task_378 { get; set; }
//        public int task_379 { get; set; }
//        public int task_380 { get; set; }
//        public int task_381 { get; set; }
//        public int task_382 { get; set; }
//        public int task_383 { get; set; }
//        public int task_384 { get; set; }
//        public int task_385 { get; set; }
//        public int task_386 { get; set; }
//        public int task_387 { get; set; }
//        public int task_388 { get; set; }
//        public int task_389 { get; set; }
//        public int task_390 { get; set; }
//        public int task_391 { get; set; }
//        public int task_392 { get; set; }
//        public int task_393 { get; set; }
//        public int task_394 { get; set; }
//        public int task_395 { get; set; }
//        public int task_396 { get; set; }
//        public int task_397 { get; set; }
//        public int task_398 { get; set; }
//        public int task_399 { get; set; }
//        public int task_400 { get; set; }
//        public int task_401 { get; set; }
//        public int task_402 { get; set; }
//        public int task_403 { get; set; }
//        public int task_404 { get; set; }
//        public int task_405 { get; set; }
//        public int task_406 { get; set; }
//        public int task_407 { get; set; }
//        public int task_408 { get; set; }
//        public int task_409 { get; set; }
//        public int task_410 { get; set; }
//        public int task_411 { get; set; }
//        public int task_412 { get; set; }
//        public int task_413 { get; set; }
//        public int task_414 { get; set; }
//        public int task_415 { get; set; }
//        public int task_416 { get; set; }
//        public int task_417 { get; set; }
//        public int task_418 { get; set; }
//        public int task_419 { get; set; }
//        public int task_420 { get; set; }
//        public int task_421 { get; set; }
//        public int task_422 { get; set; }
//        public int task_423 { get; set; }
//        public int task_424 { get; set; }
//        public int task_425 { get; set; }
//        public int task_426 { get; set; }
//        public int task_427 { get; set; }
//        public int task_428 { get; set; }
//        public int task_429 { get; set; }
//        public int task_430 { get; set; }
//        public int task_431 { get; set; }
//        public int task_432 { get; set; }
//        public int task_433 { get; set; }
//        public int task_434 { get; set; }
//        public int task_435 { get; set; }
//        public int task_436 { get; set; }
//        public int task_437 { get; set; }
//        public int task_438 { get; set; }
//        public int task_439 { get; set; }
//        public int task_440 { get; set; }
//        public int task_441 { get; set; }
//        public int task_442 { get; set; }
//        public int task_443 { get; set; }
//        public int task_444 { get; set; }
//        public int task_445 { get; set; }
//        public int task_446 { get; set; }
//        public int task_447 { get; set; }
//        public int task_448 { get; set; }
//        public int task_449 { get; set; }
//        public int task_450 { get; set; }
//        public int task_451 { get; set; }
//        public int task_452 { get; set; }
//        public int task_453 { get; set; }
//        public int task_454 { get; set; }
//        public int task_455 { get; set; }
//        public int task_456 { get; set; }
//        public int task_457 { get; set; }
//        public int task_458 { get; set; }
//        public int task_459 { get; set; }
//        public int task_460 { get; set; }
//        public int task_461 { get; set; }
//        public int task_462 { get; set; }
//        public int task_463 { get; set; }
//        public int task_464 { get; set; }
//        public int task_465 { get; set; }
//        public int task_466 { get; set; }
//        public int task_467 { get; set; }
//        public int task_468 { get; set; }
//        public int task_469 { get; set; }
//        public int task_470 { get; set; }
//        public int task_471 { get; set; }
//        public int task_472 { get; set; }
//        public int task_473 { get; set; }
//        public int task_474 { get; set; }
//        public int task_475 { get; set; }
//        public int task_476 { get; set; }
//        public int task_477 { get; set; }
//        public int task_478 { get; set; }
//        public int task_479 { get; set; }
//        public int task_480 { get; set; }
//        public int task_481 { get; set; }
//        public int task_482 { get; set; }
//        public int task_483 { get; set; }
//        public int task_484 { get; set; }
//        public int task_485 { get; set; }
//        public int task_486 { get; set; }
//        public int task_487 { get; set; }
//        public int task_488 { get; set; }
//        public int task_489 { get; set; }
//        public int task_490 { get; set; }
//        public int task_491 { get; set; }
//        public int task_492 { get; set; }
//        public int task_493 { get; set; }
//        public int task_494 { get; set; }
//        public int task_495 { get; set; }
//        public int task_496 { get; set; }
//        public int task_497 { get; set; }
//        public int task_498 { get; set; }
//        public int task_499 { get; set; }
//        public int task_500 { get; set; }
//        public int task_501 { get; set; }
//        public int task_502 { get; set; }
//        public int task_503 { get; set; }
//        public int task_504 { get; set; }
//        public int task_505 { get; set; }
//        public int task_506 { get; set; }
//        public int task_507 { get; set; }
//        public int task_508 { get; set; }
//        public int task_509 { get; set; }
//        public int task_510 { get; set; }
//        public int task_511 { get; set; }
//        public int task_512 { get; set; }
//        public int skill_1 { get; set; }
//        public int skill_2 { get; set; }
//        public int skill_3 { get; set; }
//        public int skill_4 { get; set; }
//        public int skill_5 { get; set; }
//        public int skill_6 { get; set; }
//        public int skill_7 { get; set; }
//        public int skill_8 { get; set; }
//        public int skill_9 { get; set; }
//        public int skill_10 { get; set; }
//        public int skill_11 { get; set; }
//        public int skill_12 { get; set; }
//        public int skill_13 { get; set; }
//        public int skill_14 { get; set; }
//        public int skill_15 { get; set; }
//        public int skill_16 { get; set; }
//        public int skill_17 { get; set; }
//        public int skill_18 { get; set; }
//        public int skill_19 { get; set; }
//        public int skill_20 { get; set; }
//        public int skill_21 { get; set; }
//        public int skill_22 { get; set; }
//        public int skill_23 { get; set; }
//        public int skill_24 { get; set; }
//        public int skill_25 { get; set; }
//        public int skill_26 { get; set; }
//        public int skill_27 { get; set; }
//        public int skill_28 { get; set; }
//        public int skill_29 { get; set; }
//        public int skill_30 { get; set; }
//        public int skill_31 { get; set; }
//        public int skill_32 { get; set; }
//        public int skill_33 { get; set; }
//        public int skill_34 { get; set; }
//        public int skill_35 { get; set; }
//        public int skill_36 { get; set; }
//        public int skill_37 { get; set; }
//        public int skill_38 { get; set; }
//        public int skill_39 { get; set; }
//        public int skill_40 { get; set; }
//        public int skill_41 { get; set; }
//        public int skill_42 { get; set; }
//        public int skill_43 { get; set; }
//        public int skill_44 { get; set; }
//        public int skill_45 { get; set; }
//        public int skill_46 { get; set; }
//        public int skill_47 { get; set; }
//        public int skill_48 { get; set; }
//        public int skill_49 { get; set; }
//        public int skill_50 { get; set; }
//        public int skill_51 { get; set; }
//        public int skill_52 { get; set; }
//        public int skill_53 { get; set; }
//        public int skill_54 { get; set; }
//        public int skill_55 { get; set; }
//        public int skill_56 { get; set; }
//        public int skill_57 { get; set; }
//        public int skill_58 { get; set; }
//        public int skill_59 { get; set; }
//        public int skill_60 { get; set; }
//        public int skill_61 { get; set; }
//        public int skill_62 { get; set; }
//        public int skill_63 { get; set; }
//        public int skill_64 { get; set; }
//        public int skill_65 { get; set; }
//        public int skill_66 { get; set; }
//        public int skill_67 { get; set; }
//        public int skill_68 { get; set; }
//        public int skill_69 { get; set; }
//        public int skill_70 { get; set; }
//        public int skill_71 { get; set; }
//        public int skill_72 { get; set; }
//        public int skill_73 { get; set; }
//        public int skill_74 { get; set; }
//        public int skill_75 { get; set; }
//        public int skill_76 { get; set; }
//        public int skill_77 { get; set; }
//        public int skill_78 { get; set; }
//        public int skill_79 { get; set; }
//        public int skill_80 { get; set; }
//        public int skill_81 { get; set; }
//        public int skill_82 { get; set; }
//        public int skill_83 { get; set; }
//        public int skill_84 { get; set; }
//        public int skill_85 { get; set; }
//        public int skill_86 { get; set; }
//        public int skill_87 { get; set; }
//        public int skill_88 { get; set; }
//        public int skill_89 { get; set; }
//        public int skill_90 { get; set; }
//        public int skill_91 { get; set; }
//        public int skill_92 { get; set; }
//        public int skill_93 { get; set; }
//        public int skill_94 { get; set; }
//        public int skill_95 { get; set; }
//        public int skill_96 { get; set; }
//        public int skill_97 { get; set; }
//        public int skill_98 { get; set; }
//        public int skill_99 { get; set; }
//        public int skill_100 { get; set; }
//        public int skill_101 { get; set; }
//        public int skill_102 { get; set; }
//        public int skill_103 { get; set; }
//        public int skill_104 { get; set; }
//        public int skill_105 { get; set; }
//        public int skill_106 { get; set; }
//        public int skill_107 { get; set; }
//        public int skill_108 { get; set; }
//        public int skill_109 { get; set; }
//        public int skill_110 { get; set; }
//        public int skill_111 { get; set; }
//        public int skill_112 { get; set; }
//        public int skill_113 { get; set; }
//        public int skill_114 { get; set; }
//        public int skill_115 { get; set; }
//        public int skill_116 { get; set; }
//        public int skill_117 { get; set; }
//        public int skill_118 { get; set; }
//        public int skill_119 { get; set; }
//        public int skill_120 { get; set; }
//        public int skill_121 { get; set; }
//        public int skill_122 { get; set; }
//        public int skill_123 { get; set; }
//        public int skill_124 { get; set; }
//        public int skill_125 { get; set; }
//        public int skill_126 { get; set; }
//        public int skill_127 { get; set; }
//        public int skill_128 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FORCE_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int color { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
//        public byte[] desc;

//        public string Desc
//        {
//            get => Structure.Unicode.GetString(desc);
//            set { desc = BinReader.FillArray(Structure.Unicode.GetBytes(value), 512); }
//        }

//        public int reputation_max { get; set; }
//        public int contribution_max { get; set; }
//        public int join_money_cost { get; set; }
//        public int join_item_cost { get; set; }
//        public int quit_repution_cost { get; set; }
//        public int quit_contribution_cost { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class FORCE_TOKEN_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int require_force { get; set; }
//        public int reputation_add { get; set; }
//        public int reputation_increase_ratio { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class NPC_FORCE_SERVICE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int force_id { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class PLAYER_DEATH_DROP_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int itemlist_1 { get; set; }
//        public int itemlist_2 { get; set; }
//        public int itemlist_3 { get; set; }
//        public int itemlist_4 { get; set; }
//        public int itemlist_5 { get; set; }
//        public int itemlist_6 { get; set; }
//        public int itemlist_7 { get; set; }
//        public int itemlist_8 { get; set; }
//        public int itemlist_9 { get; set; }
//        public int itemlist_10 { get; set; }
//        public int itemlist_11 { get; set; }
//        public int itemlist_12 { get; set; }
//        public int itemlist_13 { get; set; }
//        public int itemlist_14 { get; set; }
//        public int itemlist_15 { get; set; }
//        public int itemlist_16 { get; set; }
//        public int itemlist_17 { get; set; }
//        public int itemlist_18 { get; set; }
//        public int itemlist_19 { get; set; }
//        public int itemlist_20 { get; set; }
//        public int itemlist_21 { get; set; }
//        public int itemlist_22 { get; set; }
//        public int itemlist_23 { get; set; }
//        public int itemlist_24 { get; set; }
//        public int itemlist_25 { get; set; }
//        public int itemlist_26 { get; set; }
//        public int itemlist_27 { get; set; }
//        public int itemlist_28 { get; set; }
//        public int itemlist_29 { get; set; }
//        public int itemlist_30 { get; set; }
//        public int itemlist_31 { get; set; }
//        public int itemlist_32 { get; set; }
//        public int itemlist_33 { get; set; }
//        public int itemlist_34 { get; set; }
//        public int itemlist_35 { get; set; }
//        public int itemlist_36 { get; set; }
//        public int itemlist_37 { get; set; }
//        public int itemlist_38 { get; set; }
//        public int itemlist_39 { get; set; }
//        public int itemlist_40 { get; set; }
//        public int itemlist_41 { get; set; }
//        public int itemlist_42 { get; set; }
//        public int itemlist_43 { get; set; }
//        public int itemlist_44 { get; set; }
//        public int itemlist_45 { get; set; }
//        public int itemlist_46 { get; set; }
//        public int itemlist_47 { get; set; }
//        public int itemlist_48 { get; set; }
//        public int itemlist_49 { get; set; }
//        public int itemlist_50 { get; set; }
//        public int itemlist_51 { get; set; }
//        public int itemlist_52 { get; set; }
//        public int itemlist_53 { get; set; }
//        public int itemlist_54 { get; set; }
//        public int itemlist_55 { get; set; }
//        public int itemlist_56 { get; set; }
//        public int itemlist_57 { get; set; }
//        public int itemlist_58 { get; set; }
//        public int itemlist_59 { get; set; }
//        public int itemlist_60 { get; set; }
//        public int itemlist_61 { get; set; }
//        public int itemlist_62 { get; set; }
//        public int itemlist_63 { get; set; }
//        public int itemlist_64 { get; set; }
//        public int itemlist_65 { get; set; }
//        public int itemlist_66 { get; set; }
//        public int itemlist_67 { get; set; }
//        public int itemlist_68 { get; set; }
//        public int itemlist_69 { get; set; }
//        public int itemlist_70 { get; set; }
//        public int itemlist_71 { get; set; }
//        public int itemlist_72 { get; set; }
//        public int itemlist_73 { get; set; }
//        public int itemlist_74 { get; set; }
//        public int itemlist_75 { get; set; }
//        public int itemlist_76 { get; set; }
//        public int itemlist_77 { get; set; }
//        public int itemlist_78 { get; set; }
//        public int itemlist_79 { get; set; }
//        public int itemlist_80 { get; set; }
//        public int itemlist_81 { get; set; }
//        public int itemlist_82 { get; set; }
//        public int itemlist_83 { get; set; }
//        public int itemlist_84 { get; set; }
//        public int itemlist_85 { get; set; }
//        public int itemlist_86 { get; set; }
//        public int itemlist_87 { get; set; }
//        public int itemlist_88 { get; set; }
//        public int itemlist_89 { get; set; }
//        public int itemlist_90 { get; set; }
//        public int itemlist_91 { get; set; }
//        public int itemlist_92 { get; set; }
//        public int itemlist_93 { get; set; }
//        public int itemlist_94 { get; set; }
//        public int itemlist_95 { get; set; }
//        public int itemlist_96 { get; set; }
//        public int itemlist_97 { get; set; }
//        public int itemlist_98 { get; set; }
//        public int itemlist_99 { get; set; }
//        public int itemlist_100 { get; set; }
//        public int itemlist_101 { get; set; }
//        public int itemlist_102 { get; set; }
//        public int itemlist_103 { get; set; }
//        public int itemlist_104 { get; set; }
//        public int itemlist_105 { get; set; }
//        public int itemlist_106 { get; set; }
//        public int itemlist_107 { get; set; }
//        public int itemlist_108 { get; set; }
//        public int itemlist_109 { get; set; }
//        public int itemlist_110 { get; set; }
//        public int itemlist_111 { get; set; }
//        public int itemlist_112 { get; set; }
//        public int itemlist_113 { get; set; }
//        public int itemlist_114 { get; set; }
//        public int itemlist_115 { get; set; }
//        public int itemlist_116 { get; set; }
//        public int itemlist_117 { get; set; }
//        public int itemlist_118 { get; set; }
//        public int itemlist_119 { get; set; }
//        public int itemlist_120 { get; set; }
//        public int itemlist_121 { get; set; }
//        public int itemlist_122 { get; set; }
//        public int itemlist_123 { get; set; }
//        public int itemlist_124 { get; set; }
//        public int itemlist_125 { get; set; }
//        public int itemlist_126 { get; set; }
//        public int itemlist_127 { get; set; }
//        public int itemlist_128 { get; set; }
//        public int itemlist_129 { get; set; }
//        public int itemlist_130 { get; set; }
//        public int itemlist_131 { get; set; }
//        public int itemlist_132 { get; set; }
//        public int itemlist_133 { get; set; }
//        public int itemlist_134 { get; set; }
//        public int itemlist_135 { get; set; }
//        public int itemlist_136 { get; set; }
//        public int itemlist_137 { get; set; }
//        public int itemlist_138 { get; set; }
//        public int itemlist_139 { get; set; }
//        public int itemlist_140 { get; set; }
//        public int itemlist_141 { get; set; }
//        public int itemlist_142 { get; set; }
//        public int itemlist_143 { get; set; }
//        public int itemlist_144 { get; set; }
//        public int itemlist_145 { get; set; }
//        public int itemlist_146 { get; set; }
//        public int itemlist_147 { get; set; }
//        public int itemlist_148 { get; set; }
//        public int itemlist_149 { get; set; }
//        public int itemlist_150 { get; set; }
//        public int itemlist_151 { get; set; }
//        public int itemlist_152 { get; set; }
//        public int itemlist_153 { get; set; }
//        public int itemlist_154 { get; set; }
//        public int itemlist_155 { get; set; }
//        public int itemlist_156 { get; set; }
//        public int itemlist_157 { get; set; }
//        public int itemlist_158 { get; set; }
//        public int itemlist_159 { get; set; }
//        public int itemlist_160 { get; set; }
//        public int itemlist_161 { get; set; }
//        public int itemlist_162 { get; set; }
//        public int itemlist_163 { get; set; }
//        public int itemlist_164 { get; set; }
//        public int itemlist_165 { get; set; }
//        public int itemlist_166 { get; set; }
//        public int itemlist_167 { get; set; }
//        public int itemlist_168 { get; set; }
//        public int itemlist_169 { get; set; }
//        public int itemlist_170 { get; set; }
//        public int itemlist_171 { get; set; }
//        public int itemlist_172 { get; set; }
//        public int itemlist_173 { get; set; }
//        public int itemlist_174 { get; set; }
//        public int itemlist_175 { get; set; }
//        public int itemlist_176 { get; set; }
//        public int itemlist_177 { get; set; }
//        public int itemlist_178 { get; set; }
//        public int itemlist_179 { get; set; }
//        public int itemlist_180 { get; set; }
//        public int itemlist_181 { get; set; }
//        public int itemlist_182 { get; set; }
//        public int itemlist_183 { get; set; }
//        public int itemlist_184 { get; set; }
//        public int itemlist_185 { get; set; }
//        public int itemlist_186 { get; set; }
//        public int itemlist_187 { get; set; }
//        public int itemlist_188 { get; set; }
//        public int itemlist_189 { get; set; }
//        public int itemlist_190 { get; set; }
//        public int itemlist_191 { get; set; }
//        public int itemlist_192 { get; set; }
//        public int itemlist_193 { get; set; }
//        public int itemlist_194 { get; set; }
//        public int itemlist_195 { get; set; }
//        public int itemlist_196 { get; set; }
//        public int itemlist_197 { get; set; }
//        public int itemlist_198 { get; set; }
//        public int itemlist_199 { get; set; }
//        public int itemlist_200 { get; set; }
//        public int itemlist_201 { get; set; }
//        public int itemlist_202 { get; set; }
//        public int itemlist_203 { get; set; }
//        public int itemlist_204 { get; set; }
//        public int itemlist_205 { get; set; }
//        public int itemlist_206 { get; set; }
//        public int itemlist_207 { get; set; }
//        public int itemlist_208 { get; set; }
//        public int itemlist_209 { get; set; }
//        public int itemlist_210 { get; set; }
//        public int itemlist_211 { get; set; }
//        public int itemlist_212 { get; set; }
//        public int itemlist_213 { get; set; }
//        public int itemlist_214 { get; set; }
//        public int itemlist_215 { get; set; }
//        public int itemlist_216 { get; set; }
//        public int itemlist_217 { get; set; }
//        public int itemlist_218 { get; set; }
//        public int itemlist_219 { get; set; }
//        public int itemlist_220 { get; set; }
//        public int itemlist_221 { get; set; }
//        public int itemlist_222 { get; set; }
//        public int itemlist_223 { get; set; }
//        public int itemlist_224 { get; set; }
//        public int itemlist_225 { get; set; }
//        public int itemlist_226 { get; set; }
//        public int itemlist_227 { get; set; }
//        public int itemlist_228 { get; set; }
//        public int itemlist_229 { get; set; }
//        public int itemlist_230 { get; set; }
//        public int itemlist_231 { get; set; }
//        public int itemlist_232 { get; set; }
//        public int itemlist_233 { get; set; }
//        public int itemlist_234 { get; set; }
//        public int itemlist_235 { get; set; }
//        public int itemlist_236 { get; set; }
//        public int itemlist_237 { get; set; }
//        public int itemlist_238 { get; set; }
//        public int itemlist_239 { get; set; }
//        public int itemlist_240 { get; set; }
//        public int itemlist_241 { get; set; }
//        public int itemlist_242 { get; set; }
//        public int itemlist_243 { get; set; }
//        public int itemlist_244 { get; set; }
//        public int itemlist_245 { get; set; }
//        public int itemlist_246 { get; set; }
//        public int itemlist_247 { get; set; }
//        public int itemlist_248 { get; set; }
//        public int itemlist_249 { get; set; }
//        public int itemlist_250 { get; set; }
//        public int itemlist_251 { get; set; }
//        public int itemlist_252 { get; set; }
//        public int itemlist_253 { get; set; }
//        public int itemlist_254 { get; set; }
//        public int itemlist_255 { get; set; }
//        public int itemlist_256 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class DYNSKILLEQUIP_ESSENCE
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_matter;

//        public string File_matter
//        {
//            get => Structure.Gbk.GetString(file_matter);
//            set { file_matter = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] file_icon;

//        public string File_icon
//        {
//            get => Structure.Gbk.GetString(file_icon);
//            set { file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int id_skill { get; set; }
//        public int price { get; set; }
//        public int shop_price { get; set; }
//        public int pile_num_max { get; set; }
//        public int has_guid { get; set; }
//        [ProcType] public int proc_type { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class CONSUME_POINTS_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int list_1_id { get; set; }
//        public int list_1_point { get; set; }
//        public int list_2_id { get; set; }
//        public int list_2_point { get; set; }
//        public int list_3_id { get; set; }
//        public int list_3_point { get; set; }
//        public int list_4_id { get; set; }
//        public int list_4_point { get; set; }
//        public int list_5_id { get; set; }
//        public int list_5_point { get; set; }
//        public int list_6_id { get; set; }
//        public int list_6_point { get; set; }
//        public int list_7_id { get; set; }
//        public int list_7_point { get; set; }
//        public int list_8_id { get; set; }
//        public int list_8_point { get; set; }
//        public int list_9_id { get; set; }
//        public int list_9_point { get; set; }
//        public int list_10_id { get; set; }
//        public int list_10_point { get; set; }
//        public int list_11_id { get; set; }
//        public int list_11_point { get; set; }
//        public int list_12_id { get; set; }
//        public int list_12_point { get; set; }
//        public int list_13_id { get; set; }
//        public int list_13_point { get; set; }
//        public int list_14_id { get; set; }
//        public int list_14_point { get; set; }
//        public int list_15_id { get; set; }
//        public int list_15_point { get; set; }
//        public int list_16_id { get; set; }
//        public int list_16_point { get; set; }
//        public int list_17_id { get; set; }
//        public int list_17_point { get; set; }
//        public int list_18_id { get; set; }
//        public int list_18_point { get; set; }
//        public int list_19_id { get; set; }
//        public int list_19_point { get; set; }
//        public int list_20_id { get; set; }
//        public int list_20_point { get; set; }
//        public int list_21_id { get; set; }
//        public int list_21_point { get; set; }
//        public int list_22_id { get; set; }
//        public int list_22_point { get; set; }
//        public int list_23_id { get; set; }
//        public int list_23_point { get; set; }
//        public int list_24_id { get; set; }
//        public int list_24_point { get; set; }
//        public int list_25_id { get; set; }
//        public int list_25_point { get; set; }
//        public int list_26_id { get; set; }
//        public int list_26_point { get; set; }
//        public int list_27_id { get; set; }
//        public int list_27_point { get; set; }
//        public int list_28_id { get; set; }
//        public int list_28_point { get; set; }
//        public int list_29_id { get; set; }
//        public int list_29_point { get; set; }
//        public int list_30_id { get; set; }
//        public int list_30_point { get; set; }
//        public int list_31_id { get; set; }
//        public int list_31_point { get; set; }
//        public int list_32_id { get; set; }
//        public int list_32_point { get; set; }
//        public int list_33_id { get; set; }
//        public int list_33_point { get; set; }
//        public int list_34_id { get; set; }
//        public int list_34_point { get; set; }
//        public int list_35_id { get; set; }
//        public int list_35_point { get; set; }
//        public int list_36_id { get; set; }
//        public int list_36_point { get; set; }
//        public int list_37_id { get; set; }
//        public int list_37_point { get; set; }
//        public int list_38_id { get; set; }
//        public int list_38_point { get; set; }
//        public int list_39_id { get; set; }
//        public int list_39_point { get; set; }
//        public int list_40_id { get; set; }
//        public int list_40_point { get; set; }
//        public int list_41_id { get; set; }
//        public int list_41_point { get; set; }
//        public int list_42_id { get; set; }
//        public int list_42_point { get; set; }
//        public int list_43_id { get; set; }
//        public int list_43_point { get; set; }
//        public int list_44_id { get; set; }
//        public int list_44_point { get; set; }
//        public int list_45_id { get; set; }
//        public int list_45_point { get; set; }
//        public int list_46_id { get; set; }
//        public int list_46_point { get; set; }
//        public int list_47_id { get; set; }
//        public int list_47_point { get; set; }
//        public int list_48_id { get; set; }
//        public int list_48_point { get; set; }
//        public int list_49_id { get; set; }
//        public int list_49_point { get; set; }
//        public int list_50_id { get; set; }
//        public int list_50_point { get; set; }
//        public int list_51_id { get; set; }
//        public int list_51_point { get; set; }
//        public int list_52_id { get; set; }
//        public int list_52_point { get; set; }
//        public int list_53_id { get; set; }
//        public int list_53_point { get; set; }
//        public int list_54_id { get; set; }
//        public int list_54_point { get; set; }
//        public int list_55_id { get; set; }
//        public int list_55_point { get; set; }
//        public int list_56_id { get; set; }
//        public int list_56_point { get; set; }
//        public int list_57_id { get; set; }
//        public int list_57_point { get; set; }
//        public int list_58_id { get; set; }
//        public int list_58_point { get; set; }
//        public int list_59_id { get; set; }
//        public int list_59_point { get; set; }
//        public int list_60_id { get; set; }
//        public int list_60_point { get; set; }
//        public int list_61_id { get; set; }
//        public int list_61_point { get; set; }
//        public int list_62_id { get; set; }
//        public int list_62_point { get; set; }
//        public int list_63_id { get; set; }
//        public int list_63_point { get; set; }
//        public int list_64_id { get; set; }
//        public int list_64_point { get; set; }
//        public int list_65_id { get; set; }
//        public int list_65_point { get; set; }
//        public int list_66_id { get; set; }
//        public int list_66_point { get; set; }
//        public int list_67_id { get; set; }
//        public int list_67_point { get; set; }
//        public int list_68_id { get; set; }
//        public int list_68_point { get; set; }
//        public int list_69_id { get; set; }
//        public int list_69_point { get; set; }
//        public int list_70_id { get; set; }
//        public int list_70_point { get; set; }
//        public int list_71_id { get; set; }
//        public int list_71_point { get; set; }
//        public int list_72_id { get; set; }
//        public int list_72_point { get; set; }
//        public int list_73_id { get; set; }
//        public int list_73_point { get; set; }
//        public int list_74_id { get; set; }
//        public int list_74_point { get; set; }
//        public int list_75_id { get; set; }
//        public int list_75_point { get; set; }
//        public int list_76_id { get; set; }
//        public int list_76_point { get; set; }
//        public int list_77_id { get; set; }
//        public int list_77_point { get; set; }
//        public int list_78_id { get; set; }
//        public int list_78_point { get; set; }
//        public int list_79_id { get; set; }
//        public int list_79_point { get; set; }
//        public int list_80_id { get; set; }
//        public int list_80_point { get; set; }
//        public int list_81_id { get; set; }
//        public int list_81_point { get; set; }
//        public int list_82_id { get; set; }
//        public int list_82_point { get; set; }
//        public int list_83_id { get; set; }
//        public int list_83_point { get; set; }
//        public int list_84_id { get; set; }
//        public int list_84_point { get; set; }
//        public int list_85_id { get; set; }
//        public int list_85_point { get; set; }
//        public int list_86_id { get; set; }
//        public int list_86_point { get; set; }
//        public int list_87_id { get; set; }
//        public int list_87_point { get; set; }
//        public int list_88_id { get; set; }
//        public int list_88_point { get; set; }
//        public int list_89_id { get; set; }
//        public int list_89_point { get; set; }
//        public int list_90_id { get; set; }
//        public int list_90_point { get; set; }
//        public int list_91_id { get; set; }
//        public int list_91_point { get; set; }
//        public int list_92_id { get; set; }
//        public int list_92_point { get; set; }
//        public int list_93_id { get; set; }
//        public int list_93_point { get; set; }
//        public int list_94_id { get; set; }
//        public int list_94_point { get; set; }
//        public int list_95_id { get; set; }
//        public int list_95_point { get; set; }
//        public int list_96_id { get; set; }
//        public int list_96_point { get; set; }
//        public int list_97_id { get; set; }
//        public int list_97_point { get; set; }
//        public int list_98_id { get; set; }
//        public int list_98_point { get; set; }
//        public int list_99_id { get; set; }
//        public int list_99_point { get; set; }
//        public int list_100_id { get; set; }
//        public int list_100_point { get; set; }
//        public int list_101_id { get; set; }
//        public int list_101_point { get; set; }
//        public int list_102_id { get; set; }
//        public int list_102_point { get; set; }
//        public int list_103_id { get; set; }
//        public int list_103_point { get; set; }
//        public int list_104_id { get; set; }
//        public int list_104_point { get; set; }
//        public int list_105_id { get; set; }
//        public int list_105_point { get; set; }
//        public int list_106_id { get; set; }
//        public int list_106_point { get; set; }
//        public int list_107_id { get; set; }
//        public int list_107_point { get; set; }
//        public int list_108_id { get; set; }
//        public int list_108_point { get; set; }
//        public int list_109_id { get; set; }
//        public int list_109_point { get; set; }
//        public int list_110_id { get; set; }
//        public int list_110_point { get; set; }
//        public int list_111_id { get; set; }
//        public int list_111_point { get; set; }
//        public int list_112_id { get; set; }
//        public int list_112_point { get; set; }
//        public int list_113_id { get; set; }
//        public int list_113_point { get; set; }
//        public int list_114_id { get; set; }
//        public int list_114_point { get; set; }
//        public int list_115_id { get; set; }
//        public int list_115_point { get; set; }
//        public int list_116_id { get; set; }
//        public int list_116_point { get; set; }
//        public int list_117_id { get; set; }
//        public int list_117_point { get; set; }
//        public int list_118_id { get; set; }
//        public int list_118_point { get; set; }
//        public int list_119_id { get; set; }
//        public int list_119_point { get; set; }
//        public int list_120_id { get; set; }
//        public int list_120_point { get; set; }
//        public int list_121_id { get; set; }
//        public int list_121_point { get; set; }
//        public int list_122_id { get; set; }
//        public int list_122_point { get; set; }
//        public int list_123_id { get; set; }
//        public int list_123_point { get; set; }
//        public int list_124_id { get; set; }
//        public int list_124_point { get; set; }
//        public int list_125_id { get; set; }
//        public int list_125_point { get; set; }
//        public int list_126_id { get; set; }
//        public int list_126_point { get; set; }
//        public int list_127_id { get; set; }
//        public int list_127_point { get; set; }
//        public int list_128_id { get; set; }
//        public int list_128_point { get; set; }
//        public int list_129_id { get; set; }
//        public int list_129_point { get; set; }
//        public int list_130_id { get; set; }
//        public int list_130_point { get; set; }
//        public int list_131_id { get; set; }
//        public int list_131_point { get; set; }
//        public int list_132_id { get; set; }
//        public int list_132_point { get; set; }
//        public int list_133_id { get; set; }
//        public int list_133_point { get; set; }
//        public int list_134_id { get; set; }
//        public int list_134_point { get; set; }
//        public int list_135_id { get; set; }
//        public int list_135_point { get; set; }
//        public int list_136_id { get; set; }
//        public int list_136_point { get; set; }
//        public int list_137_id { get; set; }
//        public int list_137_point { get; set; }
//        public int list_138_id { get; set; }
//        public int list_138_point { get; set; }
//        public int list_139_id { get; set; }
//        public int list_139_point { get; set; }
//        public int list_140_id { get; set; }
//        public int list_140_point { get; set; }
//        public int list_141_id { get; set; }
//        public int list_141_point { get; set; }
//        public int list_142_id { get; set; }
//        public int list_142_point { get; set; }
//        public int list_143_id { get; set; }
//        public int list_143_point { get; set; }
//        public int list_144_id { get; set; }
//        public int list_144_point { get; set; }
//        public int list_145_id { get; set; }
//        public int list_145_point { get; set; }
//        public int list_146_id { get; set; }
//        public int list_146_point { get; set; }
//        public int list_147_id { get; set; }
//        public int list_147_point { get; set; }
//        public int list_148_id { get; set; }
//        public int list_148_point { get; set; }
//        public int list_149_id { get; set; }
//        public int list_149_point { get; set; }
//        public int list_150_id { get; set; }
//        public int list_150_point { get; set; }
//        public int list_151_id { get; set; }
//        public int list_151_point { get; set; }
//        public int list_152_id { get; set; }
//        public int list_152_point { get; set; }
//        public int list_153_id { get; set; }
//        public int list_153_point { get; set; }
//        public int list_154_id { get; set; }
//        public int list_154_point { get; set; }
//        public int list_155_id { get; set; }
//        public int list_155_point { get; set; }
//        public int list_156_id { get; set; }
//        public int list_156_point { get; set; }
//        public int list_157_id { get; set; }
//        public int list_157_point { get; set; }
//        public int list_158_id { get; set; }
//        public int list_158_point { get; set; }
//        public int list_159_id { get; set; }
//        public int list_159_point { get; set; }
//        public int list_160_id { get; set; }
//        public int list_160_point { get; set; }
//        public int list_161_id { get; set; }
//        public int list_161_point { get; set; }
//        public int list_162_id { get; set; }
//        public int list_162_point { get; set; }
//        public int list_163_id { get; set; }
//        public int list_163_point { get; set; }
//        public int list_164_id { get; set; }
//        public int list_164_point { get; set; }
//        public int list_165_id { get; set; }
//        public int list_165_point { get; set; }
//        public int list_166_id { get; set; }
//        public int list_166_point { get; set; }
//        public int list_167_id { get; set; }
//        public int list_167_point { get; set; }
//        public int list_168_id { get; set; }
//        public int list_168_point { get; set; }
//        public int list_169_id { get; set; }
//        public int list_169_point { get; set; }
//        public int list_170_id { get; set; }
//        public int list_170_point { get; set; }
//        public int list_171_id { get; set; }
//        public int list_171_point { get; set; }
//        public int list_172_id { get; set; }
//        public int list_172_point { get; set; }
//        public int list_173_id { get; set; }
//        public int list_173_point { get; set; }
//        public int list_174_id { get; set; }
//        public int list_174_point { get; set; }
//        public int list_175_id { get; set; }
//        public int list_175_point { get; set; }
//        public int list_176_id { get; set; }
//        public int list_176_point { get; set; }
//        public int list_177_id { get; set; }
//        public int list_177_point { get; set; }
//        public int list_178_id { get; set; }
//        public int list_178_point { get; set; }
//        public int list_179_id { get; set; }
//        public int list_179_point { get; set; }
//        public int list_180_id { get; set; }
//        public int list_180_point { get; set; }
//        public int list_181_id { get; set; }
//        public int list_181_point { get; set; }
//        public int list_182_id { get; set; }
//        public int list_182_point { get; set; }
//        public int list_183_id { get; set; }
//        public int list_183_point { get; set; }
//        public int list_184_id { get; set; }
//        public int list_184_point { get; set; }
//        public int list_185_id { get; set; }
//        public int list_185_point { get; set; }
//        public int list_186_id { get; set; }
//        public int list_186_point { get; set; }
//        public int list_187_id { get; set; }
//        public int list_187_point { get; set; }
//        public int list_188_id { get; set; }
//        public int list_188_point { get; set; }
//        public int list_189_id { get; set; }
//        public int list_189_point { get; set; }
//        public int list_190_id { get; set; }
//        public int list_190_point { get; set; }
//        public int list_191_id { get; set; }
//        public int list_191_point { get; set; }
//        public int list_192_id { get; set; }
//        public int list_192_point { get; set; }
//        public int list_193_id { get; set; }
//        public int list_193_point { get; set; }
//        public int list_194_id { get; set; }
//        public int list_194_point { get; set; }
//        public int list_195_id { get; set; }
//        public int list_195_point { get; set; }
//        public int list_196_id { get; set; }
//        public int list_196_point { get; set; }
//        public int list_197_id { get; set; }
//        public int list_197_point { get; set; }
//        public int list_198_id { get; set; }
//        public int list_198_point { get; set; }
//        public int list_199_id { get; set; }
//        public int list_199_point { get; set; }
//        public int list_200_id { get; set; }
//        public int list_200_point { get; set; }
//        public int list_201_id { get; set; }
//        public int list_201_point { get; set; }
//        public int list_202_id { get; set; }
//        public int list_202_point { get; set; }
//        public int list_203_id { get; set; }
//        public int list_203_point { get; set; }
//        public int list_204_id { get; set; }
//        public int list_204_point { get; set; }
//        public int list_205_id { get; set; }
//        public int list_205_point { get; set; }
//        public int list_206_id { get; set; }
//        public int list_206_point { get; set; }
//        public int list_207_id { get; set; }
//        public int list_207_point { get; set; }
//        public int list_208_id { get; set; }
//        public int list_208_point { get; set; }
//        public int list_209_id { get; set; }
//        public int list_209_point { get; set; }
//        public int list_210_id { get; set; }
//        public int list_210_point { get; set; }
//        public int list_211_id { get; set; }
//        public int list_211_point { get; set; }
//        public int list_212_id { get; set; }
//        public int list_212_point { get; set; }
//        public int list_213_id { get; set; }
//        public int list_213_point { get; set; }
//        public int list_214_id { get; set; }
//        public int list_214_point { get; set; }
//        public int list_215_id { get; set; }
//        public int list_215_point { get; set; }
//        public int list_216_id { get; set; }
//        public int list_216_point { get; set; }
//        public int list_217_id { get; set; }
//        public int list_217_point { get; set; }
//        public int list_218_id { get; set; }
//        public int list_218_point { get; set; }
//        public int list_219_id { get; set; }
//        public int list_219_point { get; set; }
//        public int list_220_id { get; set; }
//        public int list_220_point { get; set; }
//        public int list_221_id { get; set; }
//        public int list_221_point { get; set; }
//        public int list_222_id { get; set; }
//        public int list_222_point { get; set; }
//        public int list_223_id { get; set; }
//        public int list_223_point { get; set; }
//        public int list_224_id { get; set; }
//        public int list_224_point { get; set; }
//        public int list_225_id { get; set; }
//        public int list_225_point { get; set; }
//        public int list_226_id { get; set; }
//        public int list_226_point { get; set; }
//        public int list_227_id { get; set; }
//        public int list_227_point { get; set; }
//        public int list_228_id { get; set; }
//        public int list_228_point { get; set; }
//        public int list_229_id { get; set; }
//        public int list_229_point { get; set; }
//        public int list_230_id { get; set; }
//        public int list_230_point { get; set; }
//        public int list_231_id { get; set; }
//        public int list_231_point { get; set; }
//        public int list_232_id { get; set; }
//        public int list_232_point { get; set; }
//        public int list_233_id { get; set; }
//        public int list_233_point { get; set; }
//        public int list_234_id { get; set; }
//        public int list_234_point { get; set; }
//        public int list_235_id { get; set; }
//        public int list_235_point { get; set; }
//        public int list_236_id { get; set; }
//        public int list_236_point { get; set; }
//        public int list_237_id { get; set; }
//        public int list_237_point { get; set; }
//        public int list_238_id { get; set; }
//        public int list_238_point { get; set; }
//        public int list_239_id { get; set; }
//        public int list_239_point { get; set; }
//        public int list_240_id { get; set; }
//        public int list_240_point { get; set; }
//        public int list_241_id { get; set; }
//        public int list_241_point { get; set; }
//        public int list_242_id { get; set; }
//        public int list_242_point { get; set; }
//        public int list_243_id { get; set; }
//        public int list_243_point { get; set; }
//        public int list_244_id { get; set; }
//        public int list_244_point { get; set; }
//        public int list_245_id { get; set; }
//        public int list_245_point { get; set; }
//        public int list_246_id { get; set; }
//        public int list_246_point { get; set; }
//        public int list_247_id { get; set; }
//        public int list_247_point { get; set; }
//        public int list_248_id { get; set; }
//        public int list_248_point { get; set; }
//        public int list_249_id { get; set; }
//        public int list_249_point { get; set; }
//        public int list_250_id { get; set; }
//        public int list_250_point { get; set; }
//        public int list_251_id { get; set; }
//        public int list_251_point { get; set; }
//        public int list_252_id { get; set; }
//        public int list_252_point { get; set; }
//        public int list_253_id { get; set; }
//        public int list_253_point { get; set; }
//        public int list_254_id { get; set; }
//        public int list_254_point { get; set; }
//        public int list_255_id { get; set; }
//        public int list_255_point { get; set; }
//        public int list_256_id { get; set; }
//        public int list_256_point { get; set; }
//        public int list_257_id { get; set; }
//        public int list_257_point { get; set; }
//        public int list_258_id { get; set; }
//        public int list_258_point { get; set; }
//        public int list_259_id { get; set; }
//        public int list_259_point { get; set; }
//        public int list_260_id { get; set; }
//        public int list_260_point { get; set; }
//        public int list_261_id { get; set; }
//        public int list_261_point { get; set; }
//        public int list_262_id { get; set; }
//        public int list_262_point { get; set; }
//        public int list_263_id { get; set; }
//        public int list_263_point { get; set; }
//        public int list_264_id { get; set; }
//        public int list_264_point { get; set; }
//        public int list_265_id { get; set; }
//        public int list_265_point { get; set; }
//        public int list_266_id { get; set; }
//        public int list_266_point { get; set; }
//        public int list_267_id { get; set; }
//        public int list_267_point { get; set; }
//        public int list_268_id { get; set; }
//        public int list_268_point { get; set; }
//        public int list_269_id { get; set; }
//        public int list_269_point { get; set; }
//        public int list_270_id { get; set; }
//        public int list_270_point { get; set; }
//        public int list_271_id { get; set; }
//        public int list_271_point { get; set; }
//        public int list_272_id { get; set; }
//        public int list_272_point { get; set; }
//        public int list_273_id { get; set; }
//        public int list_273_point { get; set; }
//        public int list_274_id { get; set; }
//        public int list_274_point { get; set; }
//        public int list_275_id { get; set; }
//        public int list_275_point { get; set; }
//        public int list_276_id { get; set; }
//        public int list_276_point { get; set; }
//        public int list_277_id { get; set; }
//        public int list_277_point { get; set; }
//        public int list_278_id { get; set; }
//        public int list_278_point { get; set; }
//        public int list_279_id { get; set; }
//        public int list_279_point { get; set; }
//        public int list_280_id { get; set; }
//        public int list_280_point { get; set; }
//        public int list_281_id { get; set; }
//        public int list_281_point { get; set; }
//        public int list_282_id { get; set; }
//        public int list_282_point { get; set; }
//        public int list_283_id { get; set; }
//        public int list_283_point { get; set; }
//        public int list_284_id { get; set; }
//        public int list_284_point { get; set; }
//        public int list_285_id { get; set; }
//        public int list_285_point { get; set; }
//        public int list_286_id { get; set; }
//        public int list_286_point { get; set; }
//        public int list_287_id { get; set; }
//        public int list_287_point { get; set; }
//        public int list_288_id { get; set; }
//        public int list_288_point { get; set; }
//        public int list_289_id { get; set; }
//        public int list_289_point { get; set; }
//        public int list_290_id { get; set; }
//        public int list_290_point { get; set; }
//        public int list_291_id { get; set; }
//        public int list_291_point { get; set; }
//        public int list_292_id { get; set; }
//        public int list_292_point { get; set; }
//        public int list_293_id { get; set; }
//        public int list_293_point { get; set; }
//        public int list_294_id { get; set; }
//        public int list_294_point { get; set; }
//        public int list_295_id { get; set; }
//        public int list_295_point { get; set; }
//        public int list_296_id { get; set; }
//        public int list_296_point { get; set; }
//        public int list_297_id { get; set; }
//        public int list_297_point { get; set; }
//        public int list_298_id { get; set; }
//        public int list_298_point { get; set; }
//        public int list_299_id { get; set; }
//        public int list_299_point { get; set; }
//        public int list_300_id { get; set; }
//        public int list_300_point { get; set; }
//        public int list_301_id { get; set; }
//        public int list_301_point { get; set; }
//        public int list_302_id { get; set; }
//        public int list_302_point { get; set; }
//        public int list_303_id { get; set; }
//        public int list_303_point { get; set; }
//        public int list_304_id { get; set; }
//        public int list_304_point { get; set; }
//        public int list_305_id { get; set; }
//        public int list_305_point { get; set; }
//        public int list_306_id { get; set; }
//        public int list_306_point { get; set; }
//        public int list_307_id { get; set; }
//        public int list_307_point { get; set; }
//        public int list_308_id { get; set; }
//        public int list_308_point { get; set; }
//        public int list_309_id { get; set; }
//        public int list_309_point { get; set; }
//        public int list_310_id { get; set; }
//        public int list_310_point { get; set; }
//        public int list_311_id { get; set; }
//        public int list_311_point { get; set; }
//        public int list_312_id { get; set; }
//        public int list_312_point { get; set; }
//        public int list_313_id { get; set; }
//        public int list_313_point { get; set; }
//        public int list_314_id { get; set; }
//        public int list_314_point { get; set; }
//        public int list_315_id { get; set; }
//        public int list_315_point { get; set; }
//        public int list_316_id { get; set; }
//        public int list_316_point { get; set; }
//        public int list_317_id { get; set; }
//        public int list_317_point { get; set; }
//        public int list_318_id { get; set; }
//        public int list_318_point { get; set; }
//        public int list_319_id { get; set; }
//        public int list_319_point { get; set; }
//        public int list_320_id { get; set; }
//        public int list_320_point { get; set; }
//        public int list_321_id { get; set; }
//        public int list_321_point { get; set; }
//        public int list_322_id { get; set; }
//        public int list_322_point { get; set; }
//        public int list_323_id { get; set; }
//        public int list_323_point { get; set; }
//        public int list_324_id { get; set; }
//        public int list_324_point { get; set; }
//        public int list_325_id { get; set; }
//        public int list_325_point { get; set; }
//        public int list_326_id { get; set; }
//        public int list_326_point { get; set; }
//        public int list_327_id { get; set; }
//        public int list_327_point { get; set; }
//        public int list_328_id { get; set; }
//        public int list_328_point { get; set; }
//        public int list_329_id { get; set; }
//        public int list_329_point { get; set; }
//        public int list_330_id { get; set; }
//        public int list_330_point { get; set; }
//        public int list_331_id { get; set; }
//        public int list_331_point { get; set; }
//        public int list_332_id { get; set; }
//        public int list_332_point { get; set; }
//        public int list_333_id { get; set; }
//        public int list_333_point { get; set; }
//        public int list_334_id { get; set; }
//        public int list_334_point { get; set; }
//        public int list_335_id { get; set; }
//        public int list_335_point { get; set; }
//        public int list_336_id { get; set; }
//        public int list_336_point { get; set; }
//        public int list_337_id { get; set; }
//        public int list_337_point { get; set; }
//        public int list_338_id { get; set; }
//        public int list_338_point { get; set; }
//        public int list_339_id { get; set; }
//        public int list_339_point { get; set; }
//        public int list_340_id { get; set; }
//        public int list_340_point { get; set; }
//        public int list_341_id { get; set; }
//        public int list_341_point { get; set; }
//        public int list_342_id { get; set; }
//        public int list_342_point { get; set; }
//        public int list_343_id { get; set; }
//        public int list_343_point { get; set; }
//        public int list_344_id { get; set; }
//        public int list_344_point { get; set; }
//        public int list_345_id { get; set; }
//        public int list_345_point { get; set; }
//        public int list_346_id { get; set; }
//        public int list_346_point { get; set; }
//        public int list_347_id { get; set; }
//        public int list_347_point { get; set; }
//        public int list_348_id { get; set; }
//        public int list_348_point { get; set; }
//        public int list_349_id { get; set; }
//        public int list_349_point { get; set; }
//        public int list_350_id { get; set; }
//        public int list_350_point { get; set; }
//        public int list_351_id { get; set; }
//        public int list_351_point { get; set; }
//        public int list_352_id { get; set; }
//        public int list_352_point { get; set; }
//        public int list_353_id { get; set; }
//        public int list_353_point { get; set; }
//        public int list_354_id { get; set; }
//        public int list_354_point { get; set; }
//        public int list_355_id { get; set; }
//        public int list_355_point { get; set; }
//        public int list_356_id { get; set; }
//        public int list_356_point { get; set; }
//        public int list_357_id { get; set; }
//        public int list_357_point { get; set; }
//        public int list_358_id { get; set; }
//        public int list_358_point { get; set; }
//        public int list_359_id { get; set; }
//        public int list_359_point { get; set; }
//        public int list_360_id { get; set; }
//        public int list_360_point { get; set; }
//        public int list_361_id { get; set; }
//        public int list_361_point { get; set; }
//        public int list_362_id { get; set; }
//        public int list_362_point { get; set; }
//        public int list_363_id { get; set; }
//        public int list_363_point { get; set; }
//        public int list_364_id { get; set; }
//        public int list_364_point { get; set; }
//        public int list_365_id { get; set; }
//        public int list_365_point { get; set; }
//        public int list_366_id { get; set; }
//        public int list_366_point { get; set; }
//        public int list_367_id { get; set; }
//        public int list_367_point { get; set; }
//        public int list_368_id { get; set; }
//        public int list_368_point { get; set; }
//        public int list_369_id { get; set; }
//        public int list_369_point { get; set; }
//        public int list_370_id { get; set; }
//        public int list_370_point { get; set; }
//        public int list_371_id { get; set; }
//        public int list_371_point { get; set; }
//        public int list_372_id { get; set; }
//        public int list_372_point { get; set; }
//        public int list_373_id { get; set; }
//        public int list_373_point { get; set; }
//        public int list_374_id { get; set; }
//        public int list_374_point { get; set; }
//        public int list_375_id { get; set; }
//        public int list_375_point { get; set; }
//        public int list_376_id { get; set; }
//        public int list_376_point { get; set; }
//        public int list_377_id { get; set; }
//        public int list_377_point { get; set; }
//        public int list_378_id { get; set; }
//        public int list_378_point { get; set; }
//        public int list_379_id { get; set; }
//        public int list_379_point { get; set; }
//        public int list_380_id { get; set; }
//        public int list_380_point { get; set; }
//        public int list_381_id { get; set; }
//        public int list_381_point { get; set; }
//        public int list_382_id { get; set; }
//        public int list_382_point { get; set; }
//        public int list_383_id { get; set; }
//        public int list_383_point { get; set; }
//        public int list_384_id { get; set; }
//        public int list_384_point { get; set; }
//        public int list_385_id { get; set; }
//        public int list_385_point { get; set; }
//        public int list_386_id { get; set; }
//        public int list_386_point { get; set; }
//        public int list_387_id { get; set; }
//        public int list_387_point { get; set; }
//        public int list_388_id { get; set; }
//        public int list_388_point { get; set; }
//        public int list_389_id { get; set; }
//        public int list_389_point { get; set; }
//        public int list_390_id { get; set; }
//        public int list_390_point { get; set; }
//        public int list_391_id { get; set; }
//        public int list_391_point { get; set; }
//        public int list_392_id { get; set; }
//        public int list_392_point { get; set; }
//        public int list_393_id { get; set; }
//        public int list_393_point { get; set; }
//        public int list_394_id { get; set; }
//        public int list_394_point { get; set; }
//        public int list_395_id { get; set; }
//        public int list_395_point { get; set; }
//        public int list_396_id { get; set; }
//        public int list_396_point { get; set; }
//        public int list_397_id { get; set; }
//        public int list_397_point { get; set; }
//        public int list_398_id { get; set; }
//        public int list_398_point { get; set; }
//        public int list_399_id { get; set; }
//        public int list_399_point { get; set; }
//        public int list_400_id { get; set; }
//        public int list_400_point { get; set; }
//        public int list_401_id { get; set; }
//        public int list_401_point { get; set; }
//        public int list_402_id { get; set; }
//        public int list_402_point { get; set; }
//        public int list_403_id { get; set; }
//        public int list_403_point { get; set; }
//        public int list_404_id { get; set; }
//        public int list_404_point { get; set; }
//        public int list_405_id { get; set; }
//        public int list_405_point { get; set; }
//        public int list_406_id { get; set; }
//        public int list_406_point { get; set; }
//        public int list_407_id { get; set; }
//        public int list_407_point { get; set; }
//        public int list_408_id { get; set; }
//        public int list_408_point { get; set; }
//        public int list_409_id { get; set; }
//        public int list_409_point { get; set; }
//        public int list_410_id { get; set; }
//        public int list_410_point { get; set; }
//        public int list_411_id { get; set; }
//        public int list_411_point { get; set; }
//        public int list_412_id { get; set; }
//        public int list_412_point { get; set; }
//        public int list_413_id { get; set; }
//        public int list_413_point { get; set; }
//        public int list_414_id { get; set; }
//        public int list_414_point { get; set; }
//        public int list_415_id { get; set; }
//        public int list_415_point { get; set; }
//        public int list_416_id { get; set; }
//        public int list_416_point { get; set; }
//        public int list_417_id { get; set; }
//        public int list_417_point { get; set; }
//        public int list_418_id { get; set; }
//        public int list_418_point { get; set; }
//        public int list_419_id { get; set; }
//        public int list_419_point { get; set; }
//        public int list_420_id { get; set; }
//        public int list_420_point { get; set; }
//        public int list_421_id { get; set; }
//        public int list_421_point { get; set; }
//        public int list_422_id { get; set; }
//        public int list_422_point { get; set; }
//        public int list_423_id { get; set; }
//        public int list_423_point { get; set; }
//        public int list_424_id { get; set; }
//        public int list_424_point { get; set; }
//        public int list_425_id { get; set; }
//        public int list_425_point { get; set; }
//        public int list_426_id { get; set; }
//        public int list_426_point { get; set; }
//        public int list_427_id { get; set; }
//        public int list_427_point { get; set; }
//        public int list_428_id { get; set; }
//        public int list_428_point { get; set; }
//        public int list_429_id { get; set; }
//        public int list_429_point { get; set; }
//        public int list_430_id { get; set; }
//        public int list_430_point { get; set; }
//        public int list_431_id { get; set; }
//        public int list_431_point { get; set; }
//        public int list_432_id { get; set; }
//        public int list_432_point { get; set; }
//        public int list_433_id { get; set; }
//        public int list_433_point { get; set; }
//        public int list_434_id { get; set; }
//        public int list_434_point { get; set; }
//        public int list_435_id { get; set; }
//        public int list_435_point { get; set; }
//        public int list_436_id { get; set; }
//        public int list_436_point { get; set; }
//        public int list_437_id { get; set; }
//        public int list_437_point { get; set; }
//        public int list_438_id { get; set; }
//        public int list_438_point { get; set; }
//        public int list_439_id { get; set; }
//        public int list_439_point { get; set; }
//        public int list_440_id { get; set; }
//        public int list_440_point { get; set; }
//        public int list_441_id { get; set; }
//        public int list_441_point { get; set; }
//        public int list_442_id { get; set; }
//        public int list_442_point { get; set; }
//        public int list_443_id { get; set; }
//        public int list_443_point { get; set; }
//        public int list_444_id { get; set; }
//        public int list_444_point { get; set; }
//        public int list_445_id { get; set; }
//        public int list_445_point { get; set; }
//        public int list_446_id { get; set; }
//        public int list_446_point { get; set; }
//        public int list_447_id { get; set; }
//        public int list_447_point { get; set; }
//        public int list_448_id { get; set; }
//        public int list_448_point { get; set; }
//        public int list_449_id { get; set; }
//        public int list_449_point { get; set; }
//        public int list_450_id { get; set; }
//        public int list_450_point { get; set; }
//        public int list_451_id { get; set; }
//        public int list_451_point { get; set; }
//        public int list_452_id { get; set; }
//        public int list_452_point { get; set; }
//        public int list_453_id { get; set; }
//        public int list_453_point { get; set; }
//        public int list_454_id { get; set; }
//        public int list_454_point { get; set; }
//        public int list_455_id { get; set; }
//        public int list_455_point { get; set; }
//        public int list_456_id { get; set; }
//        public int list_456_point { get; set; }
//        public int list_457_id { get; set; }
//        public int list_457_point { get; set; }
//        public int list_458_id { get; set; }
//        public int list_458_point { get; set; }
//        public int list_459_id { get; set; }
//        public int list_459_point { get; set; }
//        public int list_460_id { get; set; }
//        public int list_460_point { get; set; }
//        public int list_461_id { get; set; }
//        public int list_461_point { get; set; }
//        public int list_462_id { get; set; }
//        public int list_462_point { get; set; }
//        public int list_463_id { get; set; }
//        public int list_463_point { get; set; }
//        public int list_464_id { get; set; }
//        public int list_464_point { get; set; }
//        public int list_465_id { get; set; }
//        public int list_465_point { get; set; }
//        public int list_466_id { get; set; }
//        public int list_466_point { get; set; }
//        public int list_467_id { get; set; }
//        public int list_467_point { get; set; }
//        public int list_468_id { get; set; }
//        public int list_468_point { get; set; }
//        public int list_469_id { get; set; }
//        public int list_469_point { get; set; }
//        public int list_470_id { get; set; }
//        public int list_470_point { get; set; }
//        public int list_471_id { get; set; }
//        public int list_471_point { get; set; }
//        public int list_472_id { get; set; }
//        public int list_472_point { get; set; }
//        public int list_473_id { get; set; }
//        public int list_473_point { get; set; }
//        public int list_474_id { get; set; }
//        public int list_474_point { get; set; }
//        public int list_475_id { get; set; }
//        public int list_475_point { get; set; }
//        public int list_476_id { get; set; }
//        public int list_476_point { get; set; }
//        public int list_477_id { get; set; }
//        public int list_477_point { get; set; }
//        public int list_478_id { get; set; }
//        public int list_478_point { get; set; }
//        public int list_479_id { get; set; }
//        public int list_479_point { get; set; }
//        public int list_480_id { get; set; }
//        public int list_480_point { get; set; }
//        public int list_481_id { get; set; }
//        public int list_481_point { get; set; }
//        public int list_482_id { get; set; }
//        public int list_482_point { get; set; }
//        public int list_483_id { get; set; }
//        public int list_483_point { get; set; }
//        public int list_484_id { get; set; }
//        public int list_484_point { get; set; }
//        public int list_485_id { get; set; }
//        public int list_485_point { get; set; }
//        public int list_486_id { get; set; }
//        public int list_486_point { get; set; }
//        public int list_487_id { get; set; }
//        public int list_487_point { get; set; }
//        public int list_488_id { get; set; }
//        public int list_488_point { get; set; }
//        public int list_489_id { get; set; }
//        public int list_489_point { get; set; }
//        public int list_490_id { get; set; }
//        public int list_490_point { get; set; }
//        public int list_491_id { get; set; }
//        public int list_491_point { get; set; }
//        public int list_492_id { get; set; }
//        public int list_492_point { get; set; }
//        public int list_493_id { get; set; }
//        public int list_493_point { get; set; }
//        public int list_494_id { get; set; }
//        public int list_494_point { get; set; }
//        public int list_495_id { get; set; }
//        public int list_495_point { get; set; }
//        public int list_496_id { get; set; }
//        public int list_496_point { get; set; }
//        public int list_497_id { get; set; }
//        public int list_497_point { get; set; }
//        public int list_498_id { get; set; }
//        public int list_498_point { get; set; }
//        public int list_499_id { get; set; }
//        public int list_499_point { get; set; }
//        public int list_500_id { get; set; }
//        public int list_500_point { get; set; }
//        public int list_501_id { get; set; }
//        public int list_501_point { get; set; }
//        public int list_502_id { get; set; }
//        public int list_502_point { get; set; }
//        public int list_503_id { get; set; }
//        public int list_503_point { get; set; }
//        public int list_504_id { get; set; }
//        public int list_504_point { get; set; }
//        public int list_505_id { get; set; }
//        public int list_505_point { get; set; }
//        public int list_506_id { get; set; }
//        public int list_506_point { get; set; }
//        public int list_507_id { get; set; }
//        public int list_507_point { get; set; }
//        public int list_508_id { get; set; }
//        public int list_508_point { get; set; }
//        public int list_509_id { get; set; }
//        public int list_509_point { get; set; }
//        public int list_510_id { get; set; }
//        public int list_510_point { get; set; }
//        public int list_511_id { get; set; }
//        public int list_511_point { get; set; }
//        public int list_512_id { get; set; }
//        public int list_512_point { get; set; }
//        public int list_513_id { get; set; }
//        public int list_513_point { get; set; }
//        public int list_514_id { get; set; }
//        public int list_514_point { get; set; }
//        public int list_515_id { get; set; }
//        public int list_515_point { get; set; }
//        public int list_516_id { get; set; }
//        public int list_516_point { get; set; }
//        public int list_517_id { get; set; }
//        public int list_517_point { get; set; }
//        public int list_518_id { get; set; }
//        public int list_518_point { get; set; }
//        public int list_519_id { get; set; }
//        public int list_519_point { get; set; }
//        public int list_520_id { get; set; }
//        public int list_520_point { get; set; }
//        public int list_521_id { get; set; }
//        public int list_521_point { get; set; }
//        public int list_522_id { get; set; }
//        public int list_522_point { get; set; }
//        public int list_523_id { get; set; }
//        public int list_523_point { get; set; }
//        public int list_524_id { get; set; }
//        public int list_524_point { get; set; }
//        public int list_525_id { get; set; }
//        public int list_525_point { get; set; }
//        public int list_526_id { get; set; }
//        public int list_526_point { get; set; }
//        public int list_527_id { get; set; }
//        public int list_527_point { get; set; }
//        public int list_528_id { get; set; }
//        public int list_528_point { get; set; }
//        public int list_529_id { get; set; }
//        public int list_529_point { get; set; }
//        public int list_530_id { get; set; }
//        public int list_530_point { get; set; }
//        public int list_531_id { get; set; }
//        public int list_531_point { get; set; }
//        public int list_532_id { get; set; }
//        public int list_532_point { get; set; }
//        public int list_533_id { get; set; }
//        public int list_533_point { get; set; }
//        public int list_534_id { get; set; }
//        public int list_534_point { get; set; }
//        public int list_535_id { get; set; }
//        public int list_535_point { get; set; }
//        public int list_536_id { get; set; }
//        public int list_536_point { get; set; }
//        public int list_537_id { get; set; }
//        public int list_537_point { get; set; }
//        public int list_538_id { get; set; }
//        public int list_538_point { get; set; }
//        public int list_539_id { get; set; }
//        public int list_539_point { get; set; }
//        public int list_540_id { get; set; }
//        public int list_540_point { get; set; }
//        public int list_541_id { get; set; }
//        public int list_541_point { get; set; }
//        public int list_542_id { get; set; }
//        public int list_542_point { get; set; }
//        public int list_543_id { get; set; }
//        public int list_543_point { get; set; }
//        public int list_544_id { get; set; }
//        public int list_544_point { get; set; }
//        public int list_545_id { get; set; }
//        public int list_545_point { get; set; }
//        public int list_546_id { get; set; }
//        public int list_546_point { get; set; }
//        public int list_547_id { get; set; }
//        public int list_547_point { get; set; }
//        public int list_548_id { get; set; }
//        public int list_548_point { get; set; }
//        public int list_549_id { get; set; }
//        public int list_549_point { get; set; }
//        public int list_550_id { get; set; }
//        public int list_550_point { get; set; }
//        public int list_551_id { get; set; }
//        public int list_551_point { get; set; }
//        public int list_552_id { get; set; }
//        public int list_552_point { get; set; }
//        public int list_553_id { get; set; }
//        public int list_553_point { get; set; }
//        public int list_554_id { get; set; }
//        public int list_554_point { get; set; }
//        public int list_555_id { get; set; }
//        public int list_555_point { get; set; }
//        public int list_556_id { get; set; }
//        public int list_556_point { get; set; }
//        public int list_557_id { get; set; }
//        public int list_557_point { get; set; }
//        public int list_558_id { get; set; }
//        public int list_558_point { get; set; }
//        public int list_559_id { get; set; }
//        public int list_559_point { get; set; }
//        public int list_560_id { get; set; }
//        public int list_560_point { get; set; }
//        public int list_561_id { get; set; }
//        public int list_561_point { get; set; }
//        public int list_562_id { get; set; }
//        public int list_562_point { get; set; }
//        public int list_563_id { get; set; }
//        public int list_563_point { get; set; }
//        public int list_564_id { get; set; }
//        public int list_564_point { get; set; }
//        public int list_565_id { get; set; }
//        public int list_565_point { get; set; }
//        public int list_566_id { get; set; }
//        public int list_566_point { get; set; }
//        public int list_567_id { get; set; }
//        public int list_567_point { get; set; }
//        public int list_568_id { get; set; }
//        public int list_568_point { get; set; }
//        public int list_569_id { get; set; }
//        public int list_569_point { get; set; }
//        public int list_570_id { get; set; }
//        public int list_570_point { get; set; }
//        public int list_571_id { get; set; }
//        public int list_571_point { get; set; }
//        public int list_572_id { get; set; }
//        public int list_572_point { get; set; }
//        public int list_573_id { get; set; }
//        public int list_573_point { get; set; }
//        public int list_574_id { get; set; }
//        public int list_574_point { get; set; }
//        public int list_575_id { get; set; }
//        public int list_575_point { get; set; }
//        public int list_576_id { get; set; }
//        public int list_576_point { get; set; }
//        public int list_577_id { get; set; }
//        public int list_577_point { get; set; }
//        public int list_578_id { get; set; }
//        public int list_578_point { get; set; }
//        public int list_579_id { get; set; }
//        public int list_579_point { get; set; }
//        public int list_580_id { get; set; }
//        public int list_580_point { get; set; }
//        public int list_581_id { get; set; }
//        public int list_581_point { get; set; }
//        public int list_582_id { get; set; }
//        public int list_582_point { get; set; }
//        public int list_583_id { get; set; }
//        public int list_583_point { get; set; }
//        public int list_584_id { get; set; }
//        public int list_584_point { get; set; }
//        public int list_585_id { get; set; }
//        public int list_585_point { get; set; }
//        public int list_586_id { get; set; }
//        public int list_586_point { get; set; }
//        public int list_587_id { get; set; }
//        public int list_587_point { get; set; }
//        public int list_588_id { get; set; }
//        public int list_588_point { get; set; }
//        public int list_589_id { get; set; }
//        public int list_589_point { get; set; }
//        public int list_590_id { get; set; }
//        public int list_590_point { get; set; }
//        public int list_591_id { get; set; }
//        public int list_591_point { get; set; }
//        public int list_592_id { get; set; }
//        public int list_592_point { get; set; }
//        public int list_593_id { get; set; }
//        public int list_593_point { get; set; }
//        public int list_594_id { get; set; }
//        public int list_594_point { get; set; }
//        public int list_595_id { get; set; }
//        public int list_595_point { get; set; }
//        public int list_596_id { get; set; }
//        public int list_596_point { get; set; }
//        public int list_597_id { get; set; }
//        public int list_597_point { get; set; }
//        public int list_598_id { get; set; }
//        public int list_598_point { get; set; }
//        public int list_599_id { get; set; }
//        public int list_599_point { get; set; }
//        public int list_600_id { get; set; }
//        public int list_600_point { get; set; }
//        public int list_601_id { get; set; }
//        public int list_601_point { get; set; }
//        public int list_602_id { get; set; }
//        public int list_602_point { get; set; }
//        public int list_603_id { get; set; }
//        public int list_603_point { get; set; }
//        public int list_604_id { get; set; }
//        public int list_604_point { get; set; }
//        public int list_605_id { get; set; }
//        public int list_605_point { get; set; }
//        public int list_606_id { get; set; }
//        public int list_606_point { get; set; }
//        public int list_607_id { get; set; }
//        public int list_607_point { get; set; }
//        public int list_608_id { get; set; }
//        public int list_608_point { get; set; }
//        public int list_609_id { get; set; }
//        public int list_609_point { get; set; }
//        public int list_610_id { get; set; }
//        public int list_610_point { get; set; }
//        public int list_611_id { get; set; }
//        public int list_611_point { get; set; }
//        public int list_612_id { get; set; }
//        public int list_612_point { get; set; }
//        public int list_613_id { get; set; }
//        public int list_613_point { get; set; }
//        public int list_614_id { get; set; }
//        public int list_614_point { get; set; }
//        public int list_615_id { get; set; }
//        public int list_615_point { get; set; }
//        public int list_616_id { get; set; }
//        public int list_616_point { get; set; }
//        public int list_617_id { get; set; }
//        public int list_617_point { get; set; }
//        public int list_618_id { get; set; }
//        public int list_618_point { get; set; }
//        public int list_619_id { get; set; }
//        public int list_619_point { get; set; }
//        public int list_620_id { get; set; }
//        public int list_620_point { get; set; }
//        public int list_621_id { get; set; }
//        public int list_621_point { get; set; }
//        public int list_622_id { get; set; }
//        public int list_622_point { get; set; }
//        public int list_623_id { get; set; }
//        public int list_623_point { get; set; }
//        public int list_624_id { get; set; }
//        public int list_624_point { get; set; }
//        public int list_625_id { get; set; }
//        public int list_625_point { get; set; }
//        public int list_626_id { get; set; }
//        public int list_626_point { get; set; }
//        public int list_627_id { get; set; }
//        public int list_627_point { get; set; }
//        public int list_628_id { get; set; }
//        public int list_628_point { get; set; }
//        public int list_629_id { get; set; }
//        public int list_629_point { get; set; }
//        public int list_630_id { get; set; }
//        public int list_630_point { get; set; }
//        public int list_631_id { get; set; }
//        public int list_631_point { get; set; }
//        public int list_632_id { get; set; }
//        public int list_632_point { get; set; }
//        public int list_633_id { get; set; }
//        public int list_633_point { get; set; }
//        public int list_634_id { get; set; }
//        public int list_634_point { get; set; }
//        public int list_635_id { get; set; }
//        public int list_635_point { get; set; }
//        public int list_636_id { get; set; }
//        public int list_636_point { get; set; }
//        public int list_637_id { get; set; }
//        public int list_637_point { get; set; }
//        public int list_638_id { get; set; }
//        public int list_638_point { get; set; }
//        public int list_639_id { get; set; }
//        public int list_639_point { get; set; }
//        public int list_640_id { get; set; }
//        public int list_640_point { get; set; }
//        public int list_641_id { get; set; }
//        public int list_641_point { get; set; }
//        public int list_642_id { get; set; }
//        public int list_642_point { get; set; }
//        public int list_643_id { get; set; }
//        public int list_643_point { get; set; }
//        public int list_644_id { get; set; }
//        public int list_644_point { get; set; }
//        public int list_645_id { get; set; }
//        public int list_645_point { get; set; }
//        public int list_646_id { get; set; }
//        public int list_646_point { get; set; }
//        public int list_647_id { get; set; }
//        public int list_647_point { get; set; }
//        public int list_648_id { get; set; }
//        public int list_648_point { get; set; }
//        public int list_649_id { get; set; }
//        public int list_649_point { get; set; }
//        public int list_650_id { get; set; }
//        public int list_650_point { get; set; }
//        public int list_651_id { get; set; }
//        public int list_651_point { get; set; }
//        public int list_652_id { get; set; }
//        public int list_652_point { get; set; }
//        public int list_653_id { get; set; }
//        public int list_653_point { get; set; }
//        public int list_654_id { get; set; }
//        public int list_654_point { get; set; }
//        public int list_655_id { get; set; }
//        public int list_655_point { get; set; }
//        public int list_656_id { get; set; }
//        public int list_656_point { get; set; }
//        public int list_657_id { get; set; }
//        public int list_657_point { get; set; }
//        public int list_658_id { get; set; }
//        public int list_658_point { get; set; }
//        public int list_659_id { get; set; }
//        public int list_659_point { get; set; }
//        public int list_660_id { get; set; }
//        public int list_660_point { get; set; }
//        public int list_661_id { get; set; }
//        public int list_661_point { get; set; }
//        public int list_662_id { get; set; }
//        public int list_662_point { get; set; }
//        public int list_663_id { get; set; }
//        public int list_663_point { get; set; }
//        public int list_664_id { get; set; }
//        public int list_664_point { get; set; }
//        public int list_665_id { get; set; }
//        public int list_665_point { get; set; }
//        public int list_666_id { get; set; }
//        public int list_666_point { get; set; }
//        public int list_667_id { get; set; }
//        public int list_667_point { get; set; }
//        public int list_668_id { get; set; }
//        public int list_668_point { get; set; }
//        public int list_669_id { get; set; }
//        public int list_669_point { get; set; }
//        public int list_670_id { get; set; }
//        public int list_670_point { get; set; }
//        public int list_671_id { get; set; }
//        public int list_671_point { get; set; }
//        public int list_672_id { get; set; }
//        public int list_672_point { get; set; }
//        public int list_673_id { get; set; }
//        public int list_673_point { get; set; }
//        public int list_674_id { get; set; }
//        public int list_674_point { get; set; }
//        public int list_675_id { get; set; }
//        public int list_675_point { get; set; }
//        public int list_676_id { get; set; }
//        public int list_676_point { get; set; }
//        public int list_677_id { get; set; }
//        public int list_677_point { get; set; }
//        public int list_678_id { get; set; }
//        public int list_678_point { get; set; }
//        public int list_679_id { get; set; }
//        public int list_679_point { get; set; }
//        public int list_680_id { get; set; }
//        public int list_680_point { get; set; }
//        public int list_681_id { get; set; }
//        public int list_681_point { get; set; }
//        public int list_682_id { get; set; }
//        public int list_682_point { get; set; }
//        public int list_683_id { get; set; }
//        public int list_683_point { get; set; }
//        public int list_684_id { get; set; }
//        public int list_684_point { get; set; }
//        public int list_685_id { get; set; }
//        public int list_685_point { get; set; }
//        public int list_686_id { get; set; }
//        public int list_686_point { get; set; }
//        public int list_687_id { get; set; }
//        public int list_687_point { get; set; }
//        public int list_688_id { get; set; }
//        public int list_688_point { get; set; }
//        public int list_689_id { get; set; }
//        public int list_689_point { get; set; }
//        public int list_690_id { get; set; }
//        public int list_690_point { get; set; }
//        public int list_691_id { get; set; }
//        public int list_691_point { get; set; }
//        public int list_692_id { get; set; }
//        public int list_692_point { get; set; }
//        public int list_693_id { get; set; }
//        public int list_693_point { get; set; }
//        public int list_694_id { get; set; }
//        public int list_694_point { get; set; }
//        public int list_695_id { get; set; }
//        public int list_695_point { get; set; }
//        public int list_696_id { get; set; }
//        public int list_696_point { get; set; }
//        public int list_697_id { get; set; }
//        public int list_697_point { get; set; }
//        public int list_698_id { get; set; }
//        public int list_698_point { get; set; }
//        public int list_699_id { get; set; }
//        public int list_699_point { get; set; }
//        public int list_700_id { get; set; }
//        public int list_700_point { get; set; }
//        public int list_701_id { get; set; }
//        public int list_701_point { get; set; }
//        public int list_702_id { get; set; }
//        public int list_702_point { get; set; }
//        public int list_703_id { get; set; }
//        public int list_703_point { get; set; }
//        public int list_704_id { get; set; }
//        public int list_704_point { get; set; }
//        public int list_705_id { get; set; }
//        public int list_705_point { get; set; }
//        public int list_706_id { get; set; }
//        public int list_706_point { get; set; }
//        public int list_707_id { get; set; }
//        public int list_707_point { get; set; }
//        public int list_708_id { get; set; }
//        public int list_708_point { get; set; }
//        public int list_709_id { get; set; }
//        public int list_709_point { get; set; }
//        public int list_710_id { get; set; }
//        public int list_710_point { get; set; }
//        public int list_711_id { get; set; }
//        public int list_711_point { get; set; }
//        public int list_712_id { get; set; }
//        public int list_712_point { get; set; }
//        public int list_713_id { get; set; }
//        public int list_713_point { get; set; }
//        public int list_714_id { get; set; }
//        public int list_714_point { get; set; }
//        public int list_715_id { get; set; }
//        public int list_715_point { get; set; }
//        public int list_716_id { get; set; }
//        public int list_716_point { get; set; }
//        public int list_717_id { get; set; }
//        public int list_717_point { get; set; }
//        public int list_718_id { get; set; }
//        public int list_718_point { get; set; }
//        public int list_719_id { get; set; }
//        public int list_719_point { get; set; }
//        public int list_720_id { get; set; }
//        public int list_720_point { get; set; }
//        public int list_721_id { get; set; }
//        public int list_721_point { get; set; }
//        public int list_722_id { get; set; }
//        public int list_722_point { get; set; }
//        public int list_723_id { get; set; }
//        public int list_723_point { get; set; }
//        public int list_724_id { get; set; }
//        public int list_724_point { get; set; }
//        public int list_725_id { get; set; }
//        public int list_725_point { get; set; }
//        public int list_726_id { get; set; }
//        public int list_726_point { get; set; }
//        public int list_727_id { get; set; }
//        public int list_727_point { get; set; }
//        public int list_728_id { get; set; }
//        public int list_728_point { get; set; }
//        public int list_729_id { get; set; }
//        public int list_729_point { get; set; }
//        public int list_730_id { get; set; }
//        public int list_730_point { get; set; }
//        public int list_731_id { get; set; }
//        public int list_731_point { get; set; }
//        public int list_732_id { get; set; }
//        public int list_732_point { get; set; }
//        public int list_733_id { get; set; }
//        public int list_733_point { get; set; }
//        public int list_734_id { get; set; }
//        public int list_734_point { get; set; }
//        public int list_735_id { get; set; }
//        public int list_735_point { get; set; }
//        public int list_736_id { get; set; }
//        public int list_736_point { get; set; }
//        public int list_737_id { get; set; }
//        public int list_737_point { get; set; }
//        public int list_738_id { get; set; }
//        public int list_738_point { get; set; }
//        public int list_739_id { get; set; }
//        public int list_739_point { get; set; }
//        public int list_740_id { get; set; }
//        public int list_740_point { get; set; }
//        public int list_741_id { get; set; }
//        public int list_741_point { get; set; }
//        public int list_742_id { get; set; }
//        public int list_742_point { get; set; }
//        public int list_743_id { get; set; }
//        public int list_743_point { get; set; }
//        public int list_744_id { get; set; }
//        public int list_744_point { get; set; }
//        public int list_745_id { get; set; }
//        public int list_745_point { get; set; }
//        public int list_746_id { get; set; }
//        public int list_746_point { get; set; }
//        public int list_747_id { get; set; }
//        public int list_747_point { get; set; }
//        public int list_748_id { get; set; }
//        public int list_748_point { get; set; }
//        public int list_749_id { get; set; }
//        public int list_749_point { get; set; }
//        public int list_750_id { get; set; }
//        public int list_750_point { get; set; }
//        public int list_751_id { get; set; }
//        public int list_751_point { get; set; }
//        public int list_752_id { get; set; }
//        public int list_752_point { get; set; }
//        public int list_753_id { get; set; }
//        public int list_753_point { get; set; }
//        public int list_754_id { get; set; }
//        public int list_754_point { get; set; }
//        public int list_755_id { get; set; }
//        public int list_755_point { get; set; }
//        public int list_756_id { get; set; }
//        public int list_756_point { get; set; }
//        public int list_757_id { get; set; }
//        public int list_757_point { get; set; }
//        public int list_758_id { get; set; }
//        public int list_758_point { get; set; }
//        public int list_759_id { get; set; }
//        public int list_759_point { get; set; }
//        public int list_760_id { get; set; }
//        public int list_760_point { get; set; }
//        public int list_761_id { get; set; }
//        public int list_761_point { get; set; }
//        public int list_762_id { get; set; }
//        public int list_762_point { get; set; }
//        public int list_763_id { get; set; }
//        public int list_763_point { get; set; }
//        public int list_764_id { get; set; }
//        public int list_764_point { get; set; }
//        public int list_765_id { get; set; }
//        public int list_765_point { get; set; }
//        public int list_766_id { get; set; }
//        public int list_766_point { get; set; }
//        public int list_767_id { get; set; }
//        public int list_767_point { get; set; }
//        public int list_768_id { get; set; }
//        public int list_768_point { get; set; }
//        public int list_769_id { get; set; }
//        public int list_769_point { get; set; }
//        public int list_770_id { get; set; }
//        public int list_770_point { get; set; }
//        public int list_771_id { get; set; }
//        public int list_771_point { get; set; }
//        public int list_772_id { get; set; }
//        public int list_772_point { get; set; }
//        public int list_773_id { get; set; }
//        public int list_773_point { get; set; }
//        public int list_774_id { get; set; }
//        public int list_774_point { get; set; }
//        public int list_775_id { get; set; }
//        public int list_775_point { get; set; }
//        public int list_776_id { get; set; }
//        public int list_776_point { get; set; }
//        public int list_777_id { get; set; }
//        public int list_777_point { get; set; }
//        public int list_778_id { get; set; }
//        public int list_778_point { get; set; }
//        public int list_779_id { get; set; }
//        public int list_779_point { get; set; }
//        public int list_780_id { get; set; }
//        public int list_780_point { get; set; }
//        public int list_781_id { get; set; }
//        public int list_781_point { get; set; }
//        public int list_782_id { get; set; }
//        public int list_782_point { get; set; }
//        public int list_783_id { get; set; }
//        public int list_783_point { get; set; }
//        public int list_784_id { get; set; }
//        public int list_784_point { get; set; }
//        public int list_785_id { get; set; }
//        public int list_785_point { get; set; }
//        public int list_786_id { get; set; }
//        public int list_786_point { get; set; }
//        public int list_787_id { get; set; }
//        public int list_787_point { get; set; }
//        public int list_788_id { get; set; }
//        public int list_788_point { get; set; }
//        public int list_789_id { get; set; }
//        public int list_789_point { get; set; }
//        public int list_790_id { get; set; }
//        public int list_790_point { get; set; }
//        public int list_791_id { get; set; }
//        public int list_791_point { get; set; }
//        public int list_792_id { get; set; }
//        public int list_792_point { get; set; }
//        public int list_793_id { get; set; }
//        public int list_793_point { get; set; }
//        public int list_794_id { get; set; }
//        public int list_794_point { get; set; }
//        public int list_795_id { get; set; }
//        public int list_795_point { get; set; }
//        public int list_796_id { get; set; }
//        public int list_796_point { get; set; }
//        public int list_797_id { get; set; }
//        public int list_797_point { get; set; }
//        public int list_798_id { get; set; }
//        public int list_798_point { get; set; }
//        public int list_799_id { get; set; }
//        public int list_799_point { get; set; }
//        public int list_800_id { get; set; }
//        public int list_800_point { get; set; }
//        public int list_801_id { get; set; }
//        public int list_801_point { get; set; }
//        public int list_802_id { get; set; }
//        public int list_802_point { get; set; }
//        public int list_803_id { get; set; }
//        public int list_803_point { get; set; }
//        public int list_804_id { get; set; }
//        public int list_804_point { get; set; }
//        public int list_805_id { get; set; }
//        public int list_805_point { get; set; }
//        public int list_806_id { get; set; }
//        public int list_806_point { get; set; }
//        public int list_807_id { get; set; }
//        public int list_807_point { get; set; }
//        public int list_808_id { get; set; }
//        public int list_808_point { get; set; }
//        public int list_809_id { get; set; }
//        public int list_809_point { get; set; }
//        public int list_810_id { get; set; }
//        public int list_810_point { get; set; }
//        public int list_811_id { get; set; }
//        public int list_811_point { get; set; }
//        public int list_812_id { get; set; }
//        public int list_812_point { get; set; }
//        public int list_813_id { get; set; }
//        public int list_813_point { get; set; }
//        public int list_814_id { get; set; }
//        public int list_814_point { get; set; }
//        public int list_815_id { get; set; }
//        public int list_815_point { get; set; }
//        public int list_816_id { get; set; }
//        public int list_816_point { get; set; }
//        public int list_817_id { get; set; }
//        public int list_817_point { get; set; }
//        public int list_818_id { get; set; }
//        public int list_818_point { get; set; }
//        public int list_819_id { get; set; }
//        public int list_819_point { get; set; }
//        public int list_820_id { get; set; }
//        public int list_820_point { get; set; }
//        public int list_821_id { get; set; }
//        public int list_821_point { get; set; }
//        public int list_822_id { get; set; }
//        public int list_822_point { get; set; }
//        public int list_823_id { get; set; }
//        public int list_823_point { get; set; }
//        public int list_824_id { get; set; }
//        public int list_824_point { get; set; }
//        public int list_825_id { get; set; }
//        public int list_825_point { get; set; }
//        public int list_826_id { get; set; }
//        public int list_826_point { get; set; }
//        public int list_827_id { get; set; }
//        public int list_827_point { get; set; }
//        public int list_828_id { get; set; }
//        public int list_828_point { get; set; }
//        public int list_829_id { get; set; }
//        public int list_829_point { get; set; }
//        public int list_830_id { get; set; }
//        public int list_830_point { get; set; }
//        public int list_831_id { get; set; }
//        public int list_831_point { get; set; }
//        public int list_832_id { get; set; }
//        public int list_832_point { get; set; }
//        public int list_833_id { get; set; }
//        public int list_833_point { get; set; }
//        public int list_834_id { get; set; }
//        public int list_834_point { get; set; }
//        public int list_835_id { get; set; }
//        public int list_835_point { get; set; }
//        public int list_836_id { get; set; }
//        public int list_836_point { get; set; }
//        public int list_837_id { get; set; }
//        public int list_837_point { get; set; }
//        public int list_838_id { get; set; }
//        public int list_838_point { get; set; }
//        public int list_839_id { get; set; }
//        public int list_839_point { get; set; }
//        public int list_840_id { get; set; }
//        public int list_840_point { get; set; }
//        public int list_841_id { get; set; }
//        public int list_841_point { get; set; }
//        public int list_842_id { get; set; }
//        public int list_842_point { get; set; }
//        public int list_843_id { get; set; }
//        public int list_843_point { get; set; }
//        public int list_844_id { get; set; }
//        public int list_844_point { get; set; }
//        public int list_845_id { get; set; }
//        public int list_845_point { get; set; }
//        public int list_846_id { get; set; }
//        public int list_846_point { get; set; }
//        public int list_847_id { get; set; }
//        public int list_847_point { get; set; }
//        public int list_848_id { get; set; }
//        public int list_848_point { get; set; }
//        public int list_849_id { get; set; }
//        public int list_849_point { get; set; }
//        public int list_850_id { get; set; }
//        public int list_850_point { get; set; }
//        public int list_851_id { get; set; }
//        public int list_851_point { get; set; }
//        public int list_852_id { get; set; }
//        public int list_852_point { get; set; }
//        public int list_853_id { get; set; }
//        public int list_853_point { get; set; }
//        public int list_854_id { get; set; }
//        public int list_854_point { get; set; }
//        public int list_855_id { get; set; }
//        public int list_855_point { get; set; }
//        public int list_856_id { get; set; }
//        public int list_856_point { get; set; }
//        public int list_857_id { get; set; }
//        public int list_857_point { get; set; }
//        public int list_858_id { get; set; }
//        public int list_858_point { get; set; }
//        public int list_859_id { get; set; }
//        public int list_859_point { get; set; }
//        public int list_860_id { get; set; }
//        public int list_860_point { get; set; }
//        public int list_861_id { get; set; }
//        public int list_861_point { get; set; }
//        public int list_862_id { get; set; }
//        public int list_862_point { get; set; }
//        public int list_863_id { get; set; }
//        public int list_863_point { get; set; }
//        public int list_864_id { get; set; }
//        public int list_864_point { get; set; }
//        public int list_865_id { get; set; }
//        public int list_865_point { get; set; }
//        public int list_866_id { get; set; }
//        public int list_866_point { get; set; }
//        public int list_867_id { get; set; }
//        public int list_867_point { get; set; }
//        public int list_868_id { get; set; }
//        public int list_868_point { get; set; }
//        public int list_869_id { get; set; }
//        public int list_869_point { get; set; }
//        public int list_870_id { get; set; }
//        public int list_870_point { get; set; }
//        public int list_871_id { get; set; }
//        public int list_871_point { get; set; }
//        public int list_872_id { get; set; }
//        public int list_872_point { get; set; }
//        public int list_873_id { get; set; }
//        public int list_873_point { get; set; }
//        public int list_874_id { get; set; }
//        public int list_874_point { get; set; }
//        public int list_875_id { get; set; }
//        public int list_875_point { get; set; }
//        public int list_876_id { get; set; }
//        public int list_876_point { get; set; }
//        public int list_877_id { get; set; }
//        public int list_877_point { get; set; }
//        public int list_878_id { get; set; }
//        public int list_878_point { get; set; }
//        public int list_879_id { get; set; }
//        public int list_879_point { get; set; }
//        public int list_880_id { get; set; }
//        public int list_880_point { get; set; }
//        public int list_881_id { get; set; }
//        public int list_881_point { get; set; }
//        public int list_882_id { get; set; }
//        public int list_882_point { get; set; }
//        public int list_883_id { get; set; }
//        public int list_883_point { get; set; }
//        public int list_884_id { get; set; }
//        public int list_884_point { get; set; }
//        public int list_885_id { get; set; }
//        public int list_885_point { get; set; }
//        public int list_886_id { get; set; }
//        public int list_886_point { get; set; }
//        public int list_887_id { get; set; }
//        public int list_887_point { get; set; }
//        public int list_888_id { get; set; }
//        public int list_888_point { get; set; }
//        public int list_889_id { get; set; }
//        public int list_889_point { get; set; }
//        public int list_890_id { get; set; }
//        public int list_890_point { get; set; }
//        public int list_891_id { get; set; }
//        public int list_891_point { get; set; }
//        public int list_892_id { get; set; }
//        public int list_892_point { get; set; }
//        public int list_893_id { get; set; }
//        public int list_893_point { get; set; }
//        public int list_894_id { get; set; }
//        public int list_894_point { get; set; }
//        public int list_895_id { get; set; }
//        public int list_895_point { get; set; }
//        public int list_896_id { get; set; }
//        public int list_896_point { get; set; }
//        public int list_897_id { get; set; }
//        public int list_897_point { get; set; }
//        public int list_898_id { get; set; }
//        public int list_898_point { get; set; }
//        public int list_899_id { get; set; }
//        public int list_899_point { get; set; }
//        public int list_900_id { get; set; }
//        public int list_900_point { get; set; }
//        public int list_901_id { get; set; }
//        public int list_901_point { get; set; }
//        public int list_902_id { get; set; }
//        public int list_902_point { get; set; }
//        public int list_903_id { get; set; }
//        public int list_903_point { get; set; }
//        public int list_904_id { get; set; }
//        public int list_904_point { get; set; }
//        public int list_905_id { get; set; }
//        public int list_905_point { get; set; }
//        public int list_906_id { get; set; }
//        public int list_906_point { get; set; }
//        public int list_907_id { get; set; }
//        public int list_907_point { get; set; }
//        public int list_908_id { get; set; }
//        public int list_908_point { get; set; }
//        public int list_909_id { get; set; }
//        public int list_909_point { get; set; }
//        public int list_910_id { get; set; }
//        public int list_910_point { get; set; }
//        public int list_911_id { get; set; }
//        public int list_911_point { get; set; }
//        public int list_912_id { get; set; }
//        public int list_912_point { get; set; }
//        public int list_913_id { get; set; }
//        public int list_913_point { get; set; }
//        public int list_914_id { get; set; }
//        public int list_914_point { get; set; }
//        public int list_915_id { get; set; }
//        public int list_915_point { get; set; }
//        public int list_916_id { get; set; }
//        public int list_916_point { get; set; }
//        public int list_917_id { get; set; }
//        public int list_917_point { get; set; }
//        public int list_918_id { get; set; }
//        public int list_918_point { get; set; }
//        public int list_919_id { get; set; }
//        public int list_919_point { get; set; }
//        public int list_920_id { get; set; }
//        public int list_920_point { get; set; }
//        public int list_921_id { get; set; }
//        public int list_921_point { get; set; }
//        public int list_922_id { get; set; }
//        public int list_922_point { get; set; }
//        public int list_923_id { get; set; }
//        public int list_923_point { get; set; }
//        public int list_924_id { get; set; }
//        public int list_924_point { get; set; }
//        public int list_925_id { get; set; }
//        public int list_925_point { get; set; }
//        public int list_926_id { get; set; }
//        public int list_926_point { get; set; }
//        public int list_927_id { get; set; }
//        public int list_927_point { get; set; }
//        public int list_928_id { get; set; }
//        public int list_928_point { get; set; }
//        public int list_929_id { get; set; }
//        public int list_929_point { get; set; }
//        public int list_930_id { get; set; }
//        public int list_930_point { get; set; }
//        public int list_931_id { get; set; }
//        public int list_931_point { get; set; }
//        public int list_932_id { get; set; }
//        public int list_932_point { get; set; }
//        public int list_933_id { get; set; }
//        public int list_933_point { get; set; }
//        public int list_934_id { get; set; }
//        public int list_934_point { get; set; }
//        public int list_935_id { get; set; }
//        public int list_935_point { get; set; }
//        public int list_936_id { get; set; }
//        public int list_936_point { get; set; }
//        public int list_937_id { get; set; }
//        public int list_937_point { get; set; }
//        public int list_938_id { get; set; }
//        public int list_938_point { get; set; }
//        public int list_939_id { get; set; }
//        public int list_939_point { get; set; }
//        public int list_940_id { get; set; }
//        public int list_940_point { get; set; }
//        public int list_941_id { get; set; }
//        public int list_941_point { get; set; }
//        public int list_942_id { get; set; }
//        public int list_942_point { get; set; }
//        public int list_943_id { get; set; }
//        public int list_943_point { get; set; }
//        public int list_944_id { get; set; }
//        public int list_944_point { get; set; }
//        public int list_945_id { get; set; }
//        public int list_945_point { get; set; }
//        public int list_946_id { get; set; }
//        public int list_946_point { get; set; }
//        public int list_947_id { get; set; }
//        public int list_947_point { get; set; }
//        public int list_948_id { get; set; }
//        public int list_948_point { get; set; }
//        public int list_949_id { get; set; }
//        public int list_949_point { get; set; }
//        public int list_950_id { get; set; }
//        public int list_950_point { get; set; }
//        public int list_951_id { get; set; }
//        public int list_951_point { get; set; }
//        public int list_952_id { get; set; }
//        public int list_952_point { get; set; }
//        public int list_953_id { get; set; }
//        public int list_953_point { get; set; }
//        public int list_954_id { get; set; }
//        public int list_954_point { get; set; }
//        public int list_955_id { get; set; }
//        public int list_955_point { get; set; }
//        public int list_956_id { get; set; }
//        public int list_956_point { get; set; }
//        public int list_957_id { get; set; }
//        public int list_957_point { get; set; }
//        public int list_958_id { get; set; }
//        public int list_958_point { get; set; }
//        public int list_959_id { get; set; }
//        public int list_959_point { get; set; }
//        public int list_960_id { get; set; }
//        public int list_960_point { get; set; }
//        public int list_961_id { get; set; }
//        public int list_961_point { get; set; }
//        public int list_962_id { get; set; }
//        public int list_962_point { get; set; }
//        public int list_963_id { get; set; }
//        public int list_963_point { get; set; }
//        public int list_964_id { get; set; }
//        public int list_964_point { get; set; }
//        public int list_965_id { get; set; }
//        public int list_965_point { get; set; }
//        public int list_966_id { get; set; }
//        public int list_966_point { get; set; }
//        public int list_967_id { get; set; }
//        public int list_967_point { get; set; }
//        public int list_968_id { get; set; }
//        public int list_968_point { get; set; }
//        public int list_969_id { get; set; }
//        public int list_969_point { get; set; }
//        public int list_970_id { get; set; }
//        public int list_970_point { get; set; }
//        public int list_971_id { get; set; }
//        public int list_971_point { get; set; }
//        public int list_972_id { get; set; }
//        public int list_972_point { get; set; }
//        public int list_973_id { get; set; }
//        public int list_973_point { get; set; }
//        public int list_974_id { get; set; }
//        public int list_974_point { get; set; }
//        public int list_975_id { get; set; }
//        public int list_975_point { get; set; }
//        public int list_976_id { get; set; }
//        public int list_976_point { get; set; }
//        public int list_977_id { get; set; }
//        public int list_977_point { get; set; }
//        public int list_978_id { get; set; }
//        public int list_978_point { get; set; }
//        public int list_979_id { get; set; }
//        public int list_979_point { get; set; }
//        public int list_980_id { get; set; }
//        public int list_980_point { get; set; }
//        public int list_981_id { get; set; }
//        public int list_981_point { get; set; }
//        public int list_982_id { get; set; }
//        public int list_982_point { get; set; }
//        public int list_983_id { get; set; }
//        public int list_983_point { get; set; }
//        public int list_984_id { get; set; }
//        public int list_984_point { get; set; }
//        public int list_985_id { get; set; }
//        public int list_985_point { get; set; }
//        public int list_986_id { get; set; }
//        public int list_986_point { get; set; }
//        public int list_987_id { get; set; }
//        public int list_987_point { get; set; }
//        public int list_988_id { get; set; }
//        public int list_988_point { get; set; }
//        public int list_989_id { get; set; }
//        public int list_989_point { get; set; }
//        public int list_990_id { get; set; }
//        public int list_990_point { get; set; }
//        public int list_991_id { get; set; }
//        public int list_991_point { get; set; }
//        public int list_992_id { get; set; }
//        public int list_992_point { get; set; }
//        public int list_993_id { get; set; }
//        public int list_993_point { get; set; }
//        public int list_994_id { get; set; }
//        public int list_994_point { get; set; }
//        public int list_995_id { get; set; }
//        public int list_995_point { get; set; }
//        public int list_996_id { get; set; }
//        public int list_996_point { get; set; }
//        public int list_997_id { get; set; }
//        public int list_997_point { get; set; }
//        public int list_998_id { get; set; }
//        public int list_998_point { get; set; }
//        public int list_999_id { get; set; }
//        public int list_999_point { get; set; }
//        public int list_1000_id { get; set; }
//        public int list_1000_point { get; set; }
//        public int list_1001_id { get; set; }
//        public int list_1001_point { get; set; }
//        public int list_1002_id { get; set; }
//        public int list_1002_point { get; set; }
//        public int list_1003_id { get; set; }
//        public int list_1003_point { get; set; }
//        public int list_1004_id { get; set; }
//        public int list_1004_point { get; set; }
//        public int list_1005_id { get; set; }
//        public int list_1005_point { get; set; }
//        public int list_1006_id { get; set; }
//        public int list_1006_point { get; set; }
//        public int list_1007_id { get; set; }
//        public int list_1007_point { get; set; }
//        public int list_1008_id { get; set; }
//        public int list_1008_point { get; set; }
//        public int list_1009_id { get; set; }
//        public int list_1009_point { get; set; }
//        public int list_1010_id { get; set; }
//        public int list_1010_point { get; set; }
//        public int list_1011_id { get; set; }
//        public int list_1011_point { get; set; }
//        public int list_1012_id { get; set; }
//        public int list_1012_point { get; set; }
//        public int list_1013_id { get; set; }
//        public int list_1013_point { get; set; }
//        public int list_1014_id { get; set; }
//        public int list_1014_point { get; set; }
//        public int list_1015_id { get; set; }
//        public int list_1015_point { get; set; }
//        public int list_1016_id { get; set; }
//        public int list_1016_point { get; set; }
//        public int list_1017_id { get; set; }
//        public int list_1017_point { get; set; }
//        public int list_1018_id { get; set; }
//        public int list_1018_point { get; set; }
//        public int list_1019_id { get; set; }
//        public int list_1019_point { get; set; }
//        public int list_1020_id { get; set; }
//        public int list_1020_point { get; set; }
//        public int list_1021_id { get; set; }
//        public int list_1021_point { get; set; }
//        public int list_1022_id { get; set; }
//        public int list_1022_point { get; set; }
//        public int list_1023_id { get; set; }
//        public int list_1023_point { get; set; }
//        public int list_1024_id { get; set; }
//        public int list_1024_point { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class ONLINE_AWARDS_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        public int max_time { get; set; }
//        public int choice_1_time { get; set; }
//        public int choice_1_interval { get; set; }
//        public int choice_1_ids_1 { get; set; }
//        public int choice_1_ids_2 { get; set; }
//        public int choice_1_ids_3 { get; set; }
//        public int choice_1_ids_4 { get; set; }
//        public int choice_1_ids_5 { get; set; }
//        public int choice_1_ids_6 { get; set; }
//        public int choice_1_ids_7 { get; set; }
//        public int choice_1_ids_8 { get; set; }
//        public int choice_1_exp_1 { get; set; }
//        public int choice_1_exp_2 { get; set; }
//        public int choice_1_exp_3 { get; set; }
//        public int choice_1_exp_4 { get; set; }
//        public int choice_1_exp_5 { get; set; }
//        public int choice_1_exp_6 { get; set; }
//        public int choice_1_exp_7 { get; set; }
//        public int choice_1_exp_8 { get; set; }
//        public int choice_1_exp_9 { get; set; }
//        public int choice_1_exp_10 { get; set; }
//        public int choice_1_exp_11 { get; set; }
//        public int choice_1_exp_12 { get; set; }
//        public int choice_1_exp_13 { get; set; }
//        public int choice_1_exp_14 { get; set; }
//        public int choice_1_exp_15 { get; set; }
//        public int choice_1_exp_16 { get; set; }
//        public int choice_1_exp_17 { get; set; }
//        public int choice_1_exp_18 { get; set; }
//        public int choice_1_exp_19 { get; set; }
//        public int choice_1_exp_20 { get; set; }
//        public int choice_1_exp_21 { get; set; }
//        public int choice_1_exp_22 { get; set; }
//        public int choice_1_exp_23 { get; set; }
//        public int choice_1_exp_24 { get; set; }
//        public int choice_1_exp_25 { get; set; }
//        public int choice_1_exp_26 { get; set; }
//        public int choice_1_exp_27 { get; set; }
//        public int choice_1_exp_28 { get; set; }
//        public int choice_1_exp_29 { get; set; }
//        public int choice_1_exp_30 { get; set; }
//        public int choice_1_exp_31 { get; set; }
//        public int choice_1_exp_32 { get; set; }
//        public int choice_1_exp_33 { get; set; }
//        public int choice_1_exp_34 { get; set; }
//        public int choice_1_exp_35 { get; set; }
//        public int choice_1_exp_36 { get; set; }
//        public int choice_1_exp_37 { get; set; }
//        public int choice_1_exp_38 { get; set; }
//        public int choice_1_exp_39 { get; set; }
//        public int choice_1_exp_40 { get; set; }
//        public int choice_1_exp_41 { get; set; }
//        public int choice_1_exp_42 { get; set; }
//        public int choice_1_exp_43 { get; set; }
//        public int choice_1_exp_44 { get; set; }
//        public int choice_1_exp_45 { get; set; }
//        public int choice_1_exp_46 { get; set; }
//        public int choice_1_exp_47 { get; set; }
//        public int choice_1_exp_48 { get; set; }
//        public int choice_1_exp_49 { get; set; }
//        public int choice_1_exp_50 { get; set; }
//        public int choice_1_exp_51 { get; set; }
//        public int choice_1_exp_52 { get; set; }
//        public int choice_1_exp_53 { get; set; }
//        public int choice_1_exp_54 { get; set; }
//        public int choice_1_exp_55 { get; set; }
//        public int choice_1_exp_56 { get; set; }
//        public int choice_1_exp_57 { get; set; }
//        public int choice_1_exp_58 { get; set; }
//        public int choice_1_exp_59 { get; set; }
//        public int choice_1_exp_60 { get; set; }
//        public int choice_1_exp_61 { get; set; }
//        public int choice_1_exp_62 { get; set; }
//        public int choice_1_exp_63 { get; set; }
//        public int choice_1_exp_64 { get; set; }
//        public int choice_1_exp_65 { get; set; }
//        public int choice_1_exp_66 { get; set; }
//        public int choice_1_exp_67 { get; set; }
//        public int choice_1_exp_68 { get; set; }
//        public int choice_1_exp_69 { get; set; }
//        public int choice_1_exp_70 { get; set; }
//        public int choice_1_exp_71 { get; set; }
//        public int choice_1_exp_72 { get; set; }
//        public int choice_1_exp_73 { get; set; }
//        public int choice_1_exp_74 { get; set; }
//        public int choice_1_exp_75 { get; set; }
//        public int choice_1_exp_76 { get; set; }
//        public int choice_1_exp_77 { get; set; }
//        public int choice_1_exp_78 { get; set; }
//        public int choice_1_exp_79 { get; set; }
//        public int choice_1_exp_80 { get; set; }
//        public int choice_1_exp_81 { get; set; }
//        public int choice_1_exp_82 { get; set; }
//        public int choice_1_exp_83 { get; set; }
//        public int choice_1_exp_84 { get; set; }
//        public int choice_1_exp_85 { get; set; }
//        public int choice_1_exp_86 { get; set; }
//        public int choice_1_exp_87 { get; set; }
//        public int choice_1_exp_88 { get; set; }
//        public int choice_1_exp_89 { get; set; }
//        public int choice_1_exp_90 { get; set; }
//        public int choice_1_exp_91 { get; set; }
//        public int choice_1_exp_92 { get; set; }
//        public int choice_1_exp_93 { get; set; }
//        public int choice_1_exp_94 { get; set; }
//        public int choice_1_exp_95 { get; set; }
//        public int choice_1_exp_96 { get; set; }
//        public int choice_1_exp_97 { get; set; }
//        public int choice_1_exp_98 { get; set; }
//        public int choice_1_exp_99 { get; set; }
//        public int choice_1_exp_100 { get; set; }
//        public int choice_1_exp_101 { get; set; }
//        public int choice_1_exp_102 { get; set; }
//        public int choice_1_exp_103 { get; set; }
//        public int choice_1_exp_104 { get; set; }
//        public int choice_1_exp_105 { get; set; }
//        public int choice_1_exp_106 { get; set; }
//        public int choice_1_exp_107 { get; set; }
//        public int choice_1_exp_108 { get; set; }
//        public int choice_1_exp_109 { get; set; }
//        public int choice_1_exp_110 { get; set; }
//        public int choice_1_exp_111 { get; set; }
//        public int choice_1_exp_112 { get; set; }
//        public int choice_1_exp_113 { get; set; }
//        public int choice_1_exp_114 { get; set; }
//        public int choice_1_exp_115 { get; set; }
//        public int choice_1_exp_116 { get; set; }
//        public int choice_1_exp_117 { get; set; }
//        public int choice_1_exp_118 { get; set; }
//        public int choice_1_exp_119 { get; set; }
//        public int choice_1_exp_120 { get; set; }
//        public int choice_1_exp_121 { get; set; }
//        public int choice_1_exp_122 { get; set; }
//        public int choice_1_exp_123 { get; set; }
//        public int choice_1_exp_124 { get; set; }
//        public int choice_1_exp_125 { get; set; }
//        public int choice_1_exp_126 { get; set; }
//        public int choice_1_exp_127 { get; set; }
//        public int choice_1_exp_128 { get; set; }
//        public int choice_1_exp_129 { get; set; }
//        public int choice_1_exp_130 { get; set; }
//        public int choice_1_exp_131 { get; set; }
//        public int choice_1_exp_132 { get; set; }
//        public int choice_1_exp_133 { get; set; }
//        public int choice_1_exp_134 { get; set; }
//        public int choice_1_exp_135 { get; set; }
//        public int choice_1_exp_136 { get; set; }
//        public int choice_1_exp_137 { get; set; }
//        public int choice_1_exp_138 { get; set; }
//        public int choice_1_exp_139 { get; set; }
//        public int choice_1_exp_140 { get; set; }
//        public int choice_1_exp_141 { get; set; }
//        public int choice_1_exp_142 { get; set; }
//        public int choice_1_exp_143 { get; set; }
//        public int choice_1_exp_144 { get; set; }
//        public int choice_1_exp_145 { get; set; }
//        public int choice_1_exp_146 { get; set; }
//        public int choice_1_exp_147 { get; set; }
//        public int choice_1_exp_148 { get; set; }
//        public int choice_1_exp_149 { get; set; }
//        public int choice_1_exp_150 { get; set; }
//        public int choice_2_time { get; set; }
//        public int choice_2_interval { get; set; }
//        public int choice_2_ids_1 { get; set; }
//        public int choice_2_ids_2 { get; set; }
//        public int choice_2_ids_3 { get; set; }
//        public int choice_2_ids_4 { get; set; }
//        public int choice_2_ids_5 { get; set; }
//        public int choice_2_ids_6 { get; set; }
//        public int choice_2_ids_7 { get; set; }
//        public int choice_2_ids_8 { get; set; }
//        public int choice_2_exp_1 { get; set; }
//        public int choice_2_exp_2 { get; set; }
//        public int choice_2_exp_3 { get; set; }
//        public int choice_2_exp_4 { get; set; }
//        public int choice_2_exp_5 { get; set; }
//        public int choice_2_exp_6 { get; set; }
//        public int choice_2_exp_7 { get; set; }
//        public int choice_2_exp_8 { get; set; }
//        public int choice_2_exp_9 { get; set; }
//        public int choice_2_exp_10 { get; set; }
//        public int choice_2_exp_11 { get; set; }
//        public int choice_2_exp_12 { get; set; }
//        public int choice_2_exp_13 { get; set; }
//        public int choice_2_exp_14 { get; set; }
//        public int choice_2_exp_15 { get; set; }
//        public int choice_2_exp_16 { get; set; }
//        public int choice_2_exp_17 { get; set; }
//        public int choice_2_exp_18 { get; set; }
//        public int choice_2_exp_19 { get; set; }
//        public int choice_2_exp_20 { get; set; }
//        public int choice_2_exp_21 { get; set; }
//        public int choice_2_exp_22 { get; set; }
//        public int choice_2_exp_23 { get; set; }
//        public int choice_2_exp_24 { get; set; }
//        public int choice_2_exp_25 { get; set; }
//        public int choice_2_exp_26 { get; set; }
//        public int choice_2_exp_27 { get; set; }
//        public int choice_2_exp_28 { get; set; }
//        public int choice_2_exp_29 { get; set; }
//        public int choice_2_exp_30 { get; set; }
//        public int choice_2_exp_31 { get; set; }
//        public int choice_2_exp_32 { get; set; }
//        public int choice_2_exp_33 { get; set; }
//        public int choice_2_exp_34 { get; set; }
//        public int choice_2_exp_35 { get; set; }
//        public int choice_2_exp_36 { get; set; }
//        public int choice_2_exp_37 { get; set; }
//        public int choice_2_exp_38 { get; set; }
//        public int choice_2_exp_39 { get; set; }
//        public int choice_2_exp_40 { get; set; }
//        public int choice_2_exp_41 { get; set; }
//        public int choice_2_exp_42 { get; set; }
//        public int choice_2_exp_43 { get; set; }
//        public int choice_2_exp_44 { get; set; }
//        public int choice_2_exp_45 { get; set; }
//        public int choice_2_exp_46 { get; set; }
//        public int choice_2_exp_47 { get; set; }
//        public int choice_2_exp_48 { get; set; }
//        public int choice_2_exp_49 { get; set; }
//        public int choice_2_exp_50 { get; set; }
//        public int choice_2_exp_51 { get; set; }
//        public int choice_2_exp_52 { get; set; }
//        public int choice_2_exp_53 { get; set; }
//        public int choice_2_exp_54 { get; set; }
//        public int choice_2_exp_55 { get; set; }
//        public int choice_2_exp_56 { get; set; }
//        public int choice_2_exp_57 { get; set; }
//        public int choice_2_exp_58 { get; set; }
//        public int choice_2_exp_59 { get; set; }
//        public int choice_2_exp_60 { get; set; }
//        public int choice_2_exp_61 { get; set; }
//        public int choice_2_exp_62 { get; set; }
//        public int choice_2_exp_63 { get; set; }
//        public int choice_2_exp_64 { get; set; }
//        public int choice_2_exp_65 { get; set; }
//        public int choice_2_exp_66 { get; set; }
//        public int choice_2_exp_67 { get; set; }
//        public int choice_2_exp_68 { get; set; }
//        public int choice_2_exp_69 { get; set; }
//        public int choice_2_exp_70 { get; set; }
//        public int choice_2_exp_71 { get; set; }
//        public int choice_2_exp_72 { get; set; }
//        public int choice_2_exp_73 { get; set; }
//        public int choice_2_exp_74 { get; set; }
//        public int choice_2_exp_75 { get; set; }
//        public int choice_2_exp_76 { get; set; }
//        public int choice_2_exp_77 { get; set; }
//        public int choice_2_exp_78 { get; set; }
//        public int choice_2_exp_79 { get; set; }
//        public int choice_2_exp_80 { get; set; }
//        public int choice_2_exp_81 { get; set; }
//        public int choice_2_exp_82 { get; set; }
//        public int choice_2_exp_83 { get; set; }
//        public int choice_2_exp_84 { get; set; }
//        public int choice_2_exp_85 { get; set; }
//        public int choice_2_exp_86 { get; set; }
//        public int choice_2_exp_87 { get; set; }
//        public int choice_2_exp_88 { get; set; }
//        public int choice_2_exp_89 { get; set; }
//        public int choice_2_exp_90 { get; set; }
//        public int choice_2_exp_91 { get; set; }
//        public int choice_2_exp_92 { get; set; }
//        public int choice_2_exp_93 { get; set; }
//        public int choice_2_exp_94 { get; set; }
//        public int choice_2_exp_95 { get; set; }
//        public int choice_2_exp_96 { get; set; }
//        public int choice_2_exp_97 { get; set; }
//        public int choice_2_exp_98 { get; set; }
//        public int choice_2_exp_99 { get; set; }
//        public int choice_2_exp_100 { get; set; }
//        public int choice_2_exp_101 { get; set; }
//        public int choice_2_exp_102 { get; set; }
//        public int choice_2_exp_103 { get; set; }
//        public int choice_2_exp_104 { get; set; }
//        public int choice_2_exp_105 { get; set; }
//        public int choice_2_exp_106 { get; set; }
//        public int choice_2_exp_107 { get; set; }
//        public int choice_2_exp_108 { get; set; }
//        public int choice_2_exp_109 { get; set; }
//        public int choice_2_exp_110 { get; set; }
//        public int choice_2_exp_111 { get; set; }
//        public int choice_2_exp_112 { get; set; }
//        public int choice_2_exp_113 { get; set; }
//        public int choice_2_exp_114 { get; set; }
//        public int choice_2_exp_115 { get; set; }
//        public int choice_2_exp_116 { get; set; }
//        public int choice_2_exp_117 { get; set; }
//        public int choice_2_exp_118 { get; set; }
//        public int choice_2_exp_119 { get; set; }
//        public int choice_2_exp_120 { get; set; }
//        public int choice_2_exp_121 { get; set; }
//        public int choice_2_exp_122 { get; set; }
//        public int choice_2_exp_123 { get; set; }
//        public int choice_2_exp_124 { get; set; }
//        public int choice_2_exp_125 { get; set; }
//        public int choice_2_exp_126 { get; set; }
//        public int choice_2_exp_127 { get; set; }
//        public int choice_2_exp_128 { get; set; }
//        public int choice_2_exp_129 { get; set; }
//        public int choice_2_exp_130 { get; set; }
//        public int choice_2_exp_131 { get; set; }
//        public int choice_2_exp_132 { get; set; }
//        public int choice_2_exp_133 { get; set; }
//        public int choice_2_exp_134 { get; set; }
//        public int choice_2_exp_135 { get; set; }
//        public int choice_2_exp_136 { get; set; }
//        public int choice_2_exp_137 { get; set; }
//        public int choice_2_exp_138 { get; set; }
//        public int choice_2_exp_139 { get; set; }
//        public int choice_2_exp_140 { get; set; }
//        public int choice_2_exp_141 { get; set; }
//        public int choice_2_exp_142 { get; set; }
//        public int choice_2_exp_143 { get; set; }
//        public int choice_2_exp_144 { get; set; }
//        public int choice_2_exp_145 { get; set; }
//        public int choice_2_exp_146 { get; set; }
//        public int choice_2_exp_147 { get; set; }
//        public int choice_2_exp_148 { get; set; }
//        public int choice_2_exp_149 { get; set; }
//        public int choice_2_exp_150 { get; set; }
//        public int choice_3_time { get; set; }
//        public int choice_3_interval { get; set; }
//        public int choice_3_ids_1 { get; set; }
//        public int choice_3_ids_2 { get; set; }
//        public int choice_3_ids_3 { get; set; }
//        public int choice_3_ids_4 { get; set; }
//        public int choice_3_ids_5 { get; set; }
//        public int choice_3_ids_6 { get; set; }
//        public int choice_3_ids_7 { get; set; }
//        public int choice_3_ids_8 { get; set; }
//        public int choice_3_exp_1 { get; set; }
//        public int choice_3_exp_2 { get; set; }
//        public int choice_3_exp_3 { get; set; }
//        public int choice_3_exp_4 { get; set; }
//        public int choice_3_exp_5 { get; set; }
//        public int choice_3_exp_6 { get; set; }
//        public int choice_3_exp_7 { get; set; }
//        public int choice_3_exp_8 { get; set; }
//        public int choice_3_exp_9 { get; set; }
//        public int choice_3_exp_10 { get; set; }
//        public int choice_3_exp_11 { get; set; }
//        public int choice_3_exp_12 { get; set; }
//        public int choice_3_exp_13 { get; set; }
//        public int choice_3_exp_14 { get; set; }
//        public int choice_3_exp_15 { get; set; }
//        public int choice_3_exp_16 { get; set; }
//        public int choice_3_exp_17 { get; set; }
//        public int choice_3_exp_18 { get; set; }
//        public int choice_3_exp_19 { get; set; }
//        public int choice_3_exp_20 { get; set; }
//        public int choice_3_exp_21 { get; set; }
//        public int choice_3_exp_22 { get; set; }
//        public int choice_3_exp_23 { get; set; }
//        public int choice_3_exp_24 { get; set; }
//        public int choice_3_exp_25 { get; set; }
//        public int choice_3_exp_26 { get; set; }
//        public int choice_3_exp_27 { get; set; }
//        public int choice_3_exp_28 { get; set; }
//        public int choice_3_exp_29 { get; set; }
//        public int choice_3_exp_30 { get; set; }
//        public int choice_3_exp_31 { get; set; }
//        public int choice_3_exp_32 { get; set; }
//        public int choice_3_exp_33 { get; set; }
//        public int choice_3_exp_34 { get; set; }
//        public int choice_3_exp_35 { get; set; }
//        public int choice_3_exp_36 { get; set; }
//        public int choice_3_exp_37 { get; set; }
//        public int choice_3_exp_38 { get; set; }
//        public int choice_3_exp_39 { get; set; }
//        public int choice_3_exp_40 { get; set; }
//        public int choice_3_exp_41 { get; set; }
//        public int choice_3_exp_42 { get; set; }
//        public int choice_3_exp_43 { get; set; }
//        public int choice_3_exp_44 { get; set; }
//        public int choice_3_exp_45 { get; set; }
//        public int choice_3_exp_46 { get; set; }
//        public int choice_3_exp_47 { get; set; }
//        public int choice_3_exp_48 { get; set; }
//        public int choice_3_exp_49 { get; set; }
//        public int choice_3_exp_50 { get; set; }
//        public int choice_3_exp_51 { get; set; }
//        public int choice_3_exp_52 { get; set; }
//        public int choice_3_exp_53 { get; set; }
//        public int choice_3_exp_54 { get; set; }
//        public int choice_3_exp_55 { get; set; }
//        public int choice_3_exp_56 { get; set; }
//        public int choice_3_exp_57 { get; set; }
//        public int choice_3_exp_58 { get; set; }
//        public int choice_3_exp_59 { get; set; }
//        public int choice_3_exp_60 { get; set; }
//        public int choice_3_exp_61 { get; set; }
//        public int choice_3_exp_62 { get; set; }
//        public int choice_3_exp_63 { get; set; }
//        public int choice_3_exp_64 { get; set; }
//        public int choice_3_exp_65 { get; set; }
//        public int choice_3_exp_66 { get; set; }
//        public int choice_3_exp_67 { get; set; }
//        public int choice_3_exp_68 { get; set; }
//        public int choice_3_exp_69 { get; set; }
//        public int choice_3_exp_70 { get; set; }
//        public int choice_3_exp_71 { get; set; }
//        public int choice_3_exp_72 { get; set; }
//        public int choice_3_exp_73 { get; set; }
//        public int choice_3_exp_74 { get; set; }
//        public int choice_3_exp_75 { get; set; }
//        public int choice_3_exp_76 { get; set; }
//        public int choice_3_exp_77 { get; set; }
//        public int choice_3_exp_78 { get; set; }
//        public int choice_3_exp_79 { get; set; }
//        public int choice_3_exp_80 { get; set; }
//        public int choice_3_exp_81 { get; set; }
//        public int choice_3_exp_82 { get; set; }
//        public int choice_3_exp_83 { get; set; }
//        public int choice_3_exp_84 { get; set; }
//        public int choice_3_exp_85 { get; set; }
//        public int choice_3_exp_86 { get; set; }
//        public int choice_3_exp_87 { get; set; }
//        public int choice_3_exp_88 { get; set; }
//        public int choice_3_exp_89 { get; set; }
//        public int choice_3_exp_90 { get; set; }
//        public int choice_3_exp_91 { get; set; }
//        public int choice_3_exp_92 { get; set; }
//        public int choice_3_exp_93 { get; set; }
//        public int choice_3_exp_94 { get; set; }
//        public int choice_3_exp_95 { get; set; }
//        public int choice_3_exp_96 { get; set; }
//        public int choice_3_exp_97 { get; set; }
//        public int choice_3_exp_98 { get; set; }
//        public int choice_3_exp_99 { get; set; }
//        public int choice_3_exp_100 { get; set; }
//        public int choice_3_exp_101 { get; set; }
//        public int choice_3_exp_102 { get; set; }
//        public int choice_3_exp_103 { get; set; }
//        public int choice_3_exp_104 { get; set; }
//        public int choice_3_exp_105 { get; set; }
//        public int choice_3_exp_106 { get; set; }
//        public int choice_3_exp_107 { get; set; }
//        public int choice_3_exp_108 { get; set; }
//        public int choice_3_exp_109 { get; set; }
//        public int choice_3_exp_110 { get; set; }
//        public int choice_3_exp_111 { get; set; }
//        public int choice_3_exp_112 { get; set; }
//        public int choice_3_exp_113 { get; set; }
//        public int choice_3_exp_114 { get; set; }
//        public int choice_3_exp_115 { get; set; }
//        public int choice_3_exp_116 { get; set; }
//        public int choice_3_exp_117 { get; set; }
//        public int choice_3_exp_118 { get; set; }
//        public int choice_3_exp_119 { get; set; }
//        public int choice_3_exp_120 { get; set; }
//        public int choice_3_exp_121 { get; set; }
//        public int choice_3_exp_122 { get; set; }
//        public int choice_3_exp_123 { get; set; }
//        public int choice_3_exp_124 { get; set; }
//        public int choice_3_exp_125 { get; set; }
//        public int choice_3_exp_126 { get; set; }
//        public int choice_3_exp_127 { get; set; }
//        public int choice_3_exp_128 { get; set; }
//        public int choice_3_exp_129 { get; set; }
//        public int choice_3_exp_130 { get; set; }
//        public int choice_3_exp_131 { get; set; }
//        public int choice_3_exp_132 { get; set; }
//        public int choice_3_exp_133 { get; set; }
//        public int choice_3_exp_134 { get; set; }
//        public int choice_3_exp_135 { get; set; }
//        public int choice_3_exp_136 { get; set; }
//        public int choice_3_exp_137 { get; set; }
//        public int choice_3_exp_138 { get; set; }
//        public int choice_3_exp_139 { get; set; }
//        public int choice_3_exp_140 { get; set; }
//        public int choice_3_exp_141 { get; set; }
//        public int choice_3_exp_142 { get; set; }
//        public int choice_3_exp_143 { get; set; }
//        public int choice_3_exp_144 { get; set; }
//        public int choice_3_exp_145 { get; set; }
//        public int choice_3_exp_146 { get; set; }
//        public int choice_3_exp_147 { get; set; }
//        public int choice_3_exp_148 { get; set; }
//        public int choice_3_exp_149 { get; set; }
//        public int choice_3_exp_150 { get; set; }
//        public int choice_4_time { get; set; }
//        public int choice_4_interval { get; set; }
//        public int choice_4_ids_1 { get; set; }
//        public int choice_4_ids_2 { get; set; }
//        public int choice_4_ids_3 { get; set; }
//        public int choice_4_ids_4 { get; set; }
//        public int choice_4_ids_5 { get; set; }
//        public int choice_4_ids_6 { get; set; }
//        public int choice_4_ids_7 { get; set; }
//        public int choice_4_ids_8 { get; set; }
//        public int choice_4_exp_1 { get; set; }
//        public int choice_4_exp_2 { get; set; }
//        public int choice_4_exp_3 { get; set; }
//        public int choice_4_exp_4 { get; set; }
//        public int choice_4_exp_5 { get; set; }
//        public int choice_4_exp_6 { get; set; }
//        public int choice_4_exp_7 { get; set; }
//        public int choice_4_exp_8 { get; set; }
//        public int choice_4_exp_9 { get; set; }
//        public int choice_4_exp_10 { get; set; }
//        public int choice_4_exp_11 { get; set; }
//        public int choice_4_exp_12 { get; set; }
//        public int choice_4_exp_13 { get; set; }
//        public int choice_4_exp_14 { get; set; }
//        public int choice_4_exp_15 { get; set; }
//        public int choice_4_exp_16 { get; set; }
//        public int choice_4_exp_17 { get; set; }
//        public int choice_4_exp_18 { get; set; }
//        public int choice_4_exp_19 { get; set; }
//        public int choice_4_exp_20 { get; set; }
//        public int choice_4_exp_21 { get; set; }
//        public int choice_4_exp_22 { get; set; }
//        public int choice_4_exp_23 { get; set; }
//        public int choice_4_exp_24 { get; set; }
//        public int choice_4_exp_25 { get; set; }
//        public int choice_4_exp_26 { get; set; }
//        public int choice_4_exp_27 { get; set; }
//        public int choice_4_exp_28 { get; set; }
//        public int choice_4_exp_29 { get; set; }
//        public int choice_4_exp_30 { get; set; }
//        public int choice_4_exp_31 { get; set; }
//        public int choice_4_exp_32 { get; set; }
//        public int choice_4_exp_33 { get; set; }
//        public int choice_4_exp_34 { get; set; }
//        public int choice_4_exp_35 { get; set; }
//        public int choice_4_exp_36 { get; set; }
//        public int choice_4_exp_37 { get; set; }
//        public int choice_4_exp_38 { get; set; }
//        public int choice_4_exp_39 { get; set; }
//        public int choice_4_exp_40 { get; set; }
//        public int choice_4_exp_41 { get; set; }
//        public int choice_4_exp_42 { get; set; }
//        public int choice_4_exp_43 { get; set; }
//        public int choice_4_exp_44 { get; set; }
//        public int choice_4_exp_45 { get; set; }
//        public int choice_4_exp_46 { get; set; }
//        public int choice_4_exp_47 { get; set; }
//        public int choice_4_exp_48 { get; set; }
//        public int choice_4_exp_49 { get; set; }
//        public int choice_4_exp_50 { get; set; }
//        public int choice_4_exp_51 { get; set; }
//        public int choice_4_exp_52 { get; set; }
//        public int choice_4_exp_53 { get; set; }
//        public int choice_4_exp_54 { get; set; }
//        public int choice_4_exp_55 { get; set; }
//        public int choice_4_exp_56 { get; set; }
//        public int choice_4_exp_57 { get; set; }
//        public int choice_4_exp_58 { get; set; }
//        public int choice_4_exp_59 { get; set; }
//        public int choice_4_exp_60 { get; set; }
//        public int choice_4_exp_61 { get; set; }
//        public int choice_4_exp_62 { get; set; }
//        public int choice_4_exp_63 { get; set; }
//        public int choice_4_exp_64 { get; set; }
//        public int choice_4_exp_65 { get; set; }
//        public int choice_4_exp_66 { get; set; }
//        public int choice_4_exp_67 { get; set; }
//        public int choice_4_exp_68 { get; set; }
//        public int choice_4_exp_69 { get; set; }
//        public int choice_4_exp_70 { get; set; }
//        public int choice_4_exp_71 { get; set; }
//        public int choice_4_exp_72 { get; set; }
//        public int choice_4_exp_73 { get; set; }
//        public int choice_4_exp_74 { get; set; }
//        public int choice_4_exp_75 { get; set; }
//        public int choice_4_exp_76 { get; set; }
//        public int choice_4_exp_77 { get; set; }
//        public int choice_4_exp_78 { get; set; }
//        public int choice_4_exp_79 { get; set; }
//        public int choice_4_exp_80 { get; set; }
//        public int choice_4_exp_81 { get; set; }
//        public int choice_4_exp_82 { get; set; }
//        public int choice_4_exp_83 { get; set; }
//        public int choice_4_exp_84 { get; set; }
//        public int choice_4_exp_85 { get; set; }
//        public int choice_4_exp_86 { get; set; }
//        public int choice_4_exp_87 { get; set; }
//        public int choice_4_exp_88 { get; set; }
//        public int choice_4_exp_89 { get; set; }
//        public int choice_4_exp_90 { get; set; }
//        public int choice_4_exp_91 { get; set; }
//        public int choice_4_exp_92 { get; set; }
//        public int choice_4_exp_93 { get; set; }
//        public int choice_4_exp_94 { get; set; }
//        public int choice_4_exp_95 { get; set; }
//        public int choice_4_exp_96 { get; set; }
//        public int choice_4_exp_97 { get; set; }
//        public int choice_4_exp_98 { get; set; }
//        public int choice_4_exp_99 { get; set; }
//        public int choice_4_exp_100 { get; set; }
//        public int choice_4_exp_101 { get; set; }
//        public int choice_4_exp_102 { get; set; }
//        public int choice_4_exp_103 { get; set; }
//        public int choice_4_exp_104 { get; set; }
//        public int choice_4_exp_105 { get; set; }
//        public int choice_4_exp_106 { get; set; }
//        public int choice_4_exp_107 { get; set; }
//        public int choice_4_exp_108 { get; set; }
//        public int choice_4_exp_109 { get; set; }
//        public int choice_4_exp_110 { get; set; }
//        public int choice_4_exp_111 { get; set; }
//        public int choice_4_exp_112 { get; set; }
//        public int choice_4_exp_113 { get; set; }
//        public int choice_4_exp_114 { get; set; }
//        public int choice_4_exp_115 { get; set; }
//        public int choice_4_exp_116 { get; set; }
//        public int choice_4_exp_117 { get; set; }
//        public int choice_4_exp_118 { get; set; }
//        public int choice_4_exp_119 { get; set; }
//        public int choice_4_exp_120 { get; set; }
//        public int choice_4_exp_121 { get; set; }
//        public int choice_4_exp_122 { get; set; }
//        public int choice_4_exp_123 { get; set; }
//        public int choice_4_exp_124 { get; set; }
//        public int choice_4_exp_125 { get; set; }
//        public int choice_4_exp_126 { get; set; }
//        public int choice_4_exp_127 { get; set; }
//        public int choice_4_exp_128 { get; set; }
//        public int choice_4_exp_129 { get; set; }
//        public int choice_4_exp_130 { get; set; }
//        public int choice_4_exp_131 { get; set; }
//        public int choice_4_exp_132 { get; set; }
//        public int choice_4_exp_133 { get; set; }
//        public int choice_4_exp_134 { get; set; }
//        public int choice_4_exp_135 { get; set; }
//        public int choice_4_exp_136 { get; set; }
//        public int choice_4_exp_137 { get; set; }
//        public int choice_4_exp_138 { get; set; }
//        public int choice_4_exp_139 { get; set; }
//        public int choice_4_exp_140 { get; set; }
//        public int choice_4_exp_141 { get; set; }
//        public int choice_4_exp_142 { get; set; }
//        public int choice_4_exp_143 { get; set; }
//        public int choice_4_exp_144 { get; set; }
//        public int choice_4_exp_145 { get; set; }
//        public int choice_4_exp_146 { get; set; }
//        public int choice_4_exp_147 { get; set; }
//        public int choice_4_exp_148 { get; set; }
//        public int choice_4_exp_149 { get; set; }
//        public int choice_4_exp_150 { get; set; }
//    }

//    [StructLayout(LayoutKind.Sequential)]
//    public class COUNTRY_CONFIG
//    {
//        public int id;

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] name;



//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] country_1_name;

//        public string Country_1_name
//        {
//            get => Structure.Unicode.GetString(country_1_name);
//            set { country_1_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 64); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] country_1_file_icon;

//        public string Country_1_file_icon
//        {
//            get => Structure.Gbk.GetString(country_1_file_icon);
//            set { country_1_file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int country_1_color { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] country_2_name;

//        public string Country_2_name
//        {
//            get => Structure.Unicode.GetString(country_2_name);
//            set { country_2_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 64); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] country_2_file_icon;

//        public string Country_2_file_icon
//        {
//            get => Structure.Gbk.GetString(country_2_file_icon);
//            set { country_2_file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int country_2_color { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] country_3_name;

//        public string Country_3_name
//        {
//            get => Structure.Unicode.GetString(country_3_name);
//            set { country_3_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 64); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] country_3_file_icon;

//        public string Country_3_file_icon
//        {
//            get => Structure.Gbk.GetString(country_3_file_icon);
//            set { country_3_file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int country_3_color { get; set; }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
//        public byte[] country_4_name;

//        public string Country_4_name
//        {
//            get => Structure.Unicode.GetString(country_4_name);
//            set { country_4_name = BinReader.FillArray(Structure.Unicode.GetBytes(value), 64); }
//        }

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
//        public byte[] country_4_file_icon;

//        public string Country_4_file_icon
//        {
//            get => Structure.Gbk.GetString(country_4_file_icon);
//            set { country_4_file_icon = BinReader.FillArray(Structure.Gbk.GetBytes(value), 128); }
//        }

//        public int country_4_color { get; set; }
//        public int flag_controller_id_1 { get; set; }
//        public int flag_controller_id_2 { get; set; }
//        public int flag_controller_id_3 { get; set; }
//        public int flag_mine_id { get; set; }
//        public float attack_flag_goal_1 { get; set; }
//        public float attack_flag_goal_2 { get; set; }
//        public float attack_flag_goal_3 { get; set; }
//        public float attack_flag_goal_radius { get; set; }
//        public float defence_flag_goal_1 { get; set; }
//        public float defence_flag_goal_2 { get; set; }
//        public float defence_flag_goal_3 { get; set; }
//        public float defence_flag_goal_radius { get; set; }
//    }
//}