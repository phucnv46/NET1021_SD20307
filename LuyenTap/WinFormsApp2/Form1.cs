using Bai1;
using System.Linq.Expressions;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoThu1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSoThu1.Text == "") textBoxSoThu1.Text = "0";
                a = double.Parse(textBoxSoThu1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không được nhập chữ");
            }
        }

        private void textBoxSoThu2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSoThu2.Text == "") textBoxSoThu2.Text = "0";
                b = double.Parse(textBoxSoThu2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Không được nhập chữ");
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender as Button;

            double sum = 0;
            if (button.Text.Equals("+")) sum = a + b;
            if (button.Text.Equals("-")) sum = a - b;
            if (button.Text.Equals("*")) sum = a * b;
            if (button.Text.Equals("/")) sum = a / b;
            textBoxKetQua.Text = sum.ToString();
        }

        private void buttonCB_Click(object sender, EventArgs e)
        {
            FormBai2 formBai2 = new FormBai2();
            formBai2.Show();
            this.Hide();
        }
    }
}
