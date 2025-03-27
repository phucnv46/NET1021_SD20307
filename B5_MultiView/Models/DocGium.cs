﻿using System;
using System.Collections.Generic;

namespace B5_MultiView.Models;

public partial class DocGium
{
    public int MaDocGia { get; set; }

    public string? TenDocGia { get; set; }

    public string? SoDienThoai { get; set; }

    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
}
