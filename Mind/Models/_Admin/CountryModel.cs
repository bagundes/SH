using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models._Admin
{
    [Table("Contries")]
    public class CountryModel : BaseModel, IBaseModel<CountryModel>
    {
        public string Country { get => Name; }
        public string Abbrev { get; set; }

        public void Update(CountryModel model)
        {
            base.Update(model);
            Abbrev = model.Abbrev;
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<CountryModel>();
            e.HasIndex(t => t.Abbrev).IsUnique();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new CountryModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
