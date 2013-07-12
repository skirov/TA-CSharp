using System;
class CombinationsWithoutRepetition
{
    static int n;
    static int k;

    private static void Print(int[] array, int length)
    {
        for (int j = 0; j < length; j++)
        {
            Console.Write("{0} ", array[j]);
        }
        Console.WriteLine();
    }

    private static void CombinationWithoutRepetition(int[] array, int index = 1, int after = 0)
    {
        if (index > k)
        {
            return;
        }

        for (int j = after + 1; j <= n; j++)
        {
            array[index - 1] = j;
            if (index == k)
            {
                Print(array, index);
            }
            CombinationWithoutRepetition(array, index + 1, j);
        }
    }

    static void Main()
    {
        Console.Write("N=");
        n = int.Parse(Console.ReadLine());

        Console.Write("K=");
        k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        CombinationWithoutRepetition(array);
    }
}

