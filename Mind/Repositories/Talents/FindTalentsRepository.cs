using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;
using System.Linq;

namespace Mind.Repositories.Talents
{
    public interface IFindTalentsRepository
    {

    }

    public class ExperienceRepository : BaseRepository<SkillsModel>, IFindTalentsRepository
    {

        private readonly ApplicationContext Context;
        private readonly ITalentRepository TalentRepository;
        public ExperienceRepository(ApplicationContext Context
            ITalentRepository TalentRepository;) : base(context)
        {
            this.TalentRepository = TalentRepository;
        }

        #region Interface Base

        public List<TalentModel> GetTop1(VacantionModel model)
        {
            return dbSet.Where(t => t.Contains(model.Skills) && t.Contains(model.Nivels))).FirstOrDefault();
        }
        public List<TalentModel> GetTop2(VacantionModel model)
        {
            return dbSet.Where(t => t.Contains(model.Skills) || t.Contains(model.Nivels))).FirstOrDefault();
        }
        public List<TalentModel> GetTop3(VacantionModel model)
        {
            return dbSet.Where(t => t.Contains(model.Skills)).FirstOrDefault();
        }

        public SkillsModel Add(SkillsModel model)
        {
            throw new NotImplementationException();
        }

        public SkillsModel GetFirst()
        {
            throw new NotImplementationException();
        }

        public SkillsModel GetByCode(int code)
        {
            throw new NotImplementationException();
        }

        public SkillsModel GetByUnique(string unique)
        {
            throw new NotImplementationException();
        }

        public SkillsModel GetById(int id)
        {
            throw new NotImplementationException();
        }

        public SkillsModel GetByName(string name)
        {
            throw new NotImplementationException();
        }

        public void Update(int id, SkillsModel model)
        {
            throw new NotImplementationException();
        }

        public void Update(SkillsModel model)
        {
            throw new NotImplementationException();
        }

        public List<SkillsModel> GetByUser(string unique)
        {
            throw new NotImplementationException();
        }

        public bool Delete(SkillsModel model)
        {
            throw new NotImplementationException();
        }

        public void AddOrUpdate(SkillsModel model)
        {
            throw new NotImplementationException();
        }
        #endregion
    }
}
