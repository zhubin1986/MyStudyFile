using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class MyStudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult MyOrgChartTest()
        {
            return View();
        }
        
    }
}
