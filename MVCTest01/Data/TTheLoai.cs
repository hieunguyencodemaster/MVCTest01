using System;
using System.Collections.Generic;

namespace MVCTest01.Data;

public partial class TTheLoai
{
    public string MaTheLoai { get; set; } = null!;

    public string? TenTheLoai { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
