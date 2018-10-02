using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_3DetailsRedundancy")]
    public class DetailsRedundancyModel : BaseModel, IBaseModel<DetailsRedundancyModel>
    {
        public string EmployeerPerson1 { get; set; }

        public void Update(DetailsRedundancyModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<DetailsRedundancyModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new DetailsRedundancyModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
