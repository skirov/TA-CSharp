//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        decimal radius = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Area: {0}", (decimal)Math.PI * (radius * radius));
        Console.WriteLine("Perimeter: {0}", 2 * (decimal)Math.PI * radius);
    }
}