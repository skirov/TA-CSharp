using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class Student : Person
    {
        private int classNumber;
        private List<int> allStudentsNumbers = new List<int>();

        public Student(string studentName, int studentClassNumber)
        {
            this.Name = studentName;
            this.classNumber = studentClassNumber;
        }

        #region Properties

        public int ClassNumber
        {
            get { return this.classNumber; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// View the comment (if there is any) for this teacher
        /// </summary>
        public void ViewComments()
        {
            if (String.IsNullOrWhiteSpace(this.Comments))
            {
                Console.WriteLine("Student {0} has no comments.", this.Name);
            }
            else
            {
                Console.WriteLine("Student {0} has a comment - \"{1}\" ", this.Name, this.Comments);
            }
        }

        #endregion
    }
}