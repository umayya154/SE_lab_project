using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Person
    {
       [Required]
        [Display(Name = "Enter Id")]
        public int PersonId { get; set; }
        [Required]
        [Display(Name = "Enter your firstname")]
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        [Required]
        [Display(Name = "Enter your lastname")]
        public String LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Enter your DateofBirth")]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedOn { get; set; }
        [DataType(DataType.Date)]
        public String AddedBy { get; set; }
        [Required]
        [Display(Name = "Enter your Address")]
        public String HomeAddress { get; set; }
        [Required]
        [Display(Name = "Enter your City Name")]
        public String HomeCity { get; set; }
        public String FaceBookAccountId { get; set; }
        public String LinkedInId { get; set; }
        public DateTime Updateon { get; set; }
        public String ImagePath { get; set; }
        public String TwitterId { get; set; }
        [Required]
        [Display(Name = "Enter your EmailId")]
        public String EmailId { get; set; }
        

    }
}