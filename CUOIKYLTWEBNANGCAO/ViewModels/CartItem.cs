using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUOIKYLTWEBNANGCAO.ViewModels
{
    public class CartItem
    {
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string Hinhanh { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;
    }
    public class CartViewModel
    {
        public int Quantity { get; set; }
        public decimal TongTien
        { get; set; }
    }
}
