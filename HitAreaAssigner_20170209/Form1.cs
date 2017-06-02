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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //todo
        //bufferedListView1をBufferedListViewに置き換え
        //tagによるareacolorの紐づけ(coloredit)
        //選択中のareaを若干白っぽく
        //情報をarea,tagのみに

        //want
        //専用データの作成

        //think
        //tagはattack,damage２種のどちらかを選択させる
        //tag==damageのとき、基礎ダメージ量を記入できるように

        ImageData targetImageData;

        int a = 0;
        int worldScale;
        
        AreaManager[] areaList;
        int areaIndex;

        Point LocatedPointInpictureBox1
        {
            get
            {
                int posX = AreaPictureBox.PointToClient(System.Windows.Forms.Cursor.Position).X / worldScale;
                int posY = AreaPictureBox.PointToClient(System.Windows.Forms.Cursor.Position).Y / worldScale;
                return new Point(posX, posY);
            }
        }
        Point HasLocatedPointInpictureBox1;

        PictureBox layer;

        enum OrderCodeName
        {
            NONE, DRAWRECTANGLE
        }

        OrderCodeName orderCode;

        private void Form1_Load(object sender, EventArgs e)
        {
            AreaPanel.Controls.Add(AreaPictureBox);

            AreaPictureBox.AllowDrop = true;

            targetImageData = null;

            AreaPictureBox.MouseWheel += PictureBox1_MouseWheel;
            AreaPanel.MouseWheel += Panel1_MouseWheel;

            //areaList = new AreaManager();

            LayerInfoInitialize();

            CheckBoxIsUseState.Enabled = false;
            CheckBoxIsUseTag.Enabled = false;
            TextBoxforState.Enabled = false;
            TextBoxforTag.Enabled = false;

            orderCode = OrderCodeName.NONE;
            worldScale = 1;
        }

        void LayerInfoInitialize()
        {
            layer = new PictureBox();
            layer.AllowDrop = true;
            layer.MouseWheel += PictureBox1_MouseWheel;
            layer.MouseDown += Layer_MouseDown;
            layer.MouseMove += Layer_MouseMove;
            layer.MouseUp += Layer_MouseUp;
            layer.Paint += Layer_Paint;
            layer.Enabled = true;

            AreaPanel.Controls.Add(layer);
            layer.Parent = AreaPictureBox;
            layer.BringToFront();
            layer.BackColor = Color.Transparent;
        }

        private void Layer_Paint(object sender, PaintEventArgs e)
        {
            if (targetImageData != null)
            {
                DrawToLayer(e.Graphics);
            }
        }

        void DrawToLayer(Graphics g)
        {
            g.InterpolationMode =
               System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            g.TranslateTransform(targetImageData.drawPosX * worldScale, targetImageData.drawPosY * worldScale);
            g.ScaleTransform(worldScale, worldScale);

            areaList[targetImageData.nowFrame].Draw(g);
        }

        private void Layer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {

                if (targetImageData != null)
                {
                    if (IsDrawRectangle)
                    {
                        orderCode = OrderCodeName.DRAWRECTANGLE;
                        int posX = LocatedPointInpictureBox1.X - targetImageData.drawPosX;
                        int posY = LocatedPointInpictureBox1.Y - targetImageData.drawPosY;
                        areaList[targetImageData.nowFrame].SetLeftUpPosToIndexedNode(areaIndex, new Point(posX, posY));
                        areaList[targetImageData.nowFrame].SetLengthToIndexedNode(areaIndex, new Size(1, 1));
                    }

                }
            }
        }

        private void Layer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {

                if (targetImageData != null)
                {
                    orderCode = OrderCodeName.NONE;
                }
            }
        }

        private void Layer_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (targetImageData == null) return;

            Point cursolLocation
                = new Point(LocatedPointInpictureBox1.X - targetImageData.drawPosX,
                            LocatedPointInpictureBox1.Y - targetImageData.drawPosY);

            AreaLblCarsorPos.Text = cursolLocation.ToString();

            switch (orderCode)
            {
                case OrderCodeName.NONE: break;
                case OrderCodeName.DRAWRECTANGLE: DrawRectangle(); break;
            }
            AreaPictureBox.Invalidate();
            layer.Invalidate();
            HasLocatedPointInpictureBox1 = LocatedPointInpictureBox1;
        }
       
        void ImageScaling(int delta)
        {
            if (targetImageData != null)
            {
                a += delta;
                if (a < 0) a = 0;
                
                int oldWorldScale = worldScale;
                worldScale = a / 120 + 1;
                AreaLblimageScale.Text = "Scale: x"+worldScale.ToString();

                AreaPictureBox.Size = new Size(AreaPictureBox.Width * worldScale / oldWorldScale,
                                            AreaPictureBox.Height * worldScale / oldWorldScale);

                layer.Size = AreaPictureBox.Size;

                int denominator, numerator;

                if (worldScale % 2 == 0)
                {
                    denominator = worldScale * 2;
                    numerator = denominator / 2 - 1;
                }
                else
                {
                    denominator = worldScale;
                    if (worldScale == 1) numerator = 1;
                    else numerator = denominator / 2;
                }

                AreaPanel.AutoScrollPosition
                    = new Point(AreaPictureBox.Width / denominator * numerator,
                                AreaPictureBox.Height / denominator * numerator);

                AreaPictureBox.Invalidate();
                layer.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (targetImageData != null)
            {
                DrawToPictureBox(e.Graphics); 
            }
        }

        void DrawToPictureBox(Graphics g)
        {
            Rectangle drawRect 
                = new Rectangle(0, 0, targetImageData.drawWidth, targetImageData.drawHeight);

            // 描画補間法の指定
            g.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            g.TranslateTransform(targetImageData.drawPosX * worldScale, targetImageData.drawPosY * worldScale);
            g.ScaleTransform(worldScale, worldScale);

            g.FillRectangle(new SolidBrush(Color.DeepPink), drawRect);
            //g.DrawImage(currentImage, drawRect);

            targetImageData.Draw(g);
        }

        private void Panel1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ImageScaling(e.Delta);
        }

        private void PictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ImageScaling(e.Delta);
        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (targetImageData == null) return;

            Point cursolLocation
                = new Point(LocatedPointInpictureBox1.X - targetImageData.drawPosX,
                            LocatedPointInpictureBox1.Y - targetImageData.drawPosY);

            AreaLblCarsorPos.Text = cursolLocation.ToString();

            switch (orderCode)
            {
                case OrderCodeName.NONE: break;
                case OrderCodeName.DRAWRECTANGLE: DrawRectangle(); break;
            }
            AreaPictureBox.Invalidate();
            HasLocatedPointInpictureBox1 = LocatedPointInpictureBox1;
        }

        void DrawRectangle()
        {
            int width = LocatedPointInpictureBox1.X 
                        - targetImageData.drawPosX - areaList[targetImageData.nowFrame].getNode(areaIndex).LeftUpPosition.X;
                
            int height = LocatedPointInpictureBox1.Y 
                        - targetImageData.drawPosY - areaList[targetImageData.nowFrame].getNode(areaIndex).LeftUpPosition.Y;
         
            areaList[targetImageData.nowFrame].SetLengthToIndexedNode(areaIndex, new Size(width, height));
            
            AreaListView.Items[areaIndex].SubItems[1].Text =
                areaList[targetImageData.nowFrame].getNode(areaIndex).area.ToString();
        }

        bool IsLocatedCasorOnTheImage
        {
            get
            {
                if (HasLocatedPointInpictureBox1.X >= targetImageData.drawPosX &&
                    HasLocatedPointInpictureBox1.X <= targetImageData.DrawPos_RightBottomX &&
                    HasLocatedPointInpictureBox1.Y >= targetImageData.drawPosY &&
                    HasLocatedPointInpictureBox1.Y <= targetImageData.DrawPos_RightBottomY)
                    return true;

                return false;
            }
        }
        
        bool IsDrawRectangle
        {
            get
            {
                if (IsLocatedCasorOnTheImage) return true;
                return false;
            }
        }

        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button.HasFlag(MouseButtons.Left))
            {
                if(targetImageData != null)
                {
                    if (IsDrawRectangle)
                    {
                        orderCode = OrderCodeName.DRAWRECTANGLE;
                        int posX = LocatedPointInpictureBox1.X - targetImageData.drawPosX;
                        int posY = LocatedPointInpictureBox1.Y - targetImageData.drawPosY;
                        areaList[targetImageData.nowFrame].SetLeftUpPosToIndexedNode(areaIndex, new Point(posX, posY));
                        areaList[targetImageData.nowFrame].SetLengthToIndexedNode(areaIndex, new Size(1, 1));
                    }
                    
                }
            }
            
        }

        private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
            {
                
                if (targetImageData != null)
                {
                    orderCode = OrderCodeName.NONE;
                }
            }
                
        }

        void IsworkableImage(DragEventArgs e)
        {
            try
            {
                //コントロール内にドラッグされたとき実行される
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                {
                    string[] filepath =
                    (string[])e.Data.GetData(DataFormats.FileDrop, false);
                    string fileExt = System.IO.Path.GetExtension(filepath[0]);
                    if (fileExt == ".jpg" || fileExt == ".png") e.Effect = DragDropEffects.Copy;
                }
                else
                    //ファイル以外は受け付けない
                    e.Effect = DragDropEffects.None;
            }
            catch { }
        }

        int SetFrame(Image image)
        {
            Enabled = false;

            int i = Form2.ShowMiniForm(image.Width);

            Enabled = true;

            return i;
        }

        Image LoadImage(DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] filepath =
                (string[])e.Data.GetData(DataFormats.FileDrop, false);
            return Image.FromFile(filepath[0]);
        }

        void Setting(Image image, int frames)
        {
            AreaPictureBox.Location = new Point(0, 0);
            AreaPictureBox.Size = AreaPanel.Size;

            AreaPictureBox.BackColor = Color.DeepSkyBlue;

            targetImageData = new ImageData(image, frames, AreaPictureBox.Size);

            for(int frameNum = 0; frameNum < frames; frameNum++)
                AreaComboBox.Items.Add((frameNum+1).ToString());

            AreaComboBox.SelectedIndex = 0;

            worldScale = 1;

            areaList = new AreaManager[frames];
            for (int i = 0; i < frames; i++)
            {
                areaList[i] = new AreaManager();
                areaList[i].AddLast();
            }
            
            areaIndex = 0;

            CheckBoxIsUseState.Enabled = true;
            CheckBoxIsUseTag.Enabled = true;

            TextBoxforState.Text = areaList[targetImageData.nowFrame].getNode(areaIndex).state.ToString();
            TextBoxforTag.Text = areaList[targetImageData.nowFrame].getNode(areaIndex).tag;

            AreaListView.View = View.Details;
            AreaListView.Columns.Add("Number", 40);
            AreaListView.Columns.Add("Area", 200);
            AreaListView.HideSelection = false;
            ListViewItem inputdata = new ListViewItem();
            inputdata.Text = areaIndex.ToString();
            inputdata.SubItems.Add(areaList[targetImageData.nowFrame].getNode(areaIndex).area.ToString());
            AreaListView.Items.Add(inputdata);
            AreaListView.Items[0].Selected = true;

            //PictureBox addPictureBox = new PictureBox();
            layer.Location = new Point(0, 0);
            layer.Size = AreaPictureBox.Size;

            AreaPictureBox.Invalidate();
            layer.Invalidate();

            AreaLblCarsorPos.Text = AreaPanel.Size.ToString();
        }

        void LoadAndSetting(DragEventArgs e)
        {
            Image image = LoadImage(e);
            int frames = SetFrame(image);
            if (frames > 0) Setting(image, frames);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            IsworkableImage(e);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            LoadAndSetting(e);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            IsworkableImage(e);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            LoadAndSetting(e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(targetImageData!=null)
            {
                areaList[targetImageData.nowFrame].AddAfterIndex(areaIndex);
                AreaListView.Items[areaIndex].Selected = false;
                areaIndex++;
                ListViewItem inputdata = new ListViewItem();

                //仮データをlistviewに入れる
                inputdata.Text = areaIndex.ToString();
                inputdata.SubItems.Add("");
                AreaListView.Items.Add(inputdata);

                for (int i = 0; i < AreaListView.Items.Count; i++)
                {
                    AreaListView.Items[i].Text = i.ToString();
                    AreaListView.Items[i].SubItems[1].Text
                        = areaList[targetImageData.nowFrame].getNode(i).area.ToString();
                }

                AreaListView.Items[areaIndex].Selected = true;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (areaList == null) return;
            
            targetImageData.nowFrame = AreaComboBox.SelectedIndex;
            AreaListView.Items.Clear();

            areaIndex = 0;
            for (int i = 0; i < areaList[targetImageData.nowFrame].Count; i++)
            {
                ListViewItem inputdata = new ListViewItem();
                inputdata.Text = areaIndex.ToString();
                inputdata.SubItems.Add(areaList[targetImageData.nowFrame].getNode(i).area.ToString());
                AreaListView.Items.Add(inputdata);
            }    
            
            AreaListView.Items[0].Selected = true;
            AreaPictureBox.Invalidate();
            layer.Invalidate();
        }

        private void checkBoxIsUseState_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxforState.Enabled = CheckBoxIsUseState.Checked;
        }

        private void checkBoxIsUseTag_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxforTag.Enabled = CheckBoxIsUseTag.Checked;
        }

        private void textBoxEx1_Enter(object sender, EventArgs e)
        {
            TextBoxforState.tempState = areaList[targetImageData.nowFrame].getNode(areaIndex).state;
        }

        private void textBoxEx1_Leave(object sender, EventArgs e)
        {
            TextBoxforState.Text = TextBoxforState.tempState.ToString();
        }

        private void textBoxEx1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                try
                {
                    areaList[targetImageData.nowFrame].getNode(areaIndex).state =
                        Convert.ToInt32(TextBoxforState.Text);
                    TextBoxforState.tempState = areaList[targetImageData.nowFrame].getNode(areaIndex).state;
                }
                catch
                {

                }
                AreaListView.Focus();
            }
            
        }

        private void textBoxEx2_Enter(object sender, EventArgs e)
        {
            TextBoxforTag.tempTag = areaList[targetImageData.nowFrame].getNode(areaIndex).tag;
        }

        private void textBoxEx2_Leave(object sender, EventArgs e)
        {
            TextBoxforTag.Text = TextBoxforTag.tempTag;
        }

        private void textBoxEx2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    areaList[targetImageData.nowFrame].getNode(areaIndex).tag =TextBoxforTag.Text;
                    TextBoxforTag.tempTag = areaList[targetImageData.nowFrame].getNode(areaIndex).tag;
                }
                catch
                {

                }
                AreaListView.Focus();
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (targetImageData == null) return;
            if (areaList[targetImageData.nowFrame].Count < 2) return;
            //areaManager
            areaList[targetImageData.nowFrame].Remove(areaIndex);

            //listview
            AreaListView.Items.RemoveAt(areaIndex);
            for(int index = 0; index+areaIndex < areaList[targetImageData.nowFrame].Count; index++)
            {
                AreaListView.Items[index + areaIndex].Text = (index + areaIndex).ToString();
            }

            if(areaIndex > 0)areaIndex--;
            AreaListView.Items[areaIndex].Selected = true;

            layer.Invalidate();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (targetImageData == null) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "newdata.csv";
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.Filter = "CSVFile(*.csv)|*.csv";
            sfd.FilterIndex = 1;
            sfd.Title = "save";
            sfd.RestoreDirectory = true;
            sfd.AddExtension = true;
            

            if(sfd.ShowDialog()==DialogResult.OK)
            {
                //拡張子分の文字列のみ切り抜いてそれを参照した方がよさそう
                //下記の条件文ではディレクトリ部分にも反応するかも　未検証
                //ex. /file.csvle/.../a.csv
                if(sfd.FileName.LastIndexOf(".csv")>-1)
                {
                    FileConverter fc = new FileConverter();
                    fc.ConvertToCSV(sfd.FileName, areaList, CheckBoxIsUseState.Checked, CheckBoxIsUseTag.Checked);
                }
                
            }
            
        }
    }

}
