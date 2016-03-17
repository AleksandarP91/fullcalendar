using fullcalendar.Models;
using fullcalendar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fullcalendar.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(CreateEvent _createEvent)
        {

            DataModel.createEvent(_createEvent);

            return RedirectToAction("Index");
        }
        public ActionResult addresource()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addresource(AddResource addResource)
        {
            
            DataModel.addResource(addResource);

            return RedirectToAction("Index");
        }
        public JsonResult getresources()

        {

            var resourses = DataModel.displayResources();
            return Json(resourses, JsonRequestBehavior.AllowGet);
            
        }
        public JsonResult getevents()
        {

            var events = DataModel.displayEvents();
            return Json(events, JsonRequestBehavior.AllowGet);

        }
     
        public void changedate(int id,  string end)
        {
          
            var changeDate = DataModel.displayEvents();
            changeDate.Where(w => w.id == id).ToList().ForEach(s => s.end = end);
          
            
        }

    }
}