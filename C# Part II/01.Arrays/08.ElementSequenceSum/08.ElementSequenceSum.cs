//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?
using System;
using System.Collections.Generic;

class ElementSequenceSum
{
    static void Main()
    {
        int[] array = { -3, -2, -1, -6, -1, -9 };
        int sum = 0;
        int bestSum = int.MinValue;
        int startElement = 0;
        int printStart = 0; //for printing the array
        int printEnd = 0; //for printing the array

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum > bestSum)
            {
                printStart = startElement; //get the element from which we start printing
                printEnd = i; //get the element at which we end printing
                bestSum = sum;
            }
            //increase the startIndex if the end of the array is reached
            if (i == array.Length - 1)
            {
                sum = 0;
                startElement++;
                if (startElement == array.Length)
                {
                    break;
                }
                i = startElement - 1; //-1, because we have a i++ in the for loop
            }
        }

        //print array
        for (int i = printStart; i <= printEnd; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.Write("-> {0}", bestSum);
    }
}