using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B5_MultiView.Models;

public partial class Sach
{
    [DisplayName("Mã sách")]
    public int MaSach { get; set; }

    [DisplayName("Tên sách")]
    public string? TenSach { get; set; }

    [DisplayName("Tác Giả")]
    public string? TacGia { get; set; }

    [Browsable(false)]
    public int? MaTheLoai { get; set; }

    public string? Nxb { get; set; }
    [DisplayName("Năm Xuất Bản")]
    public int? NamXuatBan { get; set; }

    [Browsable(false)]
    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    [Browsable(false)]
    public virtual TheLoai? TheLoai { get; set; }

    [DisplayName("Thể Loại")]
    public string TenTheLoai  // Hiển thị tên thể loại
    {
        get
        { return TheLoai?.TenTheLoai ?? "Không xác định"; }
    }
}
