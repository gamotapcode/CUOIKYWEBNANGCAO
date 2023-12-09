using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CUOIKYLTWEBNANGCAO.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;

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
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            return View();
        }
        [Route("danhsachsanpham")]
        public IActionResult DanhSachSanPham(int? page)
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            int pagesize = 8;
            int pagenumber = page == null || page < 0 ? 1 : page.Value;
            var listsanpham = db.TbSanphams.Include(p=>p.MadanhmucNavigation).AsNoTracking().ToList().OrderBy(x=>x.Tensanpham);
            PagedList<TbSanpham> list = new PagedList<TbSanpham>(listsanpham, pagenumber, pagesize);
            return View(list);
        }
        [Route("ThemSanPham")]
        [HttpGet]
        public IActionResult ThemSanPham()
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            ViewData["Madanhmuc"] = new SelectList(db.TbDanhmucs, "Madanhmuc", "Tendanhmuc");
            return View();
        }
        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPham(TbSanpham sanpham, IFormFile uploadHinh)
        {
            
            if (ModelState.IsValid)
            {
                db.TbSanphams.Add(sanpham);
                db.SaveChanges();
                if (uploadHinh!=null && uploadHinh.Length>0)
                {
                    var filePath = Path.Combine("wwwroot", "ImageProducts", uploadHinh.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        uploadHinh.CopyTo(stream);
                    }
                    sanpham.Hinhanh = uploadHinh.FileName;
                    db.SaveChanges();
                }
                return RedirectToAction("DanhSachSanPham");
            }
            return View();
        }
        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(int masanpham)
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            var sanpham = db.TbSanphams.Find(masanpham);
            ViewData["Madanhmuc"] = new SelectList(db.TbDanhmucs, "Madanhmuc", "Tendanhmuc");
            return View(sanpham);
        }
        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(TbSanpham sanpham,IFormFile uploadHinh)
        {
            
            if (ModelState.IsValid)
            {
                var oldSanpham = db.TbSanphams.AsNoTracking().FirstOrDefault(s => s.Masanpham == sanpham.Masanpham);
                if (uploadHinh!=null && uploadHinh.Length > 0)
                {
                    var filePath = Path.Combine("wwwroot", "ImageProducts", uploadHinh.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        uploadHinh.CopyTo(stream);
                    }
                    sanpham.Hinhanh = uploadHinh.FileName;              
                }
                db.Update(sanpham);
                db.SaveChanges();
                var isOldImageInUse = db.TbSanphams.Any(s => s.Hinhanh == oldSanpham.Hinhanh);
                if (!isOldImageInUse)
                {
                    var oldImagePath = Path.Combine("wwwroot", "ImageProducts", oldSanpham.Hinhanh);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                
                return RedirectToAction("DanhSachSanPham");
            }
            return View(sanpham);
        }
        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult XoaSanPham(int masanpham)
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            var sanpham = db.TbSanphams.Include(p => p.MadanhmucNavigation).FirstOrDefault(p => p.Masanpham == masanpham);
            ViewData["Madanhmuc"] = new SelectList(db.TbDanhmucs, "Madanhmuc", "Tendanhmuc");
            return View(sanpham);
        }
        [Route("XoaSanPham"),ActionName("XoaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult XoaSanPhamPost(int masanpham)
        {
            
            var sanpham = db.TbSanphams.Find(masanpham);
            try
            {

                if (sanpham != null)
                {
                    db.TbSanphams.Remove(sanpham);
                    db.SaveChanges();
                    TempData["Messages"] = "Xoá sản phẩm thành công";
                    return RedirectToAction("DanhSachSanPham");
                }
                else
                {
                    TempData["Messages"] = "Không tìm thấy sản phẩm để xoá";
                }
            }
            catch (Exception ex)
            {
                TempData["Messages"] = $"Lỗi khi xoá sản phẩm: {ex.Message}";
            }
            return View(sanpham);
        }
    }
}
