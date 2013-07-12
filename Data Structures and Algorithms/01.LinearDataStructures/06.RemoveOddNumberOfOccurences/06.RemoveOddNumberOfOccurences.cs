using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveOddNumberOfOccurences
{
    public static void Main()
    {
        Console.WriteLine("Write a sequence of integer numbers separated by space or comma");

        Console.Write("Integers: ");

        string[] userInput = Console.ReadLine().Split(' ', ',');

        List<int> sequence = new List<int>();

        for (int i = 0; i < userInput.Length; i++)
        {
            int number = int.Parse(userInput[i].Trim());
            sequence.Add(number);
        }

        for (int i = 0; i < sequence.Count; i++)
        {
            sequence.RemoveOddNumbers(sequence[i]);
        }

        Console.Write("Removed numbers with odd number of occurences -> ");
        for (int i = 0; i < sequence.Count; i++)
        {
            if (i == sequence.Count - 1)
            {
                Console.Write("{0}", sequence[i]);
                break;
            }
            Console.Write("{0}, ", sequence[i]);
        }
        Console.WriteLine();
    }
}