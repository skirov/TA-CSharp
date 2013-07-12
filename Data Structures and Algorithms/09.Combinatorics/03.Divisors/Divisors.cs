using System;
using System.Linq;
using System.Collections.Generic;

class Divisors
{
    static Dictionary<int, int> result = new Dictionary<int, int>();
    static int divisors = 0;

    public static void GetFactorCount(string[] array)
    {
        int numberToCheck = int.Parse(String.Join("", array));
        int sqrt = (int)Math.Ceiling(Math.Sqrt(numberToCheck));

        for (int i = 1; i < sqrt; i++)
        {
            if (numberToCheck % i == 0)
            {
                divisors += 2;
            }
        }
        if (sqrt * sqrt == numberToCheck)
        {
            divisors++;
        }

        if (result.ContainsKey(divisors))
        {
            if (result[divisors] > numberToCheck)
            {
                result[divisors] = numberToCheck;
            }
        }
        else
        {
            result.Add(divisors, numberToCheck);
        }


        divisors = 0;
    }

    private static void Swap(ref string a, ref string b)
    {
        string tmp = a;

        a = b;
        b = tmp;
    }

    private static void Permute(string[] array, int k)
    {
        if (k >= array.Length)
        {
            GetFactorCount(array);
        }
        else
        {
            Permute(array, k + 1);
            for (int i = k + 1; i < array.Length; i++)
            {
                Swap(ref array[k], ref array[i]);
                Permute(array, k + 1);
                Swap(ref array[k], ref array[i]);
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        Permute(array, 0);

        Console.WriteLine(result.OrderBy(kvp => kvp.Key).First().Value);
    }
}