using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            return "About Index";
        }

        public IActionResult Create()
        {
            //return Content("About Create");

            return View("Index");

            //var a = nameof(HomeController);
            //var b = nameof(Startup);
            //return RedirectToAction("Index");
            //return RedirectToAction("Detail");
            //return RedirectToAction(nameof(Detail));
            //return RedirectToAction(nameof(Index));
            //return RedirectToAction("Index", "Home");
        }

        public IActionResult Detail()
        {
            return Content("About Detail");
        }
    }
}
