using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace TheaterClient_.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id)
        {
            Service1Client service = new Service1Client();
            MovieData movie = service.GetMovie(id);
            return View(movie);
        }
    }
}
