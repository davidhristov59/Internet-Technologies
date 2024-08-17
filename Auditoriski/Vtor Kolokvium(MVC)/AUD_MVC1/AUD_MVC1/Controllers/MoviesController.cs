using AUD_MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AUD_MVC1.Controllers
{
    public class MoviesController : Controller
    {
        //kreirame objekti 
        public static Movie movie = new Movie()
        {
            Title="Shrek", Rating = 5, DownloadURL = "#", ImageUrl = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKZR3LgB_kPu-elRBgLF1Am5ciHPV0gdJiQCu5yJRSPQ&s", Id = 5
        };

        public static List<Client> clients = new List<Client>() 
        {
            //dodavame klienti staticno za ovaa lista

            new Client() {  Name="David", Address = "ASNOM 21", Phone = 4233, ID = 23, clenskaKarta = "1235"},
            new Client() {  Name="Marko", Address = "ASNOM 29", Phone = 3235, ID = 13, clenskaKarta = "9585"},
            new Client() {  Name="Luka", Address = "ASNOM 11", Phone = 652, ID = 39, clenskaKarta = "8942"},
            new Client() {  Name="Mario", Address = "ASNOM 51", Phone = 4236, ID = 65, clenskaKarta = "9424"}
                
    };


        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Random() //vo Views --> Movies --> Add View --> Random so isto ime kako akcijata Random
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = movie;
            return View(model);
        }

        public ActionResult ShowClient(int id) //vo ASP .NET 1 parametar koga prakame toj parametar mora da se vika id. 
        {
            return View(clients.ElementAt(id));
        }
    }
}