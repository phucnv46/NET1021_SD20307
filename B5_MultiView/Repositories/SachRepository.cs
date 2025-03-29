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


        public List<Sach> LayDSKemQuanHe(params string[] relatations)
        {
            // Code vào đây :)
            var query = _dbSet.AsQueryable(); // Chuyển bảng query
          
            foreach (var rel in relatations)
            {
                query = query.Include(rel); // Bao gồm
            }
            
            return query.ToList();
        }


        public void Them(Sach sach)
        {
            // Code vào đây :)
            try
            {
                _dbSet.Add(sach);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Update(Sach sach)
        {
            // Code vào đây :)
            try
            {
                _dbSet.Update(sach);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void Delete(Sach sach)
        {
            // Code vào đây :)
            try
            {
                _dbSet.Remove(sach);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
