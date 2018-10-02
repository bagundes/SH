using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mind.Models.Talents
{
    public class EducationModel : BaseModel, IBaseModel<EducationModel>
    {
        public string EducationName { get => Name; set => Name = value; }
        [Required]
        [StringLength(150, MinimumLength = 5)]
        public string Formation { get; set; }
        [Required]
        public Mind.Enums.Talent_LevelEducation Level { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }
        public bool Studing { get; protected set; }
        [Required]
        public int CountryId { get; set; }
        [DataType(DataType.Html)]
        public string Comments { get; set; }

        public void Update(EducationModel model)
        {
            base.Update(model);
            Formation = model.Formation;
            DateEnd = model.DateEnd;
            if (DateEnd.CompareTo(DateTime.Now) == 1)
                Studing = true;
            else
                Studing = false;

            Level = model.Level;
            CountryId = model.CountryId;
            Comments = model.Comments;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<EducationModel>();
            e.Ignore(t => t.EducationName);

        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new EducationModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
