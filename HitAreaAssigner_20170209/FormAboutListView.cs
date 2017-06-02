using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace HitAreaAssigner_20170209
{
    // partialの試用
    public partial class Form1 : Form
    {
        private void bufferedListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bufferedListView1.SelectedItems.Count > 0)
            {
                if (areaIndex == bufferedListView1.SelectedItems[0].Index) return;

                bufferedListView1.Items[areaIndex].Selected = false;
                areaIndex = bufferedListView1.SelectedItems[0].Index;
                bufferedListView1.Items[areaIndex].Selected = true;
            }
        }

        private void bufferedListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            //DrawSubItemEventを使う場合、DrawItemEventもあると描画に誤作動が生じる

            if (bufferedListView1.Items[e.ItemIndex].Selected)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.Bounds);
                areaIndex = bufferedListView1.SelectedItems[0].Index;
                e.Graphics.DrawString(
                        e.SubItem.Text,
                        e.Item.Font,
                        SystemBrushes.HighlightText,
                        e.Bounds);
            }
            else
            {
                e.Graphics.DrawString(
                        e.SubItem.Text,
                        e.Item.Font,
                        SystemBrushes.WindowText,
                        e.Bounds);
            }
        }

        private void bufferedListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
