using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views_Example.Models;

namespace Views_Example.Controllers
{
    public class GenreController : Controller
    {

        //sega sakame preku baza da manipulirame so listata
        private ApplicationDbContext dbContext; //kreirame objekt sto ke se odnesuva na bazata
        //aplicaitondbcontext e klasata za bazata, kreirame objekt od bazata

        public GenreController()
        {
            dbContext = new ApplicationDbContext();
        }

        //desen klik --> quick actions and refactorings --> generate overrides
        protected override void Dispose(bool disposing) //obavezno
        {
            base.Dispose(disposing);
            dbContext.Dispose();
        }

        public ActionResult Index() {

            var genreList = dbContext.Genres.ToList(); //site genre-ovi stavi gi vo lista

            return View(genreList);

        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateNew(Genre genre) {

            dbContext.Genres.Add(genre); //go dodadovme vo DbSet, ama toj ne e tamu fizicki
            dbContext.SaveChanges(); //fizicki gi primenuva promenite vo bazata

            return RedirectToAction("Index", "Genre");
        }

        public ActionResult Delete(int id) {

            Genre g = dbContext.Genres.Find(id);
            dbContext.Genres.Remove(g);
            dbContext.SaveChanges();

            return RedirectToAction("Index", "Genre");
        }

        public ActionResult Edit(int id)
        {

            var genre = dbContext.Genres.Single(g => g.GenreID == id); //ako postoi ovoj genre so ova id, vrati mi go

            if(genre == null)
            {
                return HttpNotFound();
            }
            
            return View(genre);
        }

        public ActionResult EditGenre(Genre genre)
        {
            var genreinDB = dbContext.Genres.Single(g => g.GenreID == genre.GenreID);

            TryUpdateModel(genreinDB); //vo tabelata ke go izmeni zapisot
            dbContext.SaveChanges(); 

            return RedirectToAction("Index", "Genre");
        }

        public ActionResult Search(string term)
        {
            var genreList = dbContext.Genres.Where(g => g.GenreName.Contains(term)).ToList();

            return View(genreList);
        }


        //koristime staticka lista 

        /*
        static List<Genre> genreList = new List<Genre>
        {
            new Genre() { GenreID = 1, GenreName = "Jazz"},
            new Genre(){ GenreID = 2, GenreName = "Rock"}
        };
        

        // GET: Genre
        public ActionResult Index()
        {
            return View(genreList);
        }

        public ActionResult Create()
        {

            return View();
        }

        public ActionResult CreateNew(Genre genre)
        {
            //toa sto ke napisam vo Create potocno vo ID i Name i kliknam Submit preku ovoj metod ke go dodadam
            genreList.Add(genre);

            return RedirectToAction("Index", "Genre"); //se vrakame na pocetok
        }

        public ActionResult Delete(int id)
        {

            foreach (Genre g in genreList.ToList())
            {
                if (g.GenreID == id)
                {
                    genreList.Remove(g);
                }
            }

            return RedirectToAction("Index", "Genre"); //se vrakame na pocetok
        }

        public ActionResult Edit(int id)
        {

            var genre = new Genre() { GenreID = 0 };

            foreach (Genre g in genreList.ToList())
            {
                if (g.GenreID == id)
                {
                    genre = g;
                }

            }

            if (genre.GenreID == 0)
            {
                return HttpNotFound();
            }

            return View();
        }

        public ActionResult EditGenre(Genre genre)
        {

            foreach (Genre g in genreList)
            {
                if (g.GenreID == genre.GenreID)
                {
                    genre.GenreName = g.GenreName;
                }

            }
            return RedirectToAction("Index", "Genre"); //se vrakame na pocetok
        }

        */
    }
}



