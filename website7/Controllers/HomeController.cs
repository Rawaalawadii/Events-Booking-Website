using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website7.Models;

namespace website7.Controllers
{
    public class HomeController : Controller
    {
        int rem;
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult information()
        {
            return View();
        }
        public ActionResult testDB()
        {

            eventsDBEntities db = new eventsDBEntities();
            EventBooking eventBooking = db.EventBookings.SingleOrDefault(x => x.eventID == 1);

            EventBookingView eventvm = new EventBookingView();
            eventvm.eventID = eventBooking.eventID;
            eventvm.eventName = eventBooking.eventName;
            eventvm.remainingSeats = eventBooking.remainingSeats;
            eventvm.remainingSeats = eventvm.remainingSeats - 1;
            rem = eventvm.remainingSeats - 1;



            return View(eventvm);
        }
        public ActionResult testdbd()
        {
            rem = rem - 1;
            return View();


        }

        }
}