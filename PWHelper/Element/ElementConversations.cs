using PWHelper.Elements;
using PWHelper.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PWHelper.Element
{
    public class ElementConversations
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
                    set => _text = Binary.FillArray(Encoding.GetEncoding("Unicode").GetBytes(value), 128);
                }
                public int Param { get; set; }

                public void Load()
                {
                    Id = Binary.ReadInt32();
                    _text = Binary.ReadBytes(128);
                    Param = Binary.ReadInt32();
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
                    set => _talkText = Binary.FillArray(Encoding.GetEncoding("Unicode").GetBytes(value), 128);
                }

                public int NumOption { get; set; }
                public Option[] Options { get; set; }

                public void Load()
                {
                    Id = Binary.ReadInt32();
                    IdParent = Binary.ReadInt32();
                    TalkTextLen = Binary.ReadInt32();
                    _talkText = Binary.ReadBytes(TalkTextLen * 2);
                    NumOption = Binary.ReadInt32();
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
                id = Binary.ReadInt32();
                _text = Binary.ReadBytes(128);
                NumWindow = Binary.ReadInt32();
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

        public void Load(Dictionary<int, ElementItem> items, Type type, int count)
        {
            // br.BaseStream.Seek(position, SeekOrigin.Begin);

            Collection = new ConversationItem[count];
            for (var i = 0; i < count; i++)
            {
                Collection[i] = new ConversationItem();
                Collection[i].Load();
                items.Add(Collection[i].id, new ElementItem { Fields = Collection[i], Type = type, Space = ID_SPACE.TALK });
            }

            //return items;
        }

        public void Save(BinaryWriter bw)
        {
            bw.Write(Collection.Length);
            foreach (var item in Collection)
                item.Save(bw);
        }
    }
}
