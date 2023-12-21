using CKWEBNANGCAO.NET8.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CKWEBNANGCAO.NET8.Controllers
{
    public class AccessController : Controller
    {
        DbQuanlybanhangContext db;
        public AccessController(DbQuanlybanhangContext context)
        {
            this.db = context;
        }
        [Route("/login")]
        [HttpGet]
        public IActionResult Login(string? returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [Route("/signup")]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        [Route("/signup")]
        public IActionResult Signup(Party party) //Trong party có Username, Password, Person.CurrentLastName
        {
            if (db.Parties.Any(p => p.Username == party.Username))
            {
                // Nếu tồn tại, hiển thị thông báo và không thêm vào cơ sở dữ liệu
                TempData["ErrorMessage"] = "Tài khoản đã tồn tại. Vui lòng chọn một tên đăng nhập khác.";
                return View(); // Nó trả về lại để hiển thị thông báo lỗi trong View Signup
            }

            // Nếu chưa tồn tại, thêm vào cơ sở dữ liệu
            Person person = new Person
            {
                CurrentLastName = party.Person.CurrentLastName
            };

            Party newparty = new Party
            {
                TypeOfParty = "2",
                Username = party.Username,
                Password = party.Password,
                Person = person,
            };

            db.Parties.Add(newparty);
            db.SaveChanges();
            TempData["SuccessMessage"] = "Đăng ký tài khoản thành công!";
            return RedirectToAction("Login");
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(Party party, string? returnUrl) {
            ViewBag.ReturnUrl = returnUrl;
                var kh = db.Parties.Include(p=>p.Person).SingleOrDefault(p => p.Username==party.Username);
                if (kh == null) 
                {
                    TempData["Error"] = "Lỗi đăng nhập. Tên đăng nhập không chính xác!";
                    
                }
                else
                {
                    if (!kh.Password.Equals(party.Password))
                    {
                        TempData["Error"] = "Lỗi đăng nhập. Mật khẩu không chính xác!";
                    }
                    else
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Role,kh.TypeOfParty),
                             new Claim(ClaimTypes.Name, kh.Person.CurrentLastName)
                        };
                        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        HttpContext.SignInAsync(claimsPrincipal);
                        if (kh.TypeOfParty == "1")
                        {
                            return RedirectToAction("Index", "Admin");
                        }
                        if (Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return Redirect("/");
                        }
                    }
                }
            return View();
        }
        [Route("/logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }

    }
}
