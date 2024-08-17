using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC.Models;

namespace CRUD_MVC.Controllers
{
    public class MovieController : Controller
    {

        public static List<Movie> movies = new List<Movie>()
        {
            new Movie(){
            MovieName = "Shrek",
            Rating = 5,
            DownloadURL = "#",
            ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKZR3LgB_kPu-elRBgLF1Am5ciHPV0gdJiQCu5yJRSPQ&s",
            Id = 5
            }
        };

        public static List<Client> clients = new List<Client>();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllMovies () //lista na site filmovi
        {
            return View(movies);
        }

        public ActionResult ShowMovie(int id) {

            MovieRental model = new MovieRental();
            model.clients = clients;
            model.RentedMovie = movies.ElementAt(id);

            return View(model);
        }

        public ActionResult ShowClient(int id)
        {
            return View(clients.ElementAt(id));
        }


        public ActionResult NewMovie()
        {
            Movie model = new Movie();

            return View(model);

        }

        [HttpPost]
        public ActionResult InsertNewMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movies.Add(movie);
                return RedirectToAction("GetAllMovies");
            }

            return View("NewMovie", movie);
        }

        [HttpPost]
        public ActionResult InsertNewClient(Client client)
        {
            if (ModelState.IsValid)
            {
                clients.Add(client);
                return RedirectToAction("GetAllMovies");
            }

            return View("NewMovie", movies);
        }

        public ActionResult EditMovie(int id)
        {
            var model = movies.ElementAt(id);
            model.Id = id;

            return View(model);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if(ModelState.IsValid == false)
            {
                return View("NewMovie", model);
            }

            var forUpdate = movies.ElementAt(model.Id);

            forUpdate.MovieName = model.MovieName;
            forUpdate.Rating = model.Rating;
            forUpdate.ImageUrl = model.ImageUrl;
            forUpdate.DownloadURL = model.DownloadURL;

            return View("GetAllMovies", movies);
        }

        public ActionResult DeleteMovie(int id)
        {
            movies.RemoveAt(id);
            return View("GetAllMovies", movies);
        }
    }
}