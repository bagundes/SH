using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mind.Models.Proof
{
    [Table("Proof_Proofs")]
    public class ProofModel : BaseModel, IBaseModel<ProofModel>
    {
        public int Version { get; set; }
        public Enums.Difficult Difficult { get; set; }
        public BuildModel Build { get; set; }
        public string Skills { get; set; }

        public int Hits { get; set; }
        public int Errors { get; set; }
        public int Skips { get; set; }

        public string Question { get; set; }
        public string InputFormat { get; set; }
        public string OutputFormat { get; set; }
        public string SampleOutput { get; set; }
        public Enums.Proof_Answer Answer {get; set; }

        public string StrCode { get; set; }
        public string StdOut { get; set; }

        public void Update(ProofModel model)
        {
            throw new NotImplementedException();
        }
        public override void ModelCreating(ModelBuilder modelBuilder)
        {
            base.ModelCreating(modelBuilder);
            var e = modelBuilder.Entity<ProofModel>();
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            var model = new ProofModel();
            model.ModelCreating(modelBuilder);
        }
    }
}
