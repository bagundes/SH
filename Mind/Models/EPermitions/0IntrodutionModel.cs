using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_0Itrodutions")]
    public class IntrodutionModel : BaseModel, IBaseModel<IntrodutionModel>
    {
        public string Applicant1 { get; set; }
        public string Agent2 { get; set; }

        public void Update(IntrodutionModel model)
        {
            base.Update(model);
            Applicant1 = model.Applicant1;
            Agent2 = model.Agent2;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<IntrodutionModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new IntrodutionModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
