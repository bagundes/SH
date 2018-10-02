
using Mind.Models.EPermitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories.EPermitions
{
    public interface IIntrodutionRepository : IBaseRepository<IntrodutionModel>
    {

    }

    public class IntrodutionRepository : BaseRepository<IntrodutionModel>, IIntrodutionRepository
    {
        public IntrodutionRepository(ApplicationContext context) : base(context)
        {

        }

        public IntrodutionModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public IntrodutionModel Add(IntrodutionModel model)
        {
            model.Name = model.Name ?? Mind.libs.Security.NewKey();
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        

        public IntrodutionModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public IntrodutionModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public IntrodutionModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public IntrodutionModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, IntrodutionModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(IntrodutionModel model)
        {
            throw new NotImplementedException();
        }

        public List<IntrodutionModel> GetByUser(string unique)
        {
            if (unique != null && unique == GlobalConf.UserTest_UNIQUE)
                return dbSet.ToList();
            else
                return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(IntrodutionModel model)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(IntrodutionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
