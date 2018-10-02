using System;
using System.Collections.Generic;
using System.Text;
using Mind.Repositories.EPermitions;
namespace Mind.Models.EPermitions
{
    public class FinalReportViewModel
    {
        private readonly IIntrodutionRepository Introdution;
        private readonly IRegistrationDetailsRepository RegistrationDetails;
        private readonly IDetailsOfForeignNationalRepository DetailsOfForeign;
        private readonly IDetailsRedundancyRepository DetailsRedundancy;
        public IntrodutionModel oIntrodutionModel;
        public RegistrationDetailsModel oRegistrationDetailsModel;
        public DetailsOfForeignNationalModel oDetailsOfForeignNationalModel;
        public DetailsRedundancyModel oDetailsRedundancyModel;

        public FinalReportViewModel(IIntrodutionRepository introdution, IRegistrationDetailsRepository registrationDetails, IDetailsOfForeignNationalRepository detailsOfForeign, IDetailsRedundancyRepository detailsRedundancy)
        {
            Introdution = introdution;
            RegistrationDetails = registrationDetails;
            DetailsOfForeign = detailsOfForeign;
            DetailsRedundancy = detailsRedundancy;
        }

        public void Loader(string unique)
        {
            //oIntrodutionModel = Introdution.GetByUnique(unique);
            //oRegistrationDetailsModel = RegistrationDetails.GetByUnique(unique);
            //oDetailsOfForeignNationalModel = DetailsOfForeign.GetByUnique(unique);
            //oDetailsRedundancyModel = DetailsRedundancy.GetByUnique(unique);
            oIntrodutionModel = Introdution.GetFirst();
            oRegistrationDetailsModel = RegistrationDetails.GetFirst();
            oDetailsOfForeignNationalModel = DetailsOfForeign.GetFirst();
            oDetailsRedundancyModel = DetailsRedundancy.GetFirst();
        }
    }
}
