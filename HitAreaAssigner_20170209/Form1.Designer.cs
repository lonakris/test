namespace HitAreaAssigner_20170209
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.checkBoxIsUseState = new System.Windows.Forms.CheckBox();
            this.checkBoxIsUseTag = new System.Windows.Forms.CheckBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.textBoxEx2 = new HitAreaAssigner_20170209.TextBoxEx();
            this.textBoxEx1 = new HitAreaAssigner_20170209.TextBoxEx();
            this.bufferedListView1 = new HitAreaAssigner_20170209.BufferedListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(367, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 330);
            this.panel1.TabIndex = 5;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 178);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(67, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(85, 178);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(67, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // checkBoxIsUseState
            // 
            this.checkBoxIsUseState.AutoSize = true;
            this.checkBoxIsUseState.Location = new System.Drawing.Point(12, 83);
            this.checkBoxIsUseState.Name = "checkBoxIsUseState";
            this.checkBoxIsUseState.Size = new System.Drawing.Size(74, 16);
            this.checkBoxIsUseState.TabIndex = 10;
            this.checkBoxIsUseState.Text = "Use state";
            this.checkBoxIsUseState.UseVisualStyleBackColor = true;
            this.checkBoxIsUseState.CheckedChanged += new System.EventHandler(this.checkBoxIsUseState_CheckedChanged);
            // 
            // checkBoxIsUseTag
            // 
            this.checkBoxIsUseTag.AutoSize = true;
            this.checkBoxIsUseTag.Location = new System.Drawing.Point(12, 130);
            this.checkBoxIsUseTag.Name = "checkBoxIsUseTag";
            this.checkBoxIsUseTag.Size = new System.Drawing.Size(67, 16);
            this.checkBoxIsUseTag.TabIndex = 12;
            this.checkBoxIsUseTag.Text = "Use Tag";
            this.checkBoxIsUseTag.UseVisualStyleBackColor = true;
            this.checkBoxIsUseTag.CheckedChanged += new System.EventHandler(this.checkBoxIsUseTag_CheckedChanged);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(158, 178);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(67, 23);
            this.ConvertBtn.TabIndex = 14;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.Location = new System.Drawing.Point(12, 152);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.Size = new System.Drawing.Size(100, 19);
            this.textBoxEx2.TabIndex = 13;
            this.textBoxEx2.tempState = 0;
            this.textBoxEx2.tempTag = null;
            this.textBoxEx2.WatermarkText = "String";
            this.textBoxEx2.Enter += new System.EventHandler(this.textBoxEx2_Enter);
            this.textBoxEx2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEx2_KeyDown);
            this.textBoxEx2.Leave += new System.EventHandler(this.textBoxEx2_Leave);
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.Location = new System.Drawing.Point(12, 105);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(100, 19);
            this.textBoxEx1.TabIndex = 11;
            this.textBoxEx1.tempState = 0;
            this.textBoxEx1.tempTag = null;
            this.textBoxEx1.WatermarkText = "Integer";
            this.textBoxEx1.Enter += new System.EventHandler(this.textBoxEx1_Enter);
            this.textBoxEx1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEx1_KeyDown);
            this.textBoxEx1.Leave += new System.EventHandler(this.textBoxEx1_Leave);
            // 
            // bufferedListView1
            // 
            this.bufferedListView1.Location = new System.Drawing.Point(12, 207);
            this.bufferedListView1.Name = "bufferedListView1";
            this.bufferedListView1.Size = new System.Drawing.Size(228, 135);
            this.bufferedListView1.TabIndex = 15;
            this.bufferedListView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 570);
            this.Controls.Add(this.bufferedListView1);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.textBoxEx2);
            this.Controls.Add(this.checkBoxIsUseTag);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.checkBoxIsUseState);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.CheckBox checkBoxIsUseState;
        private TextBoxEx textBoxEx1;
        private TextBoxEx textBoxEx2;
        private System.Windows.Forms.CheckBox checkBoxIsUseTag;
        private System.Windows.Forms.Button ConvertBtn;
        private BufferedListView bufferedListView1;
    }
}

