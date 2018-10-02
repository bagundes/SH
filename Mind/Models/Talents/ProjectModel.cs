using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mind.Models.Talents
{
    public class ProjectModel : BaseModel, IBaseModel<ProjectModel>
    {
        public string Company { get; set; }
        public _Admin.FormationModel Formation { get; set; }
        [StringLength(150, MinimumLength = 1)]
        public string Function { get; set; }
        public int Duration { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
        public int CountryId { get; set; }
        public string Skills { get; set; }
        [DataType(DataType.Html)]
        public string Description { get; set; }

        public void Update(ProjectModel model)
        {
            base.Update(model);
            Company = model.Company;
            Formation = model.Formation;
            Function = model.Function;
            Duration = model.Duration;
            DateEnd = model.DateEnd;
            CountryId = model.CountryId;
            Description = model.Description;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<ProjectModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new ProjectModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
