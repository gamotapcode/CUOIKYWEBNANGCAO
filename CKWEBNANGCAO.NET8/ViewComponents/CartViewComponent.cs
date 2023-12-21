using CKWEBNANGCAO.NET8.Helpers;
using CKWEBNANGCAO.NET8.Models;
using CKWEBNANGCAO.NET8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CKWEBNANGCAO.NET8.ViewComponents
{
    public class CartViewComponent: ViewComponent
    {
        const string CART_KEY = "MYCART";
        private readonly DbQuanlybanhangContext db;
        public CartViewComponent(DbQuanlybanhangContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var Cart=HttpContext.Session.Get<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            return View(new CartViewModel
            {
                TongTien=Cart.Sum(p=>p.ThanhTien),
                Quantity=Cart.Sum(p=>p.SoLuong)
            });
        }
    }
}
