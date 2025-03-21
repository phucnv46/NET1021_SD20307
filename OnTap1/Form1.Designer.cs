namespace OnTap1
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
            textBoxTK = new TextBox();
            textBoxMK = new TextBox();
            label2 = new Label();
            buttonDangNhap = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 78);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // textBoxTK
            // 
            textBoxTK.Location = new Point(180, 89);
            textBoxTK.Name = "textBoxTK";
            textBoxTK.PlaceholderText = "Xin mời nhập tài khoản";
            textBoxTK.Size = new Size(402, 27);
            textBoxTK.TabIndex = 1;
            textBoxTK.TextChanged += textBox1_TextChanged;
            // 
            // textBoxMK
            // 
            textBoxMK.Location = new Point(180, 181);
            textBoxMK.Name = "textBoxMK";
            textBoxMK.PasswordChar = '*';
            textBoxMK.PlaceholderText = "Xin mời nhập mật khẩu";
            textBoxMK.Size = new Size(402, 27);
            textBoxMK.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 170);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Location = new Point(180, 315);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(94, 29);
            buttonDangNhap.TabIndex = 4;
            buttonDangNhap.Text = "Đăng nhập";
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(376, 315);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(94, 29);
            buttonThoat.TabIndex = 5;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 425);
            Controls.Add(buttonThoat);
            Controls.Add(buttonDangNhap);
            Controls.Add(textBoxMK);
            Controls.Add(label2);
            Controls.Add(textBoxTK);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTK;
        private TextBox textBoxMK;
        private Label label2;
        private Button buttonDangNhap;
        private Button buttonThoat;
    }
}
