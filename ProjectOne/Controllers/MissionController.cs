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
        public static List<FAQ> lstFAQ = new List<FAQ>()
        {
            new FAQ{MessageID = 1, Question = "What's the best food you ate?", Answer = "The best food I ate on my mission was Banane Pese. It's a hatian food that's made of fried plantanes, meat, and a spicy colslaw"},
            new FAQ{MessageID = 1, Question = "What's a day in the life like as a missionary?", Answer = "Great question, as missionaries we wake up at 6:30 and study during the morning. After that we spend the afternoon and evening finding people interested in our message and teaching them. We then go to bed at 10:30 each night. For more information read the missionary handbook."},
            new FAQ{MessageID = 1, Question = "What's the best way to prepare for a mission?", Answer = "The best way to get ready for a mission is being a missionary today. Find opportunities to share the gospel with those around you."}

        };
        // GET: Mission
        public ActionResult Index()
        {
           
       
            return View();
        }
        [HttpGet]
        public ActionResult FAQ()
        {
            return View(lstFAQ);
        }
        [HttpPost]
        public ActionResult FAQ(string Question)
        {
            return View(lstFAQ);
        }
        [HttpGet]
        public ActionResult Reply(string sQuestion)
        {
            ViewBag.Question = sQuestion;
            return View();
        }
        [HttpPost]
        public ActionResult Reply(FAQ myFAQ)
        {
            
            return View("FAQ", lstFAQ);
        }



    }
}