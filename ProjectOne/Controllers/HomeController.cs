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

        [HttpGet]
        public ActionResult Mission()
        {
            ViewBag.Mission = MissionController.lstMission;

            return View();
        }
        [HttpPost]
        public ActionResult Mission(int myMission)
        {
            Mission oMission = MissionController.lstMission.Find(x => x.MissionID == myMission);
            return RedirectToAction("Index", "Mission", oMission);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}