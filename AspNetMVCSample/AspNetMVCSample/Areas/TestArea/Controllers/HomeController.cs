﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCSample.Areas.TestArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: TestArea/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}