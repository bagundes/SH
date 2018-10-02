using System;
using System.Collections.Generic;
using System.Text;
using Mind.Repositories.Talents;

namespace Mind.Models.Talents
{
    public class ResumeViewModel : BaseViewModel
    {
        public readonly List<TalentModel> Talents;
        public readonly List<ExperienceModel> Experiences;
        public readonly List<EducationModel> Educations;
        public readonly List<ProfileModel> Profiles;
        public readonly List<ProjectModel> Projects;

        public ResumeViewModel(List<TalentModel> talent, 
            List<ExperienceModel> experiences, 
            List<EducationModel> educations,
            List<ProfileModel> profiles, 
            List<ProjectModel> projects)
        {
            Talents = talent ?? new List<TalentModel>();
            Experiences = experiences ?? new List<ExperienceModel>();
            Educations = educations ?? new List<EducationModel>();
            Profiles = profiles ?? new List<ProfileModel>();
            Projects = projects ?? new List<ProjectModel>();
        }
    }
}
