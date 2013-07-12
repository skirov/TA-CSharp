using System;
using System.Collections.Generic;

class AllCombinations
{
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void Combinations(int[] array, int index, int current, int n)
    {
        if (index == array.Length)
        {
            PrintArray(array);
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1, n);
            }
        }
    }

    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[k];
        Combinations(array, 0, 1, n);
    }

}