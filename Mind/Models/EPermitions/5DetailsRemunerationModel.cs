using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_5DetailsRemuneration")]
    public class DetailsRemunerationModel : BaseModel, IBaseModel<DetailsRemunerationModel>
    {
        public double GrossAnnualRemuneration1 { get; set; }
        public double GrossAnnualSalary2 { get; set; }
        public double GrossWeeklySalary3 { get; set; }
        public double HourlyRate4 { get; set; }
        public string Deductions5 { get; set; }
        public string Payments6 { get; set; }
        public int HoursWorkWeek7 {get;set;}

        public void Update(DetailsRemunerationModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<DetailsRemunerationModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new DetailsRemunerationModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
