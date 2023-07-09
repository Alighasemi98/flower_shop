using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flower_shop.Class
{
    public static class ListViewExtensions
    {
        public static void MakeColumnHeaders(this ListView listView1, params object[] header_info)
        {
            listView1.Columns.Clear();
            for (int i = header_info.GetLowerBound(0);
                     i <= header_info.GetUpperBound(0);
                     i += 3)
            {
                listView1.Columns.Add(
                    (string)header_info[i],
                    (int)header_info[i + 1],
                    (HorizontalAlignment)header_info[i + 2]);
            }
        }
        public static void AddRow(this ListView listView1, string key, string item_title, params string[] subitem_titles)
        {
            ListViewItem new_item = listView1.Items.Add(item_title, key);
            for (int i = subitem_titles.GetLowerBound(0); i <= subitem_titles.GetUpperBound(0); i++)
            {
                new_item.SubItems.Add(subitem_titles[i]);
            }
        }
    }
    
}
