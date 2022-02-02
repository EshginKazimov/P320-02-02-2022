using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Parviz";
            ViewData["Surname"] = "Asadov";
            TempData["Age"] = 20;

            return View();

            //return RedirectToAction(nameof(Detail));
        }

        public IActionResult All()
        {
            var students = new List<Student>
            {
                new Student {Id = 1, Name = "Emil", Surname = "Kerimov"},
                new Student {Id = 2, Name = "Idris", Surname = "Jafarzade"},
                new Student {Id = 3, Name = "Azim", Surname = "Memmedov"},
            };

            return Json(students);
        }

        public IActionResult Detail(int? id)
        {
            var students = new List<Student>
            {
                new Student {Id = 1, Name = "Emil", Surname = "Kerimov"},
                new Student {Id = 2, Name = "Idris", Surname = "Jafarzade"},
                new Student {Id = 3, Name = "Azim", Surname = "Memmedov"},
            };

            if (id == null)
                return NotFound();

            var student = students.Find(x => x.Id == id);
            if (student == null)
                return NotFound();

            //return View(students);
            return View(student);
        }
    }
}
