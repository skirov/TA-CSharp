using System;
class SumSequenceOfNumbers
{
    static int Sum(string[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i]);
        }
        return sum;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ', '-', ',', '+');

        Console.WriteLine(Sum(input));
    }
}

