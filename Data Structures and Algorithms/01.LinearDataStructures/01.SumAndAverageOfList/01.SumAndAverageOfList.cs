using System;
using System.Collections.Generic;
using System.Linq;

public class SumAndAverageOfList
{
    public static void Main()
    {
        Console.WriteLine("Write a sequence of integer numbers separated by space or comma");

        Console.Write("Integers: ");

        string[] userInput = Console.ReadLine().Split(' ', ',');

        List<int> sequence = new List<int>();

        for (int i = 0; i < userInput.Length; i++)
        {
            sequence.Add(int.Parse(userInput[i]));
        }

        Console.WriteLine("Average of numbers in sequence -> {0}", sequence.Average());
        Console.WriteLine("Sum of numbers in sequence -> {0}", sequence.Sum());
    }
}

