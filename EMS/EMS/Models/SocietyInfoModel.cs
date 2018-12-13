using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class SocietyInfoModel
    {
        [Required]
        public string SocietyName { set; get; }
        [Required]
        public string PresidentName { set; get; }
        [Required]
        public string WisePrsidentName { set; get; }
        [Required]
        public string ContactNumber { set; get; }
        [Required]
        public string ContactNumber1 { set; get; }
        [Required]
        public int Members { set; get; }
        public string facebookPageName { set; get; }
        [Required]
        public string EmailAddress { set; get; }
        [Required]
        public string SocietyLogo { set; get; }
    }
}