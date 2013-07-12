//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13 …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
using System;
using System.Collections.Generic;

class FirstNNumbersOfFibonacciSequence
{
    static void CalculateFibonacci(int number)
    {
        decimal firstFibNumber = 0;
        decimal secondFibNumber = 1;
        decimal sum;

        for (int i = 0; i < number; i++)
        {
            Console.Write("{0} ", firstFibNumber);

            sum = firstFibNumber + secondFibNumber;
            firstFibNumber = secondFibNumber;
            secondFibNumber = sum;
        }

    }

    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());


        CalculateFibonacci(userInput);
    }
}