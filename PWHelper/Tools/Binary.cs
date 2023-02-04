using PWHelper.Tools.Errors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(Position + size > Source.Length)
            {
                return BitConverter.ToInt16(Source, Position);
            }
            else
            {
                throw new HelperError(ErrorCode.);
            }

            return 0;
        }

        public static int ReadInt32()
        {
            var size = sizeof(int);

            return 0;
        }

        public static string ReadString()
        {
            return "";
        }

    }
}
