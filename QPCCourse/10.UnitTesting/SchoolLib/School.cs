using System;
using System.Collections.Generic;

namespace SchoolLib
{
    public class School
    {
        private List<Course> coursesInSchool;

        public School(string schoolName)
        {
            if (string.IsNullOrEmpty(schoolName))
            {
                throw new ArgumentNullException("The school must have a name.");
            }

            this.SchoolName = schoolName;
        }

        public string SchoolName
        {
            get;
            private set;
        }

        public IReadOnlyList<Course> CoursesInSchool
        {
            get
            {
                return this.coursesInSchool;
            }
        }

        public void AddCourse(Course course)
        {
            for (int i = 0; i < CoursesInSchool.Count; i++)
            {
                if (CoursesInSchool[i].CourseName == course.CourseName)
                {
                    throw new InvalidOperationException("There is already a course with the same name.");
                }
            }

            coursesInSchool.Add(course);
            Console.WriteLine("Course {0} added.", course.CourseName);
        }

        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < CoursesInSchool.Count; i++)
            {
                if (CoursesInSchool[i].CourseName == course.CourseName)
                {
                    coursesInSchool.Remove(course);
                    Console.WriteLine("Course {0} removed.", course.CourseName);
                    return;
                }
            }
            Console.WriteLine("Invalid remove operation. Course not found.");
        }
    }
}
