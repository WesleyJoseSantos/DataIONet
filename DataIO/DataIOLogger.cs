using System.IO;

namespace DataIO
{
    public class DataIOLogger
    {
        public string Directory { get; set; } = "C:\\Dat";

        public int MaxSize { get; set; } = 102300;

        private DataIOFile file = new DataIOFile();

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
            file = new DataIOFile();
        }
    }
}
