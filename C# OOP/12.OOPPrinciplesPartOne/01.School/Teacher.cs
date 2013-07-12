using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public IReadOnlyCollection<Discipline> AllDiciplines
        {
            get { return disciplines; }
        }

        public Teacher(string teacherName)
        {
            this.Name = teacherName;
        }

        #region Methods

        /// <summary>
        /// Add a discipline that the teacher teaches
        /// </summary>
        /// <param name="discipline"></param>
        public void AddDicipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        /// <summary>
        /// View the comment (if there is any) for this teacher
        /// </summary>
        public void ViewComments()
        {
            if (String.IsNullOrWhiteSpace(this.Comments))
            {
                Console.WriteLine("Teacher {0} has no comments.", this.Name);
            }
            else
            {
                Console.WriteLine("Teacher {0} has a comment - \"{1}\" ", this.Name, this.Comments);
            }
        }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}