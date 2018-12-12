using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UET_EMS.Models
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name = "PersonId")]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        
        [Display(Name = "PersonName")]
        public string PersonName { get; set; }
        public string PersonType { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string SocietyName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        public string confirmpassword { get; set; }
        public string RegsitrationNo { get; set; }
        public string FeedBack { get; set; }
       
        //public object Status { get; set; }
    }
}