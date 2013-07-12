//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }
        Console.WriteLine(prime); 
    }
}