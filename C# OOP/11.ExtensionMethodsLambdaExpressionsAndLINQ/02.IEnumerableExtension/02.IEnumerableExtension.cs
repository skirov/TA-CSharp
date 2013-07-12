using System;
using System.Collections.Generic;

public static class IEnumerableExtension
{
   
    static void Main()
    {
        long[] numbers = { 125,6,72,1,12,1,6171,12,3 };

        foreach (var number in numbers)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();

        Console.WriteLine("The biggest number is {0}", numbers.Max<long>());
        Console.WriteLine("The smalles number is {0}", numbers.Min<long>());
        Console.WriteLine("The average is {0}", numbers.Average<long>());
        Console.WriteLine("The product is {0}", numbers.Product<long>());
        Console.WriteLine("The sum is {0}", numbers.Sum<long>());
    }
}

