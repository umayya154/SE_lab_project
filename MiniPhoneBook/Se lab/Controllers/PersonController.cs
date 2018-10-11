using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<Person> list = db.People.ToList();
            List<Person> viewList = new List<Person>();
            foreach (Person s in list)
            {
                Person obj = new Person();
                obj.PersonId = s.PersonId;
                obj.FirstName = s.FirstName;
                obj.MiddleName = s.MiddleName;
                obj.LastName = s.LastName;
                obj.DateOfBirth = s.DateOfBirth;
                obj.AddedOn = s.AddedOn;
                obj.AddedBy = s.AddedBy;
                obj.HomeAddress = s.HomeAddress;
                obj.HomeCity = s.HomeCity;
                obj.FaceBookAccountId = s.FaceBookAccountId;
                obj.LinkedInId = s.LinkedInId;
                obj.UpdateOn = s.UpdateOn;
                obj.TwitterId = s.TwitterId;
                obj.EmailId = s.EmailId;
            
                viewList.Add(obj);
            }
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            String user = User.Identity.Name;
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person obj)
        {
            try
            {
                // TODO: Add insert logic here
                Person s = new Person();
                s.PersonId = obj.PersonId;
                s.FirstName = obj.FirstName;
                s.MiddleName = obj.MiddleName;
                s.LastName = obj.LastName;
                s.DateOfBirth = obj.DateOfBirth;
                s.AddedOn = obj.AddedOn;
                s.AddedBy = obj.AddedBy;
                s.HomeAddress = obj.HomeAddress;
                s.HomeCity = obj.HomeCity;
                s.FaceBookAccountId = obj.FaceBookAccountId;
                s.LinkedInId = obj.LinkedInId;
                s.UpdateOn = obj.UpdateOn;
                s.TwitterId = s.TwitterId;
                s.EmailId = s.EmailId;
                

                PhoneBookDbEntities db = new PhoneBookDbEntities();
                db.People.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
