using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.Companies
{
    [Table("Companies")]
    public class CompanyModel : BaseModel, IBaseModel<CompanyModel>
    {
        public string NameCompany { get => Name; }
        // TODO : @bfagundes - Ajustar o code
        public override int Code { get => int.Parse(DateTime.Now.ToString("ffffff")); }
        public string RegisterNumber { get; set; }
        

        public string NatureBusiness { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string Site { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public int CountryId { get; set; }

        public void Update(CompanyModel model)
        {
            base.Update(model);
            RegisterNumber = model.RegisterNumber;
            NatureBusiness = model.NatureBusiness;
            PhoneNumber = model.PhoneNumber;
            Email = model.Email;
            Site = model.Site;
            Address1 = model.Address1;
            Address2 = model.Address2;
            City = model.City;
            Postcode = model.Postcode;
            CountryId = model.CountryId;
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<CompanyModel>();
            e.Ignore(t => t.NameCompany);

        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new CompanyModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
