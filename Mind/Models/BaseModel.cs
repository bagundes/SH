using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mind.Models
{
    public interface IBaseModel<T> where T : BaseModel
    {
        void Update(T model);
        void ModelCreating(ModelBuilder modelBuilder);
    }

    public class BaseModel
    {
        public int Id { get; protected set; }
        public Guid UUID { get; set; } = Guid.NewGuid();
        public virtual int Code { get; set; }
        public virtual String Name { get; set; }

        public bool Actived { get; set; }
        public bool Blocked { get; set; }

        
        public int UserId { get; set; }
        
        public DateTime CreatedAt { get; protected set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdateAt { get; protected set; }
        public int UpdatedUser { get; set; }
        
        public String Unique {
            get
            {
                var zeros = "00000000000000000000000000000000";
                var foo = UUID.ToString("N");

                if (foo.Equals(zeros))
                    return null;
                else
                    return foo;

            }
        }

        public virtual void Update(BaseModel model)
        {
            Code = model.Code;
            Name = model.Name;
            Actived = model.Actived;
            Blocked = model.Blocked;
            UserId = model.UserId;
        }

        public virtual void ModelCreating(ModelBuilder modelBuilder)
        {
            var e = modelBuilder.Entity<BaseModel>();
            e.HasKey(t => t.Id);

            e.HasIndex(t => t.Code).IsUnique();
            e.HasIndex(t => t.Name).IsUnique();

            e.Property(t => t.Id).ValueGeneratedOnAdd().IsRequired(true);
            e.Property(t => t.CreatedAt).ValueGeneratedOnAdd();
            e.Property(t => t.UpdateAt).ValueGeneratedOnAddOrUpdate();
            e.Ignore(t => t.Unique);
        }

    }
}
