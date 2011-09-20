﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC on Windows Azure! Time is now " + DateTime.UtcNow.ToString("o");
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
