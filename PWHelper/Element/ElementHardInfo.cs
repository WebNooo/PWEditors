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
            Tag = 0;
            Length = 0;
            Buffer = Array.Empty<byte>();
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Tag);
            bw.Write(Buffer.Length);
            bw.Write(Buffer);
        }
    }
}
