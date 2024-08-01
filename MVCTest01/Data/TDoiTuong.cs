using System;
using System.Collections.Generic;

namespace MVCTest01.Data;

public partial class TDoiTuong
{
    public string MaDt { get; set; } = null!;

    public string? TenDoiTuong { get; set; }

    public virtual ICollection<TDocGium> TDocGia { get; set; } = new List<TDocGium>();
}
