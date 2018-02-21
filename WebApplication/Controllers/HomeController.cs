using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }       

        public ActionResult Page1()
        {
            ViewBag.IsImported = bool.Parse(ConfigurationManager.AppSettings["ImportFeature"]);

            return View();
        }

        public ActionResult Page2()
        {
            ViewBag.IsImported = bool.Parse(ConfigurationManager.AppSettings["ImportFeature"]);

            return View();
        }
    }
}