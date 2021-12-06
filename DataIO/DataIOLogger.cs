using System;
using System.Collections.Generic;
using System.IO;

namespace DataIO
{
    public class DataIOLogger
    {
        public string Directory { get; set; } = "C:\\Dat";

        public int MaxSize { get; set; } = 102300;

        private DatFile file = new DatFile();

        private int fileCount = 0;

        public DataIOLogger()
        {
            Init();
        }

        public void Init()
        {
            var dir = new DirectoryInfo(Directory);
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                if (file.Extension == ".bin")
                {
                    fileCount++;
                }
            }
        }

        public void AddData(byte[] data)
        {
            if (file.AddData(data) >= MaxSize)
            {
                Save();
            }
        }

        public void Save()
        {
            file.FileName = Directory + "\\DAT" + fileCount + ".bin";
            file.FileName = Directory + "\\DAT" + fileCount + ".bin";
            fileCount++;
            file.Save();
            file = new DatFile();
        }
    }

    public class DatFile
    {
        public string FileName { get; set; }

        public List<byte> Data { get; set; }

        public int Size { get; set; }

        public DatFile()
        {
            Size = 0;
            Data = new List<byte>();
        }

        public int AddData(byte[] data)
        {
            Data.AddRange(data);
            return Data.Count;
        }

        public void Save()
        {
            File.WriteAllBytes(FileName, Data.ToArray());
        }

        public void Load()
        {
            byte[] data = File.ReadAllBytes(FileName);
            Size = data.Length;
            for (int i = 1; i < data.Length; i++)
            {
                Data.Add(data[i]);
            }
        }
    }
}
