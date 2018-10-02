using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_4DetailsEmployment")]
    public class DetailsEmploymentModel : BaseModel, IBaseModel<DetailsEmploymentModel>
    {
        public string TitleJob1 { get; set; }
        public string HealthProfessional2 { get; set; }
        public string RegulatoryBody3 { get; set; }
        public string EmploymentAddress4 { get; set; }
        public string BusinessName4 { get; set; }
        public string Town4 { get; set; }
        public string Postcode4 { get; set; }
        public string Country4 { get; set; }
        public int Period5 { get; set; }
        public DateTime StartDate6 { get; set; }
        public string Functions7 { get; set; }
        public string Qualifications9 { get; set; }
        public string Agent10 { get; set; }

        public void Update(DetailsEmploymentModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<DetailsEmploymentModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new DetailsEmploymentModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
