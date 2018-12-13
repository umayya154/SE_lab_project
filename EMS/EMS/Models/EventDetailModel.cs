using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class EventDetailModel
    {
        public int EventId { set; get; }
        public string FoodDetail { set; get; }
        public string StageDetail { set; get; }
        public string LightingDetail { set; get; }
        public string Flowering { set; get; }
        public string Sitting { set; get; }
        public string DecorImage { set; get; }
    }
}