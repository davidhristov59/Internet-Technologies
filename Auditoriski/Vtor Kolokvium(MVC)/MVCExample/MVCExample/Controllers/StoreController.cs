using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class StoreController : Controller //nase
    {
        // GET: Store
        //public string Index()
        //{
        //  return "Hello from Store.Index()";
        //}
         
        public ActionResult Index() //klikame na Index desen klik i odime Add View
        {
            return View();
            //return HttpNotFound();

        //  return RedirectToAction("Index", "Home"); //povikaj ja akcijata index od Home controller-ot
        }

        public string Browse()
        {
            return "Hello from Store.Browse()";
        }

        public string Details(int? id, string artist_album) //bez ?, samo id za 1 parametar i ova dole 
        {
            //return "Hello from Store.Details(), ID=" + id;
            return "Hello from Store.Details(), ID=" + id + "and artist album " + artist_album;

            //vo url-to vnesuvame /store/details/?artist_album=david&id=4
        }

    }
}