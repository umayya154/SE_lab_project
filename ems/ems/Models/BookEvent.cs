using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ems.Models
{
    public class BookEvent
    {
        public int EventId { get; set; }
        public string EventType { get; set; }
        public string Days { get; set; }
        public DateTime Time { get; set; }
        public string Society { get; set; }
        public string Place { get; set; }
        public BadImageFormatException EventImage { get; set; }
        public int People { get; set; }

    }
}