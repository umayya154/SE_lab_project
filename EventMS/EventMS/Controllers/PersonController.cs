﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EventMS.Models;

namespace EventMS.Controllers
{
    public class PersonController : Controller
    {
       
        // GET: Person
        public ActionResult Index()
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> list = db.Person.ToList();
            List<PersonRegister> viewList = new List<PersonRegister>();
            foreach (Person s in list)
            {
                PersonRegister p = new PersonRegister();
                p.Address = s.Address;
                p.Department = s.Department;
                p.Email = s.Email;
                p.FeedBack = s.FeedBack;
                p.Password = s.Password;
                p.PersonId = s.PersonId;
                p.PersonName = s.PersonName;
                p.PersonType = s.PersonType;
                p.PhoneNumber = s.PhoneNumber;
                p.RegsitrationNo = s.RegistrationNo;
                p.SocietyName = s.SocietyName;
                p.Status = s.Status;
                viewList.Add(p);
            }

            return View(viewList);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonRegister obj)
        {
            try
            {
                // TODO: Add insert logic here
                Person s = new Person();
                s.Address = obj.Address;
                s.Department = obj.Department;
                s.Email = obj.Email;
                s.FeedBack = obj.FeedBack;
                s.Password = obj.Password;
                s.PersonId = obj.PersonId;
                s.PersonName = obj.PersonName;
                s.PersonType = obj.PersonType;
                s.PhoneNumber = obj.PhoneNumber;
                s.RegistrationNo = obj.RegistrationNo;
                s.SocietyName = obj.SocietyName;
                s.Status = obj.Status;

                EventManagementDbEntities db = new EventManagementDbEntities();
                db.Person.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(decimal id)
        {
           
            return View();

        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(Person p)
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
        //[HttpPost]
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
        // POST: People/Delete/5
       

    
    }

}
