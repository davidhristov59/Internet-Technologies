using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views_Example.Models;
using Views_Example.ViewModels;

namespace Views_Example.Controllers
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

        public ActionResult List()
        {

            Artist artist = new Artist { Artist_Name = "famous" };


            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album
                {
                    Title = "AlbumTitle" + i
                });
            }

            //var viewModel = new ArtistAlbumViewModel
            //{
            //    Artist = artist,
            //    Albums = albums,
            //};

            // ViewBag.Albums = albums; //moze i vaka, a moze i kako argument da stavam albums vo View

            ViewBag.Artist = artist;
            return View(albums); //samoto View e vrzano za listata na albumi
            //view ke vrati albums

            //return View(viewModel);
        }

        public ActionResult ShowSearch()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View(); 
        }

        public ActionResult CreateNew(Genre genre)
        {
            return View();
        }


         
    }
}