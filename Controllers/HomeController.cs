using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;


namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        linqEntities s1 = new linqEntities();
        // GET: Home
        public ActionResult Index()
        {
            var s = s1.emps.ToList();
            return View(s);
        }
        public ActionResult Admin()
        {
           return View();   
        }
        public ActionResult Register()
        {
            return View();  
        }


        public ActionResult Delete()
        {
            var x= s1.emps.Find(id);
            s1.emps.Remove(x);  
            RedirectToAction("Index", "Home");
        }
        



    }
}