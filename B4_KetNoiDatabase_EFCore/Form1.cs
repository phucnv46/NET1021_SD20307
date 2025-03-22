using B4_KetNoiDatabase_EFCore.Models;
using B4_KetNoiDatabase_EFCore.Repositories;
using System.ComponentModel;

namespace B4_KetNoiDatabase_EFCore
{
    public partial class Form1 : Form
    {
        private readonly SinhVienRepository _repository;

        private BindingList<SinhVien> _sinhViens;
        public Form1()
        {
            InitializeComponent();
            _repository = new SinhVienRepository();
            LoadSinhVien();
        }

        private void LoadSinhVien()
        {
          _sinhViens = new BindingList<SinhVien>(_repository.GetAllSinhVien());
            dataGridView1.DataSource = _sinhViens; //
            dataGridView1.Columns["LichHocs"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dataGridView1.ReadOnly = true; // Không được edit
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn toàn bộ dòng
            dataGridView1.MultiSelect = false; // Tắt chế độ chọn nhiều
        }


    }
}
