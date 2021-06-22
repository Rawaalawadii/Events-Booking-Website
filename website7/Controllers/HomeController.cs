using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website7.Controllers
{
    public class HomeController : Controller
    {
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
    }
}