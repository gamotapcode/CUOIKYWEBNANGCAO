using System.Collections.Generic;
using System.Linq;

namespace CUOIKYLTWEBNANGCAO.Models
{
    public class CartItem
    {
        public int IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set;}
        public string Hinhanh { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;
    }

    public class CartViewModel
    {
        public int InvoiceId { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal TongTien => Items.Sum(item => item.ThanhTien);
    }
}