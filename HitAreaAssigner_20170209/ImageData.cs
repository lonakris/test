using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace HitAreaAssigner_20170209
{
    class ImageData
    {
        public Image currentImage { get; }
        public int nowFrame { get; set; }
        public int sumFrame { get; }
        public int drawPosX { get; }
        public int drawPosY { get; }
        public int drawWidth { get; }
        public int drawHeight { get; }

        public ImageData(Image loadImage, int frames, Size pictureBoxSize)
        {
            currentImage = loadImage;

            sumFrame = frames;
            drawWidth = currentImage.Width / frames;
            drawHeight = currentImage.Height;
            nowFrame = 0;

            int posX, posY;

            posX = pictureBoxSize.Width;
            posX -= currentImage.Width;
            posX /= 2;

            if (sumFrame >= 3)
                posX += (sumFrame - 1) * drawWidth;
            if (sumFrame % 2 == 0)
                posX += drawWidth / 2;

            posY = (pictureBoxSize.Height - currentImage.Height) / 2;

            drawPosX = posX;
            drawPosY = posY;
        }

        public Point DrawPos_LeftUp
        {
            get { return new Point(drawPosX, drawPosY); }
        }

        public int DrawPos_RightBottomX
        { get { return drawPosX + drawWidth; } }

        public int DrawPos_RightBottomY
        { get { return drawPosY + drawHeight; } }

        public Point DrawPos_RightBottom
        {
            get { return new Point(drawPosX + drawWidth, drawPosY + drawHeight); }
        }

        public Size DrawSize
        {
            get { return new Size(drawWidth, drawHeight); }
        }

        public void Draw(Graphics g)
        {
            //clipping
            //g.SetClip(new Rectangle(0, 0, drawWidth, drawHeight));
            //g.DrawImage(currentImage, (nowFrame) * drawWidth, 0, drawWidth, drawHeight);

            //trimming
            int posX = (nowFrame) * drawWidth;
            Rectangle target = new Rectangle(posX, 0, drawWidth, drawHeight);
            Rectangle based = new Rectangle(0, 0, drawWidth, drawHeight);
            g.DrawImage(currentImage, based, target, GraphicsUnit.Pixel);
        }
    }
}
