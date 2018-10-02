using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.Proof
{
    [Table("Proof_Builds")]
    public class BuildModel : BaseModel, IBaseModel<BuildModel>
    {
        public string Param { get; set; }
        public string Shell { get; set; }

        public void Update(BuildModel model)
        {
            throw new NotImplementedException();
        }
    }
}
