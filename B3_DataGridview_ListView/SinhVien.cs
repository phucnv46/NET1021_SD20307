using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_DataGridview_ListView
{
    internal class SinhVien
    {
        [DisplayName("Mã Sinh Viên")]
        public string MaSinhVien { get; set; }
        [DisplayName("Tên")]

        public string Ten { get; set; }
        [DisplayName("Môn")]

        public string Mon { get; set; }

        [DisplayName("Điểm")]
        public double Diem { get; set; }
    }
}
