
using Mind.Models.EPermitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories.EPermitions
{
    public interface IDetailsRedundancyRepository : IBaseRepository<DetailsRedundancyModel>
    {

    }

    public class DetailsRedundancyRepository : BaseRepository<DetailsRedundancyModel>, IDetailsRedundancyRepository
    {
        public DetailsRedundancyRepository(ApplicationContext context) : base(context)
        {

        }


        public DetailsRedundancyModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public DetailsRedundancyModel Add(DetailsRedundancyModel model)
        {
            model.Name = model.Name ?? Mind.libs.Security.NewKey();
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public bool Delete(DetailsRedundancyModel model)
        {
            throw new NotImplementedException();
        }

        public DetailsRedundancyModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public DetailsRedundancyModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public DetailsRedundancyModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public DetailsRedundancyModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, DetailsRedundancyModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(DetailsRedundancyModel model)
        {
            throw new NotImplementedException();
        }

        public List<DetailsRedundancyModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string unique)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdate(DetailsRedundancyModel model)
        {
            throw new NotImplementedException();
        }
    }
}
