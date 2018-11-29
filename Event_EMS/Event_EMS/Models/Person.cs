using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Event_EMS.Models
{
    public class Person
    {

        public int PersonId { get; set; }
        [Required]
        public string PersonType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegsitrationNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string SocietyName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        //[Range()]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

    }
}