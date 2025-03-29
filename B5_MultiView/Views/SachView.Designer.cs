namespace B5_MultiView.Views
{
    partial class SachView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBoxMS = new TextBox();
            textBoxTG = new TextBox();
            label2 = new Label();
            textBoxNamXuatBan = new TextBox();
            label3 = new Label();
            textBoxTS = new TextBox();
            label4 = new Label();
            textBoxNXB = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            buttonThem = new Button();
            buttonCN = new Button();
            buttonXoa = new Button();
            buttonLM = new Button();
            buttonTimKiem = new Button();
            textBoxTK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 450);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1071, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Sách";
            // 
            // textBoxMS
            // 
            textBoxMS.Location = new Point(139, 68);
            textBoxMS.Name = "textBoxMS";
            textBoxMS.ReadOnly = true;
            textBoxMS.Size = new Size(208, 27);
            textBoxMS.TabIndex = 2;
            // 
            // textBoxTG
            // 
            textBoxTG.Location = new Point(139, 132);
            textBoxTG.Name = "textBoxTG";
            textBoxTG.Size = new Size(208, 27);
            textBoxTG.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 135);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Tác Giả";
            // 
            // textBoxNamXuatBan
            // 
            textBoxNamXuatBan.Location = new Point(486, 135);
            textBoxNamXuatBan.Name = "textBoxNamXuatBan";
            textBoxNamXuatBan.Size = new Size(208, 27);
            textBoxNamXuatBan.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 138);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 7;
            label3.Text = "Năm xuất bản";
            // 
            // textBoxTS
            // 
            textBoxTS.Location = new Point(486, 74);
            textBoxTS.Name = "textBoxTS";
            textBoxTS.Size = new Size(208, 27);
            textBoxTS.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 74);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên sách";
            // 
            // textBoxNXB
            // 
            textBoxNXB.Location = new Point(843, 132);
            textBoxNXB.Name = "textBoxNXB";
            textBoxNXB.Size = new Size(208, 27);
            textBoxNXB.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(754, 135);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 11;
            label5.Text = "NXB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(754, 71);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 9;
            label6.Text = "Thể loại";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(843, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(50, 252);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(82, 34);
            buttonThem.TabIndex = 14;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonCN
            // 
            buttonCN.Location = new Point(183, 252);
            buttonCN.Name = "buttonCN";
            buttonCN.Size = new Size(82, 34);
            buttonCN.TabIndex = 15;
            buttonCN.Text = "Cập nhật";
            buttonCN.UseVisualStyleBackColor = true;
            buttonCN.Click += buttonCN_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(305, 252);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(82, 34);
            buttonXoa.TabIndex = 16;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(439, 252);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(82, 34);
            buttonLM.TabIndex = 17;
            buttonLM.Text = "Làm mới";
            buttonLM.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(439, 344);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(82, 34);
            buttonTimKiem.TabIndex = 18;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTK
            // 
            textBoxTK.Location = new Point(50, 348);
            textBoxTK.Name = "textBoxTK";
            textBoxTK.Size = new Size(350, 27);
            textBoxTK.TabIndex = 19;
            // 
            // SachView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxTK);
            Controls.Add(buttonTimKiem);
            Controls.Add(buttonLM);
            Controls.Add(buttonXoa);
            Controls.Add(buttonCN);
            Controls.Add(buttonThem);
            Controls.Add(comboBox1);
            Controls.Add(textBoxNXB);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBoxNamXuatBan);
            Controls.Add(label3);
            Controls.Add(textBoxTS);
            Controls.Add(label4);
            Controls.Add(textBoxTG);
            Controls.Add(label2);
            Controls.Add(textBoxMS);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "SachView";
            Size = new Size(1071, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMS;
        private TextBox textBoxTG;
        private Label label2;
        private TextBox textBoxNamXuatBan;
        private Label label3;
        private TextBox textBoxTS;
        private Label label4;
        private TextBox textBoxNXB;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button buttonThem;
        private Button buttonCN;
        private Button buttonXoa;
        private Button buttonLM;
        private Button buttonTimKiem;
        private TextBox textBoxTK;
    }
}
