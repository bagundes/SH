
using Mind.Models.Companies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories.Companies
{
    public interface IVacationRepository: IBaseRepository<CompanyModel>
    {

    }

    public class VacationRepository : BaseRepository<TalentSkillsModel>, IVacationRepository
    {
        public CompanyRepository(ApplicationContext context) : base(context)
        {

        }

        #region Interface Base
        public CompanyModel Add(CompanyModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public CompanyModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public CompanyModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public CompanyModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public CompanyModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public CompanyModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, CompanyModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(CompanyModel model)
        {
            if(base.IsExist(model))
                Update(model.Id, model);
        }

        public List<CompanyModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();

        }

        public bool Delete(CompanyModel model)
        {
           throw new NotImplementation();
        }

        public void AddOrUpdate(CompanyModel model)
        {
            var foo = dbSet.Where(t => t.Id == model.Id || t.Unique == model.Unique).FirstOrDefault();
            if (foo == null)
                Add(model);
            else
                Update(foo.Id, model);
        }
        #endregion
    }
}
