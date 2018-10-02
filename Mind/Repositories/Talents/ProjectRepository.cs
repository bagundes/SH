using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface IProjectRepository : IBaseRepository<ProjectModel>
    {

    }

    public class ProjectRepository : BaseRepository<ProjectModel>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {

        }

        #region Interface Base
        public ProjectModel Add(ProjectModel model)
        {
            dbSet.Add(model);
            context.SaveChanges();

            return model;
        }

        public ProjectModel GetFirst()
        {
            return dbSet.FirstOrDefault();
        }

        public ProjectModel GetByCode(int code)
        {
            return dbSet.Where(t => t.Code == code).FirstOrDefault();
        }

        public ProjectModel GetByUnique(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).FirstOrDefault();
        }

        public ProjectModel GetById(int id)
        {
            return dbSet.Where(t => t.Id == id).FirstOrDefault();
        }

        public ProjectModel GetByName(string name)
        {
            return dbSet.Where(t => t.Name == name).FirstOrDefault();
        }

        public void Update(int id, ProjectModel model)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                throw new System.Exception($"This is Id:{id} not exists");
            foo.Update(model);
            context.SaveChanges();
        }

        public void Update(ProjectModel model)
        {
            if (base.IsExist(model))
                Update(model.Id, model);
        }

        public List<ProjectModel> GetByUser(string unique)
        {
            return dbSet.Where(t => t.Unique == unique).ToList();
        }

        public bool Delete(ProjectModel model)
        {
            return base.Delete(model);
        }

        public void AddOrUpdate(ProjectModel model)
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
