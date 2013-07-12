using System;
using System.Collections.Generic;
using System.Linq;

public static class SubsequenceUtils
{
    public static List<int> GetLongestSubsequence(this List<int> sequence)
    {
        List<int> longestSubsequence = new List<int>();

        int subsequenceCount = 1;
        int maxSubsequence = 1;
        int number = 0;

        for (int i = 0; i < sequence.Count-1; i++)
        {
            if (sequence[i] == sequence[i+1])
            {
                subsequenceCount++;
            }
            else
            {
                subsequenceCount = 1;
            }

            if (subsequenceCount >= maxSubsequence)
            {
                maxSubsequence = subsequenceCount;
                number = sequence[i];
            }
        }

        if (maxSubsequence == 1)
        {
            longestSubsequence.Add(sequence[sequence.Count-1]);
            return longestSubsequence;
        }

        for (int i = 0; i < maxSubsequence; i++)
        {
            longestSubsequence.Add(number);
        }

        return longestSubsequence;
    }
}
