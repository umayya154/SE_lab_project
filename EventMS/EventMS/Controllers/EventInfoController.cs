using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventMS.Models;

namespace EventMS.Controllers
{
    public class EventInfoController : Controller
    {
        // GET: EventInfo
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<EventInfo> list = db.EventInfo.ToList();
            List<BookEvent> viewlist = new List<BookEvent>();
            foreach(EventInfo d in list)
            {
                BookEvent obj = new BookEvent();
                obj.EventId = d.EventId;
                obj.EventName = d.EventName;
                obj.EventType = d.EventType;
                obj.Days = d.Days;
                obj.Date = Convert.ToDateTime(d.Date);
                obj.StartTime = d.StartTime;
                obj.EndTime = d.EndTime;
                obj.PlaceAddress = d.PlaceAddress;
                obj.ImagePath = d.ImagePath;
                obj.People = Convert.ToInt16(d.People);
                obj.EventStatus = d.EventStatus;
                viewlist.Add(obj);

            }

             
            return View(viewlist);
        }

        // GET: EventInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventInfo/Create
        [HttpPost]
        public ActionResult Create(BookEvent obj)
        {
            try
            {
                // TODO: Add insert logic here
                BookEvent d = new BookEvent();
                d.EventId = obj.EventId;
                d.EventName = obj.EventName;
                d.EventType = obj.EventType;
                d.Days = obj.Days;
                d.Date = Convert.ToDateTime( obj.Date);

                d.StartTime = obj.StartTime;
                d.EndTime = obj.EndTime;
                d.PlaceAddress = obj.PlaceAddress;
                d.ImagePath = obj.ImagePath;
                d.People = obj.People;
                d.EventStatus = obj.EventStatus;
                EventManagementDbEntities db = new EventManagementDbEntities();
                //db.Person.Add(d);
                db.SaveChanges();             
                return RedirectToAction("Index");
               
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: EventInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
