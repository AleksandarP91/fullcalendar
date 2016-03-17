using fullcalendar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fullcalendar.Models
{
    public class Event
    
       
    {
        
     

        //public Event(string i, string t)
        //{
        //    // TODO: Complete member initialization
        //    this.id = i;
        //    this.title =t;
            
        //}
        
        //public List<Event> createEvent(CreateEvent model)
        //{
        //List<Event> list = new List<Event>();
        //     Event event1 = new Event(id, title);
        //    {
               
        //        event1.title = model.title;
        //        event1.id = model.id;
                
        //        list.Add(event1);


        //    }
        //  return list;
            
        //    }
       
        public int id { get; set; }
        public string resourceId { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string title { get; set; }




    }
}