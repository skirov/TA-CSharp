//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
using System;

class BinarySearchAlgorithm
{
    static void BinarySearch(int[] array, int number, int min, int max)
    {
        if (min > max)
        {
            Console.WriteLine("No such number in array.");
            return;
        }
        int middleElement = (min + max) / 2;

        if (number > array[middleElement])
        {
            min = middleElement + 1;
        }
        else if (number < array[middleElement])
        {
            max = middleElement - 1;
        }
        else if (number == array[middleElement])
        {
            Console.WriteLine(middleElement);
            return;
        }
        BinarySearch(array, number, min, max);
    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 5, 6, 7, 8 };

        Array.Sort(array); //Binary Search works only on sorted arrays

        BinarySearch(array, 4, 0, array.Length - 1);
    }
}