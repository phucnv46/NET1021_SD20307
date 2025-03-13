namespace B1_LamQuen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxTen = new TextBox();
            label2 = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            label3 = new Label();
            textBoxTuoi = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            comboBox1 = new ComboBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            checkBoxKhac = new CheckBox();
            checkBoxTikTok = new CheckBox();
            checkBoxDocSach = new CheckBox();
            checkBoxBiA = new CheckBox();
            checkBoxTC = new CheckBox();
            checkBoxMQ = new CheckBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 87);
            label1.Name = "label1";
            label1.Size = new Size(125, 35);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(193, 96);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(344, 27);
            textBoxTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 184);
            label2.Name = "label2";
            label2.Size = new Size(130, 35);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(193, 184);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(344, 27);
            dateTimePickerNgaySinh.TabIndex = 3;
            dateTimePickerNgaySinh.ValueChanged += dateTimePickerNgaySinh_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(572, 184);
            label3.Name = "label3";
            label3.Size = new Size(64, 35);
            label3.TabIndex = 4;
            label3.Text = "Tuổi";
            // 
            // textBoxTuoi
            // 
            textBoxTuoi.Location = new Point(642, 184);
            textBoxTuoi.Name = "textBoxTuoi";
            textBoxTuoi.ReadOnly = true;
            textBoxTuoi.Size = new Size(142, 27);
            textBoxTuoi.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNu);
            groupBox1.Controls.Add(radioButtonNam);
            groupBox1.Location = new Point(50, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 111);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(143, 50);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 1;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Checked = true;
            radioButtonNam.Location = new Point(13, 50);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 0;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Java", "C#", "Web", "Mobile", "Game" });
            comboBox1.Location = new Point(633, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 28);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(436, 313);
            label5.Name = "label5";
            label5.Size = new Size(182, 35);
            label5.TabIndex = 8;
            label5.Text = "Chuyên ngành";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxKhac);
            groupBox2.Controls.Add(checkBoxTikTok);
            groupBox2.Controls.Add(checkBoxDocSach);
            groupBox2.Controls.Add(checkBoxBiA);
            groupBox2.Controls.Add(checkBoxTC);
            groupBox2.Controls.Add(checkBoxMQ);
            groupBox2.Location = new Point(50, 441);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 115);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sở thích";
            // 
            // checkBoxKhac
            // 
            checkBoxKhac.AutoSize = true;
            checkBoxKhac.Location = new Point(282, 81);
            checkBoxKhac.Name = "checkBoxKhac";
            checkBoxKhac.Size = new Size(63, 24);
            checkBoxKhac.TabIndex = 5;
            checkBoxKhac.Text = "Khác";
            checkBoxKhac.UseVisualStyleBackColor = true;
            checkBoxKhac.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // checkBoxTikTok
            // 
            checkBoxTikTok.AutoSize = true;
            checkBoxTikTok.Location = new Point(143, 81);
            checkBoxTikTok.Name = "checkBoxTikTok";
            checkBoxTikTok.Size = new Size(102, 24);
            checkBoxTikTok.TabIndex = 4;
            checkBoxTikTok.Text = "Xem tiktok";
            checkBoxTikTok.UseVisualStyleBackColor = true;
            checkBoxTikTok.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // checkBoxDocSach
            // 
            checkBoxDocSach.AutoSize = true;
            checkBoxDocSach.Location = new Point(13, 81);
            checkBoxDocSach.Name = "checkBoxDocSach";
            checkBoxDocSach.Size = new Size(91, 24);
            checkBoxDocSach.TabIndex = 3;
            checkBoxDocSach.Text = "Đọc sách";
            checkBoxDocSach.UseVisualStyleBackColor = true;
            checkBoxDocSach.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // checkBoxBiA
            // 
            checkBoxBiA.AutoSize = true;
            checkBoxBiA.Location = new Point(282, 37);
            checkBoxBiA.Name = "checkBoxBiA";
            checkBoxBiA.Size = new Size(65, 24);
            checkBoxBiA.TabIndex = 2;
            checkBoxBiA.Text = "BiDA";
            checkBoxBiA.UseVisualStyleBackColor = true;
            checkBoxBiA.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // checkBoxTC
            // 
            checkBoxTC.AutoSize = true;
            checkBoxTC.Location = new Point(143, 37);
            checkBoxTC.Name = "checkBoxTC";
            checkBoxTC.Size = new Size(106, 24);
            checkBoxTC.TabIndex = 1;
            checkBoxTC.Text = "Thông chốt";
            checkBoxTC.UseVisualStyleBackColor = true;
            checkBoxTC.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // checkBoxMQ
            // 
            checkBoxMQ.AutoSize = true;
            checkBoxMQ.Location = new Point(13, 37);
            checkBoxMQ.Name = "checkBoxMQ";
            checkBoxMQ.Size = new Size(96, 24);
            checkBoxMQ.TabIndex = 0;
            checkBoxMQ.Text = "Múa Quạt";
            checkBoxMQ.UseVisualStyleBackColor = true;
            checkBoxMQ.CheckedChanged += checkBoxBiA_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(572, 441);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 115);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(453, 642);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 733);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBoxTuoi);
            Controls.Add(label3);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(label2);
            Controls.Add(textBoxTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Màn hình chính";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTen;
        private Label label2;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label label3;
        private TextBox textBoxTuoi;
        private GroupBox groupBox1;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private ComboBox comboBox1;
        private Label label5;
        private GroupBox groupBox2;
        private CheckBox checkBoxBiA;
        private CheckBox checkBoxTC;
        private CheckBox checkBoxMQ;
        private CheckBox checkBoxKhac;
        private CheckBox checkBoxTikTok;
        private CheckBox checkBoxDocSach;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}
