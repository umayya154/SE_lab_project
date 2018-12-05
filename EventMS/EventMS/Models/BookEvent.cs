using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventMS.Models
{
    public class BookEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public int Days { get; set; }
        public System.DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string PlaceAddress { get; set; }
        public string ImagePath { get; set; }
        public int People { get; set; }
        public string EventStatus { get; set; }
        //public string SocietyName { get; set; }
    }
}