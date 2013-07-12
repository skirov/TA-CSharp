using System;
using System.Linq;

class StudentsWithAgeBetween18And24
{
    static void Main()
    {
        var students = new[]
            {
                new { FirstName = "Ivan", LastName = "Mihailov", Age = 18},
                new { FirstName = "Kiril", LastName = "Ivanov", Age = 25},
                new { FirstName = "Asen", LastName = "Dimitrov", Age = 24},
                new { FirstName = "Pavel", LastName = "Stoianov", Age = 16}
            };

        var selectByName =
            from name in students
            where name.Age >= 18 && name.Age <= 24
            select name;

        Console.WriteLine("Students with age between 18 and 24");
        foreach (var student in selectByName)
        {
            Console.WriteLine("{0} {1} - {2} years of age", student.FirstName, student.LastName, student.Age);
        }
    }
}

