using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap1
{
    public partial class FormQuanLy : Form
    {
        BindingList<SinhVien> _students = new BindingList<SinhVien>();
        public FormQuanLy()
        {
            InitializeComponent();
            LoadTable();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có thực sự muốn thoát",
               "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ketQua != DialogResult.Yes) // nếu không chọn yes thì huỷ sự kiện đóng
            {
                e.Cancel = true; // huỷ sự kiện đóng 
            }
            //còn không đóng như thường
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = BindingToModel();
            _students.Add(sinhVien);
        }

        private SinhVien BindingToModel() // Chuyển dữ liệu từ control vào model sinh viên
        {
            SinhVien sv = new SinhVien();
            sv.MaSinhVien = textBoxMSV.Text;
            sv.Ten = textBoxTen.Text;
            sv.NgaySinh = dateTimePicker1.Value;
            sv.GioiTinh = radioButtonNam.Checked ? true : false;
            sv.Mon = (string)comboBox1.SelectedValue ?? "Chưa có môn";
            return sv;
        }

        private void LoadTable()
        {
            dataGridView1.DataSource = _students;
            dataGridView1.ReadOnly = true;
            


            comboBox1.DataSource = new BindingList<Mon>()
            {
                new Mon(){MaMon="NET1021",TenMon="C# 2"},
                new Mon(){MaMon="COM2012",TenMon="Hệ CSDL"},
            };

            comboBox1.DisplayMember = nameof(Mon.TenMon);
            comboBox1.ValueMember = nameof(Mon.MaMon);

            radioButtonNam.Checked = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e) //chuyển lại dữ liệu từ model sinh viên vào các controls
        {
           SinhVien sinhVien =(SinhVien) dataGridView1.SelectedRows[0].DataBoundItem;
            textBoxMSV.Text = sinhVien.MaSinhVien;
   
            textBoxTen.Text = sinhVien.Ten; 
            //...
        }
    }
}
