using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PWHelper.Elements
{
    public class ItemProperty
    {
        //public static dynamic CurrentItem;
        public static dynamic CurrentItem;
        public dynamic Item;

        private object _value;
        public string Name { get; set; }
        public dynamic Control { get; set; }

        public object Value
        {
            get => _value;
            set
            {
                if (Type != null && _value != value)
                {
                    Type.SetValue(Item, GetTypeValue(Type.PropertyType.Name, value));
                }

                _value = value;
            }
        }

        public PropertyInfo Type { get; set; }

        public static object GetTypeValue(string type, object value)
        {
            value = value.ToString()?.Replace("\0", "");
            var numberValue = value == null || value == "" ? "0" : value;
            
            return type switch
            {
                "Int16" => Convert.ToInt16(numberValue),
                "Int32" => Convert.ToInt32(numberValue),
                "UInt32" => Convert.ToUInt32(numberValue),
                "Int64" => Convert.ToInt64(numberValue),

                "Short" => Convert.ToInt16(numberValue),
                "Int" => Convert.ToInt32(numberValue),
                "Long" => Convert.ToInt64(numberValue),
                "Single" => Convert.ToSingle(numberValue),
                "Float" => Convert.ToSingle(numberValue),
                _ => value.ToString()
            };
        }

    }
}
