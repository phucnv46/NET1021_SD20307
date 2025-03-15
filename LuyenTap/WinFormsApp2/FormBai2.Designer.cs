namespace Bai1
{
    partial class FormBai2
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
            textBox1 = new TextBox();
            checkBoxCV = new CheckBox();
            checkBoxTayTrang = new CheckBox();
            checkBoxTramRang = new CheckBox();
            checkBoxNhoRang = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            buttonTinhTien = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 74);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 27);
            textBox1.TabIndex = 1;
            // 
            // checkBoxCV
            // 
            checkBoxCV.AutoSize = true;
            checkBoxCV.Location = new Point(63, 142);
            checkBoxCV.Name = "checkBoxCV";
            checkBoxCV.Size = new Size(81, 24);
            checkBoxCV.TabIndex = 2;
            checkBoxCV.Text = "Cạo vôi";
            checkBoxCV.UseVisualStyleBackColor = true;
            // 
            // checkBoxTayTrang
            // 
            checkBoxTayTrang.AutoSize = true;
            checkBoxTayTrang.Location = new Point(63, 206);
            checkBoxTayTrang.Name = "checkBoxTayTrang";
            checkBoxTayTrang.Size = new Size(97, 24);
            checkBoxTayTrang.TabIndex = 3;
            checkBoxTayTrang.Text = "Tẩy trắng ";
            checkBoxTayTrang.UseVisualStyleBackColor = true;
            // 
            // checkBoxTramRang
            // 
            checkBoxTramRang.AutoSize = true;
            checkBoxTramRang.Location = new Point(63, 330);
            checkBoxTramRang.Name = "checkBoxTramRang";
            checkBoxTramRang.Size = new Size(98, 24);
            checkBoxTramRang.TabIndex = 5;
            checkBoxTramRang.Text = "Trám răng";
            checkBoxTramRang.UseVisualStyleBackColor = true;
            // 
            // checkBoxNhoRang
            // 
            checkBoxNhoRang.AutoSize = true;
            checkBoxNhoRang.Location = new Point(63, 266);
            checkBoxNhoRang.Name = "checkBoxNhoRang";
            checkBoxNhoRang.Size = new Size(93, 24);
            checkBoxNhoRang.TabIndex = 4;
            checkBoxNhoRang.Text = "Nhổ răng";
            checkBoxNhoRang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 146);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 6;
            label2.Text = "150k";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "250k";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 266);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 8;
            label4.Text = "100k";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 330);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "300k";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 416);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(363, 27);
            textBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 423);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "ThanhTien";
            // 
            // buttonTinhTien
            // 
            buttonTinhTien.Location = new Point(149, 556);
            buttonTinhTien.Name = "buttonTinhTien";
            buttonTinhTien.Size = new Size(94, 29);
            buttonTinhTien.TabIndex = 12;
            buttonTinhTien.Text = "TinhTien";
            buttonTinhTien.UseVisualStyleBackColor = true;
            buttonTinhTien.Click += buttonTinhTien_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(429, 556);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(94, 29);
            buttonThoat.TabIndex = 13;
            buttonThoat.Text = "Thoat";
            buttonThoat.UseVisualStyleBackColor = true;
            // 
            // FormBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 678);
            Controls.Add(buttonThoat);
            Controls.Add(buttonTinhTien);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBoxTramRang);
            Controls.Add(checkBoxNhoRang);
            Controls.Add(checkBoxTayTrang);
            Controls.Add(checkBoxCV);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormBai2";
            Text = "FormBai2";
            FormClosed += FormBai2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBoxCV;
        private CheckBox checkBoxTayTrang;
        private CheckBox checkBoxTramRang;
        private CheckBox checkBoxNhoRang;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Button buttonTinhTien;
        private Button buttonThoat;
    }
}