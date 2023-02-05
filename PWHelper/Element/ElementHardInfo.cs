using PWHelper.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Element
{
    public class ElementHardInfo
    {
        public int Tag;
        public int Length;
        public byte[] Buffer;

        public void Load()
        {
            Tag = Binary.ReadInt32();
            Length = Binary.ReadInt32();
            Buffer = Binary.ReadBytes(Length);
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Tag);
            bw.Write(Buffer.Length);
            bw.Write(Buffer);
        }
    }
}
