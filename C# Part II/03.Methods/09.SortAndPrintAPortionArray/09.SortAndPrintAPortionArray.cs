//Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
using System;
using Sorting;

namespace Sorting
{
    static class Selection
    {
        static int[] Sort(this int[] array, int ascOrDesc)
        {
            if (ascOrDesc == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int minElement = i;
                    int tmp = 0;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[minElement])
                        {
                            minElement = j;
                        }
                    }
                    tmp = array[i];
                    array[i] = array[minElement];
                    array[minElement] = tmp;
                }
            }
            else if (ascOrDesc == 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int minElement = i;
                    int tmp = 0;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > array[minElement])
                        {
                            minElement = j;
                        }
                    }
                    tmp = array[i];
                    array[i] = array[minElement];
                    array[minElement] = tmp;
                }
            }
            return array;
        }

        static int[] ReturnPartion(this int[] array, int startIndex)
        {
            for (int i = startIndex; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            return array;
        }

        static void Main()
        {
            int[] array = { 1, 4, 5, 6, 2, 3, 4, 6, 7, 0 };

            array.Sort(0); //0 for ascending, 1 for descending
            array.ReturnPartion(4); //4 is the index from whic we start
        }
    }
}