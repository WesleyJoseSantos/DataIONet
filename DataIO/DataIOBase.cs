using System;
using System.Collections.Generic;
using System.Linq;

namespace DataIO
{
    public abstract class DataIOBase
    {
        public DataLink DataIn { get; set; }
        public DataLink DataOut { get; set; }

        public delegate void DataIOEventHandler(object sender, DataIOEventArgs e);

        public DataIOBase()
        {
            DataIn = new DataLink();
            DataOut = new DataLink();
        }

        public void AddLink(object it, DataLinkDirection direction)
        {
            switch (direction)
            {
                case DataLinkDirection.DataIn:
                    DataIn.AddLink(it);
                    break;
                case DataLinkDirection.DataOut:
                    DataOut.AddLink(it);
                    break;
                default:
                    break;
            }
        }

        public abstract void Task();
    }

}
