using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mind.Models.Talents
{
    public class ExperienceModel : BaseModel, IBaseModel<ExperienceModel>
    {
        public string Company { get; set; }
        public _Admin.FormationModel Formation { get; set; }
        [StringLength(150, MinimumLength = 1)]
        public string Function { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateEnd { get; set; }
        public int Years {
            get
            {
                var dateEnd = DateTime.Now;
                if (DateEnd != null)
                    dateEnd = (DateTime) DateEnd;

                return dateEnd.Subtract(DateStart).Days / 365;
            }
        }
        public int CountryId { get; set; }
        public string Skills { get; set; }
        [DataType(DataType.Html)]
        public string Description { get; set; }

        public void Update(ExperienceModel model)
        {
            base.Update(model);
            Company = model.Company;
            Formation = model.Formation;
            Function = model.Function;
            DateStart = model.DateStart;
            DateEnd = model.DateEnd;
            CountryId = model.CountryId;
            Description = model.Description;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<ExperienceModel>();
            e.Ignore(t => t.Years);

        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new ExperienceModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
