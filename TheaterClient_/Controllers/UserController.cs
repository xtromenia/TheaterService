using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;
using System.Security.Claims;

namespace TheaterClient_.Controllers
{
    /* Denna klass hanterar allting som har med användarens information att göra.
     * Visar upp information kring namn, epost och eventuellt lösenord.
     * Här kan användarna ändra sin information ifall något blev felinmatat vid registrering.
     */
    [Authorize]
    public class UserController : Controller
    {
        Service1Client service = new Service1Client();
        public IActionResult Index()
        {
            //Hämtar id ur sparade identities.
            int id = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            CustomerData customer = service.GetCustomerDataById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateMail(CustomerData customerToUpdate)
        {
            customerToUpdate.Id = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            service.UpdateCustomerMail(customerToUpdate);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdatePassword(CustomerData customerToUpdate)
        {
            customerToUpdate.Id = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            service.UpdateCustomerPass(customerToUpdate);
            return RedirectToAction("Index");
        }

        public IActionResult ActiveBookings()
        {
            //Hämtar id ur sparade identities.
            int id = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            List<BookingData> bookings = service.GetCustomersBookings(id).ToList();
            List<BookingData> activeBookings = bookings.FindAll(x => x.Viewing.Date > DateTime.Now);
            return View(activeBookings);
        }

        public IActionResult BookingHistory()
        {
            //Hämtar id ur sparade identities.
            int id = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            List<BookingData> bookings = service.GetCustomersBookings(id).ToList();
            List<BookingData> pastBookings = bookings.FindAll(x => x.Viewing.Date < DateTime.Now);
            return View(pastBookings);
        }
    }
}
