using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Element
{
    internal class ElementHeader
    {
        public short Version { get; set; }
        public short Signature { get; set; }
        public int Timestamp { get; set; }

        public void Load()
        {
            Version = 0;
            Signature = 0;
            Timestamp = 0;
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Version);
            bw.Write(Timestamp);
            bw.Write(Timestamp);
        }
    }
}
