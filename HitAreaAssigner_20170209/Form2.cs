using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitAreaAssigner_20170209
{
    public partial class Form2 : Form
    {
        int width;
        int ReturnValue;

        List<int> framelist;

        public Form2(int imageWidth)
        {
            width = imageWidth;
            InitializeComponent();
        }

        void ListUp()
        {
            for(int divisionNumber = 1; divisionNumber < (int)Math.Sqrt(width); divisionNumber++)
            {
                if (width % divisionNumber != 0) continue;
                framelist.Add(divisionNumber);
            }
            
            comboBox1.DataSource = framelist;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Loaded image's width";
            label2.Text = width.ToString();
            label5.Text = "Select sum of frames";
            framelist = new List<int>();
            ListUp();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReturnValue = (int)comboBox1.SelectedItem;
            label3.Text = "Caluclated width per frame";
            label4.Text = (width / ReturnValue).ToString();
        }

        private void decideBtn_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            Close();
        }

        static public int ShowMiniForm(int imageWidth)
        {
            Form2 f = new Form2(imageWidth);
            f.ShowDialog();
            int sumFrame = f.ReturnValue;
            f.Dispose();
            return sumFrame;
        }
    }
}
