using System;
using System.Collections.Generic;

namespace B4_KetNoiDatabase_EFCore.Models;

public partial class SinhVien
{
    public string MaSinhVien { get; set; } = null!;

    public string TenSinhVien { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public bool? GioiTinh { get; set; }

    public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
}
