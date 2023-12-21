using CKWEBNANGCAO.NET8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace CKWEBNANGCAO.NET8.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DbQuanlybanhangContext db;
        public ProductsController(DbQuanlybanhangContext context) => db = context;
        [Route("products")]
        public IActionResult Index(int? madm,string searchString,int ?page)
        {
            int pagesize = 8;
            int pagenumber = (page == null || page < 0) ? 1 : page.Value;
            ViewData["search"] = searchString;
            ViewData["madm"] = madm;
            var sanphams = db.TbSanphams.Include(p => p.MadanhmucNavigation).AsQueryable();
            if (madm.HasValue && !string.IsNullOrEmpty(searchString))
            {
                sanphams = sanphams.Where(p => p.Madanhmuc == madm.Value && p.Tensanpham.Contains(searchString));
            }
            else 
            if (madm.HasValue)
            {
                sanphams = sanphams.Where(p => p.Madanhmuc == madm.Value);
            }
            else
            if (!string.IsNullOrEmpty(searchString))
            {
                sanphams = sanphams.Where(p => p.Tensanpham.Contains(searchString));
            }
            PagedList<TbSanpham> list = new PagedList<TbSanpham>(sanphams, pagenumber, pagesize);
            return View(list);
        }
        [Route("productdetails")]
        public IActionResult Detail(int masp)
        {
            var sanpham = db.TbSanphams
                .AsNoTracking()
                .Include(p=>p.MadanhmucNavigation)
                .SingleOrDefault(p => p.Masanpham == masp);
            if (sanpham == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(sanpham);
        }
    }
}
