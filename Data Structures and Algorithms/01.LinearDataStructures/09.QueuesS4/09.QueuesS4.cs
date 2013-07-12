using System;
using System.Collections.Generic;
public class QueuesS4
{
    public static void Main()
    {
        Console.Write("Enter a digit for N: ");
        int n = int.Parse(Console.ReadLine());

        Queue<int> sequence = new Queue<int>();

        int elementsCount = 1;

        int lastIndex = n;
        sequence.Enqueue(n);

        Console.WriteLine("These are the first 50 elements of the sequence");
        for (int i = 0; i < 50; i++)
        {
            lastIndex = sequence.Dequeue();
            Console.WriteLine("{0} ", lastIndex);

            if (elementsCount >= 50)
            {
                continue;
            }
            sequence.Enqueue(lastIndex + 1);
            elementsCount++;
            if (elementsCount >= 50)
            {
                continue;
            }
            sequence.Enqueue((2 * lastIndex) + 1);
            elementsCount++;
            if (elementsCount >= 50)
            {
                continue;
            }
            sequence.Enqueue(lastIndex + 2);
            elementsCount++;
        }

    }
}

