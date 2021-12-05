using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataIO
{
    public enum DataLinkDirection
    {
        DataIn,
        DataOut
    }

    public class DataLink
    {
        public List<DataLinkItem> Items { get; set; }

        public DataLink()
        {
            Items = new List<DataLinkItem>();
        }

        public void AddLink(object item)
        {
            Items.Add(new DataLinkItem(item));
        }
    }
}
