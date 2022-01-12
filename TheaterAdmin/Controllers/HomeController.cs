using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TheaterAdmin.Models;

namespace TheaterAdmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Admin admin = new Admin();
            return View(admin);
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(Admin admin)
        {
            if (admin.Username.Equals("admin") &&
                admin.Password.Equals("password"))
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, admin.Username));
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.LoginError = "Wrong info, try again.";
                return View();
            }
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
