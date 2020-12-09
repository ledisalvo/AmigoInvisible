using AmigoInvisible.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmigoInvisible.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InputDataMembers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveOrganizerData(AttendeeModel model)
        {
            return RedirectToAction("InsertAttendees", model);
        }

        public ActionResult InsertAttendees()
        {
            return View();
        }

        [HttpPost]
        public JsonResult InsertAttendees(List<AttendeeModel> model)
        {
            var a = model;
            return null;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}