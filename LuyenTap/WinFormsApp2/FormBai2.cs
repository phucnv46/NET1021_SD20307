using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void FormBai2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) MessageBox.Show("Điền tên khách hàng");
            else
            {
                int sum = 0;
                if (checkBoxCV.Checked)
                {
                    sum += 150;
                }
                if (checkBoxNhoRang.Checked)
                {
                    sum += 200;
                }
                if (checkBoxTayTrang.Checked)
                {
                    sum += 250;
                }
                if (checkBoxTramRang.Checked)
                {
                    sum += 300;
                }
                textBox2.Text = sum.ToString();
            }
          
            
        }
    }
}
