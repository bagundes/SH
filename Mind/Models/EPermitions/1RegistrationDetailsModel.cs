using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_1RegistrationDetail")]
    public class RegistrationDetailsModel : BaseModel, IBaseModel<RegistrationDetailsModel>
    {
        public string EmployerRegNumber1 { get; set; }
        public string CompanyRegNumber2 {get;set;}
        public string BusinessRegdNumber3 { get; set; }
        public string CharityNumber4 { get; set; }
        public string SocietyRegNumber5 { get; set; }
        public string LimitedCompany6 { get; set; }
        public string NameCompany7 { get; set; }
        public string TradingName8 { get; set; }
        public string NatureBusiness9 { get; set; }
        public string Address110 { get; set; }
        public string Address210 { get; set; }
        public string Town10 { get; set; }
        public string Postcode10 { get; set; }
        public string Country10 { get; set; }
        public string PhoneNumber10 { get; set; }
        public string MobileNumber10 { get; set; }
        public string Email10 { get; set; }
        public string Website10 { get; set; }
        public string EEA11 { get; set; }
        public string NoEEA12 { get; set; }
        public string Title13 { get; set; }
        public string Name13 { get; set; }
        public string Position13 { get; set; }
        public string Phone13 { get; set; }
        public string Mobile13 { get; set; }
        public string Email13 { get; set; }

        public void Update(RegistrationDetailsModel model)
        {
            base.Update(model);
            EmployerRegNumber1 = model.EmployerRegNumber1;
            CompanyRegNumber2 = model.CompanyRegNumber2;
            BusinessRegdNumber3 = model.BusinessRegdNumber3;
            CharityNumber4 = model.CharityNumber4;
            SocietyRegNumber5 = model.SocietyRegNumber5;
            LimitedCompany6 = model.LimitedCompany6;
            NameCompany7 = model.NameCompany7;
            TradingName8 = model.TradingName8;
            NatureBusiness9 = model.NatureBusiness9;
            Address110 = model.Address110;
            Address210 = model.Address210;
            Town10 = model.Town10;
            Postcode10 = model.Postcode10;
            Country10 = model.Country10;
            PhoneNumber10 = model.PhoneNumber10;
            Email10 = model.Email10;
            Website10 = model.Website10;
            EEA11 = model.EEA11;
            NoEEA12 = model.NoEEA12;
            Title13 = model.Title13;
            Name13 = model.Name13;
            Position13 = model.Position13;
            Phone13 = model.Phone13;
            Mobile13 = model.Mobile13;
            Email13 = model.Email13;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<RegistrationDetailsModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new RegistrationDetailsModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
