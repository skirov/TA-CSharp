//Sort 3 real values in descending order using nested if statements.
using System;
using System.Collections.Generic;

class SortThreeDescendingNumbers
{
    static void Main()
    {
        int[] numbers = { 4, 12, 5 };
        Array.Sort(numbers);
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}