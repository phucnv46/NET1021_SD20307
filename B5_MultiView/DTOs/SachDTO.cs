using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_MultiView.DTOs
{
    public class SachDTO
    {
        [DisplayName("Mã sách")]
        public int MaSach { get; set; }

        public string? TenSach { get; set; }

        public string? TacGia { get; set; }

        public string TheLoai { get; set; }

        public string? Nxb { get; set; }

        public int? NamXuatBan { get; set; }
    }
}
