using Mind.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mind.Repositories
{

    public interface IBaseRepository<T> where T : BaseModel
    {
        T Add(T model);
        void Update(int id, T model);
        void Update(T model);
        void AddOrUpdate(T model);

        bool Delete(T model);
        bool Delete(int id);
        bool Delete(string unique);
        
        List<T> GetByUser(string unique);

        T GetByName(string name);
        T GetByCode(int code);
        T GetByUnique(string unique);
        T GetById(int id);
        T GetFirst();
    }
   

    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext context)
        {
            dbSet = context.Set<T>();
            this.context = context;
        }

        public virtual bool Delete(int id)
        {
            var foo = dbSet.Where(t => t.Id == id).FirstOrDefault();
            if (foo == null)
                return false;
            else
                return Delete(foo);
        }

        public virtual bool Delete(string unique)
        {
            var foo = dbSet.Where(t => t.Unique == unique).FirstOrDefault();
            if (foo == null)
                return false;
            else
                return Delete(foo);
        }

        public virtual bool Delete(BaseModel model)
        {
            var foo = dbSet.Where(t => t.Unique == model.Unique && t.Id == model.Id).FirstOrDefault();
            if (foo == null)
                return false;

            dbSet.Remove(foo);
            var res = context.SaveChanges();

            return res > 0;
        }

        protected bool IsExist(BaseModel model)
        {
            return dbSet.Any(t => t.Id == model.Id && t.Unique == model.Unique);
        }
    }
}
