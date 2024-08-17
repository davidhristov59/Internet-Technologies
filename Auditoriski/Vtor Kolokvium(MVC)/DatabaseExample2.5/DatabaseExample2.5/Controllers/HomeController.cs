using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseExample2._5.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous] //pocetnata strana ke bide pristapliva za site i za tie sto ne se logirani
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
    }
}