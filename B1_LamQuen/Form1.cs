namespace B1_LamQuen
{
    public partial class Form1 : Form
    {
        string _soThich = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaySinh = dateTimePickerNgaySinh.Value;
            var tuoi = DateTime.Now.Year - ngaySinh.Year;
            textBoxTuoi.Text = tuoi.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string soThich = "";
            if (checkBoxBiA.Checked) soThich += "BiA,";
            if (checkBoxDocSach.Checked) soThich += "Đọc sách,";
            if (checkBoxDocSach.Checked) soThich += "Đọc sách,";

            string gioiTinh = radioButtonNu.Checked == true ? "Nữ" : "Nam";
            MessageBox.Show($"Họ và tên {textBoxTen.Text}" +
                $"\nNgày sinh{dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy")}" +
                $"\nGiới tính: {gioiTinh}" +
                $"\nChuyên ngành: {comboBox1.SelectedItem}" +
                $"Sở thích:{_soThich}",
                "Hiên thị thông tin");
        }

        private void checkBoxBiA_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox =(CheckBox) sender;
            if (checkBox.Checked == true) {
                _soThich += checkBox.Text+", ";
            }
        }
    }
}
