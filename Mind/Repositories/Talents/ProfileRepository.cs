using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface IProfileRepository : IBaseRepository<ProfileModel>
    {

    }

    public class ProfileRepository : BaseRepository<ProfileModel>, IProfileRepository
    {
        public ProfileRepository(ApplicationContext context) : base(context)
        {

        }

        #region Interface Base
        public ProfileModel Add(ProfileModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public ProfileModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public ProfileModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public ProfileModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public ProfileModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public ProfileModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, ProfileModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(ProfileModel model)
        {
            if (base.IsExist(model))
                Update(model.Id, model);
        }

        public List<ProfileModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(ProfileModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(ProfileModel model)
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
