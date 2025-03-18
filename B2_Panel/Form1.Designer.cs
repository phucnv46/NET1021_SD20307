namespace B2_Panel
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label1 = new Label();
            textBoxThem = new TextBox();
            buttonThem = new Button();
            buttonVT = new Button();
            textBoxThemVT = new TextBox();
            buttonTK = new Button();
            textBoxTim = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            buttonXoa = new Button();
            buttonXoaDanhSach = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 355);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 74);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Thêm sản phẩm";
            // 
            // textBoxThem
            // 
            textBoxThem.Location = new Point(450, 71);
            textBoxThem.Name = "textBoxThem";
            textBoxThem.Size = new Size(273, 27);
            textBoxThem.TabIndex = 2;
            textBoxThem.TextChanged += textBoxThem_TextChanged;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(887, 71);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 3;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonVT
            // 
            buttonVT.Location = new Point(887, 171);
            buttonVT.Name = "buttonVT";
            buttonVT.Size = new Size(94, 29);
            buttonVT.TabIndex = 6;
            buttonVT.Text = "Thêm";
            buttonVT.UseVisualStyleBackColor = true;
            buttonVT.Click += buttonVT_Click;
            // 
            // textBoxThemVT
            // 
            textBoxThemVT.Location = new Point(450, 175);
            textBoxThemVT.Name = "textBoxThemVT";
            textBoxThemVT.Size = new Size(273, 27);
            textBoxThemVT.TabIndex = 5;
            textBoxThemVT.TextChanged += textBoxThemVT_TextChanged;
            // 
            // buttonTK
            // 
            buttonTK.Location = new Point(887, 258);
            buttonTK.Name = "buttonTK";
            buttonTK.Size = new Size(94, 29);
            buttonTK.TabIndex = 9;
            buttonTK.Text = "Tìm kiếm";
            buttonTK.UseVisualStyleBackColor = true;
            buttonTK.Click += buttonTK_Click;
            // 
            // textBoxTim
            // 
            textBoxTim.Location = new Point(450, 263);
            textBoxTim.Name = "textBoxTim";
            textBoxTim.Size = new Size(273, 27);
            textBoxTim.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 270);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 180);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 10;
            label2.Text = "Thêm sản phẩm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(740, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 28);
            comboBox1.TabIndex = 11;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(450, 380);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 12;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonXoaDanhSach
            // 
            buttonXoaDanhSach.Location = new Point(673, 380);
            buttonXoaDanhSach.Name = "buttonXoaDanhSach";
            buttonXoaDanhSach.Size = new Size(152, 29);
            buttonXoaDanhSach.TabIndex = 13;
            buttonXoaDanhSach.Text = "Xoá Danh Sách";
            buttonXoaDanhSach.UseVisualStyleBackColor = true;
            buttonXoaDanhSach.Click += buttonXoaDanhSach_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 615);
            Controls.Add(buttonXoaDanhSach);
            Controls.Add(buttonXoa);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(buttonTK);
            Controls.Add(textBoxTim);
            Controls.Add(label3);
            Controls.Add(buttonVT);
            Controls.Add(textBoxThemVT);
            Controls.Add(buttonThem);
            Controls.Add(textBoxThem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label1;
        private TextBox textBoxThem;
        private Button buttonThem;
        private Button buttonVT;
        private TextBox textBoxThemVT;
        private Button buttonTK;
        private TextBox textBoxTim;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button buttonXoa;
        private Button buttonXoaDanhSach;
    }
}
