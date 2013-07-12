using System;
class Permutations
{
    static int n;
    static int k;
    static string[] result;

    private static void Print(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    private static void Variations(string[] array, int currentPosition)
    {
        if (currentPosition == k)
        {
            Print(result);
            return;
        }

        for (int i = 0; i < array.Length; i++)
        {
            result[currentPosition] = array[i];
            Variations(array, currentPosition+1);
        }
    }

    static void Main()
    {
        Console.Write("N=");
        n = int.Parse(Console.ReadLine());

        Console.Write("K=");
        k = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element in the set - [{0}]:", i);
            array[i] = Console.ReadLine();

            Console.WriteLine();
        }

        result = new string[k];

        Variations(array, 0);
    }
}

