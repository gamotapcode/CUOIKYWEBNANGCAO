using CKWEBNANGCAO.NET8.Helpers;
using CKWEBNANGCAO.NET8.Models;
using CKWEBNANGCAO.NET8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CKWEBNANGCAO.NET8.ViewComponents
{
    public class CartDetailViewComponent:ViewComponent
    {
        const string CART_KEY = "MYCART";
        private readonly DbQuanlybanhangContext db;
        public CartDetailViewComponent(DbQuanlybanhangContext context)=>db= context;
        public IViewComponentResult Invoke()
        {
            var Cart=HttpContext.Session.Get<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            return View(Cart);
        }
    }
}
