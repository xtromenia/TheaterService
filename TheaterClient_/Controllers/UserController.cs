using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace TheaterClient_.Controllers
{
    /* Usercontroller hanterar alla vyer som har med användarens inloggning och registrering i systemet.
     * Här används service till databas för att kontrollera ifall lösenord samt epost stämmer överens.
     * Service används även för att registrera nya konton i systemet.
     */
    public class UserController : Controller
    {
        private Service1Client service = new Service1Client();

        public IActionResult Index()
        {
           return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            Customer newCustomer = new Customer();
            return View(newCustomer);
        }

        [HttpPost]
        public IActionResult Register(Customer newCustomer)
        {
            service.RegisterCustomer(newCustomer);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            ViewBag.Status = "Please Login";
            Customer customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Customer customer)
        {
            //Ifall inloggning är korrekt skall cookies sätta med email och namn för att underlätta för kund i användning.
            if (service.LoginCustomer(customer))
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Email, customer.Email));
                identity.AddClaim(new Claim(ClaimTypes.Name, customer.Name));
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                return RedirectToAction("Index", "Home");
            }else
            {
                ViewBag.Status = "Error, please try again.";
                return View();
            }
        }
    }
}
