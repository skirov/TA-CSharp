using System;
class Permutations
{
    static int n;

    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    private static void Swap(ref int a, ref int b)
    {
        int tmp = a;

        a = b;
        b = tmp;
    }

    private static void Permute(int[] array, int k)
    {
        if (k >= array.Length)
        {
            Print(array);
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
        Console.Write("N=");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Permute(array, 0);
    }
}

