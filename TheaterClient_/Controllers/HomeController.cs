using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using Microsoft.AspNetCore.Identity;

namespace TheaterClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Auth = "Logged in";
            }
            else
            {
                ViewBag.Auth = "Not Logged in";
            }
            Service1Client service = new Service1Client();
            List<MovieData> movies = service.GetMovies().ToList();
            return View(movies);
        }
    }
}
