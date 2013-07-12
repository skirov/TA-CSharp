using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Class : IComment
    {
        private List<Teacher> classTeachers = new List<Teacher>();
        private List<Student> classStudents = new List<Student>();
        private string classIdentifier;

        /// <summary>
        ///     Make a new class in the school
        /// </summary>
        /// <param name="uniqueClassIdentifier"></param>
        public Class(string uniqueClassIdentifier)
        {
            this.classIdentifier = uniqueClassIdentifier;
        }


        #region  Properties

        public IReadOnlyCollection<Teacher> ClassTeachers
        {
            get { return this.classTeachers; }
        }

        IReadOnlyCollection<Student> ClassStudents
        {
            get { return this.classStudents; }
        }

        public string ClassIdentifier
        {
            get { return this.classIdentifier; }
        }

        public string Comments { get; set; }

        #endregion


        #region Methods

        /// <summary>
        ///     Add an array of teachers to the class
        /// </summary>
        /// <param name="teachersInfo"></param>
        public void AddTeachers(Teacher[] teachersInfo)
        {
            foreach (var teacher in teachersInfo)
            {
                this.classTeachers.Add(teacher);
            }
        }

        /// <summary>
        ///     Add an array of students to the class
        /// </summary>
        /// <param name="studentsInfo"></param>
        public void AddStudents(Student[] studentsInfo)
        {
            foreach (var student in studentsInfo)
            {
                this.classStudents.Add(student);
            }
        }

        /// <summary>
        /// Add a comment  to that teacher
        /// </summary>
        /// <param name="text"></param>
        public void AddComment(string text)
        {
            Comments = text;
        }

        /// <summary>
        /// View the comment (if there is any) for this teacher
        /// </summary>
        public void ViewComments()
        {
            if (String.IsNullOrWhiteSpace(this.Comments))
            {
                Console.WriteLine("{0} class has no comments.", this.ClassIdentifier);
            }
            else
            {
                Console.WriteLine("{0} class has a comment - \"{1}\" ", this.ClassIdentifier, this.Comments);
            }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder schoolClass = new StringBuilder();

            schoolClass.AppendLine("-Students in class " + ClassIdentifier + " -");
            foreach (var student in ClassStudents)
            {
                schoolClass.AppendFormat("{0} - number {1}", student.Name, student.ClassNumber);
                schoolClass.AppendLine();
            }

            schoolClass.AppendLine("-Teachers of class-");
            foreach (var teacher in ClassTeachers)
            {
                schoolClass.AppendFormat("{0}", teacher.Name);
                schoolClass.AppendLine();
            }

            return schoolClass.ToString();
        }
    }
}