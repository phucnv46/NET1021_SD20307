using B5_MultiView.DTOs;
using B5_MultiView.Models;
using B5_MultiView.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_MultiView.Views
{
    public partial class SachView : UserControl
    {
        private readonly SachRepository _sachRepository;
        private readonly TheLoaiRepository _theLoaiRepository;
        private BindingList<SachDTO> _saches;

        public SachView()
        {
            InitializeComponent();
            _sachRepository = new SachRepository();
            _theLoaiRepository = new TheLoaiRepository();
            LoadTable();
        }

        private void LoadTable()
        {
            List<SachDTO> sachDTOs = _sachRepository.GetDbSet()
                .Include(s => s.MaTheLoaiNavigation) // Kết nối với bảng thể loại
                .Select(  //Ánh xạ Sách thành SÁch DTO
                 s => new SachDTO
                 {
                     MaSach = s.MaSach
                 ,
                     TenSach = s.TenSach
                 ,
                     TheLoai = s.MaTheLoaiNavigation.TenTheLoai // Truy cập vào Thể loại của sách để lấy tên
                 ,
                     NamXuatBan = s.NamXuatBan
                 ,
                     Nxb = s.Nxb
                 ,
                     TacGia = s.TacGia
                 }
                ).ToList(); // Để trở thành list

            _saches = new BindingList<SachDTO>(sachDTOs); // Chuyển thành binding list
            dataGridView1.DataSource = _saches;
            comboBox1.DataSource = _theLoaiRepository.LayDS();
            comboBox1.DisplayMember = nameof(TheLoai.TenTheLoai);
            comboBox1.ValueMember = nameof(TheLoai.MaTheLoai);
            dataGridView1.Columns["TheLoai"].DataPropertyName = "TheLoai.TenTheLoai";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
