using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.Models;

namespace EMS.Controllers
{
    public class BookEventController : Controller
    {
        //
        // GET: /BookEvent/
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<EventInfo> el = db.EventInfoes.ToList();
            List<BookEventModel> eml = new List<BookEventModel>();
            foreach (EventInfo em in el)
            {
                BookEventModel e = new BookEventModel();
                e.Date = em.Date;
                e.Days = em.Days;
                e.EndTime = em.EndTime;
                e.EventName = em.EventName;
                e.EventStatus = em.EventStatus;
                e.ImagePath = em.ImagePath;
                e.PlaceAddress = em.PlaceAddress;
                e.SocietyName = em.SocietyName;
                e.EventType = em.EventType;
                e.StartTime = em.StartTime;
                e.People = Convert.ToInt32(em.People);
                eml.Add(e);
            }
            return View();
        }

        //
        // GET: /BookEvent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /BookEvent/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BookEvent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /BookEvent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /BookEvent/Edit/5
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

        //
        // GET: /BookEvent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /BookEvent/Delete/5
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
        public ActionResult BookEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BookEvent(BookEventModel em)
        {
            try
            {
                EventManagementDbEntities db = new EventManagementDbEntities();
                EventInfo e = new EventInfo();
                e.Date = em.Date;
                e.Days = em.Days;
                e.EndTime = em.EndTime;
                e.EventName = em.EventName;
                e.EventStatus = "pending";
                e.ImagePath = em.ImagePath;
                e.PlaceAddress = em.PlaceAddress;
                e.SocietyName = em.SocietyName;
                e.EventType = em.EventType;
                e.StartTime = em.StartTime;
                e.People = em.People;
                db.EventInfoes.Add(e);
                db.SaveChanges();
                int id = e.EventId;
                return RedirectToAction("EventDetails");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
