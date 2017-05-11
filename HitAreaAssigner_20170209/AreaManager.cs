using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitAreaAssigner_20170209
{
    class AreaManager
    {
        LinkedList<RectangleArea> areas;
        

        public AreaManager()
        {
            areas = new LinkedList<RectangleArea>();
        }

        public LinkedList<RectangleArea> getAreas
        {
            get { return areas; }
        }

        public void AddAfterIndex(int index)
        {
            areas.AddAfter(areas.Find(areas.ElementAt(index)), new RectangleArea());
        }

        public void AddLast()
        {
            areas.AddLast(new RectangleArea());
        }

        public RectangleArea getNode(int index)
        {
            return areas.ElementAt(index);
        }

        public void SetLeftUpPosToIndexedNode(int index, Point pos)
        {
            areas.ElementAt(index).LeftUpPosition = pos;
        }

        public void SetLengthToIndexedNode(int index, Size length)
        {
            areas.ElementAt(index).length = length;
        }

        public void Remove(int index)
        {
            LinkedListNode<RectangleArea> removeNode;

            removeNode = areas.Find(areas.ElementAt(index));

            areas.Remove(removeNode);
        }

        public int Count
        {
            get
            {
                int nodeNum = 0;
                foreach (var item in areas) nodeNum++;
                return nodeNum;
            }
        }

        public void Draw(Graphics g)
        {
            foreach(var node in areas)
            {
                node.Draw(g);
            }
        }
    }
}
