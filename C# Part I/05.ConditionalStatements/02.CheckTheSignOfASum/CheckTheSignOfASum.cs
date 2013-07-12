//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
using System;
using System.Collections.Generic;

class CheckTheSignOfASum
{
    static void Main()
    {
        int a = -20;
        int b = 2;
        int c = 23;

        if ((a < 0 && b < 0 && c < 0) 
            || (a < 0 && b > 0 && c > 0) 
            || (a > 0 && b < 0 && c > 0) 
            || (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine('-');
        }
        else
        {
            Console.WriteLine("+");
        }
    }
}