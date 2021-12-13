using System;
using System.Collections.Generic;
using System.Linq;

namespace DataIO
{
    public abstract class DataIOBase
    {
        public DataLink DataLink { get; set; }

        public delegate void DataIOEventHandler(object sender, DataIOEventArgs e);

        public DataIOBase()
        {
            DataLink = new DataLink();
        }

        public void AddLink(dynamic it)
        {
            DataLink.AddLink(it);
        }

        public abstract void Task();
    }

}
