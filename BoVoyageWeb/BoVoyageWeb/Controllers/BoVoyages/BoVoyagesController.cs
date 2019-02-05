using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoVoyageWeb.Controllers.BoVoyages
{
    public class BoVoyagesController : Controller
    {
        // GET: BoVoyage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListVoyages()
        {
            return View();
        }
    }
}