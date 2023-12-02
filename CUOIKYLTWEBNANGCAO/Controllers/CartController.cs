using CUOIKYLTWEBNANGCAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CUOIKYLTWEBNANGCAO.Helper;
using System.Linq;

namespace CUOIKYLTWEBNANGCAO.Controllers
{
    public class CartController : Controller
    {
        private readonly dbQUANLYBANHANGContext _context;
        public CartController(dbQUANLYBANHANGContext context)
        {
            _context = context;
        }

        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
                else
                {

                }
                return data;
            }
        } 
        public IActionResult Index()
        {
            return View(Carts);
        }

        public IActionResult AddToCart(int id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.IdSanPham == id);
            if (item == null)
            {
                var hanghoa = _context.TbSanphams.SingleOrDefault(p => p.Masanpham == id);
                item = new CartItem()
                {
                    IdSanPham = id,
                    TenSanPham = hanghoa.Tensanpham,
                    DonGia = hanghoa.Dongia.Value,
                    SoLuong = 1,
                    Hinhanh = hanghoa.Hinhanh
                };
                myCart.Add(item);
            }
            else
            {
                item.SoLuong++;
            }
            HttpContext.Session.Set("GioHang", myCart);

            return RedirectToAction("Index");
        }

        public IActionResult AddToCartFromDetail(int id, int SoLuong)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.IdSanPham == id);
            if (item == null)
            {
                var hanghoa = _context.TbSanphams.SingleOrDefault(p => p.Masanpham == id);
                item = new CartItem()
                {
                    IdSanPham = id,
                    TenSanPham = hanghoa.Tensanpham,
                    DonGia = hanghoa.Dongia.Value,
                    SoLuong = SoLuong,
                    Hinhanh = hanghoa.Hinhanh
                };
                myCart.Add(item);
            }
            else
            {
                item.SoLuong += SoLuong;
            }
            HttpContext.Session.Set("GioHang", myCart);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.IdSanPham == id);
            if (item != null)
            {
                myCart.Remove(item);
                HttpContext.Session.Set("GioHang", myCart);
            }
			return RedirectToAction("Index");
		}
    }
}
