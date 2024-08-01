using System;
using System.Collections.Generic;

namespace MVCTest01.Data;

public partial class TDocGium
{
    public string MaDg { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDg { get; set; }

    public string? SoCmnd { get; set; }

    public string? MaDonVi { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? MaDt { get; set; }

    public string? DiaChi { get; set; }

    public string? Anh { get; set; }

    public virtual TDonVi? MaDonViNavigation { get; set; }

    public virtual TDoiTuong? MaDtNavigation { get; set; }

    public virtual ICollection<TTheDocGium> TTheDocGia { get; set; } = new List<TTheDocGium>();
}
