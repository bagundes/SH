using Mind.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mind.Repositories
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        UserModel GetByLogin(string email, string passwd);
        UserModel GetByToken(string token, string cookie);
    }
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {

        }

        /// <summary>
        /// Verify the user have register in the plataform.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="passwd">Password</param>
        /// <returns>User model</returns>
        public UserModel GetByLogin(string email, string passwd)
        {
            try
            {
                var user = dbSet.Where(t => t.Email == email).FirstOrDefault();
                if (user == null)
                    throw new Exception("User not exist.");

                if(!user.IsValidPasswd(passwd))
                    throw new Exception("Password is not valid.");

                user.Valid = DateTime.Now.AddMinutes(10);
                context.SaveChanges();

                return user;

            } catch(Exception ex)
            {
                return null;
            }
            

        }

        public UserModel GetByToken(string token, string cookie)
        {
            try
            {
                var user = dbSet.Where(
                    t => t.Token == token 
                    && t.Cookie == cookie
                    && t.Valid > DateTime.Now).FirstOrDefault();

                if (user == null)
                    throw new Exception("User logout");

                user.Valid = DateTime.Now.AddMinutes(10);
                context.SaveChanges();

                return user;

            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public UserModel Add(UserModel model)
        {
            model.AddPasswd(model.ValPasswd);

            dbSet.Add(model);
            context.SaveChanges();
            
            return model;
        }

        public bool Delete(UserModel model)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByCode(int code)
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUnique(string Unique)
        {
            throw new NotImplementedException();
        }

        public UserModel GetFirst()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, UserModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel model)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetByUser(string unique)
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

        public void AddOrUpdate(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
