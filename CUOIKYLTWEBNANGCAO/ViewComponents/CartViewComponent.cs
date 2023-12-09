using CUOIKYLTWEBNANGCAO.Helper;
using CUOIKYLTWEBNANGCAO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUOIKYLTWEBNANGCAO.ViewComponents
{
    public class CartViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart=HttpContext.Session.Get<List<CartItem>>("GioHang") ?? new List<CartItem>();
            return View(new CartViewModel
            {
                Quantity= cart.Sum(p=>p.SoLuong),
                TongTien=cart.Sum(p=>p.ThanhTien)
            }) ;
        }
    }
}
