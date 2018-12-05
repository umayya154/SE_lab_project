using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagementSystem.Controllers
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
       /* public ActionResult Login(Person obj)
        {
            EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> list = db.People.ToList();
            List<Person> viewList = new List<Person>();
            foreach(Person p in list)
            {
                if ((p.Email == obj.Email) && (p.Password == obj.Password))
                {
                    
                    return View();
                } 
            }
             
        }*/
    }
}