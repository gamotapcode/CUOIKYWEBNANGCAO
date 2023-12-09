using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CUOIKYLTWEBNANGCAO.Models;
using Microsoft.AspNetCore.Http;

namespace CUOIKYLTWEBNANGCAO.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/user")]
    public class PartiesController : Controller
    {
        private readonly dbQUANLYBANHANGContext _context;

        public PartiesController(dbQUANLYBANHANGContext context)
        {
            _context = context;
        }

        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            return View(await _context.Parties.ToListAsync());
        }

        [Route("ThemTaiKhoan")]
        public IActionResult Create()
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            return View();
        }

        [Route("ThemTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartyId,TypeOfParty,DepartmentId,Username,Password,UsernameH,PasswordH")] Party party)
        {
            if (ModelState.IsValid)
            {
                _context.Add(party);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(party);
        }

        [Route("SuaTaiKhoan")]
        public async Task<IActionResult> Edit(decimal? id)
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            if (id == null)
            {
                return NotFound();
            }

            var party = await _context.Parties.FindAsync(id);
            if (party == null)
            {
                return NotFound();
            }
            return View(party);
        }

        [Route("SuaTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, Party party)
        {
            if (id != party.PartyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(party);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartyExists(party.PartyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(party);
        }

        [Route("XoaTaiKhoan")]
        public IActionResult Delete(decimal id)
        {
            var userType = HttpContext.Session.GetString("UserType");
            if (userType == null || !userType.Equals("1"))
                return View("Error");
            var taikhoan = _context.Parties.FirstOrDefault(p => p.PartyId == id);
            return View(taikhoan);
        }

        [Route("XoaTaiKhoan")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(decimal id)
        {
            var taikhoan = _context.Parties.Find(id);
            try
            {

                if (taikhoan != null)
                {
                    _context.Parties.Remove(taikhoan);
                    _context.SaveChanges();
                    TempData["Messages"] = "Xoá tài khoản thành công";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Messages"] = "Không tìm thấy tài khoản để xoá";
                }
            }
            catch (Exception ex)
            {
                TempData["Messages"] = $"Lỗi khi xoá sản phẩm: {ex.Message}";
            }
            return RedirectToAction("Index");
        }

        private bool PartyExists(decimal id)
        {
            return _context.Parties.Any(e => e.PartyId == id);
        }
    }
}
