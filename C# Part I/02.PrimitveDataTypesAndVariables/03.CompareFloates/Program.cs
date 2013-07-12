//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) 
// false;  (5.00000001 ; 5.00000003)  true

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        float firstNumber = 1.1234567F;
        float secondNumber = 1.1234561F;
        Console.WriteLine("First number: {0}; Second number:{1}", firstNumber, secondNumber);
        Console.WriteLine("Is equal: {0}",Math.Abs(firstNumber-secondNumber) < 1e-6);
    }
}