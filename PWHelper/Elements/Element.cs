﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using PWHelper.Elements.Versions;
using System.Windows.Media;
using System.Windows.Threading;

namespace PWHelper.Elements
{
    public class Element
    {

        public static bool CheckRows { get; set; }

        public static readonly Encoding Gbk = Encoding.GetEncoding("GBK");
        public static readonly Encoding Unicode = Encoding.GetEncoding("Unicode");

        public static ImageSource UnknownIcon;

        public enum ID_SPACE
        {
            ESSENCE = 0,
            ADDON = 1,
            TALK = 2,
            FACE = 3,
            RECIPE = 4,
            CONFIG = 5,
            HOME = 6,
            UNKNOWN = 7
        };

        public class ItemIds
        {
            public int ESSENCE;
            public int ADDON;
            public int TALK;
            public int FACE;
            public int RECIPE;
            public int CONFIG;
            public int HOME;
            public int UNKNOWN;

            public void Set(ID_SPACE space, int id)
            {
                if (space == ID_SPACE.ESSENCE)
                {
                    if (id > ESSENCE)
                        ESSENCE = id;
                    return;
                }

                if (space == ID_SPACE.ADDON)
                {
                    if (id > ADDON)
                        ADDON = id;
                    return;
                }

                if (space == ID_SPACE.TALK)
                {
                    if (id > TALK)
                        TALK = id;
                    return;
                }

                if (space == ID_SPACE.FACE)
                {
                    if (id > FACE)
                        FACE = id;
                    return;
                }

                if (space == ID_SPACE.RECIPE)
                {
                    if (id > RECIPE)
                        RECIPE = id;
                    return;
                }

                if (space == ID_SPACE.CONFIG)
                {
                    if (id > CONFIG)
                        CONFIG = id;
                    return;
                }

                if (space == ID_SPACE.HOME)
                {
                    if (id > HOME)
                        HOME = id;
                    return;
                }


                if (id > UNKNOWN)
                    UNKNOWN = id;
            }
        }

        //public ItemIds IDs = new ItemIds();

        public Dictionary<ID_SPACE, int> IDs = new Dictionary<ID_SPACE, int>
        {
            {ID_SPACE.ESSENCE, 0},
            {ID_SPACE.ADDON, 0},
            {ID_SPACE.TALK, 0},
            {ID_SPACE.FACE, 0},
            {ID_SPACE.RECIPE, 0},
            {ID_SPACE.CONFIG, 0},
            {ID_SPACE.HOME, 0},
            {ID_SPACE.UNKNOWN, 0},
        };

        public static Dictionary<string, ID_SPACE> Spaces = new Dictionary<string, ID_SPACE>
        {
            {"EQUIPMENT_ADDON", ID_SPACE.ADDON},
            {"WEAPON_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"WEAPON_SUB_TYPE", ID_SPACE.ESSENCE},
            {"WEAPON_ESSENCE", ID_SPACE.ESSENCE},
            {"ARMOR_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"ARMOR_SUB_TYPE", ID_SPACE.ESSENCE},
            {"ARMOR_ESSENCE", ID_SPACE.ESSENCE},
            {"DECORATION_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"DECORATION_SUB_TYPE", ID_SPACE.ESSENCE},
            {"DECORATION_ESSENCE", ID_SPACE.ESSENCE},
            {"MEDICINE_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"MEDICINE_SUB_TYPE", ID_SPACE.ESSENCE},
            {"MEDICINE_ESSENCE", ID_SPACE.ESSENCE},
            {"MATERIAL_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"MATERIAL_SUB_TYPE", ID_SPACE.ESSENCE},
            {"MATERIAL_ESSENCE", ID_SPACE.ESSENCE},
            {"DAMAGERUNE_SUB_TYPE", ID_SPACE.ESSENCE},
            {"DAMAGERUNE_ESSENCE", ID_SPACE.ESSENCE},
            {"ARMORRUNE_SUB_TYPE", ID_SPACE.ESSENCE},
            {"ARMORRUNE_ESSENCE", ID_SPACE.ESSENCE},
            {"SKILLTOME_SUB_TYPE", ID_SPACE.ESSENCE},
            {"SKILLTOME_ESSENCE", ID_SPACE.ESSENCE},
            {"SHOP_TOKEN_ESSENCE", ID_SPACE.ESSENCE},
            {"UNIVERSAL_TOKEN_ESSENCE", ID_SPACE.ESSENCE},
            {"FASHION_SUITE_ESSENCE", ID_SPACE.ESSENCE},
            {"ASTROLABE_ESSENCE", ID_SPACE.ESSENCE},
            {"ASTROLABE_RANDOM_ADDON_ESSENCE", ID_SPACE.ESSENCE},
            {"ASTROLABE_INC_INNER_POINT_VALUE_ESSENCE", ID_SPACE.ESSENCE},
            {"ASTROLABE_INC_EXP_ESSENCE", ID_SPACE.ESSENCE},
            {"ITEM_PACKAGE_BY_PROFESSION_ESSENCE", ID_SPACE.ESSENCE},
            {"FACTION_BUILDING_SUB_TYPE", ID_SPACE.ESSENCE},
            {"FACTION_BUILDING_ESSENCE", ID_SPACE.ESSENCE},
            {"FACTION_MATERIAL_ESSENCE", ID_SPACE.ESSENCE},
            {"FLYSWORD_ESSENCE", ID_SPACE.ESSENCE},
            {"WINGMANWING_ESSENCE", ID_SPACE.ESSENCE},
            {"TOWNSCROLL_ESSENCE", ID_SPACE.ESSENCE},
            {"TRANSMITSCROLL_ESSENCE", ID_SPACE.ESSENCE},
            {"UNIONSCROLL_ESSENCE", ID_SPACE.ESSENCE},
            {"REVIVESCROLL_ESSENCE", ID_SPACE.ESSENCE},
            {"ELEMENT_ESSENCE", ID_SPACE.ESSENCE},
            {"TASKMATTER_ESSENCE", ID_SPACE.ESSENCE},
            {"TOSSMATTER_ESSENCE", ID_SPACE.ESSENCE},
            {"PROJECTILE_TYPE", ID_SPACE.ESSENCE},
            {"PROJECTILE_ESSENCE", ID_SPACE.ESSENCE},
            {"QUIVER_SUB_TYPE", ID_SPACE.ESSENCE},
            {"QUIVER_ESSENCE", ID_SPACE.ESSENCE},
            {"STONE_SUB_TYPE", ID_SPACE.ESSENCE},
            {"STONE_ESSENCE", ID_SPACE.ESSENCE},
            {"MONSTER_ADDON", ID_SPACE.ADDON},
            {"MONSTER_TYPE", ID_SPACE.ESSENCE},
            {"MONSTER_ESSENCE", ID_SPACE.ESSENCE},
            {"NPC_TALK_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_SELL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_BUY_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_REPAIR_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_INSTALL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_UNINSTALL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TASK_IN_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TASK_OUT_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TASK_MATTER_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_SKILL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_HEAL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TRANSMIT_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TRANSPORT_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_PROXY_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_STORAGE_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_MAKE_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_DECOMPOSE_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_TYPE", ID_SPACE.ESSENCE},
            {"NPC_ESSENCE", ID_SPACE.ESSENCE},
            {"TALK_PROC", ID_SPACE.TALK},
            {"FACE_TEXTURE_ESSENCE", ID_SPACE.FACE},
            {"FACE_SHAPE_ESSENCE", ID_SPACE.FACE},
            {"FACE_EMOTION_TYPE", ID_SPACE.FACE},
            {"FACE_EXPRESSION_ESSENCE", ID_SPACE.FACE},
            {"FACE_HAIR_ESSENCE", ID_SPACE.FACE},
            {"FACE_MOUSTACHE_ESSENCE", ID_SPACE.FACE},
            {"COLORPICKER_ESSENCE", ID_SPACE.FACE},
            {"CUSTOMIZEDATA_ESSENCE", ID_SPACE.FACE},
            {"RECIPE_MAJOR_TYPE", ID_SPACE.RECIPE},
            {"RECIPE_SUB_TYPE", ID_SPACE.RECIPE},
            {"RECIPE_ESSENCE", ID_SPACE.RECIPE},
            {"ENGRAVE_MAJOR_TYPE", ID_SPACE.RECIPE},
            {"ENGRAVE_SUB_TYPE", ID_SPACE.RECIPE},
            {"ENGRAVE_ESSENCE", ID_SPACE.RECIPE},
            {"RANDPROP_TYPE", ID_SPACE.RECIPE},
            {"RANDPROP_ESSENCE", ID_SPACE.RECIPE},
            {"STONE_CHANGE_RECIPE_TYPE", ID_SPACE.RECIPE},
            {"STONE_CHANGE_RECIPE", ID_SPACE.RECIPE},
            {"ENEMY_FACTION_CONFIG", ID_SPACE.CONFIG},
            {"CHARRACTER_CLASS_CONFIG", ID_SPACE.CONFIG},
            {"PARAM_ADJUST_CONFIG", ID_SPACE.CONFIG},
            {"PLAYER_ACTION_INFO_CONFIG", ID_SPACE.CONFIG},
            {"UPGRADE_PRODUCTION_CONFIG", ID_SPACE.CONFIG},
            {"ACC_STORAGE_BLACKLIST_CONFIG", ID_SPACE.CONFIG},
            {"PLAYER_DEATH_DROP_CONFIG", ID_SPACE.CONFIG},
            {"CONSUME_POINTS_CONFIG", ID_SPACE.CONFIG},
            {"ONLINE_AWARDS_CONFIG", ID_SPACE.CONFIG},
            {"PET_EVOLVE_CONFIG", ID_SPACE.CONFIG},
            {"PET_EVOLVED_SKILL_CONFIG", ID_SPACE.CONFIG},
            {"PET_EVOLVED_SKILL_RAND_CONFIG", ID_SPACE.CONFIG},
            {"AUTOTASK_DISPLAY_CONFIG", ID_SPACE.CONFIG},
            {"PLAYER_SPIRIT_CONFIG", ID_SPACE.CONFIG},
            {"HISTORY_STAGE_CONFIG", ID_SPACE.CONFIG},
            {"HISTORY_ADVANCE_CONFIG", ID_SPACE.CONFIG},
            {"AUTOTEAM_CONFIG", ID_SPACE.CONFIG},
            {"CHARIOT_CONFIG", ID_SPACE.CONFIG},
            {"CHARIOT_WAR_CONFIG", ID_SPACE.CONFIG},
            {"POKER_LEVELEXP_CONFIG", ID_SPACE.CONFIG},
            {"GT_CONFIG", ID_SPACE.CONFIG},
            {"MERIDIAN_CONFIG", ID_SPACE.CONFIG},
            {"MONEY_CONVERTIBLE_ESSENCE", ID_SPACE.ESSENCE},
            {"FASHION_WEAPON_CONFIG", ID_SPACE.CONFIG},
            {"MULTI_EXP_CONFIG", ID_SPACE.CONFIG},
            {"WEDDING_CONFIG", ID_SPACE.CONFIG},
            {"GOD_EVIL_CONVERT_CONFIG", ID_SPACE.CONFIG},
            {"WIKI_TABOO_CONFIG", ID_SPACE.CONFIG},
            {"TASKDICE_ESSENCE", ID_SPACE.ESSENCE},
            {"POKER_DICE_ESSENCE", ID_SPACE.ESSENCE},
            {"TASKNORMALMATTER_ESSENCE", ID_SPACE.ESSENCE},
            {"FACE_FALING_ESSENCE", ID_SPACE.FACE},
            {"FACE_THIRDEYE_ESSENCE", ID_SPACE.FACE},
            {"PLAYER_LEVELEXP_CONFIG", ID_SPACE.CONFIG},
            {"ASTROLABE_LEVELEXP_CONFIG", ID_SPACE.CONFIG},
            {"ASTROLABE_ADDON_RANDOM_CONFIG", ID_SPACE.CONFIG},
            {"ASTROLABE_APPEARANCE_CONFIG", ID_SPACE.CONFIG},
            {"EQUIP_MAKE_HOLE_CONFIG", ID_SPACE.CONFIG},
            {"SOLO_TOWER_CHALLENGE_LEVEL_CONFIG", ID_SPACE.CONFIG},
            {"SOLO_TOWER_CHALLENGE_AWARD_PAGE_CONFIG", ID_SPACE.CONFIG},
            {"SOLO_TOWER_CHALLENGE_AWARD_LIST_CONFIG", ID_SPACE.CONFIG},
            {"SOLO_TOWER_CHALLENGE_SCORE_COST_CONFIG", ID_SPACE.CONFIG},
            {"MNFACTION_WAR_CONFIG", ID_SPACE.CONFIG},
            {"FACTION_FORTRESS_CONFIG", ID_SPACE.CONFIG},
            {"FORCE_CONFIG", ID_SPACE.CONFIG},
            {"COUNTRY_CONFIG", ID_SPACE.CONFIG},
            {"GM_ACTIVITY_CONFIG", ID_SPACE.CONFIG},
            {"TOUCH_SHOP_CONFIG", ID_SPACE.CONFIG},
            {"TOKEN_SHOP_CONFIG", ID_SPACE.CONFIG},
            {"RAND_SHOP_CONFIG", ID_SPACE.CONFIG},
            {"PROFIT_TIME_CONFIG", ID_SPACE.CONFIG},
            {"FACTION_PVP_CONFIG", ID_SPACE.CONFIG},
            {"TASK_LIST_CONFIG", ID_SPACE.CONFIG},
            {"TASK_DICE_BY_WEIGHT_CONFIG", ID_SPACE.CONFIG},
            {"FASHION_BEST_COLOR_CONFIG", ID_SPACE.CONFIG},
            {"SIGN_AWARD_CONFIG", ID_SPACE.CONFIG},
            {"TITLE_CONFIG", ID_SPACE.CONFIG},
            {"COMPLEX_TITLE_CONFIG", ID_SPACE.CONFIG},
            {"MINE_TYPE", ID_SPACE.ESSENCE},
            {"MINE_ESSENCE", ID_SPACE.ESSENCE},
            {"NPC_IDENTIFY_SERVICE", ID_SPACE.ESSENCE},
            {"FASHION_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"FASHION_SUB_TYPE", ID_SPACE.ESSENCE},
            {"FASHION_ESSENCE", ID_SPACE.ESSENCE},
            {"POKER_SUB_TYPE", ID_SPACE.ESSENCE},
            {"POKER_ESSENCE", ID_SPACE.ESSENCE},
            {"FACETICKET_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"FACETICKET_SUB_TYPE", ID_SPACE.ESSENCE},
            {"FACETICKET_ESSENCE", ID_SPACE.ESSENCE},
            {"FACEPILL_MAJOR_TYPE", ID_SPACE.ESSENCE},
            {"FACEPILL_SUB_TYPE", ID_SPACE.ESSENCE},
            {"FACEPILL_ESSENCE", ID_SPACE.ESSENCE},
            {"SUITE_ESSENCE", ID_SPACE.ESSENCE},
            {"POKER_SUITE_ESSENCE", ID_SPACE.ESSENCE},
            {"GM_GENERATOR_TYPE", ID_SPACE.ESSENCE},
            {"GM_GENERATOR_ESSENCE", ID_SPACE.ESSENCE},
            {"PET_TYPE", ID_SPACE.ESSENCE},
            {"PET_ESSENCE", ID_SPACE.ESSENCE},
            {"PET_EGG_ESSENCE", ID_SPACE.ESSENCE},
            {"PET_FOOD_ESSENCE", ID_SPACE.ESSENCE},
            {"PET_FACETICKET_ESSENCE", ID_SPACE.ESSENCE},
            {"FIREWORKS_ESSENCE", ID_SPACE.ESSENCE},
            {"FIREWORKS2_ESSENCE", ID_SPACE.ESSENCE},
            {"FIX_POSITION_TRANSMIT_ESSENCE", ID_SPACE.ESSENCE},
            {"GOBLIN_ESSENCE", ID_SPACE.ESSENCE},
            {"GOBLIN_EQUIP_TYPE", ID_SPACE.ESSENCE},
            {"GOBLIN_EQUIP_ESSENCE", ID_SPACE.ESSENCE},
            {"GOBLIN_EXPPILL_ESSENCE", ID_SPACE.ESSENCE},
            {"SELL_CERTIFICATE_ESSENCE", ID_SPACE.ESSENCE},
            {"TARGET_ITEM_ESSENCE", ID_SPACE.ESSENCE},
            {"LOOK_INFO_ESSENCE", ID_SPACE.ESSENCE},
            {"WAR_TANKCALLIN_ESSENCE", ID_SPACE.ESSENCE},
            {"NPC_WAR_TOWERBUILD_SERVICE", ID_SPACE.ESSENCE},
            {"PLAYER_SECONDLEVEL_CONFIG", ID_SPACE.CONFIG},
            {"PLAYER_REINCARNATION_CONFIG", ID_SPACE.CONFIG},
            {"PLAYER_REALM_CONFIG", ID_SPACE.CONFIG},
            {"NPC_RESETPROP_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_PETNAME_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_PETLEARNSKILL_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_PETFORGETSKILL_SERVICE", ID_SPACE.ESSENCE},
            {"SKILLMATTER_ESSENCE", ID_SPACE.ESSENCE},
            {"DYNSKILLEQUIP_ESSENCE", ID_SPACE.ESSENCE},
            {"INC_SKILL_ABILITY_ESSENCE", ID_SPACE.ESSENCE},
            {"WEDDING_BOOKCARD_ESSENCE", ID_SPACE.ESSENCE},
            {"WEDDING_INVITECARD_ESSENCE", ID_SPACE.ESSENCE},
            {"SHARPENER_ESSENCE", ID_SPACE.ESSENCE},
            {"CONGREGATE_ESSENCE", ID_SPACE.ESSENCE},
            {"MONSTER_SPIRIT_ESSENCE", ID_SPACE.ESSENCE},
            {"DESTROYING_ESSENCE", ID_SPACE.ESSENCE},
            {"DOUBLE_EXP_ESSENCE", ID_SPACE.ESSENCE},
            {"DYE_TICKET_ESSENCE", ID_SPACE.ESSENCE},
            {"REFINE_TICKET_ESSENCE", ID_SPACE.ESSENCE},
            {"NPC_EQUIPBIND_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_EQUIPDESTROY_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_EQUIPUNDESTROY_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_ENGRAVE_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_RANDPROP_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_FORCE_SERVICE", ID_SPACE.ESSENCE},
            {"NPC_CROSS_SERVER_SERVICE", ID_SPACE.ESSENCE},
            {"BIBLE_ESSENCE", ID_SPACE.ESSENCE},
            {"SPEAKER_ESSENCE", ID_SPACE.ESSENCE},
            {"AUTOHP_ESSENCE", ID_SPACE.ESSENCE},
            {"AUTOMP_ESSENCE", ID_SPACE.ESSENCE},
            {"FORCE_TOKEN_ESSENCE", ID_SPACE.ESSENCE},
            {"FACE_HAIR_TEXTURE_MAP", ID_SPACE.FACE},
            {"HOME_CONFIG", ID_SPACE.CONFIG},
            {"HOME_PRODUCTS_CONFIG", ID_SPACE.CONFIG},
            {"HOME_RESOURCE_PRODUCE_CONFIG", ID_SPACE.CONFIG},
            {"HOME_FORMULAS_PRODUCE_RECIPE", ID_SPACE.RECIPE},
            {"HOME_FORMULAS_ITEM_ESSENCE", ID_SPACE.ESSENCE},
            {"HOME_PRODUCE_SERVICE_CONFIG", ID_SPACE.CONFIG},
            {"HOME_FACTORY_CONFIG", ID_SPACE.CONFIG},
            {"HOME_ITEM_MAJOR_TYPE", ID_SPACE.HOME},
            {"HOME_ITEM_SUB_TYPE", ID_SPACE.HOME},
            {"HOME_ITEM_ENTITY", ID_SPACE.HOME},
            {"HOME_FORMULAS_PRODUCE_MAJOR_TYPE", ID_SPACE.HOME},
            {"HOME_FORMULAS_PRODUCE_SUB_TYPE", ID_SPACE.HOME},
            {"HOME_FORMULAS_ITEM_MAJOR_TYPE", ID_SPACE.HOME},
            {"HOME_FORMULAS_ITEM_SUB_TYPE", ID_SPACE.HOME},
            {"HOME_STORAGE_TASK_CONFIG", ID_SPACE.CONFIG},
            {"WISH_TRIBUTE_ESSENCE", ID_SPACE.ESSENCE},
            {"RED_PACKET_PAPER_ESSENCE", ID_SPACE.ESSENCE}
        };


        #region Structure

        public class Props
        {
            public Item Item;
            public ItemProperty[] Properties;
        }

        public class ComputerName
        {
            public int Tag;
            public int Len;
            public byte[] Name;
            public int Time;
        }

        public class HardInfo
        {
            public int Tag;
            public int BufferLen;
            public byte[] Buffer;
        }

        public class Item
        {
            public Type Type { get; set; }
            public ID_SPACE Space { get; set; }
            public dynamic Fields { get; set; }

            public int Id
            {
                get => Fields.id;
                set => Fields.id = value;
            }

            public string Name
            {
                get => Unicode.GetString(Fields.name);
                set => Fields.name = BinReader.FillArray(Unicode.GetBytes(value), 64);
            }

            public int Links
            {
                get
                {
                    // try
                    // {

                    if (Space == ID_SPACE.ESSENCE)
                    {
                        if (Data.LinksEssence.ContainsKey(Fields.id))
                        {
                            List<Data.link> v = Data.LinksEssence[Fields.id];
                            return v.Count;
                        }
                    }

                    if (Space == ID_SPACE.RECIPE)
                    {
                        if (Data.LinksRecipe.ContainsKey(Fields.id))
                        {
                            List<Data.link> v = Data.LinksRecipe[Fields.id];
                            return v.Count;
                        }
                    }

                    if (Space == ID_SPACE.ADDON)
                    {
                        if (Data.LinksAddon.ContainsKey(Fields.id))
                        {
                            List<Data.link> v = Data.LinksAddon[Fields.id];
                            return v.Count;
                        }
                    }


                    // }
                    // catch (Exception e)
                    // {
                    //  
                    // }


                    return 0;
                }
            }
            // public RangeObservableCollection<Item> Items { get; set; } = new RangeObservableCollection<Item>();
            //public Item[] Items { get; set; } = new Item[200];

            //private ImageSource icon;
            public ImageSource Icon
            {
                get
                {
                    PropertyInfo[] fields = Fields.GetType().GetProperties();
                    if (fields.All(field => field.Name != "File_icon")) return UnknownIcon;
                    var image = (string) Fields.File_icon.Replace("\0", string.Empty);
                    return Icons.GetImage(image.Split("\\").Last().ToLower());
                }
            }

            public Item Clone()
            {
                dynamic fieldsClone = Activator.CreateInstance(Type);
                PropertyInfo[] properties = Fields.GetType().GetProperties();

                foreach (var property in properties) property.SetValue(fieldsClone, property.GetValue(Fields, null));

                return new Item
                {
                    Type = this.Type,
                    Space = this.Space,
                    Fields = fieldsClone,
                };
            }
        }

        public class ListInfo
        {
            public Type Type { get; set; }
            public ID_SPACE Space { get; set; }
            public string Name { get; set; }

            public int Count { get; set; }
        }

        public short Version;
        public short Signature;
        public int Timestamp;

        #endregion

        #region Vars

        public ComputerName ComputerInformation = new ComputerName();
        public HardInfo HardInformation = new HardInfo();
        public Conversation Conversations = new Conversation();

        public IStructure Structure;

        public List<ListInfo> ListInformation = new List<ListInfo>();

        public static Dictionary<int, Item> Essences { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Addons { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Talks { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Faces { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Recipes { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Configs { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> Homes { get; set; } = new Dictionary<int, Item>();

        public static Item[] SelectedItems;

        public BinaryWriter Bw;

        #endregion

        #region Read

        public void ReadHeader()
        {
            Version = BinReader.ReadInt16();
            Signature = BinReader.ReadInt16();
            Timestamp = BinReader.ReadInt32();
        }

        public void ReadComputerName()
        {
            ComputerInformation.Tag = BinReader.ReadInt32();
            ComputerInformation.Len = BinReader.ReadInt32();
            ComputerInformation.Name = BinReader.ReadBytes(ComputerInformation.Len);
            ComputerInformation.Time = BinReader.ReadInt32();
        }

        public void ReadHardInfo()
        {
            HardInformation.Tag = BinReader.ReadInt32();
            HardInformation.BufferLen = BinReader.ReadInt32();
            HardInformation.Buffer = BinReader.ReadBytes(HardInformation.BufferLen);
        }

        #endregion

        #region Write

        public void WriteHeader(BinaryWriter bw)
        {
            bw.Write(Version);
            bw.Write(Signature);
            bw.Write(Timestamp);
        }

        public void WriteComputerName(BinaryWriter bw)
        {
            bw.Write(ComputerInformation.Tag);
            bw.Write(ComputerInformation.Name.Length);
            bw.Write(ComputerInformation.Name);
            bw.Write(ComputerInformation.Time);
        }

        public void WriteHardInfo(BinaryWriter bw)
        {
            bw.Write(HardInformation.Tag);
            bw.Write(HardInformation.Buffer.Length);
            bw.Write(HardInformation.Buffer);
        }

        #endregion

        //NOT WORK
        public void Serialize(Type type)
        {
            if (type.Name == "TALK_PROC")
            {
                Conversations.Save(Bw);
            }
            else
            {
                // var itemsByType = Items.Where(n => n.Type == type).ToArray();
                // var size = Marshal.SizeOf(type);
                // var result = new byte[size * itemsByType.Length];
                //
                // Bw.Write(itemsByType.Length);
                //
                // var ptr = Marshal.AllocHGlobal(size);
                // var pos = 0;
                // try
                // {
                //     foreach (var list in itemsByType)
                //     {
                //         Marshal.StructureToPtr(list.Fields, ptr, true);
                //         Marshal.Copy(ptr, result, pos, size);
                //         pos += size;
                //     }
                // }
                // finally
                // {
                //     Marshal.FreeHGlobal(ptr);
                // }
                //
                // Bw.Write(result);
            }
        }

        private void ReadItems(int count, int size, IntPtr buffer, Type type, Dictionary<int, Item> collection)
        {
            for (var i = 0; i < count; i++)
            {
                Marshal.Copy(BinReader.Source, BinReader.Position, buffer, size);
                dynamic fields = Marshal.PtrToStructure(buffer, type);
                collection.Add(fields.id, new Item {Type = type, Fields = fields});
                BinReader.Position += size;
            }
        }

        public static Dictionary<int, Item> GetItems(string type)
        {
            var space = Spaces[type];

            switch (space)
            {
                case ID_SPACE.ESSENCE:
                    return Essences;
                case ID_SPACE.ADDON:
                    return Addons; 
                case ID_SPACE.TALK:
                    return Talks;
                case ID_SPACE.CONFIG:
                    return Configs;
                case ID_SPACE.FACE:
                    return Faces;
                case ID_SPACE.RECIPE:
                    return Recipes;
                case ID_SPACE.HOME:
                    return Homes;
            }

            return null;
        }

        public int Deserialize(Type type, ID_SPACE space)
        {
            if (type.Name == "TALK_PROC")
            {
                return Conversations.Load(type).Length;
            }

            var count = BinReader.ReadInt32();
            var size = Marshal.SizeOf(type);
            var buffer = Marshal.AllocHGlobal(size);

            try
            {
                switch (space)
                {
                    case ID_SPACE.ESSENCE:
                        ReadItems(count, size, buffer, type, Essences);
                        break;
                    case ID_SPACE.ADDON:
                        ReadItems(count, size, buffer, type, Addons);
                        break;
                    case ID_SPACE.CONFIG:
                        ReadItems(count, size, buffer, type, Configs);
                        break;
                    case ID_SPACE.FACE:
                        ReadItems(count, size, buffer, type, Faces);
                        break;
                    case ID_SPACE.RECIPE:
                        ReadItems(count, size, buffer, type, Recipes);
                        break;
                    case ID_SPACE.HOME:
                        ReadItems(count, size, buffer, type, Homes);
                        break;
                    case ID_SPACE.TALK:
                        break;
                    case ID_SPACE.UNKNOWN:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(space), space, null);
                }
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }

            return count;
        }

        public IEnumerable<string> GetStructureTypes(string nameSpace)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetTypes()
                .Where(type => type.Namespace == nameSpace && type.Name != "Structure")
                .Select(type => type.Name);
        }

        public object GetInstance(string strNamespace) =>
            Activator.CreateInstance(Type.GetType(strNamespace) ?? throw new InvalidOperationException());

        public void RegisterStruct(Type type, string name)
        {
            var space = Spaces.ContainsKey(type.Name) ? Spaces[type.Name] : ID_SPACE.UNKNOWN;
            var count =  Deserialize(type, space);
            ListInformation.Add(new ListInfo {Type = type, Name = name, Space = space, Count = count});
        }

        public void Add(Type type, Item item = null)
        {
            if (item != null)
            {
               // Items.Add(item.Clone());
            }
        }

        public Item[] Add(Item[] items)
        {
            var ttt = new Item[items.Length];
            if (items.Length > 0)
            {
               // Items.DisableNotify();
                for (var index = 0; index < items.Length; index++)
                {
                    ttt[index] = items[index].Clone();
                 //   Items.Add(ttt[index]);
                }

               // Items.EnableNotify();
            }

            return ttt;
        }

        public void Remove(Item item)
        {
           // Items.Remove(item);
        }
    }
}