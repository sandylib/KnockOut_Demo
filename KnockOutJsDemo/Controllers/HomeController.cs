using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOutJsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Observables()
        {
            ViewBag.Message = "Your Observables page.";

            return View();
        }

        public ActionResult ControlFlowBindings()
        {
            ViewBag.Message = "ControlFlowBindings.";

            return View();
        }
    }
}