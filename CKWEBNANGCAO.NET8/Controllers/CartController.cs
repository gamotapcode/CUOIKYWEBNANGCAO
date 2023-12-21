using CKWEBNANGCAO.NET8.Models;
using CKWEBNANGCAO.NET8.ViewModels;
using Microsoft.AspNetCore.Mvc;
using CKWEBNANGCAO.NET8.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace CKWEBNANGCAO.NET8.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        readonly DbQuanlybanhangContext db;
        const string CART_KEY = "MYCART";
        public CartController(DbQuanlybanhangContext context) => db = context;
        public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
        public IActionResult Index()
        {
            return View(Cart);
        }
        public IActionResult AddToCart(int masp,int soluong=1)
        {
            var gioHang = Cart;
            var item=gioHang.SingleOrDefault(p=>p.IdSanPham==masp);
            if (item == null)
            {
                var sanpham = db.TbSanphams.SingleOrDefault(p => p.Masanpham == masp);
                if (sanpham == null)
                {
                    return RedirectToAction("PageNotFound", "Home");
                }
                item = new CartItem
                {
                    IdSanPham = sanpham.Masanpham,
                    TenSanPham = sanpham.Tensanpham,
                    DonGia = sanpham.Dongia.Value,
                    SoLuong = soluong,
                    Hinhanh = sanpham.Hinhanh

                };
                gioHang.Add(item);
            }
            else
            {
                item.SoLuong += soluong;

            }
            HttpContext.Session.Set(CART_KEY, gioHang);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveCart(int masp)
        {
            var gioHang = Cart;
            var item=gioHang.SingleOrDefault(p=>p.IdSanPham== masp);
            if (item == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            else
            {
                gioHang.Remove(item);
                HttpContext.Session.Set(CART_KEY, gioHang);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateCart(Dictionary<int, int> quantities)
        {
            var myCart = Cart;

            // Loop through the quantities and update each corresponding item in the cart
            foreach (var (productId, quantity) in quantities)
            {
                var item = myCart.SingleOrDefault(p => p.IdSanPham == productId);
                if (item != null)
                {
                    item.SoLuong = quantity;
                }
            }

            // Save the updated cart to the session
            HttpContext.Session.Set(CART_KEY, myCart);

            // Redirect back to the cart page
            return RedirectToAction("Index");
        }
    }
}
