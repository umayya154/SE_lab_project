using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UET_EMS.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
         public virtual CategoryImageFile Image { get; set; } 
    }
}