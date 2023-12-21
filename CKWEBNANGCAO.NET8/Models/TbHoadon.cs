using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class TbHoadon
{
    public int Mahoadon { get; set; }

    public decimal? Makhachhang { get; set; }

    public DateTime? Ngay { get; set; }

    public decimal? Tongtien { get; set; }

    public virtual Party? MakhachhangNavigation { get; set; }

    public virtual ICollection<TbChitiethoadon> TbChitiethoadons { get; set; } = new List<TbChitiethoadon>();
}
