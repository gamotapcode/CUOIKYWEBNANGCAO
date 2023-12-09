using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class TbDanhmuc
    {
        public TbDanhmuc()
        {
            TbSanphams = new HashSet<TbSanpham>();
        }

        public int Madanhmuc { get; set; }
        public string Tendanhmuc { get; set; }
        public int? Danhmuccha { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<TbSanpham> TbSanphams { get; set; }
    }
}
