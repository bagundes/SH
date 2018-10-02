
using Mind.Models.EPermitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories.EPermitions
{
    public interface IRegistrationDetailsRepository : IBaseRepository<RegistrationDetailsModel>
    {

    }

    public class RegistrationDetailsRepository : BaseRepository<RegistrationDetailsModel>, IRegistrationDetailsRepository
    {
        public RegistrationDetailsRepository(ApplicationContext context) : base(context)
        {

        }

        public RegistrationDetailsModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public RegistrationDetailsModel Add(RegistrationDetailsModel model)
        {
            model.Name = model.Name ?? Mind.libs.Security.NewKey();
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public RegistrationDetailsModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public RegistrationDetailsModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public RegistrationDetailsModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public RegistrationDetailsModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, RegistrationDetailsModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(RegistrationDetailsModel model)
        {
            throw new NotImplementedException();
        }

        public List<RegistrationDetailsModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(RegistrationDetailsModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(RegistrationDetailsModel model)
        {
            throw new NotImplementedException();
        }
    }
}
