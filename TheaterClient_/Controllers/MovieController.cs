using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet]
        public IActionResult Index(int id, DateTime date)
        {
            Service1Client service = new Service1Client();
            MovieData movie = service.GetMovie(id);
            ViewBag.Date = date;
            return View(movie);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Index(int id, int viewingid, ICollection<SeatForm> seats)
        {
            int uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            BookingSubmissionData bookingData = new BookingSubmissionData
            {
                ViewingId = viewingid,
                CustomerId = uid
            };
            List<int> seatids = new();
            //foreach(ICollection<SeatForm> row in seats)
            //{
                foreach (SeatForm seat in seats)
                {
                    if (seat.Checked)
                    {
                        seatids.Add(seat.Id);
                    }
                }
            //}
            bookingData.SeatIds = seatids.ToArray();

            Service1Client service = new Service1Client();
            bool succeeded = service.BookViewing(bookingData);
            MovieData movie = service.GetMovie(id);
            ViewBag.Succeeded = succeeded;
            return View(movie);
        }
    }

    public class SeatForm : SeatData
    {
        public bool Checked { get; set; }
    }
}
