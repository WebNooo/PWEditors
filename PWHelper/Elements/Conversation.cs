using System;
using System.IO;
using System.Text;

namespace PWHelper.Elements
{
    public class Conversation
    {
        public int ConversationCount = 0;
        public ConversationItem[] Collection;

        public class ConversationItem
        {
            public class Option
            {
                public int Id { get; set; }
                
                public byte[] _text;
                public string Text
                {
                    get => Encoding.GetEncoding("Unicode").GetString(_text);
                    set => _text = BinReader.FillArray(Encoding.GetEncoding("Unicode").GetBytes(value), 128);
                }
                public int Param { get; set; }

                public void Load()
                {
                    Id = BinReader.ReadInt32();
                    _text = BinReader.ReadBytes(128);
                    Param = BinReader.ReadInt32();
                }

                public void Save(BinaryWriter bw)
                {
                    bw.Write(Id);
                    bw.Write(_text);
                    bw.Write(Param);
                }
            }

            public class Window
            {
                public int Id { get; set; }
                public int IdParent { get; set; }

                public int TalkTextLen { get; set; }

                public byte[] _talkText;

                public string TalkText
                {
                    get => Encoding.GetEncoding("Unicode").GetString(_talkText);
                    set => _talkText = BinReader.FillArray(Encoding.GetEncoding("Unicode").GetBytes(value), 128);
                }

                public int NumOption { get; set; }
                public Option[] Options { get; set; }

                public void Load()
                {
                    Id = BinReader.ReadInt32();
                    IdParent = BinReader.ReadInt32();
                    TalkTextLen = BinReader.ReadInt32();
                    _talkText = BinReader.ReadBytes(TalkTextLen * 2);
                    NumOption = BinReader.ReadInt32();
                    Options = new Option[NumOption];
                    for (var i = 0; i < NumOption; i++)
                    {
                        Options[i] = new Option();
                        Options[i].Load();
                    }
                }

                public void Save(BinaryWriter bw)
                {
                    bw.Write(Id);
                    bw.Write(IdParent);
                    bw.Write(_talkText.Length / 2);
                    bw.Write(_talkText);
                    bw.Write(Options.Length);
                    foreach (var option in Options)
                        option.Save(bw);
                }
            }

            public int id { get; set; }
            public string Name { get; set; } = "Диалог";
            
            public byte[] _text;

            public string Text
            {
                get => Encoding.GetEncoding("Unicode").GetString(_text);
                set => _text = Encoding.GetEncoding("Unicode").GetBytes(value);
            }

            public int NumWindow { get; set; }
            public Window[] Windows { get; set; }

            public void Load()
            {
                id = BinReader.ReadInt32();
                _text = BinReader.ReadBytes(128);
                NumWindow = BinReader.ReadInt32();
                Windows = new Window[NumWindow];
                for (var i = 0; i < NumWindow; i++)
                {
                    Windows[i] = new Window();
                    Windows[i].Load();
                }
            }

            public void Save(BinaryWriter bw)
            {
                bw.Write(id);
                bw.Write(_text);
                bw.Write(Windows.Length);
                foreach (var window in Windows)
                    window.Save(bw);
            }
        }

        public Element.Item[] Load(Type type)
        {
           // br.BaseStream.Seek(position, SeekOrigin.Begin);

            ConversationCount = BinReader.ReadInt32();
            Collection = new ConversationItem[ConversationCount];
            var items = new Element.Item[ConversationCount];
            for (var i = 0; i < ConversationCount; i++)
            {
                Collection[i] = new ConversationItem();
                Collection[i].Load();
                items[i] = new Element.Item {Fields = Collection[i], Type = type, Space = Element.ID_SPACE.TALK};
            }

            return items;
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Collection.Length);
            foreach (var item in Collection)
                item.Save(bw);
        }
    }
}