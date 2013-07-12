using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The course must have a name.")]
        public void CourseName_ThrowException()
        {
            Course course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "The students are already 30. You must remove one, before you can add.")]
        public void CourseList_ThrowException_MoreThan30Students()
        {
            Course course = new Course("Math");

            Random uniqueID = new Random();

            for (int i = 0; i < 50; i++)
            {
                Student student = new Student("Ivan", uniqueID.Next(10000, 99999));
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "There is already a student with the same unique ID number.")]
        public void CourseList_ThrowException_StudentAlreadyExists()
        {
            Course course = new Course("Math");

            int uniqueID = 11111;

            Student student = new Student("Ivan", uniqueID);
            Student student2 = new Student("Georgi", uniqueID);

            course.AddStudent(student);
            course.AddStudent(student2);
        }
    }
}
