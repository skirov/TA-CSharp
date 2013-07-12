using System;
using System.Collections.Generic;
using System.Linq;

public class LongestSubsequenceInList
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

        List<int> longestSubsequence = sequence.GetLongestSubsequence();

        Console.Write("Biggest subsequence -> ");
        for (int i = 0; i < longestSubsequence.Count; i++)
        {
            if (i == longestSubsequence.Count-1)
            {
                Console.Write("{0}", longestSubsequence[i]);
                break;
            }
            Console.Write("{0}, ", longestSubsequence[i]);
        }
        Console.WriteLine();
    }
}

