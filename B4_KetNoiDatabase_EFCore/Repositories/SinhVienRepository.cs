using B4_KetNoiDatabase_EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_KetNoiDatabase_EFCore.Repositories
{
    internal class SinhVienRepository
    {
        private readonly Sd20307Context _context;

        public SinhVienRepository()
        {
            _context = new Sd20307Context();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return _context.SinhViens.ToList();
        }

        public void Update(SinhVien model)
        {
            _context.SinhViens.Update(model);
            _context.SaveChanges();
        }

        public void Remove(SinhVien model)
        {
            _context.Remove(model);
            _context.SaveChanges();
        }
    }
}
