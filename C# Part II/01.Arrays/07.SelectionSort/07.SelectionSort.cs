using System;
using System.Collections.Generic;
using Sorting;

namespace Sorting
{
    static class Selection
    {
        static int[] SelectionSort(this int[] array)
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
            return array;
        }

        static void Main()
        {
            int[] array = { 1, 4, 5, 6, 2, 3, 4, 6, 7, 0 };

            array.SelectionSort();

            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}