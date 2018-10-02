using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.Talents
{
    [Table("Profiles")]
    public class ProfileModel : BaseModel, IBaseModel<ProfileModel>
    {
        [Required]
        public int FormationId { get; set; }
        [Required]
        public Mind.Enums.Skill_Level Level { get; set; }
        public double Salary { get; set; }
        [DataType(DataType.Date)]
        public DateTime? GoToIreland { get; set; }
        [Required]
        public Mind.Enums.Nivel EnglishNivel { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; }
        public string ContactSkype { get; set; }
        [DataType(DataType.Url)]
        public string ContactLinkedin { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan ContactTime { get; set; }
        
        
        public void Update(ProfileModel model)
        {
            base.Update(model);
            FormationId = model.FormationId;
            Level = model.Level;
            Salary = model.Salary;
            GoToIreland = model.GoToIreland;
            EnglishNivel = model.EnglishNivel;
            ContactEmail = model.ContactEmail;
            ContactPhone = model.ContactPhone;
            ContactSkype = model.ContactSkype;
            ContactLinkedin = model.ContactLinkedin;
            ContactTime = model.ContactTime;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<ProfileModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new ProfileModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
