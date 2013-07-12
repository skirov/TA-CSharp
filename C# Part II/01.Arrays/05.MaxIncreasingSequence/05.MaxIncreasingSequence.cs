using System;
using System.Collections.Generic;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] array = { 7, 2, 3, 4, 2, 2, 3 };
        int length = 1;
        int maxLength = 1;
        int number = 0;

        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] - array[i - 1] == 1)
            {
                length++;
            }
            else
            {
                length = 1;
            }
            if (length > maxLength)
            {
                maxLength = length;
                number = array[i - 1];
            }
        }

        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0} ", number++);
        }
    }
}