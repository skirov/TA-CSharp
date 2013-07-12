using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The name of the student can't be null or empty")]
        public void StudentName_ThrowException()
        {
            Student student = new Student("", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The unique id of the student must be between 10000 and 99999.")]
        public void StudentUniqueNumber_ThrowException_9999()
        {
            Student student2 = new Student("Ivan", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The unique id of the student must be between 10000 and 99999.")]
        public void StudentUniqueNumber_ThrowException_100000()
        {
            Student student2 = new Student("Ivan", 100000);
        }

        [TestMethod]
        public void StudentUniqueNumber_10000()
        {
            Student student = new Student("Ivan", 10000);
        }

        [TestMethod]
        public void StudentUniqueNumber_99999()
        {
            Student student = new Student("Ivan", 99999);
        }
    }
}
