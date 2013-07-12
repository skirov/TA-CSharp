//Write a program that prints all the numbers from 1 to N.
using System;
using System.Collections.Generic;

class NumbersFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}