using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Employer.Controllers
{
    public class VacancyController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult VacancyCard()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create2()
        {
            return View();
        }
    }
}