using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mind.Models.Talents
{
    public class SkillsModel : BaseModel, IBaseModel<SkillsModel>
    {
        public string Skill { get => Name; set => Name = value; }
        
        [Required]
        public Enums.Skill_Nivel Nivel {get;set;}
        [Required]
        public DateTime LastWork {get;set;}

        public int Experience {get;set;}
        public int ResultTest {get;set;}
        public string Comments { get; set; }


        public void Update(SkillsModel model)
        {
           throw new NotImplementation()
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<SkillsModel>();
            e.Ignore(t => t.EducationName);

        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new SkillsModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
