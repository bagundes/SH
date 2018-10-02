using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface IExperienceRepository : IBaseRepository<ExperienceModel>
    {

    }

    public class ExperienceRepository : BaseRepository<ExperienceModel>, IExperienceRepository
    {
        public ExperienceRepository(ApplicationContext context) : base(context)
        {
            
        }

        #region Interface Base
        public ExperienceModel Add(ExperienceModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public ExperienceModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public ExperienceModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public ExperienceModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public ExperienceModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public ExperienceModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, ExperienceModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(ExperienceModel model)
        {
            if (base.IsExist(model))
                Update(model.Id, model);
        }

        public List<ExperienceModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(ExperienceModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(ExperienceModel model)
        {
            var foo = dbSet.Where(t => t.Id == model.Id || t.Unique == t.Unique).FirstOrDefault();
            if (foo == null)
                Add(model);
            else
                Update(foo.Id, model);
        }
        #endregion
    }
}
