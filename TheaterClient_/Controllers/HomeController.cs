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
        Service1Client service = new Service1Client();
        public IActionResult Index()
        {
            List<MovieData> movies = service.GetMovies().ToList();
            return View(movies);
        }

        [HttpPost]
        public IActionResult Index(string genre)
        {
            List<MovieData> movies = service.GetMovies().ToList();
            ViewBag.Genre = genre;
            return View(movies);
        }
    }
}
