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
            new Mission{MissionID = 1, MissionName = "West Indies", PresidentName = "Mehr",MissionAddress="Port of Spain", Climate = "Tropical", DominantReligion = "Catholic", Language = "English, Dutch, French", Picture= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Flag_of_the_West_Indies_Federation_%281958%E2%80%931962%29.svg/2880px-Flag_of_the_West_Indies_Federation_%281958%E2%80%931962%29.svg.png" },
            new Mission{MissionID = 2, MissionName = "Santiago North, Chile", PresidentName = "Crowther",MissionAddress="Santiago", Climate = "Temperate", DominantReligion = "Catholic", Language = "Spanish", Picture= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Flag_of_Santiago%2C_Chile.svg/1599px-Flag_of_Santiago%2C_Chile.svg.png"},
            new Mission{MissionID = 3, MissionName = "Boston, Massachussets", PresidentName = "Brockbank",MissionAddress="Boston", Climate = "Temperate", DominantReligion = "Catholic", Language = "English, Creole", Picture="https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Flag_of_Boston.svg/500px-Flag_of_Boston.svg.png" }

        };
        // GET: Mission
        public ActionResult Index()
        {
           
       
            return View();
        }
    }
}