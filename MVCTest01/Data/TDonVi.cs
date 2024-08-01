using System;
using System.Collections.Generic;

namespace MVCTest01.Data;

public partial class TDonVi
{
    public string MaDonVi { get; set; } = null!;

    public string? TenDonVi { get; set; }

    public virtual ICollection<TDocGium> TDocGia { get; set; } = new List<TDocGium>();
}
