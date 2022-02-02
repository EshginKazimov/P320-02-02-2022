using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }

        public string Create()
        {
            return "Home Create";
        }

        public string Detail(int? id)
        {
            return $"Student number {id}";
        }

        public ViewResult Update()
        {
            var viewResult = new ViewResult();
            viewResult.ViewName = "Update";

            return viewResult;
        }
    }
}
