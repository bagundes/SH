using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_2DetailsOfForeignNational")]
    public class DetailsOfForeignNationalModel : BaseModel, IBaseModel<DetailsOfForeignNationalModel>
    {
        public string PassportNumber1 { get; set; }
        public DateTime ExpiryDate2 { get; set; }
        public string National3 { get; set; }
        public string Title4 { get; set; }
        public string FirstName5 { get; set; }
        public string MiddleName6 { get; set; }
        public string FamilyName7 { get; set; }
        public DateTime DateOfBirth8 { get; set; }
        public string Sex9 { get; set; }
        public string Address110 { get; set; }
        public string Address210 { get; set; }
        public string Town10 { get; set; }
        public string Postcode10 { get; set; }
        public string Country10 { get; set; }
        public string Phone11 { get; set; }
        public string MobilePhone12 { get; set; }
        public string PPSNumber13 { get; set; }
        public string Email14 { get; set; }
        public string ForeignNational15 { get; set; }
        public string HighestLevel16 { get; set; }
        public string ForeignNational17 { get; set; }
        public string ForeignNational18 { get; set; }
        public string ForeignNational19 { get; set; }
        public string ForeignNational20 { get; set; }
        public string ForeignNational21 { get; set; }
        public string ForeignNational22 { get; set; }
        public string ForeignNational23 { get; set; }

        public void Update(DetailsOfForeignNationalModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<DetailsOfForeignNationalModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new DetailsOfForeignNationalModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
