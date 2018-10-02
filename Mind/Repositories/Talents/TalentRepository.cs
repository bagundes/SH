using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface ITalentRepository : IBaseRepository<TalentModel>
    {

    }

    public class TalentRepository : BaseRepository<TalentModel>, ITalentRepository
    {
        public TalentRepository(ApplicationContext context) : base(context)
        {

        }

        #region Interface Base
        public TalentModel Add(TalentModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public TalentModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public TalentModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public TalentModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public TalentModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public TalentModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, TalentModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(TalentModel model)
        {
            if (base.IsExist(model))
                Update(model.Id, model);
        }

        public List<TalentModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();

        }

        public bool Delete(TalentModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(TalentModel model)
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
