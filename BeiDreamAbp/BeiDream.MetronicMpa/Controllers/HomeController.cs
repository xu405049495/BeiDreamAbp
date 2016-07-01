﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using BeiDream.Application.Test;

namespace BeiDream.MetronicMpa.Controllers
{
    public class HomeController : AbpController
    {
        private readonly ITest _test;

        public HomeController(ITest test)
        {
            _test = test;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = _test.SayHello("MetronicMpa后台框架");
            return View();
        }
    }
}