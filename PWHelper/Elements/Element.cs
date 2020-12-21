using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using PWHelper.Elements.Versions;
using System.Windows.Media;

namespace PWHelper.Elements
{
    public class Element
    {
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

        public class Item : ICloneable
        {
            public Type Type { get; set; }
            public ID_SPACE Space { get; set; }
            public dynamic Fields { get; set; }

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

            public object Clone()
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
            public string Name { get; set; }

            public int Count
            {
                get
                {
                    return Items.Count(n => n.Type == Type);
                }
            }
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
        public Dictionary<Type, object[]> Lists { get; set; } = new Dictionary<Type, object[]>();

        public static RangeObservableCollection<Item> Items = new RangeObservableCollection<Item>();

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

        public void Serialize(Type type)
        {
            if (type.Name == "TALK_PROC")
            {
                Conversations.Save(Bw);
            }
            else
            {
                var itemsByType = Items.Where(n => n.Type == type).ToArray();
                var size = Marshal.SizeOf(type);
                var result = new byte[size * itemsByType.Length];

                Bw.Write(itemsByType.Length);

                var ptr = Marshal.AllocHGlobal(size);
                var pos = 0;
                try
                {
                    foreach (var list in itemsByType)
                    {
                        Marshal.StructureToPtr(list.Fields, ptr, true);
                        Marshal.Copy(ptr, result, pos, size);
                        pos += size;
                    }
                }
                finally
                {
                    Marshal.FreeHGlobal(ptr);
                }

                Bw.Write(result);
            }
        }

        public Item[] Deserialize(Type type)
        {
            if (type.Name == "TALK_PROC") return Conversations.Load(type);
            
            var itemsCount = BinReader.ReadInt32();
            var sizeItem = Marshal.SizeOf(type);
            var buffer = Marshal.AllocHGlobal(sizeItem);
            var items = new Item[itemsCount];

            try
            {
                for (var i = 0; i < itemsCount; i++)
                {
                    Marshal.Copy(BinReader.Source, BinReader.Position, buffer, sizeItem);
                    items[i] = new Item
                    {
                        Type = type, Space = ID_SPACE.ESSENCE, Fields = Marshal.PtrToStructure(buffer, type)
                    };
                    BinReader.Position += sizeItem;
                }
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }

            return items;
        }

        public IEnumerable<string> GetStructureTypes(string nameSpace)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetTypes()
                .Where(type => type.Namespace == nameSpace && type.Name != "Structure")
                .Select(type => type.Name);
        }

        public object[] GetData(Type type) => type != null && Lists.ContainsKey(type) ? Lists[type] : new object[] { };

        public object GetInstance(string strNamespace) =>
            Activator.CreateInstance(Type.GetType(strNamespace) ?? throw new InvalidOperationException());

        public void RegisterStruct(Type type, string name)
        {
            // if (type == null || Lists.ContainsKey(type)) return;
            var deserialize = Deserialize(type);
            Items.AddRange(deserialize);
            //Lists.Add(type, deserialize);
            ListInformation.Add(new ListInfo {Type = type, Name = name});
        }

        public void Add(Type type, Item item = null)
        {
            if (item != null)
            {
                Items.Add((Item) item.Clone());
            }
        }

        public void Remove(Item item)
        {
            Items.Remove(item);
        }
    }
}