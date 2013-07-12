using System;
using System.Collections.Generic;

class CountNumberOfOccurances
{
    static void Main()
    {
        double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

        SortedDictionary<double, int> set = new SortedDictionary<double, int>();

        Console.WriteLine("Elements in the array");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
            if (set.ContainsKey(array[i]))
            {
                set[array[i]]++;
            }
            else
            {
                set.Add(array[i], 1);
            }
        }
        Console.WriteLine();

        Console.WriteLine("Number of occurences for each element in the array.");
        foreach (var item in set)
        {
            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
        }
    }
}

