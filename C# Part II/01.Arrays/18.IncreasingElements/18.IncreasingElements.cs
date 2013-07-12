//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
using System;
using System.Collections.Generic;

class IncreasingElements
{
    static bool isSorted(List<int> list)
    {
        bool isSorted = true;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                isSorted = false;
            }
        }

        return isSorted;
    }
    static void Main()
    {
        List<int> array = new List<int>() { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        List<int> bestResult = new List<int>();
        int lenght = 0;
        int maxElements = 0;

        for (int i = 1; i <= Math.Pow(2, array.Count) - 1; i++)
        {

            List<int> currentResult = new List<int>();

            for (int j = 1; j <= array.Count; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentResult.Add(array[j - 1]);
                    lenght++;
                }
            }
            if (lenght > maxElements && isSorted(currentResult))
            {
                maxElements = lenght;
                bestResult = currentResult;
            }
            lenght = 0;
        }

        foreach (var item in bestResult)
        {
            Console.Write(item);
        }
    }
}