using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap1
{
    internal class SinhVien
    {
        [DisplayName("Mã sinh viên")]
        public string MaSinhVien { get; set; }

        [DisplayName("Tên")]

        public string Ten { get; set; }

        [DisplayName("Ngày sinh")]

        public DateTime NgaySinh { get; set; }

        [DisplayName("Giới tính")]

        public bool GioiTinh { get; set; }

        public string Mon { get; set; }
    }
}
