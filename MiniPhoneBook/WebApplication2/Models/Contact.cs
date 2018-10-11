using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{/// <summary>
/// It is a contact class 
/// </summary>
    public class Contact
    {
        public String ContactId { get; set; }
        public String ContactNumber { get; set; }
        public String Type { get; set; }
        public String PersonId { get; set; }

    }
}