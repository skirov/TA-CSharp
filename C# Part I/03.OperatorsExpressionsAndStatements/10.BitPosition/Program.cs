//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
//Example: v=5; p=1  false.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 5;
        sbyte p = 2;
        int mask = 1 << p;
        Console.WriteLine((n&mask)!=0 ? true : false);
    }
}