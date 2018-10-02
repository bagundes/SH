using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mind.Models._Admin
{
    public class FormationModel : BaseModel, IBaseModel<FormationModel>
    {
        public string FormationName { get => Name; set => Name = value; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public void Update(FormationModel model)
        {
            model.Update(model);
            Description = model.Description;
        }

        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<FormationModel>();
            e.Ignore(t => t.FormationName);

        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new FormationModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
