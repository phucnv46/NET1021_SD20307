namespace OnTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = "abc";
            string passWord = "123";
            if (textBoxTK.Text.Equals(taiKhoan) && textBoxMK.Text.Equals(passWord))
            {
                this.Hide(); // ẩn form đi
                FormQuanLy formQuanLy = new FormQuanLy();
                formQuanLy.ShowDialog(); // Đưa form lên chế độ show modal top view
                this.Show(); // nếu tắt form quản lý sẽ hiện luôn form đăng nhập

            }

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Application.Exit(); // Hàm này cũng sẽ kích hoạt sự kiện form closing

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có thực sự muốn thoát",
             "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketQua != DialogResult.Yes) // nếu không chọn yes thì huỷ sự kiện đóng
            {
                e.Cancel = true; // huỷ sự kiện đóng 
            }
            //còn không đóng như thường
           
        }
    }
}
