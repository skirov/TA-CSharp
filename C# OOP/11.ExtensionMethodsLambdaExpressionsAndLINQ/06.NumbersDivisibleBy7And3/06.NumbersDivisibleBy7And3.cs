using System;
using System.Linq;

class NumbersDivisibleBy7And3
{
    static void Main()
    {
        int[] numbers = { 441, 125, 12, 125, 612, 21, 42 };

        //With Lambda
        Console.WriteLine("With lambda");
        var devisibleBy7And3 = numbers.Select(x => x).Where(x => (x % 3 == 0) && (x % 7 == 0));

        foreach (var number in devisibleBy7And3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        //With lambda
        Console.WriteLine("With LINQ");
        var devisibleBy7And3LINQ =
            from number in numbers
            where (number % 3 == 0) && (number % 7 == 0)
            select number;

        foreach (var number in devisibleBy7And3LINQ)
        {
            Console.WriteLine(number);
        }
    }
}

