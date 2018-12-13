using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.Models;

namespace EMS.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> list = db.People.ToList();
            List<Person> viewList = new List<Person>();
            foreach (Person s in list)
            {
                Person p = new Person();
                p.Address = s.Address;
                p.Department = s.Department;
                p.Email = s.Email;
                p.FeedBack = s.FeedBack;
                p.Password = s.Password;
                p.PersonId = s.PersonId;
                p.PersonName = s.PersonName;
                p.PersonType = s.PersonType;
                p.PhoneNumber = s.PhoneNumber;
                p.RegistrationNo = s.RegistrationNo;
                p.SocietyName = s.SocietyName;
                p.FeedBack = s.FeedBack;
                p.Status = s.Status;
                viewList.Add(p);
            }
            return View(viewList);
        }

        //
        // GET: /Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Person/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create
        [HttpPost]
        public ActionResult Create(PersonModel obj)
        {
            try
            {
                // TODO: Add insert logic here
                Person s = new Person(); 
                s.Address = obj.Address;
                s.Department = obj.Department;
                /*EventManagementDbEntities db = new EventManagementDbEntities();
                List<Person> list = db.People.ToList();
                List<PersonModel> viewList = new List<PersonModel>();
                foreach (Person p in list)
                {
                    if (p.Email == obj.Email)
                    {
                        ViewBag("Email already exist");
                        return View("Create");
                    }
                     
                }*/
                //s.Email = obj.Email;
                s.FeedBack = obj.FeedBack;
                s.Password = obj.Password;
                s.PersonId = obj.PersonId;
                s.PersonName = obj.PersonName;
                s.PersonType = obj.PersonType;
                s.PhoneNumber = obj.PhoneNumber;
                s.RegistrationNo = obj.RegsitrationNo;
                s.SocietyName = obj.SocietyName;
                s.FeedBack = obj.FeedBack;
                s.Status = obj.Status;

                EventManagementDbEntities db = new EventManagementDbEntities();
                List<Person> list = db.People.ToList();
                List<PersonModel> viewList = new List<PersonModel>();
                foreach (Person p in list)
                {
                    if (p.Email == obj.Email)
                    {
                        ViewBag("Email already exist");
                        return View("Create");
                    }
                     
                }
                db.People.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5
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
        // GET: /Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5
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
