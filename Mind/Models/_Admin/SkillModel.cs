using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models._Admin
{
    [Table("Skills")]
    public class SkillModel : BaseModel, IBaseModel<SkillModel>
    {
        public string Skill { get; set; }
        public Enums.Skill_Type Type { get; set; }
        
        public void Update(SkillModel model)
        {
            base.Update(model);
            Skill = model.Skill;
            Type = model.Type;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new SkillModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
