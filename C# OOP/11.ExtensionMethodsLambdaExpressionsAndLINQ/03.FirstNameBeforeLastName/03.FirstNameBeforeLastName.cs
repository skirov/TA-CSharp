using System;
using System.Linq;

class FirstNameBeforeLastName
{
    static void Main()
    {
        var students = new[]
            {
                new { FirstName = "Ivan", LastName = "Mihailov"},
                new { FirstName = "Kiril", LastName = "Ivanov"},
                new { FirstName = "Asen", LastName = "Dimitrov"},
                new { FirstName = "Pavel", LastName = "Stoianov"}
            };

        var selectByName =
            from name in students
            where name.FirstName.CompareTo(name.LastName) == -1
            select name;

        Console.WriteLine("Students whose first name is before its last name alphabetically");
        foreach (var student in selectByName)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}

