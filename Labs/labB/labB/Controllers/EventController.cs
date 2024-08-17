using labB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labB.Controllers
{
    public class EventController : Controller
    {

        private static List<EventModel> events = new List<EventModel>()
        {
            new EventModel() {ID = 1, Ime = "Maraton", Lokacija = "Skopje"},
            new EventModel() {ID = 2, Ime = "Triathlon", Lokacija = "Prilep"}, 
            new EventModel() {ID = 3, Ime = "Ohrid Trail Run", Lokacija = "Ohrid"}
        };

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllEvents() //obavezno
        {
           // List<EventModel> model = events;

            return View(events);
        }

        public ActionResult Add()
        {
            EventModel eventmodel = new EventModel();

            return View(eventmodel);
        }

        public ActionResult AddEvent(EventModel eventModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Add", eventModel);
            }

            else
            {
                if (events.Count == 0) //ako e prazna
                {
                    eventModel.ID = 1;
                }
                else
                {
                    int maxID = events.Max(x => x.ID);
                    eventModel.ID = maxID + 1;
                }

                events.Add(eventModel);

                return View("Details", eventModel);
            }

        }

        public ActionResult Details(int id)
        {
            var selectedItem = events.Find(x => x.ID == id);

            if (selectedItem != null)
            {
                return View("Details", selectedItem);
            }
            else
            {
                return HttpNotFound();
            }


        }

        public ActionResult Edit(int id)
        {
            EventModel eventModel = events.Find(x => x.ID == id);
            if (eventModel == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Edit", eventModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(EventModel updated)
        {
            
            if (ModelState.IsValid)
            {
                EventModel currentModel = events.Find(x => x.ID == updated.ID);
                if (currentModel != null)
                {
                    currentModel.Ime = updated.Ime;
                    currentModel.Lokacija = updated.Lokacija;

                    return View("ShowAllEvents", events);
                }
                else
                {
                    return HttpNotFound();
                }
            }

            return View("ShowAllEvents", events);
        }

        public ActionResult Delete(int id)
        {
            EventModel eventModel = events.Find(x => x.ID == id);
             
            if (eventModel != null)
            {
                events.Remove(eventModel);
            }
            
            return View("ShowAllEvents", events);
            
        }


    }
}