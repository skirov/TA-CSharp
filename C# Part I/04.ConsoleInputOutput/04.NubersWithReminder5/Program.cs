//Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
//such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int counter = 0;

        while (a <= b)
        {
            if (a % 5 ==0)
            {
                counter++;
            }
            a++;
        }
        Console.WriteLine(counter);

    }
}