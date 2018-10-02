using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.Talents
{
    [Table("Talents")]
    public class TalentModel : BaseModel, IBaseModel<TalentModel>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Bithday { get; set; }
        public Mind.Enums.Sex Sex { get; set; } = Mind.Enums.Sex.Others;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        public int NaciontalityId { get; set; }
        /// <summary>
        /// Cidadania européia
        /// </summary>
        public bool EuroCitizen { get; set; } = false;
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public int CountryId { get; set; }

        [NotMapped]
        public _Admin.CountryModel Country { get; set; }
        
        [NotMapped]
        public List<SkillsModel> Skills {get;set;}
        public void Update(TalentModel model)
        {
            base.Update(model);
            FirstName = model.FirstName;
            LastName = model.LastName;
            Bithday = model.Bithday;
            Sex = model.Sex;
            PhoneNumber = model.PhoneNumber;
            Address1 = model.Address1;
            Address2 = model.Address2;
            City = model.City;
            Postcode = model.Postcode;
            CountryId = model.CountryId;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<TalentModel>();

            //e.Property(t => t.Bithday).HasColumnType("Date");
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new TalentModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
