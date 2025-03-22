using System;
using System.Collections.Generic;

namespace B4_KetNoiDatabase_EFCore.Models;

public partial class LichHoc
{
    public string MaSinhVien { get; set; } = null!;

    public long MaMon { get; set; }

    public int? Ca { get; set; }

    public virtual Mon MaMonNavigation { get; set; } = null!;

    public virtual SinhVien MaSinhVienNavigation { get; set; } = null!;
}
