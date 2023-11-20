using CUOIKYLTWEBNANGCAO.Models;
using CUOIKYLTWEBNANGCAO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CUOIKYLTWEBNANGCAO.Controllers
{
    public class HomeController : Controller
    {
        dbQUANLYBANHANGContext db = new dbQUANLYBANHANGContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? page)
        {
            int pagesize = 8;
            int pagenumber = page == null || page < 0 ? 1 : page.Value;
            var listsanpham = db.TbSanphams.AsNoTracking().OrderBy(x=>x.Tensanpham);
            PagedList<TbSanpham> list = new PagedList<TbSanpham>(listsanpham, pagenumber, pagesize);
            return View(list);
        }

        public IActionResult SanPhamTheoDanhMuc(int madm,int? page)
        {
            int pagesize = 8;
            int pagenumber = page == null || page < 0 ? 1 : page.Value;
            PagedList<TbSanpham> list;   
                List<TbSanpham> listsanpham = db.TbSanphams
                .Where(x=>x.Madanhmuc==madm)    
                .OrderBy(x => x.Tensanpham)
                    .ToList();
                list = new PagedList<TbSanpham>(listsanpham, pagenumber, pagesize);              
            ViewBag.madm = madm;
            string tendanhmuc = db.TbDanhmucs
        .Where(d => d.Madanhmuc == madm)
        .Select(d => d.Tendanhmuc)
        .FirstOrDefault();
            ViewBag.tendm = tendanhmuc;
            return View(list);
        }
        public IActionResult ProductDetail (string maSP)
        {
            TbSanpham sanPham = db.TbSanphams.Where(x=>x.Masanpham.ToString() == maSP).FirstOrDefault();
            ViewBag.Anhsanpham = sanPham.Hinhanh;
            return View(sanPham);
        }
    }
}
