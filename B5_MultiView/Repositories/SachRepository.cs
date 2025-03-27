using B5_MultiView.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_MultiView.Repositories
{
    public class SachRepository
    {
        private readonly QuanLyThuVienContext _context;
        private readonly DbSet<Sach> _dbSet;

        public SachRepository()
        {
            _context = new QuanLyThuVienContext();
            _dbSet = _context.Saches;
        }

        public List<Sach> LayDS()
        {
            return _dbSet.ToList();
        }

        public DbSet<Sach> GetDbSet()
        {
            return _dbSet;
        }
    }
}
