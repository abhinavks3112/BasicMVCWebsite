using BasicMVCWebsite.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVCWebsite.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 15)]
        // GET: Home
        public string Index()
        {
            return "Welcome!! This is a basic website made with ASP.NET MVC"; 
        }

        [OutputCache(Duration = 20)] // Action filter
        [ActionName("Time")] //Action Name
        public string GetCurrentTime()
        {
            //return "Welcome!! This is a basic website made with ASP.NET MVC";
            return DateTime.Now.ToString("T");
        }

        [NonAction]
        public string StringTime()
        {
            return "The current time is " + DateTime.Now.ToString("T");
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}