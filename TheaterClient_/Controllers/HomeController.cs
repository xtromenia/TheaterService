using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace TheaterClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Service1Client service = new Service1Client();
            List<MovieData> movies = service.GetMovies().ToList();
            return View(movies);
        }
    }
}
