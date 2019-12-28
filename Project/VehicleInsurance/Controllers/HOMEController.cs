using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleInsurance.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult contactus()
        {
            return View();
        }

        public ActionResult signup()
        {
            return View();
        }


        public ActionResult signout()
        {
            return View();
        }


    }
}