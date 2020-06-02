using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // GET: Home
            ViewBag.countries = new List<string>
            {



                "indai",
                "usa",
                "UK",
                "Canada"
            };

            return View("Index");
        }
    }
}
