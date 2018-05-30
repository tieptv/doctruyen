namespace truyen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chuong = new System.Windows.Forms.Label();
            this.so = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.noidung = new System.Windows.Forms.RichTextBox();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ds_chuong = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reset = new System.Windows.Forms.Button();
            this.button_music = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textFont = new System.Windows.Forms.ComboBox();
            this.textSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.den = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1180, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1038, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "PREV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(454, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHƯƠNG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chuong
            // 
            this.chuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chuong.AutoSize = true;
            this.chuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chuong.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuong.Location = new System.Drawing.Point(635, 79);
            this.chuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chuong.Name = "chuong";
            this.chuong.Size = new System.Drawing.Size(120, 28);
            this.chuong.TabIndex = 5;
            this.chuong.Text = "Tên chương";
            this.chuong.Click += new System.EventHandler(this.chuong_Click);
            // 
            // so
            // 
            this.so.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.so.AutoSize = true;
            this.so.BackColor = System.Drawing.Color.Transparent;
            this.so.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.so.Location = new System.Drawing.Point(562, 79);
            this.so.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(33, 25);
            this.so.TabIndex = 6;
            this.so.Text = "so";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(8, 14);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(288, 43);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.search_Click);
            // 
            // noidung
            // 
            this.noidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noidung.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noidung.Location = new System.Drawing.Point(450, 144);
            this.noidung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.noidung.Size = new System.Drawing.Size(862, 553);
            this.noidung.TabIndex = 9;
            this.noidung.Text = "";
            this.noidung.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noidung_MouseDoubleClick);
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list.Location = new System.Drawing.Point(0, 65);
            this.list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(393, 443);
            this.list.TabIndex = 10;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chương";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội dung";
            this.columnHeader2.Width = 300;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 144);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 554);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ds_chuong);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(394, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách chương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ds_chuong
            // 
            this.ds_chuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ds_chuong.FormattingEnabled = true;
            this.ds_chuong.HorizontalScrollbar = true;
            this.ds_chuong.ItemHeight = 20;
            this.ds_chuong.Location = new System.Drawing.Point(8, 8);
            this.ds_chuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ds_chuong.Name = "ds_chuong";
            this.ds_chuong.Size = new System.Drawing.Size(380, 504);
            this.ds_chuong.TabIndex = 0;
            this.ds_chuong.SelectedIndexChanged += new System.EventHandler(this.ds_chuong_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.list);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.searchBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(394, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reset);
            this.tabPage3.Controls.Add(this.button_music);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textFont);
            this.tabPage3.Controls.Add(this.textSize);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(394, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Option";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(169, 239);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 29);
            this.reset.TabIndex = 21;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button_music
            // 
            this.button_music.Location = new System.Drawing.Point(169, 164);
            this.button_music.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_music.Name = "button_music";
            this.button_music.Size = new System.Drawing.Size(94, 29);
            this.button_music.TabIndex = 20;
            this.button_music.Text = "Tắt nhạc";
            this.button_music.UseVisualStyleBackColor = true;
            this.button_music.Click += new System.EventHandler(this.button_music_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Music:";
            // 
            // textFont
            // 
            this.textFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textFont.FormattingEnabled = true;
            this.textFont.Location = new System.Drawing.Point(169, 100);
            this.textFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFont.Name = "textFont";
            this.textFont.Size = new System.Drawing.Size(150, 28);
            this.textFont.TabIndex = 18;
            this.textFont.SelectedIndexChanged += new System.EventHandler(this.textFont_SelectedIndexChanged);
            // 
            // textSize
            // 
            this.textSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSize.FormattingEnabled = true;
            this.textSize.Location = new System.Drawing.Point(169, 38);
            this.textSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(150, 28);
            this.textSize.TabIndex = 17;
            this.textSize.SelectedIndexChanged += new System.EventHandler(this.textSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Font :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text size :";
            // 
            // den
            // 
            this.den.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Location = new System.Drawing.Point(20, 96);
            this.den.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(102, 45);
            this.den.TabIndex = 13;
            this.den.Text = "Tắt đèn";
            this.den.UseVisualStyleBackColor = true;
            this.den.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(20, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 96);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 45);
            this.button5.TabIndex = 15;
            this.button5.Text = "Kiểm Tra Chính Tả";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(480, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thần Điêu Đại Hiệp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 712);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.noidung);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.so);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chuong);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chuong;
        private System.Windows.Forms.Label so;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button den;
        private System.Windows.Forms.ComboBox textFont;
        private System.Windows.Forms.ComboBox textSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_music;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox noidung;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ListBox ds_chuong;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

