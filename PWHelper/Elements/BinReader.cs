using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PWHelper.Elements
{
    public class BinReader
    {
        public static byte[] Source;
        public static int Position = 0;

        public static byte[] ReadBytes(int count)
        {
            var value = new byte[count];
            Array.Copy(Source, Position, value, 0, count);
            Position += count;
            return value;
        }

        public static short ReadInt16()
        {
            var value = BitConverter.ToInt16(Source, Position);
            Position += sizeof(short);
            return value;
        }

        public static int ReadInt32()
        {
            var value = BitConverter.ToInt32(Source, Position);
            Position += sizeof(int);
            return value;
        }

        public static void Clear()
        {
            Source = new byte[]{};
            Position = 0;
        }

        public static byte[] FillArray(byte[] value, int size)
        {
            var target = new byte[size];
            Array.Copy(value, target, target.Length >= value.Length ? value.Length : target.Length);
            return target;
        }
    }
}
