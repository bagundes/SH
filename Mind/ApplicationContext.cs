using Microsoft.EntityFrameworkCore;

namespace Mind
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Models._Admin.AddressModel.OnModelCreating(modelBuilder);
            Models._Admin.CountryModel.OnModelCreating(modelBuilder);
            Models._Admin.FormationModel.OnModelCreating(modelBuilder);
            Models._Admin.SkillModel.OnModelCreating(modelBuilder);
            Models.UserModel.OnModelCreating(modelBuilder);
            Models.Companies.CompanyModel.OnModelCreating(modelBuilder);
            Models.Talents.TalentModel.OnModelCreating(modelBuilder);
            Models.Talents.ProjectModel.OnModelCreating(modelBuilder);
            Models.Talents.ProfileModel.OnModelCreating(modelBuilder);
            Models.Talents.ExperienceModel.OnModelCreating(modelBuilder);
            Models.Talents.EducationModel.OnModelCreating(modelBuilder);
            Models.EPermitions.DetailsEmploymentModel.OnModelCreating(modelBuilder);
            Models.EPermitions.DetailsOfForeignNationalModel.OnModelCreating(modelBuilder);
            Models.EPermitions.DetailsRedundancyModel.OnModelCreating(modelBuilder);
            Models.EPermitions.DetailsRemunerationModel.OnModelCreating(modelBuilder);
            Models.EPermitions.FinalDetailsModel.OnModelCreating(modelBuilder);
            Models.EPermitions.IntrodutionModel.OnModelCreating(modelBuilder);
            Models.EPermitions.RegistrationDetailsModel.OnModelCreating(modelBuilder);
        }
    }
}
