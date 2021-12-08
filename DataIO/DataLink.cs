using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataIO
{
    public class DataLink
    {
        public List<DataLinkItem> Items { get; set; }

        public DataLink()
        {
            Items = new List<DataLinkItem>();
        }

        public void AddLink(dynamic item)
        {
            Items.Add(new DataLinkItem(item));
        }
    }
}
