using System;
using System.Collections.Generic;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("How many elements will you have in the both arrays? ");
        char[] array1 = new char[int.Parse(Console.ReadLine())];

        Console.WriteLine("Elements of first array");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write("[{0}]: ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }

        char[] array2 = new char[array1.Length];

        Console.WriteLine("Elements of second array");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write("[{0}]: ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] > array2[i])
            {
                Console.WriteLine("{0} is after {1}", array1[i], array2[i]);
            }
            else if (array1[i] < array2[i])
            {
                Console.WriteLine("{0} is before {1}", array1[i], array2[i]);
            }
            else
            {
                Console.WriteLine("{0}={1}", array1[i], array2[i]);
            }
        }
    }
}