using System;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string nameOfDicipline, int numberOfLectures, int numberOfExercises)
        {
            this.name = nameOfDicipline;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        #region Properties

        public string Name
        {
            get { return this.name; }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
        }

        public string Comments { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Add a comment to this discipline
        /// </summary>
        /// <param name="text"></param>
        public void AddComment(string text)
        {
            Comments = text;
        }

        /// <summary>
        /// View the comment for this discipline (if there is any)
        /// </summary>
        public void ViewComments()
        {
            if (String.IsNullOrWhiteSpace(this.Comments))
            {
                Console.WriteLine("Dicsipline {0} has no comments.", this.Name);
            }
            else
            {
                Console.WriteLine("Dicsipline {0} has a comment - \"{1}\" ", this.Name, this.Comments);
            }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder disciplineInfo = new StringBuilder();
            disciplineInfo.AppendFormat("{0}, {1} Lectures, {2} Exercices", Name, NumberOfLectures, NumberOfLectures);
            return disciplineInfo.ToString();
        }
    }
}