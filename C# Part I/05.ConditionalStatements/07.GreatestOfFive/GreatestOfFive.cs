//Write a program that finds the greatest of given 5 variables.
using System;
using System.Collections.Generic;

class GreatestOfFive
{
    static void Main()
    {
        int[] numbers = {1123,523,1231,5132,4222};

        int biggestNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
            }
        }

        Console.WriteLine(biggestNumber);
    }
}