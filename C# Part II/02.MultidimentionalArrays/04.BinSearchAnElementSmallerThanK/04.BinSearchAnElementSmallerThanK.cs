//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch()
//finds the largest number in the array which is ≤ K. 
using System;

class BinSearchAnElementSmallerThanK
{
    static void Main()
    {
        Console.Write("How many elements will the array have? ");
        int[] array = new int[int.Parse(Console.ReadLine())];

        Console.WriteLine("Elements of first array");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        int position = Math.Abs(Array.BinarySearch(array, k)) - 1;

        if (k<array[0])
        {
            Console.WriteLine("The number k is smaller than the smallest element in the array");
            return;
        }

        if (position > array.Length-1)
        {
            Console.WriteLine(array[array.Length - 1]);
            return;
        }

        Console.WriteLine(array[position]);
    }
}