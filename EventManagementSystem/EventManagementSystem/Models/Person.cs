using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string PersonType { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string RegsitrationNo { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string SocietyName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool Status { get; set; }
    }
}