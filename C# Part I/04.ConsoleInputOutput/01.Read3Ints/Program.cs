//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(a+b+c);
    }
}