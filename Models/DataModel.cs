using fullcalendar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fullcalendar.Models
{
    public class DataModel
    {
        static List<Resource> _list = new List<Resource>();
        public static void addResource(AddResource model)
        {
            Resource resource = new Resource();
            resource.id = model.id;
            resource.title = model.title;      
            _list.Add(resource);
        }

        
        public static List<DisplayResources> displayResources()
        {
            List<DisplayResources> ret = new List<DisplayResources>();
                foreach (var item in _list)
            {
                
                DisplayResources model = new DisplayResources();
                model.id = item.id;
                model.title = item.title;
                ret.Add(model);
            }
            return ret;
            }

        static List<Event> _listEvent = new List<Event>();
        public static void createEvent(CreateEvent eventModel)
        {
            Event event1 = new Event();
            event1.id = eventModel.id;
            event1.resourceId = eventModel.resourceId;
            event1.start = eventModel.start;
            event1.end = eventModel.end;
            event1.title = eventModel.title;

            _listEvent.Add(event1);
        }


        public static List<DisplayEvents> displayEvents()
        {
            List<DisplayEvents> retEvent = new List<DisplayEvents>();
            foreach (var item in _listEvent)
            {

                DisplayEvents eventModel = new DisplayEvents();
                eventModel.id = item.id;
                eventModel.resourceId = item.resourceId;
                eventModel.start = item.start;
                eventModel.end = item.end;
                eventModel.title = item.title;
                retEvent.Add(eventModel);
            }
            return retEvent;
        }
        


    }
}