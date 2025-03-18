using System.ComponentModel;

namespace B2_Panel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(textBoxThem.Text)) buttonThem.Enabled = false;

            if (string.IsNullOrEmpty(textBoxThemVT.Text)) buttonVT.Enabled = false;


        }

        void HienThiComboBox()
        {
            comboBox1.Items.Add(listBox1.Items.Count);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxThem.Text);
            HienThiComboBox();
        }

        private void textBoxThem_TextChanged(object sender, EventArgs e)
        {
            buttonThem.Enabled = true;
        }

        private void textBoxThemVT_TextChanged(object sender, EventArgs e)
        {
            buttonVT.Enabled = true;
        }

        private void buttonVT_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn vị trí");
                return;
            }
            listBox1.Items.Insert((int)comboBox1.SelectedItem - 1, textBoxThemVT.Text);

            HienThiComboBox();

        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBoxTim.Text.Trim()))
                MessageBox.Show("Có trong danh sách");
            else MessageBox.Show("Không tìm thấy");
        }

        private void buttonXoaDanhSach_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }


}
