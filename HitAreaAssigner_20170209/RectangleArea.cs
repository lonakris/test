using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitAreaAssigner_20170209
{
    class RectangleArea
    {

        public Point LeftUpPosition { get; set; }
        public Size length { get; set; }
        public int state { get; set; }
        public string tag { get; set; }

        public RectangleArea()
        {
            LeftUpPosition = new Point(0, 0);
            length = new Size(0, 0);
            state = 0;
            tag = "";
        }

        public RectangleArea(int state)
        {
            LeftUpPosition = new Point(0, 0);
            length = new Size(0, 0);
            this.state = state;
            tag = "";
        }

        public Rectangle area
        {
            get
            {
                Point drawPos;
                Size drawSize;

                drawPos = LeftUpPosition;
                drawSize = length;

                if(length.Width < 0)
                {
                    drawPos.X += length.Width;
                    drawSize.Width = -length.Width;
                }

                if (length.Height < 0)
                {
                    drawPos.Y += length.Height;
                    drawSize.Height = -length.Height;
                }

                return new Rectangle(drawPos, drawSize);
            }
        }

        public string DataForCSVFile(bool isUseState, bool isUseTag)
        {
            
            {
                int[] tempdata = new int[] {
                    area.X,
                    area.Y,
                    area.Width,
                    area.Height,
                };

                string returndata = "";

                foreach (int item in tempdata)
                    returndata += (item.ToString() + ",");

                if (isUseState) returndata += state.ToString() + ",";
                if (isUseTag) returndata += tag;

                return returndata;
            }
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(drawcolor), area);
        }

        public void Draw(Graphics g, bool isSelect)
        {
            g.FillRectangle(new SolidBrush(drawcolor), area);
        }

        public Color drawcolor
        {
            get
            {
                Color c = Color.White;
                switch(state)
                {
                    case 0: c = Color.FromArgb(200, 64, 80, 255); break;
                    default:c = Color.FromArgb(200, 64, 80, 80); break;
                }
                
                return c;
            }
        }
    }
}
