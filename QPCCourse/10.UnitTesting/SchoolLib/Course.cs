using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLib
{
    public class Course
    {
        private List<Student> studentsInCourse;

        public Course(string courseName) 
        {
            if (string.IsNullOrEmpty(courseName))
            {
                throw new ArgumentNullException("The course must have a name.");
            }

            this.CourseName = courseName;
            this.studentsInCourse = new List<Student>(30);
        }

        public string CourseName
        {
            get;
            private set;
        }

        public IReadOnlyList<Student> StudentsInCourse
        {
            get
            {
                return this.studentsInCourse;
            }
        }

        public void AddStudent(Student student)
        {
            if (StudentsInCourse.Count == 30)
            {
                throw new InvalidOperationException("The students are already 30. You must remove one, before you can add.");
            }

            for (int i = 0; i < StudentsInCourse.Count; i++)
            {
                if (StudentsInCourse[i].UniqueID == student.UniqueID)
                {
                    throw new InvalidOperationException("There is already a student with the same unique ID number.");    
                }
            }

            studentsInCourse.Add(student);
            Console.WriteLine("Student {0} added.", student.Name);
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < StudentsInCourse.Count; i++)
            {
                if (StudentsInCourse[i].UniqueID == student.UniqueID)
                {
                    studentsInCourse.Remove(student);
                    Console.WriteLine("Student {0} removed.", student.Name);
                    return;
                }
            }
            Console.WriteLine("Invalid remove operation. Student not found");
        }
    }
}
