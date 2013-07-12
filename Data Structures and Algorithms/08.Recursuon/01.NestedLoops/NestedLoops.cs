using System;
class NestedLoops
{
    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    private static void NestedLoop(int[] array, int position = 0)
    {
        if (position == array.Length)
        {
            Print(array);
            return;
        }

        for (int i = 1; i <= array.Length; i++)
        {
            array[position] = i;
            NestedLoop(array, position + 1);
        }
    }
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] array = new int[n];

        NestedLoop(array);
    }
}

