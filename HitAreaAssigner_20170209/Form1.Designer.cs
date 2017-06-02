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
            this.AreaPictureBox = new System.Windows.Forms.PictureBox();
            this.AreaLblCarsorPos = new System.Windows.Forms.Label();
            this.AreaLblimageScale = new System.Windows.Forms.Label();
            this.AreaPanel = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CheckBoxIsUseState = new System.Windows.Forms.CheckBox();
            this.CheckBoxIsUseTag = new System.Windows.Forms.CheckBox();
            this.AreaListConvertBtn = new System.Windows.Forms.Button();
            this.TextBoxforTag = new HitAreaAssigner_20170209.TextBoxEx();
            this.TextBoxforState = new HitAreaAssigner_20170209.TextBoxEx();
            this.AreaListView = new HitAreaAssigner_20170209.BufferedListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FCMPanel = new System.Windows.Forms.Panel();
            this.FCMPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bufferedListView2 = new HitAreaAssigner_20170209.BufferedListView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEx3 = new HitAreaAssigner_20170209.TextBoxEx();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxEx4 = new HitAreaAssigner_20170209.TextBoxEx();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AreaPictureBox)).BeginInit();
            this.AreaPanel.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.FCMPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCMPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaPictureBox
            // 
            this.AreaPictureBox.Location = new System.Drawing.Point(27, 26);
            this.AreaPictureBox.Name = "AreaPictureBox";
            this.AreaPictureBox.Size = new System.Drawing.Size(256, 256);
            this.AreaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AreaPictureBox.TabIndex = 0;
            this.AreaPictureBox.TabStop = false;
            this.AreaPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.AreaPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            this.AreaPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.AreaPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.AreaPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.AreaPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // AreaLblCarsorPos
            // 
            this.AreaLblCarsorPos.AutoSize = true;
            this.AreaLblCarsorPos.Location = new System.Drawing.Point(21, 16);
            this.AreaLblCarsorPos.Name = "AreaLblCarsorPos";
            this.AreaLblCarsorPos.Size = new System.Drawing.Size(35, 12);
            this.AreaLblCarsorPos.TabIndex = 1;
            this.AreaLblCarsorPos.Text = "label1";
            // 
            // AreaLblimageScale
            // 
            this.AreaLblimageScale.AutoSize = true;
            this.AreaLblimageScale.Location = new System.Drawing.Point(21, 50);
            this.AreaLblimageScale.Name = "AreaLblimageScale";
            this.AreaLblimageScale.Size = new System.Drawing.Size(35, 12);
            this.AreaLblimageScale.TabIndex = 2;
            this.AreaLblimageScale.Text = "label2";
            // 
            // AreaPanel
            // 
            this.AreaPanel.AllowDrop = true;
            this.AreaPanel.AutoScroll = true;
            this.AreaPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreaPanel.Controls.Add(this.AreaPictureBox);
            this.AreaPanel.Location = new System.Drawing.Point(384, 31);
            this.AreaPanel.Name = "AreaPanel";
            this.AreaPanel.Size = new System.Drawing.Size(360, 330);
            this.AreaPanel.TabIndex = 5;
            this.AreaPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.AreaPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(38, 178);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(67, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(130, 16);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(121, 20);
            this.AreaComboBox.TabIndex = 8;
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(111, 179);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(67, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CheckBoxIsUseState
            // 
            this.CheckBoxIsUseState.AutoSize = true;
            this.CheckBoxIsUseState.Location = new System.Drawing.Point(23, 84);
            this.CheckBoxIsUseState.Name = "CheckBoxIsUseState";
            this.CheckBoxIsUseState.Size = new System.Drawing.Size(74, 16);
            this.CheckBoxIsUseState.TabIndex = 10;
            this.CheckBoxIsUseState.Text = "Use state";
            this.CheckBoxIsUseState.UseVisualStyleBackColor = true;
            this.CheckBoxIsUseState.CheckedChanged += new System.EventHandler(this.checkBoxIsUseState_CheckedChanged);
            // 
            // CheckBoxIsUseTag
            // 
            this.CheckBoxIsUseTag.AutoSize = true;
            this.CheckBoxIsUseTag.Location = new System.Drawing.Point(23, 131);
            this.CheckBoxIsUseTag.Name = "CheckBoxIsUseTag";
            this.CheckBoxIsUseTag.Size = new System.Drawing.Size(67, 16);
            this.CheckBoxIsUseTag.TabIndex = 12;
            this.CheckBoxIsUseTag.Text = "Use Tag";
            this.CheckBoxIsUseTag.UseVisualStyleBackColor = true;
            this.CheckBoxIsUseTag.CheckedChanged += new System.EventHandler(this.checkBoxIsUseTag_CheckedChanged);
            // 
            // AreaListConvertBtn
            // 
            this.AreaListConvertBtn.Location = new System.Drawing.Point(184, 179);
            this.AreaListConvertBtn.Name = "AreaListConvertBtn";
            this.AreaListConvertBtn.Size = new System.Drawing.Size(67, 23);
            this.AreaListConvertBtn.TabIndex = 14;
            this.AreaListConvertBtn.Text = "Convert";
            this.AreaListConvertBtn.UseVisualStyleBackColor = true;
            this.AreaListConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // TextBoxforTag
            // 
            this.TextBoxforTag.Location = new System.Drawing.Point(23, 153);
            this.TextBoxforTag.Name = "TextBoxforTag";
            this.TextBoxforTag.Size = new System.Drawing.Size(100, 19);
            this.TextBoxforTag.TabIndex = 13;
            this.TextBoxforTag.tempState = 0;
            this.TextBoxforTag.tempTag = null;
            this.TextBoxforTag.WatermarkText = "String";
            this.TextBoxforTag.Enter += new System.EventHandler(this.textBoxEx2_Enter);
            this.TextBoxforTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEx2_KeyDown);
            this.TextBoxforTag.Leave += new System.EventHandler(this.textBoxEx2_Leave);
            // 
            // TextBoxforState
            // 
            this.TextBoxforState.Location = new System.Drawing.Point(23, 106);
            this.TextBoxforState.Name = "TextBoxforState";
            this.TextBoxforState.Size = new System.Drawing.Size(100, 19);
            this.TextBoxforState.TabIndex = 11;
            this.TextBoxforState.tempState = 0;
            this.TextBoxforState.tempTag = null;
            this.TextBoxforState.WatermarkText = "Integer";
            this.TextBoxforState.Enter += new System.EventHandler(this.textBoxEx1_Enter);
            this.TextBoxforState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEx1_KeyDown);
            this.TextBoxforState.Leave += new System.EventHandler(this.textBoxEx1_Leave);
            // 
            // AreaListView
            // 
            this.AreaListView.FullRowSelect = true;
            this.AreaListView.Location = new System.Drawing.Point(23, 220);
            this.AreaListView.Name = "AreaListView";
            this.AreaListView.Size = new System.Drawing.Size(228, 141);
            this.AreaListView.TabIndex = 15;
            this.AreaListView.UseCompatibleStateImageBehavior = false;
            this.AreaListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.AreaListView_DrawColumnHeader);
            this.AreaListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.AreaListView_DrawSubItem);
            this.AreaListView.SelectedIndexChanged += new System.EventHandler(this.AreaListView_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "AreaList";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "WorkSpace";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 36);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(774, 409);
            this.TabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.AreaListView);
            this.tabPage1.Controls.Add(this.AreaPanel);
            this.tabPage1.Controls.Add(this.AreaLblCarsorPos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AreaLblimageScale);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.Controls.Add(this.AreaComboBox);
            this.tabPage1.Controls.Add(this.AreaListConvertBtn);
            this.tabPage1.Controls.Add(this.RemoveBtn);
            this.tabPage1.Controls.Add(this.TextBoxforTag);
            this.tabPage1.Controls.Add(this.CheckBoxIsUseState);
            this.tabPage1.Controls.Add(this.CheckBoxIsUseTag);
            this.tabPage1.Controls.Add(this.TextBoxforState);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Area";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.FCMPanel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.bufferedListView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxEx3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.textBoxEx4);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FrameCount&Move";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FCMPanel
            // 
            this.FCMPanel.AllowDrop = true;
            this.FCMPanel.AutoScroll = true;
            this.FCMPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FCMPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FCMPanel.Controls.Add(this.FCMPictureBox);
            this.FCMPanel.Location = new System.Drawing.Point(384, 32);
            this.FCMPanel.Name = "FCMPanel";
            this.FCMPanel.Size = new System.Drawing.Size(360, 330);
            this.FCMPanel.TabIndex = 20;
            // 
            // FCMPictureBox
            // 
            this.FCMPictureBox.Location = new System.Drawing.Point(27, 26);
            this.FCMPictureBox.Name = "FCMPictureBox";
            this.FCMPictureBox.Size = new System.Drawing.Size(256, 256);
            this.FCMPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FCMPictureBox.TabIndex = 0;
            this.FCMPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "WorkSpace";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "AreaList";
            // 
            // bufferedListView2
            // 
            this.bufferedListView2.AllowDrop = true;
            this.bufferedListView2.Location = new System.Drawing.Point(23, 221);
            this.bufferedListView2.Name = "bufferedListView2";
            this.bufferedListView2.Size = new System.Drawing.Size(228, 141);
            this.bufferedListView2.TabIndex = 29;
            this.bufferedListView2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(184, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.AllowDrop = true;
            this.textBoxEx3.Location = new System.Drawing.Point(23, 154);
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.Size = new System.Drawing.Size(100, 19);
            this.textBoxEx3.TabIndex = 27;
            this.textBoxEx3.tempState = 0;
            this.textBoxEx3.tempTag = null;
            this.textBoxEx3.WatermarkText = "String";
            // 
            // checkBox1
            // 
            this.checkBox1.AllowDrop = true;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 16);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Use Tag";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxEx4
            // 
            this.textBoxEx4.AllowDrop = true;
            this.textBoxEx4.Location = new System.Drawing.Point(23, 107);
            this.textBoxEx4.Name = "textBoxEx4";
            this.textBoxEx4.Size = new System.Drawing.Size(100, 19);
            this.textBoxEx4.TabIndex = 25;
            this.textBoxEx4.tempState = 0;
            this.textBoxEx4.tempTag = null;
            this.textBoxEx4.WatermarkText = "Integer";
            // 
            // checkBox2
            // 
            this.checkBox2.AllowDrop = true;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 16);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Use state";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 457);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AreaPictureBox)).EndInit();
            this.AreaPanel.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.FCMPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FCMPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AreaPictureBox;
        private System.Windows.Forms.Label AreaLblCarsorPos;
        private System.Windows.Forms.Label AreaLblimageScale;
        private System.Windows.Forms.Panel AreaPanel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.CheckBox CheckBoxIsUseState;
        private TextBoxEx TextBoxforState;
        private TextBoxEx TextBoxforTag;
        private System.Windows.Forms.CheckBox CheckBoxIsUseTag;
        private System.Windows.Forms.Button AreaListConvertBtn;
        private BufferedListView AreaListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel FCMPanel;
        private System.Windows.Forms.PictureBox FCMPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private BufferedListView bufferedListView2;
        private System.Windows.Forms.Button button1;
        private TextBoxEx textBoxEx3;
        private System.Windows.Forms.CheckBox checkBox1;
        private TextBoxEx textBoxEx4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

