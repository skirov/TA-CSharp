//* We are given an array of integers and a number S. Write a program to find if there exists a subset of the 
//elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSum
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;


        for (int i = 1; i <= Math.Pow(2, array.Length) - 1; i++)
        {

            List<int> currentResult = new List<int>();

            for (int j = 1; j <= array.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentResult.Add(array[j - 1]);
                }
            }
            if (currentResult.Sum() == sum)
            {
                foreach (int number in currentResult)
                {
                    Console.Write("{0} ", number);
                }
                Console.Write("= {0}", sum);
                Console.WriteLine();
            }
        }
    }
}