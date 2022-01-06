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
    /* AuthenticationController hanterar alla vyer som har med användarens inloggning och registrering i systemet.
     * Här används service till databas för att kontrollera ifall lösenord samt epost stämmer överens.
     * Service används även för att registrera nya konton i systemet.
     */
    public class AuthenticationController : Controller
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
        public async Task<IActionResult> Register(Customer newCustomer)
        {
            service.RegisterCustomer(newCustomer);
            await LoginAsync(newCustomer);
            return RedirectToAction("", "Home");
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
                CustomerData customerData = service.GetCustomerData(customer);
                
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, customerData.Name));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, customerData.Id.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Email, customerData.Email));
                
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));
                
                return RedirectToAction("Index", "Home");
            }else
            {
                ViewBag.Status = "Error, please try again.";
                return View();
            }
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
