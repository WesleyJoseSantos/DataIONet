using System.Reflection;

namespace DataIO
{
    public class DataIOEventArgs
    {
        public object Object { get; set; }

        public PropertyInfo Property { get; set; }

        public object Value { get; set; }

        public DataIOEventArgs(object obj, PropertyInfo property, dynamic value)
        {
            Object = obj;
            Property = property;
            Value = value;
        }
    }

}
