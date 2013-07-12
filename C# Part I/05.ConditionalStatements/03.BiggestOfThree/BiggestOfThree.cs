//Write a program that finds the biggest of three integers using nested if statements.
using System;
using System.Collections.Generic;

class BiggestOfThree
{
    static void Main()
    {
        int a = 13;
        int b = 5;
        int c = 7;
        int biggest = Math.Max(a, b);
        biggest = Math.Max(biggest, c);
        Console.WriteLine(biggest);
    }
}