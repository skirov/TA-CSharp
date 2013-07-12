using System;
using System.Collections.Generic;

class OddNumberOfStrings
{
    static void Main()
    {
        string[] array = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

        Dictionary<string, int> set = new Dictionary<string, int>();

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

        Console.WriteLine("Strings which occur odd number of times in the array");
        foreach (var item in set)
        {
            if (item.Value % 2 != 0)
            {
                Console.Write("{0} ", item.Key);
            }
        }
        Console.WriteLine();
    }
}