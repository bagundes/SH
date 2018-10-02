using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mind.Repositories.EPermitions;


namespace EmploymentPermits.Models
{
    public class GridView
    {
        public string Form { get; set; }
        public string Talent { get; set; }
        public string Company { get; set; }

        public DateTime Created { get; set; }
        public string Status { get; set; }
    }

    public class ListFormViewModel
    {
        public IDetailsOfForeignNationalRepository ForeignNationalRepository { get; }
        public IDetailsRedundancyRepository DetailsRedundancy { get; }
        public IIntrodutionRepository IntrodutionRepository { get; }
        public IRegistrationDetailsRepository RegistrationDetails { get; }

        public ListFormViewModel(string unique
            , IDetailsOfForeignNationalRepository foreignNationalRepository
            , IDetailsRedundancyRepository detailsRedundancy
            , IIntrodutionRepository introdutionRepository
            , IRegistrationDetailsRepository registrationDetails)
        {
            this.ForeignNationalRepository = foreignNationalRepository;
            this.DetailsRedundancy = detailsRedundancy;
            this.IntrodutionRepository = introdutionRepository;
            this.RegistrationDetails = registrationDetails;


            this.Grid = Load(unique);
        }

        /// <summary>
        /// Load the ViewModel
        /// </summary>
        /// <param name="unique">Inform Unique ID the user</param>
        private List<GridView> Load(string unique)
        {

#if DEBUG
            // HACK - @bfagundes : I'm get the default user because login module is beaing created another module.
            unique = Mind.GlobalConf.UserTest_UNIQUE;
#endif
            var introdutions = IntrodutionRepository.GetByUser(unique);
            var list = new List<GridView>();

            foreach (var introdution in introdutions)
            {
                var grid = new GridView
                {
                    Form = introdution.Name,
                    Talent = introdution.Applicant1,
                    Company = RegistrationDetails.GetByUnique(introdution.Unique).NameCompany7,
                    Created = introdution.CreatedAt,
                    Status = "Indefined"
                };

                list.Add(grid);
            }

            return list;

        }

        public readonly List<GridView> Grid;


    }
}