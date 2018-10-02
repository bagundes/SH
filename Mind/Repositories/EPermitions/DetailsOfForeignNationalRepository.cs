
using Mind.Models.EPermitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories.EPermitions
{
    public interface IDetailsOfForeignNationalRepository : IBaseRepository<DetailsOfForeignNationalModel>
    {

    }

    public class DetailsOfForeignNationalRepository : BaseRepository<DetailsOfForeignNationalModel>, IDetailsOfForeignNationalRepository
    {
        public DetailsOfForeignNationalRepository(ApplicationContext context) : base(context)
        {

        }

        public DetailsOfForeignNationalModel Add(DetailsOfForeignNationalModel model)
        {
            model.Name = model.Name ?? Mind.libs.Security.NewKey();
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public DetailsOfForeignNationalModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public bool Delete(DetailsOfForeignNationalModel model)
        {
            throw new NotImplementedException();
        }

        public DetailsOfForeignNationalModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public DetailsOfForeignNationalModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public DetailsOfForeignNationalModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public DetailsOfForeignNationalModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, DetailsOfForeignNationalModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(DetailsOfForeignNationalModel model)
        {
            throw new NotImplementedException();
        }

        public List<DetailsOfForeignNationalModel> GetByUser(string unique)
        {

            return dbSet.Where(t => t.Unique == unique).ToList();


        }

        public void AddOrUpdate(DetailsOfForeignNationalModel model)
        {
            throw new NotImplementedException();
        }
    }
}
