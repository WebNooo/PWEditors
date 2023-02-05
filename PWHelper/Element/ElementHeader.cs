using PWHelper.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PWHelper.Element
{
    internal class ElementHeader
    {
        private readonly string Namespace = "PWHelper.Element.Versions";
        public short Version { get; set; }
        public short Signature { get; set; }
        public int Timestamp { get; set; }

        public void Load()
        {
            Version = Binary.ReadInt16();
            Signature = Binary.ReadInt16();
            Timestamp = Binary.ReadInt32();
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Version);
            bw.Write(Timestamp);
            bw.Write(Timestamp);
        }

        public IEnumerable<Type> GetStructures()
        {
            var lists = Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where((x) => x.Namespace == Namespace && x.Name != $"V{Version}");
            //.Select(type => type.Name);

            //foreach (var list in lists)
            //{

            //}

            //Type.GetType(strNamespace)

            return lists;
        }

    }
}
