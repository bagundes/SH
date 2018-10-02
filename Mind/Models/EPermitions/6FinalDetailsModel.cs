using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.EPermitions
{
    [Table("CS_6FinalDetails")]
    public class FinalDetailsModel : BaseModel, IBaseModel<FinalDetailsModel>
    {
        public void Update(FinalDetailsModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<FinalDetailsModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new FinalDetailsModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
