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

        private object _value;
        public string Name { get; set; }

        public object Value
        {
            get => _value;
            set
            {
                if (Type != null && _value != value)
                {
                    Type.SetValue(CurrentItem, GetTypeValue(Type.PropertyType.Name, value));
                }

                _value = value;
            }
        }

        public PropertyInfo Type { get; set; }

        public static object GetTypeValue(string type, object value)
        {
            return type switch
            {
                "Int16" => Convert.ToInt16(value == "" ? "0" : value),
                "Int32" => Convert.ToInt32(value == "" ? "0" : value),
                "Int64" => Convert.ToInt64(value == "" ? "0" : value),

                "Short" => Convert.ToInt16(value == "" ? "0" : value),
                "Int" => Convert.ToInt32(value == "" ? "0" : value),
                "Long" => Convert.ToInt64(value == "" ? "0" : value),
                "Single" => Convert.ToSingle(value == "" ? "0.0" : value),
                "Float" => Convert.ToSingle(value == "" ? "0.0" : value),
                _ => value.ToString()
            };
        }

    }
}
