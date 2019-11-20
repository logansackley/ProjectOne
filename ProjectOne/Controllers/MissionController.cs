using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOne.Controllers
{
    
    public class MissionController : Controller
    {
        public static List<Mission> lstMission = new List<Mission>()
        {
            new Mission{MissionID = 1, MissionName = "West Indies", PresidentName = "Mehr",MissionAddress="Port of Spain", Climate = "Tropical", DominantReligion = "Catholic", Language = "English, Dutch, French" },
            new Mission{MissionID = 2, MissionName = "Santiago North, Chile", PresidentName = "Crowther",MissionAddress="Santiago", Climate = "Temperate", DominantReligion = "Catholic", Language = "Spanish" },
            new Mission{MissionID = 3, MissionName = "Boston, Massachussets", PresidentName = "Brockbank",MissionAddress="Boston", Climate = "Temperate", DominantReligion = "Catholic", Language = "English, Creole" }

        };
        // GET: Mission
        public ActionResult Index()
        {
           
       
            return View();
        }
    }
}