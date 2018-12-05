using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventMS.Models
{
    public class PersonRegister
    {
        public int PersonId { get; set; }

        public string PersonName { get; set; }
        public string PersonType { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string SocietyName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RegsitrationNo { get; set; }
        public string FeedBack { get; set; }
        public object Status { get; internal set; }
        public string RegistrationNo { get; internal set; }
    }
}
