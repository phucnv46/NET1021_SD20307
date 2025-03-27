using B5_MultiView.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_MultiView.Repositories
{
    public class TheLoaiRepository
    {
        private readonly QuanLyThuVienContext _context;
        private readonly DbSet<TheLoai> _dbSet;

        public TheLoaiRepository()
        {
            _context = new QuanLyThuVienContext(); // Đại diện cho database
            _dbSet = _context.TheLoais; // Đại diện cho bảng trong code
        }

        public List<TheLoai> LayDS()
        {
            return _dbSet.ToList(); // Chuyển bảng thành list
        }

        public DbSet<TheLoai> GetDbSet()
        {
            return _dbSet; // Lấy nguyên bảng
        }
    }
}
