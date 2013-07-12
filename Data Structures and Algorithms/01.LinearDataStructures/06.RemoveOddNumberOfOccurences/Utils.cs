using System;
using System.Collections.Generic;
using System.Linq;

public static class Utils
{
    private static bool AppearOddNumberOfTimes(List<int> sequence, int number)
    {
        int numberOfOccurences = 0;

        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] == number)
            {
                numberOfOccurences++;
            }
        }

        if (numberOfOccurences % 2 == 1)
        {
            return true;
        }

        return false;
    }

    public static void RemoveOddNumbers(this List<int> sequence, int number)
    {

        if (AppearOddNumberOfTimes(sequence, number))
        {
            while (sequence.Contains(number))
            {
                sequence.Remove(number);
            }
        }
    }
}

