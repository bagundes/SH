using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mind.Repositories.EPermitions;

namespace EmploymentPermits.Controllers
{
    public class EPermitsController : Controller
    {
        private readonly IIntrodutionRepository IntrodutionRepository;
        private readonly IRegistrationDetailsRepository RegistrationDetailsRepository;
        private readonly IDetailsOfForeignNationalRepository DetailsOfForeignNationalRepository;
        private readonly IDetailsRedundancyRepository DetailsRedundancyRepository;

        private const string SESSION_EPermits = "EPermits";

        public EPermitsController(
             IIntrodutionRepository introdution
            , IRegistrationDetailsRepository registralDetails
            , IDetailsOfForeignNationalRepository detailsOfForeignNational
            , IDetailsRedundancyRepository detailsRedundancy)
        {
            this.IntrodutionRepository = introdution;
            this.RegistrationDetailsRepository = registralDetails;
            this.DetailsOfForeignNationalRepository = detailsOfForeignNational;
            this.DetailsRedundancyRepository = detailsRedundancy;
        }

        public IActionResult Create()
        {
            //return View();
            return RedirectToAction("Introdution");
        }

        public IActionResult Introdution()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Introdution(Mind.Models.EPermitions.IntrodutionModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
                model = IntrodutionRepository.Add(model);
            else
                IntrodutionRepository.Update(model);

            HttpContext.Session.SetString(SESSION_EPermits,model.Name);

            return RedirectToAction("RegistrationDetails");
        }

        public IActionResult RegistrationDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrationDetails(Mind.Models.EPermitions.RegistrationDetailsModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                model.Name = HttpContext.Session.GetString(SESSION_EPermits);
                RegistrationDetailsRepository.Add(model);
            }
            else
                RegistrationDetailsRepository.Update(model);

            HttpContext.Session.SetString(SESSION_EPermits, model.Name);

            return RedirectToAction("DetailsOfForeignNational");
        }

        public IActionResult DetailsOfForeignNational()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsOfForeignNational(Mind.Models.EPermitions.DetailsOfForeignNationalModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                model.Name = HttpContext.Session.GetString(SESSION_EPermits);
                DetailsOfForeignNationalRepository.Add(model);
            }
            else
                DetailsOfForeignNationalRepository.Update(model);

            HttpContext.Session.SetString(SESSION_EPermits, model.Name);

            return RedirectToAction("DetailsRedundancy");
        }

        public IActionResult DetailsRedundancy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetailsRedundancy(Mind.Models.EPermitions.DetailsRedundancyModel model)
        {
            if (String.IsNullOrEmpty(model.Name))
            {
                model.Name = HttpContext.Session.GetString(SESSION_EPermits);
                DetailsRedundancyRepository.Add(model);
            }
            else
                DetailsRedundancyRepository.Update(model);

            HttpContext.Session.SetString(SESSION_EPermits, model.Name);

            return RedirectToAction("FinalForm");
        }

        public IActionResult FinalForm()
        {
            var finalForm = new Mind.Models.EPermitions.FinalReportModelView(IntrodutionRepository
                , RegistrationDetailsRepository
                , DetailsOfForeignNationalRepository
                , DetailsRedundancyRepository);

            finalForm.Loader(HttpContext.Session.GetString(SESSION_EPermits));

            return View(finalForm);
        }


        public IActionResult Update()
        {
            var model = new Models.ListFormViewModel(Mind.GlobalConf.UserTest_UNIQUE
                , DetailsOfForeignNationalRepository
                , DetailsRedundancyRepository
                , IntrodutionRepository
                , RegistrationDetailsRepository);

            return View(model);
        }
    }
}