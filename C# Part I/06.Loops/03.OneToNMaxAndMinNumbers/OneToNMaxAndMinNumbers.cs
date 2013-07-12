//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
using System;
using System.Collections.Generic;

class OneToNMaxAndMinNumbers
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        int[] allNumbers = new int[userInput];
        for (int i = 0; i < userInput; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            allNumbers[i] = currentNumber;
        }
        Array.Sort(allNumbers); //Sort the array
        Console.WriteLine("Biggest: {0}", allNumbers[0]); //Print the first element
        Console.WriteLine("Smallest: {0}", allNumbers[allNumbers.Length - 1]); //Print the last element
    }
}