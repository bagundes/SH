using System;
using System.Collections.Generic;
using System.Text;

namespace Mind
{
    public class Enums
    {
        #region Skills
        public enum Skill_Type
        {
            Language = 10,
            Especialization = 20,
        }
        public enum Skill_Nivel
        {
            Knowledge = 10,
            Experiente = 20,
            Differential = 30,
        }

        public enum Skill_Level
        {
            /// <summary>
            /// No experience
            /// </summary>
            Intern = 10,
            /// <summary>
            /// Between 1 and 3
            /// </summary>
            Junior = 20,
            /// <summary>
            /// Between 3 and 5
            /// </summary>
            Middle = 30,
            /// <summary>
            /// 5 or more
            /// </summary>
            Senior = 40,
        }
        #endregion

        #region Proof
        public enum Proof_Answer
        {
            Code = 1,
            Choise = 2,
            MultipleChoise = 3
        }
        #endregion

        #region User
        public enum User_Type
        {
            Talent = 10,
            Employer = 20,
        }
        #endregion

        #region Talents
        public enum Talent_LevelEducation
        {
            FreeCourse = 10,
            Degree = 20,
            Certification = 30,
            Master = 40,
            Doctoral = 50,

        }
        #endregion

        #region Others
        public enum Contract
        {
            Undetermined = 10,
            Contract = 20,
            Intern = 30,
            Freelance = 40,
        }

        public enum Difficult
        {
            VeryEasy = 10,
            Easy = 20,
            Medium = 30,
            Hard = 40,
            VeryHard = 50
        }
        public enum Build
        {
            Python3 = 1100,
            CSharpCore2 = 2100,
            OpenJDK10 = 3100,
        }
        public enum Sex
        {
            Male = 10,
            Female = 20,
            Others = 99,
        }
        public enum Nivel
        {
            None = 10,
            Basic = 20,
            Intermediary = 30,
            Advanced = 40,

        }
        #endregion




    }
}
