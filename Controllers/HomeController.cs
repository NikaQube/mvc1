﻿using mvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string name, int id)
        {
            Employer emp1 = new Employer() { Name = name, Id = id };

            return Json(emp1, JsonRequestBehavior.AllowGet);
        }
    }
}