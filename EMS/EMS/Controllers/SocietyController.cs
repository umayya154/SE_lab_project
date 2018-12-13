using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.Models;

namespace EMS.Controllers
{
    public class SocietyController : Controller
    {
        //
        // GET: /Society/
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<SocietyInfo> l = db.SocietyInfoes.ToList();
            List<SocietyInfoModel> ml = new List<SocietyInfoModel>();
            foreach (SocietyInfo s in l)
            {
                SocietyInfoModel sm = new SocietyInfoModel();
                sm.ContactNumber1 = s.ContactNumber1;
                sm.ContactNumber = s.ContactNumber;
                sm.EmailAddress = s.Email;
                sm.facebookPageName = s.FacebookPage;
                sm.PresidentName = s.PresidentNmae;
                sm.SocietyLogo = s.SocietyLogo;
                sm.Members = s.SocietyMamber;
                sm.SocietyName = s.SocietyNmae;
                sm.WisePrsidentName = s.WisePresident;
                ml.Add(sm);
            }
            return View(ml);
        }

        //
        // GET: /Society/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Society/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Society/Create
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
        // GET: /Society/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Society/Edit/5
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
        // GET: /Society/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Society/Delete/5
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
        public ActionResult SocietyRegistartion()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SocietyRegistartion(SocietyInfoModel s)
        {
            try
            {
                EventManagementDbEntities db = new EventManagementDbEntities();
                SocietyInfo si = new SocietyInfo();
                si.ContactNumber = s.ContactNumber;
                si.ContactNumber1 = s.ContactNumber1;
                si.Email = s.EmailAddress;
                si.FacebookPage = s.facebookPageName;
                si.PresidentNmae = s.PresidentName;
                si.SocietyLogo = s.SocietyLogo;
                si.SocietyMamber = s.Members;
                si.SocietyNmae = s.SocietyName;
                si.WisePresident = s.WisePrsidentName;
                db.SocietyInfoes.Add(si);
                db.SaveChanges();
                return RedirectToAction("SocietyRegistartion");
            }
            catch (Exception ex)
            {
                throw ex;
                // return View();
            }
        }
    }
}