using B5_MultiView.DTOs;
using B5_MultiView.Models;
using B5_MultiView.Repositories;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        private BindingList<Sach> _saches;

        public SachView()
        {
            InitializeComponent();
            _sachRepository = new SachRepository();
            _theLoaiRepository = new TheLoaiRepository();
            LoadTable();
        }

        private void LoadTable()
        {
            /*  List<SachDTO> sachDTOs = _sachRepository.GetDbSet()
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

              _saches = new BindingList<SachDTO>(sachDTOs); // Chuyển thành binding list*/
            List<Sach> sachesKemTHeLoai = _sachRepository.LayDSKemQuanHe(nameof(Sach.TheLoai)); // Tải sách cùng với thể loại
            _saches = new BindingList<Sach>(sachesKemTHeLoai);
            dataGridView1.DataSource = _saches;
            comboBox1.DataSource = _theLoaiRepository.LayDS();
            comboBox1.DisplayMember = nameof(TheLoai.TenTheLoai);
            comboBox1.ValueMember = nameof(TheLoai.MaTheLoai);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Sach BindingToSach(Sach sach)
        {
            // Code vào đây :)
            sach.TenSach = textBoxTS.Text;
            sach.TacGia = textBoxTG.Text;
            sach.NamXuatBan = Convert.ToInt32(textBoxNamXuatBan.Text);
            sach.Nxb = textBoxNXB.Text;
            sach.MaTheLoai = (int)comboBox1.SelectedValue;

            return sach;
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = _saches.Last().MaSach + 1;
            BindingToSach(sach);

            _sachRepository.Them(sach);
            LoadTable();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            textBoxMS.Text = sach.MaSach.ToString();
            textBoxTG.Text = sach.TacGia;
            textBoxTS.Text = sach.TenSach;
            textBoxNamXuatBan.Text = sach.NamXuatBan.ToString();
            textBoxNXB.Text = sach.Nxb;
            comboBox1.SelectedValue = sach.MaTheLoai;

        }

        private void buttonCN_Click(object sender, EventArgs e)
        {
            Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            BindingToSach(sach);
            _sachRepository.Update(sach);
            int index = dataGridView1.CurrentCell.RowIndex;
            LoadTable();
            dataGridView1.Rows[index].Selected = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Sach sach = (Sach)dataGridView1.SelectedRows[0].DataBoundItem;
            _sachRepository.Delete(sach);
            LoadTable();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

            string search = textBoxTK.Text;

            /*List<Sach> listTimKiem = (from sach in _saches where sach.TenSach.
                                      Contains(search,StringComparison.OrdinalIgnoreCase) 
                                      select sach).ToList();*/ // LinQ Query

            //C2: Dạng biểu thức
            List<Sach> listTimKiem = _saches.Where(s => s.TenSach.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            dataGridView1.DataSource = listTimKiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                IXLWorksheet sheet = workbook.Worksheets.Add("Sách");

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    sheet.Cell(1, col.Index + 1).Value = col.HeaderText;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        sheet.Cell(2 + row.Index, col.Index + 1).Value = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }

                workbook.SaveAs("../../../Sach.xlsx");
            }

        }
    }
}
