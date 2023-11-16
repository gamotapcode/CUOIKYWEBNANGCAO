using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class TbSanpham
    {
        public TbSanpham()
        {
            TbChitiethoadons = new HashSet<TbChitiethoadon>();
        }

        public int Masanpham { get; set; }
        public string Tensanpham { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Soluong { get; set; }
        public string Hinhanh { get; set; }
        public string Mota { get; set; }
        public int? Madanhmuc { get; set; }

        public virtual TbDanhmuc MadanhmucNavigation { get; set; }
        public virtual ICollection<TbChitiethoadon> TbChitiethoadons { get; set; }
    }
}
