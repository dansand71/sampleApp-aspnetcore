﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_linux.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Message"] = "Your application description page.";
            ViewData["HOSTNAME"] = System.Environment.MachineName;
            ViewData["PROCESSORS"] = System.Environment.ProcessorCount;
            ViewData["OSARCHITECTURE"] = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture;
            ViewData["OSDESCRIPTION"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            ViewData["PROCESSARCHITECTURE"] = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture;
            ViewData["FRAMEWORKDESCRIPTION"] = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult throwException()
        {
            // divide by zero
            int zero = 0;
            int i = 1/zero;
            return View();
        }
    }
}
