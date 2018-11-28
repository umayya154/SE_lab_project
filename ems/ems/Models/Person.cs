using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Person
    {
        public int PersonId { get; set; }
       
        public string PersonType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
       public string SocietyName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RegsitrationNo { get; set; }
    }
}