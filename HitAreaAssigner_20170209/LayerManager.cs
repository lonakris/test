using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitAreaAssigner_20170209
{
    class LayerManager
    {
        LinkedList<PictureBox> layer;

        // layerをAreaManagerに
        // AreaManagerをForm1.csにてリスト化

        public LayerManager()
        {
            layer = new LinkedList<PictureBox>();
        }

        public void AddAfterIndex(int index)
        {
            layer.AddAfter(layer.Find(layer.ElementAt(index)), new PictureBox());
            layer.Find(layer.ElementAt(index + 1)).Value.AllowDrop = true;
            layer.Find(layer.ElementAt(index + 1)).Value.DragEnter += Value_DragEnter;
            layer.Find(layer.ElementAt(index + 1)).Value.DragDrop += Value_DragDrop;
        }

        public void AddLast()
        {
            layer.AddLast(new PictureBox());
            layer.Last.Value.AllowDrop = true;
            layer.Last.Value.DragEnter += Value_DragEnter;
            layer.Last.Value.DragDrop += Value_DragDrop;
        }

        private void Value_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Value_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        public PictureBox getNode(int index)
        {
            return layer.ElementAt(index);
        }

    }
}
