using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LandPage.Models;
using Microsoft.AspNetCore.Http;
using Mind.Repositories;

namespace LandPage.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IHttpContextAccessor Context;
        protected readonly IUserRepository UserRepository;
        public HomeController(IUserRepository userRepository,
            IHttpContextAccessor context)
        {
            this.Context = context;
            this.UserRepository = userRepository;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("login/sign")]
        public IActionResult Login(Mind.Models.UserModel model = null)
        {
            model = model ?? new Mind.Models.UserModel();

            var modelView = new Models.LoginViewModel()
            {
                Email = model.Email
            };

            return View(modelView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("login/sign")]
        public IActionResult Login(Models.LoginViewModel modelView)
        {
            var user = UserRepository.GetByLogin(modelView.Email, modelView.Passwd);
            
            

            return View();
        }

        [Route("login/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("login/register")]
        public IActionResult Register(Mind.Models.UserModel model)
        {
            UserRepository.Add(model);
            return RedirectToAction("Login", "Home", model);
        }
    }
}
