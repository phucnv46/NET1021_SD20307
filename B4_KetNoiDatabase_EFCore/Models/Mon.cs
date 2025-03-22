using System;
using System.Collections.Generic;

namespace B4_KetNoiDatabase_EFCore.Models;

public partial class Mon
{
    public long Id { get; set; }

    public string TenMon { get; set; } = null!;

    public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();
}
