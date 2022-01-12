using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using TheaterAdmin.Models;

namespace TheaterAdmin.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Service1Client service = new Service1Client();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterMovie()
        {
            Movie movieToAdd = new Movie();
            return View(movieToAdd);
        }
        [HttpPost]
        public IActionResult RegisterMovie(Movie movieToAdd)
        {
            service.RegisterMovie(movieToAdd);
            ViewBag.Status = "Movie Registered";
            return View();
        }

        public IActionResult RegisterViewing()
        {
            RegisterViewingModel registerViewingModel = new RegisterViewingModel();
            registerViewingModel.Viewing = new Viewing();
            registerViewingModel.Movies = service.GetMovies().ToList();
            registerViewingModel.Theaters = service.GetTheaters().ToList();
            return View(registerViewingModel);
        }
        [HttpPost]
        public IActionResult RegisterViewing(string movieId, string theaterId, string date, string time)
        {
            date = date + " " + time;
            DateTime dateTime = DateTime.Parse(date);

            Viewing newViewing = new Viewing();
            newViewing.MovieID = int.Parse(movieId);
            newViewing.TheaterID = int.Parse(theaterId);
            newViewing.Date = dateTime;

            service.RegisterViewing(newViewing);

            return RedirectToAction("Index");
        }

        public IActionResult ListCustomers()
        {
            List<CustomerData> customers = service.GetCustomers().ToList();
            return View(customers);
        }

        public IActionResult RemoveCustomer(int id)
        {
            service.RemoveCustomer(id);
            return RedirectToAction("ListCustomers");
        }
    }
}
