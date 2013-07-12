using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumbersWithStack
{
    public static void Main()
    {
        Console.WriteLine("Write a sequence of integer numbers separated by space or comma");

        Console.Write("Integers: ");

        string[] userInput = Console.ReadLine().Split(' ', ',');

        Stack<int> sequence = new Stack<int>();

        for (int i = 0; i < userInput.Length; i++)
        {
            sequence.Push(int.Parse(userInput[i]));
        }

        Console.Write("Reversed sequence -> ");
        while (sequence.Count > 0)
        {
            if (sequence.Count == 1)
            {
                Console.Write("{0}", sequence.Pop());
                break;
            }
            Console.Write("{0}, ", sequence.Pop());
        }
        Console.WriteLine();
    }
}
