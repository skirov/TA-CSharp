//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
using System;

class AllVariationsOfKElements
{
    static int[] result;
    static int n;
    static int k;
    static void Variations(int posInArray)
    {
        if (posInArray == k)
        {
            Print(result);
            Console.WriteLine();
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            result[posInArray] = i;
            Variations(posInArray + 1);
        }
    }

    static void Print(int[] result)
    {
        foreach (var item in result)
        {
            Console.Write("{0} ", item);
        }
    }

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        result = new int[k];
        Variations(0);
    }
}