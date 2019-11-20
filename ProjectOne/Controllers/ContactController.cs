using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOne.Controllers
{
   
    public class ContactController : Controller
    {
        public static List<String> lstSubject = new List<string>();
       

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            lstSubject.Add("More Missionary Information");
            lstSubject.Add("An error on the site");
            lstSubject.Add("I would like to add my mission");
            lstSubject.Add("Other");
            ViewBag.Subjects = lstSubject;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact myContact)
        {
            ModelState.Clear();
            ViewBag.Subjects = lstSubject;
            return View();
        }
    }
}