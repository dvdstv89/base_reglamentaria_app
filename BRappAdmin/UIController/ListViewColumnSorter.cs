using System;
using System.Windows.Forms;
using System.Collections;

namespace BRappAdmin.UIController
{
    public class ListViewColumnSorter : IComparer
    {
        private int columnIndex;
        private SortOrder order;

        public ListViewColumnSorter()
        {
            columnIndex = 0;
            order = SortOrder.None;
        }

        public void Sort(ListView listView, int columnIndex)
        {
            if (this.columnIndex == columnIndex)
            {
                order = (order == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                this.columnIndex = columnIndex;
                order = SortOrder.Ascending;
            }

            listView.ListViewItemSorter = this;
            listView.Sort();
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            // Compare subitems based on the column index
            string textX = itemX.SubItems[columnIndex].Text;
            string textY = itemY.SubItems[columnIndex].Text;

            int result = string.Compare(textX, textY);

            // Reverse the result if sorting in descending order
            if (order == SortOrder.Descending)
            {
                result *= -1;
            }

            return result;
        }
    }
}
