using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models._Admin
{
    [Table("Addresses")]
    public class AddressModel : BaseModel, IBaseModel<AddressModel>
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public int CountryId { get; set; }

        public void Update(AddressModel model)
        {
            base.Update(model);
            Address1 = model.Address1;
            Address2 = model.Address2;
            City = model.City;
            Postcode = model.Postcode;
            CountryId = model.CountryId;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<AddressModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new AddressModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
