//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine(((a+b)/2)*h);
    }
}