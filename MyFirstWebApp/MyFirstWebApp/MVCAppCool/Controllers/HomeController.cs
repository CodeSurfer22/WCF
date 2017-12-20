using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppCool.EmployeeMaintenenaceClient;

namespace MVCAppCool.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeMaintenenaceClient.Service1Client em;
        public ActionResult Index()
        {
            if (em == null)
            {
                //Accesss a new instance of the WCF Web Service
                em = new Service1Client();
            }
            List<Person> empPers = new List<Person>();
            //Get all Persons from the web service
            var data = em.GetAllPersons().ToList();
            ViewBag.Persons = data;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}