using PWHelper.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Element
{
    public class ElementComputerName
    {
        public int Tag;
        public int Length;
        public byte[] Name;
        public int Time;


        public void Load()
        {
            Tag = Binary.ReadInt32();
            Length = Binary.ReadInt32();
            Name = Binary.ReadBytes(Length);
            Time = Binary.ReadInt32();
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Tag);
            bw.Write(Name.Length);
            bw.Write(Name);
            bw.Write(Time);
        }
    }
}
