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
        private void AreaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AreaListView.SelectedItems.Count > 0)
            {
                if (areaIndex == AreaListView.SelectedItems[0].Index) return;

                AreaListView.Items[areaIndex].Selected = false;
                areaIndex = AreaListView.SelectedItems[0].Index;
                AreaListView.Items[areaIndex].Selected = true;
            }
        }

        private void AreaListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            //DrawSubItemEventを使う場合、DrawItemEventもあると描画に誤作動が生じる

            if (AreaListView.Items[e.ItemIndex].Selected)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.Bounds);
                areaIndex = AreaListView.SelectedItems[0].Index;
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

        private void AreaListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
