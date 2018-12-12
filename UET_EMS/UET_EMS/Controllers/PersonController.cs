using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UET_EMS.Models;
using System.Net.Mail;
using System.Net;
 

namespace UET_EMS.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {

            EventManagementDbEntities db = new EventManagementDbEntities();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewList = new List<PersonViewModel>();
            foreach (Person s in list)
            {
                PersonViewModel p = new PersonViewModel();
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
                //p.Status = s.Status;
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
        public ActionResult Register([Bind(Exclude = "isEmailVrified, ActivationCode")] Person obj)
        {


            bool Status = false;
            string message = "";
            //Model Validation
            if (ModelState.IsValid)
            {
                //Email is already exist
                var isExist = IsEmailExist(obj.Email);
                if (isExist)
                {
                    ModelState.AddModelError("Email Exist", "Email is already exist");
                    return View(obj);
                }
                //Generate Activation Code
                obj.Activation_Code = Guid.NewGuid();

                obj.Is_email_verified = false;
                //save to database
                using (EventManagementDbEntities db = new EventManagementDbEntities())
                {
                    db.People.Add(obj);
                    db.SaveChanges();
                    //Send Email to User
                    sendVerificationLinkEmail(obj.Email, obj.Activation_Code.ToString());
                    message = "Registration Successfully done. Account Activation Link" + "has been sent to your Email id:" + obj.Email;
                    Status = true;

                }

            }
            else
            {
                message = "Invalid Request";
            }
            ViewBag.message = message;
            ViewBag.status = Status;
            return View(obj);
            /* try
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
                 s.RegistrationNo = obj.RegsitrationNo;
                 s.SocietyName = obj.SocietyName;
                 //s.Status = obj.Status;

                 EventManagementDbEntities db = new EventManagementDbEntities();
                 db.People.Add(s);
                 db.SaveChanges();
                 return RedirectToAction("Index");

             }
             catch(Exception ex)
             {
                 return View();
             }*/
        }
        [NonAction]
        public bool IsEmailExist(string email)
        {
            using (EventManagementDbEntities db = new EventManagementDbEntities())
            {
                var v = db.People.Where(a => a.Email == email).FirstOrDefault();
                return v != null;
            }
        }
        [NonAction]
        public void sendVerificationLinkEmail(string email, string activationcode)
        {
            var verifyUrl = "/User/VerifyAccount/" + activationcode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("dotnetawesome@gmail.com", "Dotnet awesome");
            var fromEmailPassword = "";
            var toEmail = new MailAddress(email);

            string subject = "Your account is successfully created";

            string body = "<br/><br/>Your account is" + "successfully created. Please click on the below link to verify your account" + "<br/><br/><a href = '" + link + "'>" + link + "</a> ";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)

            };
            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
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
