//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentElement
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        Dictionary<int, int> elementsInArray = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (elementsInArray.ContainsKey(array[i]))
            {
                elementsInArray[array[i]] += 1;
            }
            else
            {
                elementsInArray.Add(array[i], 1);
            }
        }
        int number = elementsInArray.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        int count = elementsInArray.Max(x => x.Value);
        Console.WriteLine("{0} ({1} times)", number, count);
    }
}