using PWHelper.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Element
{
    public class ElementList
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public ID_SPACE Space { get; set; }
        public int Count { get; set; }

        public void Load(Dictionary<int, ElementItem> items)
        {

            Count = Binary.ReadInt32();

            if (Type.Name == "TALK_PROC")
            {
                new ElementConversations().Load(items, Type, Count);
            }
            else { 
                var size = Marshal.SizeOf(Type);
                var buffer = Marshal.AllocHGlobal(size);
                for (int i = 0; i < Count; i++)
                {
                    Marshal.Copy(Binary.GetSource(), Binary.GetPosition(), buffer, size);
                    dynamic fields = Marshal.PtrToStructure(buffer, Type);
                    items.Add(fields.id, new ElementItem { Type = Type, Fields = fields });
                    Binary.Seek(size);

                }
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
