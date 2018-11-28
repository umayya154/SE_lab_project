using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ems.Views
{
    public class EventtController : Controller
    {
        // GET: Eventt
        public ActionResult Index()
        {
            return View();
        }

        // GET: Eventt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Eventt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventt/Create
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

        // GET: Eventt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Eventt/Edit/5
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

        // GET: Eventt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Eventt/Delete/5
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
