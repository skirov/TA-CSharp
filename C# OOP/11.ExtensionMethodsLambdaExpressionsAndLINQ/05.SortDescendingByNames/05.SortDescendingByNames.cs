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

        //With Lambda
        Console.WriteLine("Order with Lambda");
        var orderByNameLambda = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

        foreach (var student in orderByNameLambda)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        Console.WriteLine();
        //With LINQ
        Console.WriteLine("Order with LINQ");
        var orderByNameLINQ =
            from names in students
            orderby names.FirstName descending
            orderby names.LastName descending
            select names;

        foreach (var student in orderByNameLINQ)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}

