using System;
using System.Collections.Generic;
using System.IO;

namespace DataIO
{
    public class DataIOFile
    {
        public string FileName { get; set; }

        public List<byte> Data { get; set; }

        public int Size { get => Data?.Count ?? -1; }

        public DataIOFile()
        {
            Data = new List<byte>();
        }

        public int AddData(byte[] data)
        {
            var h = Convert.ToByte(DateTime.Now.Hour);
            var m = Convert.ToByte(DateTime.Now.Minute);
            var s = Convert.ToByte(DateTime.Now.Second);
            var ms = BitConverter.GetBytes(DateTime.Now.Millisecond);

            Data.AddRange(data);
            Data.Add(h);
            Data.Add(m);
            Data.Add(s);
            Data.AddRange(ms);

            return Data.Count;
        }

        public void Save()
        {
            File.WriteAllBytes(FileName, Data.ToArray());
        }

        public void Load()
        {
            byte[] data = File.ReadAllBytes(FileName);
            for (int i = 1; i < data.Length; i++)
            {
                Data.Add(data[i]);
            }
        }
    }
}
