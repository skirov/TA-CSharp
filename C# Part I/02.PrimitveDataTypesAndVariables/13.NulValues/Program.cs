//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, 
//try to add some values or the null literal to them and see the result.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;
        Console.WriteLine("_{0}_", nullableInt);
        Console.WriteLine("_{0}_", nullableDouble);
    }
}