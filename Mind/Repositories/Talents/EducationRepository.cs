using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface IEducationRepository : IBaseRepository<EducationModel>
    {

    }

    public class EducationRepository : BaseRepository<EducationModel>, IEducationRepository
    {
        public EducationRepository(ApplicationContext context) : base(context)
        {

        }

        #region Interface Base
        public EducationModel Add(EducationModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public EducationModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public EducationModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public EducationModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public EducationModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public EducationModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, EducationModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(EducationModel model)
        {
            if (base.IsExist(model))
                Update(model.Id, model);
        }

        public List<EducationModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(EducationModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(EducationModel model)
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
