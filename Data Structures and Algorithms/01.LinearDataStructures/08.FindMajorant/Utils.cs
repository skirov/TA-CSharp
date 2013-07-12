using System;
using System.Collections.Generic;

public static class Utils
{
    public static int FindMajorant(this IList<int> sequence)
    {
        int majorantFormula = (sequence.Count / 2) + 1;
        int counter = 0;

        for (int i = 0; i < sequence.Count; i++)
        {
            for (int j = 0; j < sequence.Count; j++)
            {
                if (sequence[i] == sequence[j])
                {
                    counter++;
                }

                if (counter == majorantFormula)
                {
                    return sequence[i];
                }
            }

            counter = 0;
        }
        return -1;
    }
}