using System;
using System.Collections.Generic;
using System.Linq;

public static class Utils
{
    public static Dictionary<int, int> CountNumberOccurences(this int[] array)
    {
        Dictionary<int, int> numberOfOccurences = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (numberOfOccurences.ContainsKey(array[i]))
            {
                numberOfOccurences[array[i]]++;
            }
            else
            {
                numberOfOccurences.Add(array[i], 1);
            }
        }

        return numberOfOccurences;
    }
}