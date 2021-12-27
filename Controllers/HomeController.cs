using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternalHealthCare.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Policy()
        {
            ViewBag.Message = "Your Policy page.";

            return View();
        }
        public ActionResult Claims()
        {
            ViewBag.Message = "Your Policy page.";

            return View();
        }
        public ActionResult Payments()
        {
            ViewBag.Message = "Your Policy page.";

            return View();
        }
    }
}