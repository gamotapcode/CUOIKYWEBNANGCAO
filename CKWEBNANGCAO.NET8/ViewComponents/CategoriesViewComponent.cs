using CKWEBNANGCAO.NET8.Models;
using CKWEBNANGCAO.NET8.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CKWEBNANGCAO.NET8.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly DbQuanlybanhangContext db;
        public CategoriesViewComponent(DbQuanlybanhangContext context) => db = context;
        public IViewComponentResult Invoke()
        {
            var categories = db.TbDanhmucs
                .AsNoTracking()
                .Select(p => new CategoriesSP
            {
                Madm = p.Madanhmuc,
                Tendm = p.Tendanhmuc,
                Soluong = p.TbSanphams.Count(),
            })
                .OrderBy(p=>p.Madm);
            return View(categories);
        }
    }
}
