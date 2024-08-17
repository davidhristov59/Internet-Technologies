   using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class HomeController : Controller //dadeno
    {
        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "David Hristov";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}