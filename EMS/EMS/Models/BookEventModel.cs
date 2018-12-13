using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class BookEventModel
    {
        
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public int Days { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public string PlaceAddress { set; get; }
        public string ImagePath { set; get; }
        public int People { set; get; }
        public string EventStatus { set; get; }
        public string SocietyName { get; set; }
    }
}