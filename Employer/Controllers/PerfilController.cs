using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mind.Models.Companies;
using Mind.Repositories.Companies;
namespace Employer.Controllers
{
    public class PerfilController : Controller
    {
        public ICompanyRepository CompanyRepository { get; }

        public PerfilController(ICompanyRepository companyRepository)
        {
            this.CompanyRepository = companyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Company()
        {
            var model = CompanyRepository.GetFirst();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Company(CompanyModel model)
        {
            CompanyRepository.AddOrUpdate(model);
            return RedirectToAction("Company");
        }
    }
}