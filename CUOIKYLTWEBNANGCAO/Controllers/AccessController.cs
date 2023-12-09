using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CUOIKYLTWEBNANGCAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CUOIKYLTWEBNANGCAO.Controllers
{
    public class AccessController : Controller
    {
        dbQUANLYBANHANGContext db = new dbQUANLYBANHANGContext();   
        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName")==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(Party user)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var u = db.Parties.Include(p=>p.Person).Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    HttpContext.Session.SetString("UserType", u.TypeOfParty.ToString());
                    if (u.TypeOfParty.Equals("2"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    if (u.TypeOfParty.Equals("1"))
                    {
                        return RedirectToAction("Index", "Admin");
                    }    
                }
            }
                  
                TempData["Error"] = "Lỗi đăng nhập. Tên đăng nhập hoặc mật khẩu không chính xác!";
            
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("UserType");
            return RedirectToAction("Index", "Home");
        }
        [Route("signup")]
        [HttpGet]
        public ActionResult Signup()
        {
            return View();

        }
        [HttpPost]
        [Route("signup")]
        public ActionResult Signup(string Username, string Password)
        {
            if (db.Parties.Any(p => p.Username == Username))
            {
                // Nếu tồn tại, hiển thị thông báo và không thêm vào cơ sở dữ liệu
                TempData["ErrorMessage"]  = "Tài khoản đã tồn tại. Vui lòng chọn một tên đăng nhập khác.";
                return View(); // Tạo view "Error" để hiển thị thông báo lỗi
            }

            // Nếu chưa tồn tại, thêm vào cơ sở dữ liệu
            Party party = new Party();
            party.TypeOfParty = "2";
            party.Username = Username;
            party.Password = Password;
            db.Parties.Add(party);
            db.SaveChanges();
            TempData["SuccessMessage"] = "Đăng ký tài khoản thành công!";
            return RedirectToAction("Login");
        }
    }
}
