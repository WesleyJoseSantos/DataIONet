using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

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

        private int DumpApproximateObjectSize(object toWeight)
        {
            return Marshal.ReadInt32(toWeight.GetType().TypeHandle.Value, 4);
        }

        private void GenerateDataLinkProperties()
        {
            int currId = 0;
            int pad = 4;

            Properties = new List<DataLinkItemProperty>();

            var type = Ref.GetType();

            foreach (var p in type.GetProperties())
            {
                var newProperty = new DataLinkItemProperty();
                dynamic value = p.GetValue(Ref, null);
                int size = GetSize(value);

                newProperty.Type = value.GetType();
                newProperty.Value = value;

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

        static public unsafe int GetSize<T>(T obj) where T : unmanaged
        {
            return sizeof(T);
        }

        static public object GetValue(string typeName, byte[] buffer, int byteId)
        {
            switch (typeName)
            {
                case "Byte":
                    return buffer[byteId];
                case "UInt64":
                    return BitConverter.ToUInt64(buffer, byteId);
                case "Boolean":
                    return BitConverter.ToBoolean(buffer, byteId);
                case "Char":
                    return BitConverter.ToChar(buffer, byteId);
                case "Double":
                    return BitConverter.ToDouble(buffer, byteId);
                case "Int16":
                    return BitConverter.ToInt16(buffer, byteId);
                case "Int32":
                    return BitConverter.ToInt32(buffer, byteId);
                case "Int64":
                    return BitConverter.ToInt64(buffer, byteId);
                case "Single":
                    return BitConverter.ToSingle(buffer, byteId);
                case "UInt16":
                    return BitConverter.ToUInt16(buffer, byteId);
                case "UInt32":
                    return BitConverter.ToUInt32(buffer, byteId);
                case "String":
                    return BitConverter.ToString(buffer, byteId);
                default:
                    return null;
            }
        }
    }
}
