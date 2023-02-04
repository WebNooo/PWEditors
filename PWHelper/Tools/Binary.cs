using PWHelper.Tools.Errors;
using System;
using System.IO;

namespace PWHelper.Tools
{
    public class Binary
    {


        private static byte[] Source;
        private static int Position;

        public static void ReadFile(string? path)
        {
            if (path != null)
            {
                if (File.Exists(path))
                {
                    Source = File.ReadAllBytes(path);
                }
                else
                {
                    throw new HelperError(ErrorCode.FILE_NOT_FOUND, "Файл не найден");
                }
            }
            else 
            {
                throw new HelperError(ErrorCode.PATH_IS_NULL, "Путь до файла не указан");
            }
        }

        public static byte ReadBytes()
        {
            return 0x00;
        }

        public static byte[] ReadBytes(int length = 1)
        {
            return new byte[] { 0x00 };
        }

        public static short ReadInt16()
        {
            var size = sizeof(short);

            if(Position + size < Source.Length)
            { 
                var value = BitConverter.ToInt16(Source, Position);
                Position += size;
                return value;
            }
            else
            {
                throw new HelperError(ErrorCode.POSITION_OUT_RANGE, "1");
            }
        }

        public static int ReadInt32()
        {
            var size = sizeof(int);

            if (Position + size < Source.Length)
            {
                var value = BitConverter.ToInt32(Source, Position);
                Position += size;
                return value;
            }
            else
            {
                throw new HelperError(ErrorCode.POSITION_OUT_RANGE, "1");
            }
        }

        public static string ReadString()
        {
            return "";
        }

    }
}
