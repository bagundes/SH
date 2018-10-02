using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mind.Repositories;

namespace Employer.Controllers
{
    public class MainController : Controller
    {
        private IUserRepository userRepository;

        public MainController (IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Models.LoginViewModel model)
        {
            var user = userRepository.GetByLogin(model.Email, model.Passwd);
            if (user == null)
                ViewBag.MsgError = "E-mail or password invalid!";

            return RedirectToAction("Index", "Home");
        }
    }
}