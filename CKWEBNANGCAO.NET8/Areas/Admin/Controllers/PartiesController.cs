
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CKWEBNANGCAO.NET8.Models;
using Microsoft.AspNetCore.Authorization;

namespace CUOIKYLTWEBNANGCAO.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/user")]
    [Authorize(Roles = "1")]
    public class PartiesController : Controller
    {
        private readonly DbQuanlybanhangContext _context;

        public PartiesController(DbQuanlybanhangContext context)
        {
            _context = context;
        }

        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parties.Include(p => p.Person).ToListAsync());
        }

        [Route("ThemTaiKhoan")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("ThemTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Party party)
        {
            if (_context.Parties.Any(p => p.Username == party.Username))
            {
                // Nếu tồn tại, hiển thị thông báo và không thêm vào cơ sở dữ liệu
                TempData["ErrorMessage"] = "Tài khoản đã tồn tại. Vui lòng chọn một tên đăng nhập khác.";
                return View(); // Nó trả về lại để hiển thị thông báo lỗi trong View 
            }
            Person person = new Person
            {
                CurrentLastName = party.Person.CurrentLastName
            };
            Party newparty = new Party
            {
                TypeOfParty = party.TypeOfParty,
                Username = party.Username,
                Password = party.Password,
                Person = person,
            };
            _context.Parties.Add(newparty);
            _context.SaveChanges();
            TempData["SuccessMessage"] = "Thêm tài khoản thành công!";
            return RedirectToAction(nameof(Index));
        }

        [Route("SuaTaiKhoan")]
        public IActionResult Edit(decimal? PartyId)
        {
            var taikhoan = _context.Parties.Include(p => p.Person).FirstOrDefault(p => p.PartyId == PartyId);
            return View(taikhoan);
        }

        [Route("SuaTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(decimal PartyId, Party updatedParty)
        {
            if (PartyId != updatedParty.PartyId)
            {
                return NotFound();
            }

            try
            {
                // Lấy thông tin hiện tại của dbo.PARTY từ cơ sở dữ liệu
                var existingParty = _context.Parties.Include(p => p.Person).FirstOrDefault(p => p.PartyId == PartyId);

                if (existingParty != null)
                {
                    var duplicateUsername = _context.Parties.Any(p => p.PartyId != PartyId && p.Username == updatedParty.Username);

                    if (duplicateUsername)
                    {
                        // Nếu có trùng lặp, hiển thị thông báo lỗi
                        TempData["ErrorMessage"] = "Trùng Username!";
                        return View(updatedParty);
                    }
                    // Cập nhật các trường của dbo.PARTY từ updatedParty
                    existingParty.TypeOfParty = updatedParty.TypeOfParty;
                    existingParty.Username = updatedParty.Username;
                    existingParty.Password = updatedParty.Password;

                    // Kiểm tra và cập nhật dbo.PERSON nếu có
                    if (existingParty.Person != null)
                    {
                        existingParty.Person.CurrentLastName = updatedParty.Person.CurrentLastName;
                        // Cập nhật các trường khác của dbo.PERSON nếu có
                    }

                    _context.SaveChanges();

                    TempData["SuccessMessage"] = "Sửa tài khoản thành công";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                TempData["ErrorMessage"] = "Có lỗi khi sửa tài khoản";
                return View(updatedParty);
            }
        }

        [Route("XoaTaiKhoan")]
        public IActionResult Delete(decimal PartyId)
        {
            var taikhoan = _context.Parties.Include(p => p.Person).FirstOrDefault(p => p.PartyId == PartyId);
            return View(taikhoan);
        }

        [Route("XoaTaiKhoan")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(decimal PartyId)
        {
            var taikhoan = _context.Parties
         .Include(p => p.Person)
         .FirstOrDefault(p => p.PartyId == PartyId);

            if (taikhoan != null)
            {
                // Xóa Person trước
                if (taikhoan.Person != null)
                {
                    _context.People.Remove(taikhoan.Person);
                }

                // Sau đó, xóa Party
                _context.Parties.Remove(taikhoan);
                _context.SaveChanges();

                TempData["Messages"] = "Xoá tài khoản thành công";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Messages"] = "Không tìm thấy tài khoản để xoá";
                return RedirectToAction("Index");
            }
        }

        private bool PartyExists(decimal id)
        {
            return _context.Parties.Any(e => e.PartyId == id);
        }
    }
}
