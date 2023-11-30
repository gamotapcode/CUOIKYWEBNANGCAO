using CUOIKYLTWEBNANGCAO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CUOIKYLTWEBNANGCAO.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        dbQUANLYBANHANGContext db = new dbQUANLYBANHANGContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("sanpham")]
        public IActionResult SanPham(int? page)
        {
            int pagesize = 8;
            int pagenumber = page == null || page < 0 ? 1 : page.Value;
            var listsanpham = db.TbSanphams.AsNoTracking().OrderBy(x => x.Tensanpham);
            PagedList<TbSanpham> list = new PagedList<TbSanpham>(listsanpham, pagenumber, pagesize);
            return View(list);
        }
        [Route("ThemSanPham")]
        [HttpGet]
        public IActionResult ThemSanPham()
        {
            ViewBag.Madanhmuc = new SelectList(db.TbDanhmucs.ToList(),"Madanhmuc","Tendanhmuc");
            return View();
        }
        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPham(TbSanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                db.TbSanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("SanPham");
            }
            return View(sanpham);
        }
        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(int maSanPham)
        {
            ViewBag.Madanhmuc = new SelectList(db.TbDanhmucs.ToList(), "Madanhmuc", "Tendanhmuc");
            var sanPham = db.TbSanphams.Find(maSanPham);
            return View(sanPham);
        }
        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(TbSanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Update(sanpham);
                db.SaveChanges();
                return RedirectToAction("SanPham");
            }
            return View(sanpham);
        }
        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult XoaSanPham(int maSanPham)
        {
            TempData["Message"] = "";
            var chitiethoadon = db.TbChitiethoadons.Where(x => x.Masanpham == maSanPham).ToList();
            if (chitiethoadon.Count() > 0)
            {
                TempData["Message"] = "Không xóa được sản phẩm này";
                return RedirectToAction("SanPham");
            }
            db.Remove(db.TbSanphams.Find(maSanPham));
            db.SaveChanges();
            TempData["Message"] = "sản phẩm đã được xóa";
            return RedirectToAction("SanPham");
        }
    }
}
