// <copyright file="CoursesDemo.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 03.SoftwareAcademy
// </copyright>
namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the demo of the second task in the 
    /// homework for high quality classes - 03.SoftwareAcademy
    /// </summary>
    internal class CoursesDemo
    {
        /// <summary>
        /// Represent the Main method for execution of
        /// C# console applications 
        /// </summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffSiteCourse offsiteCourse = new OffSiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev", 
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}
