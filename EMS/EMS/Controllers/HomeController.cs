using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.Models;

namespace EMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Admin()
        {

            return View();
        }
        public ActionResult Volunteer()
        {

            return View();
        }
        public ActionResult President()
        {

            return View();
        }
        public ActionResult Login(Person obj)
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> l = db.People.ToList();
            foreach (Person p in l)
            {
                if ((obj.Email == p.Email) && obj.Password == (p.Password))
                {
                    if (p.PersonType == "Admin")
                    {
                        return RedirectToAction("Admin", "Home");
                    }
                    else if (p.PersonType == "President")
                    {
                        return RedirectToAction("President", "Home");
                    }
                    else if (p.PersonType == "Volunteer")
                    {
                        return RedirectToAction("Volunteer", "Home");
                    }
                    else
                    {
                        obj.LoginErrorMessage = "Wrong email or parrword";
                    }

                }

            }
            return View();
        }
        public ActionResult Feedback(FeedbackModel obj)
        {
            try
            {
                EventManagementDbEntities1 dc = new EventManagementDbEntities1();
                Feedback f = new Feedback();
                f.feedback1 = obj.feedback;
                dc.Feedbacks.Add(f);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return View();
        }
    }
}


/*EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> list = db.People.ToList();
            //List<Person> viewList = new List<Person>();
            foreach (Person s in list)
            {
                if ((s.Email == userModel.Email) && (s.Password == userModel.Password))
                {
                    if (s.PersonType == "Admin")
                    {
                        return View("Admin");
                    }
                    else if (s.PersonType == "President")
                    {
                        return View("President");
                    }
                    else if (s.PersonType == "Volunteer")
                    {
                        return View("Volunteer");
                    }
                }
                else
                {
                    userModel.LoginErrorMessage = "Wrong Login or Password.";
                }

             }*/