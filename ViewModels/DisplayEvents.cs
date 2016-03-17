using fullcalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fullcalendar.ViewModels
{
    

    public class DisplayEvents
    {

        
        //public DisplayEvents(IEnumerable<Event> events)
        //{
        //    Events = events;
        //}
        public int id { get; set; }
        public string resourceId { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string title { get; set; }
        //public IEnumerable<Event> Events { get; private set; }
    



    }

}