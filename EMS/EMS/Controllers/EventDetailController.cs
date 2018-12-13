using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.Models;

namespace EMS.Controllers
{
    public class EventDetailController : Controller
    {
        //
        // GET: /EventDetail/
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<EventDetail> l = db.EventDetails.ToList();
            List<EventDetailModel> viewList = new List<EventDetailModel>();
            foreach (EventDetail s in l)
            {
                EventDetailModel d = new EventDetailModel();
                d.EventId = s.EventId;
                d.DecorImage = s.EventDecorImage;
                d.Flowering = s.Flowering;
                d.FoodDetail = s.FoodDetails;
                d.LightingDetail = s.LigtingDetails;
                d.Sitting = s.SittingPlane;
                d.StageDetail = s.StageDetails;
                viewList.Add(d);
            }
            return View();
        }

        //
        // GET: /EventDetail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /EventDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EventDetail/Create
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
        // GET: /EventDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /EventDetail/Edit/5
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
        // GET: /EventDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /EventDetail/Delete/5
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
        public ActionResult EventDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EventDetails(EventDetailModel obj)
        {
            try
            {
                EventManagementDbEntities db = new EventManagementDbEntities();
                EventDetail e = new EventDetail();
                e.StageDetails = obj.StageDetail;
                e.SittingPlane = obj.Sitting;
                e.LigtingDetails = obj.LightingDetail;
                e.FoodDetails = obj.FoodDetail;
                e.Flowering = obj.Flowering;
                e.EventId = obj.EventId;
                e.EventDecorImage = obj.DecorImage;

                db.EventDetails.Add(e);
                db.SaveChanges();
                return RedirectToAction("EventDetails");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return View();
        }

    }
}
