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

        sequence.Sort();

        Console.Write("Sorted numbers in increasing order -> ");
        for (int i = 0; i < sequence.Count; i++)
        {
            if (i == sequence.Count-1)
            {
                Console.Write("{0}", sequence[i]);
                break;
            }
            Console.Write("{0}, ", sequence[i]);
        }
        Console.WriteLine();
    }
}

