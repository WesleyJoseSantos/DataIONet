using System;
using System.Collections.Generic;
using System.Linq;

namespace DataIO
{
    public class DataLinkItem
    {
        public int Size
        {
            get
            {
                int size = Properties.Last().Id + Properties.Last().Size;
                int maxSize = 0;
                foreach (var p in Properties)
                {
                    if (p.Size > maxSize) maxSize = p.Size;
                }
                while (size % maxSize != 0)
                {
                    size++;
                }
                return size;
            }
        }

        public string Name { get; set; }

        public object Ref { get; set; }

        public List<DataLinkItemProperty> Properties { get; set; }

        public bool DataChanged
        {
            get
            {
                dynamic type = Ref.GetType();
                int pId = 0;
                foreach (var p in type.GetProperties())
                {
                    var value = p.GetValue(Ref, null);
                    if (value != Properties[pId].Value)
                    {
                        Properties[pId].Value = value;
                        return true;
                    }
                    pId++;
                }
                return false;
            }
        }

        public DataLinkItem(dynamic item)
        {
            Ref = item;
            GenerateDataLinkProperties();
        }

        private void GenerateDataLinkProperties()
        {
            int currId = 0;
            int pad = 4;

            Properties = new List<DataLinkItemProperty>();

            var type = Ref.GetType();
            Name = type.Name;

            foreach (var p in type.GetProperties())
            {
                var newProperty = new DataLinkItemProperty();
                dynamic value = p.GetValue(Ref, null);
                int size = GetSize(value);

                newProperty.Type = value.GetType();
                newProperty.Value = value;
                newProperty.Name = p.Name;

                if ((currId + size) > pad && currId % 4 != 0)
                {
                    currId = pad;
                    newProperty.Id = currId;
                    newProperty.Size = size;
                    currId += size;
                    while (pad < currId)
                    {
                        pad += 4;
                    }
                }
                else
                {
                    if (size == 8)
                    {
                        while (currId % 8 != 0)
                        {
                            currId++;
                        }
                    }
                    newProperty.Id = currId;
                    newProperty.Size = size;
                    currId += size;
                    if (currId > pad)
                    {
                        while (pad < currId)
                        {
                            pad += 4;
                        }
                    }
                }

                Properties.Add(newProperty);
            }
        }
    
        private unsafe int GetSize<T>(T obj) where T : unmanaged
        {
            return sizeof(T);
        }

        static public object GetValue(string typeName, byte[] data, int byteId)
        {
            switch (typeName)
            {
                case "Byte":
                    return data[byteId];
                case "UInt64":
                    return BitConverter.ToUInt64(data, byteId);
                case "Boolean":
                    return BitConverter.ToBoolean(data, byteId);
                case "Char":
                    return BitConverter.ToChar(data, byteId);
                case "Double":
                    return BitConverter.ToDouble(data, byteId);
                case "Int16":
                    return BitConverter.ToInt16(data, byteId);
                case "Int32":
                    return BitConverter.ToInt32(data, byteId);
                case "Int64":
                    return BitConverter.ToInt64(data, byteId);
                case "Single":
                    return BitConverter.ToSingle(data, byteId);
                case "UInt16":
                    return BitConverter.ToUInt16(data, byteId);
                case "UInt32":
                    return BitConverter.ToUInt32(data, byteId);
                case "String":
                    return BitConverter.ToString(data, byteId);
                default:
                    return null;
            }
        }
    }
}
