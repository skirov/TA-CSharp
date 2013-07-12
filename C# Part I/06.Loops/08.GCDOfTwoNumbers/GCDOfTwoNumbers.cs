//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
using System;
using System.Collections.Generic;

class GCDOfTwoNumbers
{
    static int FindGCD(int a, int b)
    {
        int swap;
        while (b > 0)
        {
            swap = b;
            b = a % b;
            a = swap;
        }
        return a;
    }
    static void Main()
    {
        Console.WriteLine(FindGCD(8, 12));
    }
}