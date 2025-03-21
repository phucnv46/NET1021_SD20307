namespace OnTap1
{
    partial class FormQuanLy
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
            label1 = new Label();
            textBoxMSV = new TextBox();
            textBoxTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            dataGridView1 = new DataGridView();
            buttonThem = new Button();
            buttonCapNhat = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // textBoxMSV
            // 
            textBoxMSV.Location = new Point(202, 48);
            textBoxMSV.Name = "textBoxMSV";
            textBoxMSV.Size = new Size(334, 27);
            textBoxMSV.TabIndex = 1;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(202, 128);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(334, 27);
            textBoxTen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 128);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 233);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(202, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 339);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 347);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Môn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNu);
            groupBox1.Controls.Add(radioButtonNam);
            groupBox1.Location = new Point(489, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 95);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Location = new Point(167, 39);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(50, 24);
            radioButtonNu.TabIndex = 1;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Location = new Point(6, 39);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 24);
            radioButtonNam.TabIndex = 0;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 508);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(909, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(674, 39);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 10;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonCapNhat
            // 
            buttonCapNhat.Location = new Point(674, 119);
            buttonCapNhat.Name = "buttonCapNhat";
            buttonCapNhat.Size = new Size(94, 29);
            buttonCapNhat.TabIndex = 11;
            buttonCapNhat.Text = "Cập nhật";
            buttonCapNhat.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(674, 187);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(674, 248);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 696);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonCapNhat);
            Controls.Add(buttonThem);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(textBoxMSV);
            Controls.Add(label1);
            Name = "FormQuanLy";
            Text = "FormQuanLy";
            FormClosing += FormQuanLy_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxMSV;
        private TextBox textBoxTen;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
        private DataGridView dataGridView1;
        private Button buttonThem;
        private Button buttonCapNhat;
        private Button button3;
        private Button button4;
    }
}