using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ECGenerator
{
    internal class Generator
    {
        public string GetType(string key)
        {
            if (key == "int16") return "public short";
            if (key == "int32") return "public int";
            if (key == "int64") return "public long";
            if (key == "float") return "public float";
            if (key.Contains("wstring:"))
                return "[MarshalAs(UnmanagedType.ByValArray, SizeConst = " + key.Substring(8) + ")] public byte[]";
            if (key.Contains("string:"))
                return "[MarshalAs(UnmanagedType.ByValArray, SizeConst = " + key.Substring(7) + ")] public byte[]";
            return key;
        }

        public void Run(string filePath)
        {
            var sr = new StreamReader(filePath);

            var regex = new Regex(@"PW_[\d].[\d].[\d]_v(\d+).cfg");
            var regexMatch = regex.Match(filePath);

            var version = "0";
            if (regexMatch.Groups.Count > 1)
                version = regexMatch.Groups[1].Value;
            else return;


            if (version != "70")
            {
                return;
            }

            var c = Convert.ToInt32(sr.ReadLine());
            var conversation = sr.ReadLine();

            var computerIndex = -1;
            var HardInfoIndex = -1;


            var result = "";
            for (var i = 0; i < c; i++)
            {
                sr.ReadLine();
                var name = sr.ReadLine().Split(" - ")[1];
                var offset = sr.ReadLine();
                var fieldsRaw = sr.ReadLine();
                var types = sr.ReadLine().Split(";");
                var fields = fieldsRaw.Split(";");

                result += "[StructLayout(LayoutKind.Sequential)]\npublic class " + name + "{\n";

                if (offset.ToLower() == "auto")
                    if (computerIndex == -1)
                        computerIndex = i;
                    else
                        HardInfoIndex = i;


                if (fieldsRaw != "RAW")
                {
                    for (var j = 0; j < fields.Length; j++)
                    {
                        var fName = fields[j].ToLower();
                        var end = " {get; set;}";
                        var endAdd = "";

                        if (types[j].Contains("wstring"))
                        {
                            end = ";";
                            endAdd = "  public string " + fName.UppercaseFirstLetter() +
                                     "  { get => Structure.Unicode.GetString(" + fName + "); set { " + fName +
                                     " = BinReader.FillArray(Structure.Unicode.GetBytes(value), "+ types[j].Substring(8) + "); }}\n";
                        }
                        else
                        {
                            if (types[j].Contains("string"))
                            {
                                end = ";";

                                endAdd = "  public string " + fName.UppercaseFirstLetter() +
                                         "  { get => Structure.Gbk.GetString(" + fName + "); set { " + fName +
                                         " = BinReader.FillArray(Structure.Gbk.GetBytes(value), " + types[j].Substring(7) + "); }}\n";
                            }
                        }

                        result += $"    {GetType(types[j])} {fName}{end}\n{endAdd}";
                        //result += $"var {name}_Data = Deserialize<{name}>();\n";
                    }
                }

                result += "}\n";
            }

            result = "using System.Runtime.InteropServices;\n" +
                     "using System.Text;\n\n" +
                     "namespace PWHelper.Elements.Versions._" + version + "\n" +
                     "{\n" +
                     "class Structure : IStructure {\n" +
                     "  public static readonly Encoding Gbk = Encoding.GetEncoding(\"GBK\");\n" +
                     "  public static readonly Encoding Unicode = Encoding.GetEncoding(\"Unicode\");\n" +
                     "  public int ConversionIndex { get; set; } = " + conversation + ";\n" +
                     "  public int ComputerNameIndex { get; set; } = " + computerIndex + ";\n" +
                     "  public int HardInfoIndex { get; set; } = " + HardInfoIndex + ";\n" +
                     "}\n" + result;

            Directory.CreateDirectory($"struct/{version}");
            File.AppendAllText($"struct/{version}/Structure.cs", result);
            sr.Close();

        }
    }
}
