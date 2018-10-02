using System;
using System.Collections.Generic;
using System.Text;
using Mind.Models.Talents;

namespace Mind.Repositories.Talents
{
    class ResumeViewRepository : IBaseViewRepository<ResumeViewModel>
    {
        private readonly ITalentRepository Talent;
        private readonly IEducationRepository Education;
        private readonly IExperienceRepository Experience;
        private readonly IProfileRepository Profile;
        private readonly ProjectRepository Project;

       public ResumeViewRepository(ITalentRepository talent,
           IEducationRepository education,
           IExperienceRepository experience,
           IProfileRepository profile,
           ProjectRepository project)
        {
            this.Talent = talent;
            this.Education = education;
            this.Experience = experience;
            this.Profile = profile;
            this.Project = project;
        }

        /// <summary>
        /// Get informations the user.
        /// </summary>
        /// <param name="unique">User unique</param>
        /// <returns></returns>
        public ResumeViewModel Get(string unique)
        {
            var talents = Talent.GetByUser(unique);
            var educations = Education.GetByUser(unique);
            var experiences = Experience.GetByUser(unique);
            var profiles = Profile.GetByUser(unique);
            var projects = Project.GetByUser(unique);

            return new ResumeViewModel(talents,
                experiences,
                educations,
                profiles,
                projects);
        }

        
    }
}
