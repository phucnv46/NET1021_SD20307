namespace WinFormsApp2
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
            label2 = new Label();
            textBoxSoThu1 = new TextBox();
            textBoxSoThu2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            textBoxKetQua = new TextBox();
            buttonCB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 94);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai ";
            // 
            // textBoxSoThu1
            // 
            textBoxSoThu1.Location = new Point(246, 39);
            textBoxSoThu1.Name = "textBoxSoThu1";
            textBoxSoThu1.Size = new Size(185, 27);
            textBoxSoThu1.TabIndex = 2;
            textBoxSoThu1.TextChanged += textBoxSoThu1_TextChanged;
            // 
            // textBoxSoThu2
            // 
            textBoxSoThu2.Location = new Point(246, 87);
            textBoxSoThu2.Name = "textBoxSoThu2";
            textBoxSoThu2.Size = new Size(185, 27);
            textBoxSoThu2.TabIndex = 3;
            textBoxSoThu2.TextChanged += textBoxSoThu2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(193, 167);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClick;
            // 
            // button2
            // 
            button2.Location = new Point(283, 167);
            button2.Name = "button2";
            button2.Size = new Size(40, 29);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnClick;
            // 
            // button3
            // 
            button3.Location = new Point(378, 167);
            button3.Name = "button3";
            button3.Size = new Size(39, 29);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnClick;
            // 
            // button4
            // 
            button4.Location = new Point(475, 167);
            button4.Name = "button4";
            button4.Size = new Size(40, 29);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnClick;
            // 
            // button5
            // 
            button5.Location = new Point(576, 167);
            button5.Name = "button5";
            button5.Size = new Size(48, 29);
            button5.TabIndex = 8;
            button5.Text = "Del";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 224);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "Kết quả";
            label3.Click += label3_Click;
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(246, 217);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.ReadOnly = true;
            textBoxKetQua.Size = new Size(185, 27);
            textBoxKetQua.TabIndex = 10;
            // 
            // buttonCB
            // 
            buttonCB.Location = new Point(143, 347);
            buttonCB.Name = "buttonCB";
            buttonCB.Size = new Size(94, 29);
            buttonCB.TabIndex = 11;
            buttonCB.Text = "Chuyển bài";
            buttonCB.UseVisualStyleBackColor = true;
            buttonCB.Click += buttonCB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(buttonCB);
            Controls.Add(textBoxKetQua);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxSoThu2);
            Controls.Add(textBoxSoThu1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxSoThu1;
        private TextBox textBoxSoThu2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private TextBox textBoxKetQua;
        private Button buttonCB;
    }
}
