using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProjectOne.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Mission()
        {
            ViewBag.Mission = MissionController.lstMission;

            return View();
        }
        [HttpPost]
        public ActionResult Mission(int MissionID)
        {
            Mission oMission = MissionController.lstMission.Find(x => x.MissionID == MissionID);

            return View("../Mission/Index", oMission);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}