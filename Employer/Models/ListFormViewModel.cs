using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mind.Repositories.EPermitions;


namespace Employer.Models
{
    public class GridView
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
    }

    public class ListFormViewModel
    {
        public IDetailsOfForeignNationalRepository ForeignNationalRepository { get; }
        public IDetailsRedundancyRepository DetailsRedundancy { get; }
        public IIntrodutionRepository IntrodutionRepository { get; }
        public IRegistrationDetailsRepository RegistrationDetails { get; }

        public ListFormViewModel(IDetailsOfForeignNationalRepository foreignNationalRepository
            , IDetailsRedundancyRepository detailsRedundancy
            , IIntrodutionRepository introdutionRepository
            , IRegistrationDetailsRepository registrationDetails)
        {
            this.ForeignNationalRepository = foreignNationalRepository;
            this.DetailsRedundancy = detailsRedundancy;
            this.IntrodutionRepository = introdutionRepository;
            this.RegistrationDetails = registrationDetails;

        }

        public void Load(int userId)
        {
            
        }

        public readonly List<GridView> Grid;


    }
}