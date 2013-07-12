using System;
class MinMaxAvgSum
{
    static int[] FillArray(string input)
    {
        string[] numbers = input.Split();
        int[] array = new int[numbers.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        return array;
    }

    static void Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum is {0}", sum);
    }

    static void Max(params int[] numbers)
    {
        int max = int.MinValue;
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("Biggest number is {0}", max);
    }

    static void Min(params int[] numbers)
    {
        int min = int.MaxValue;
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine("Smallest number is {0}", min);
    }

    static void Average(params int[] numbers)
    {
        decimal average = 0;
        foreach (var number in numbers)
        {
            if (number > average)
            {
                average = number;
            }
        }
        Console.WriteLine("Average of numbers is {0}", average / numbers.Length);
    }

    static void Main()
    {
        Sum(6, 21, 5, 1, 2);
        Max(6, 21, 5, 1, 2);
        Min(6, 21, 5, 1, 2);
        Average(6, 21, 5, 1, 2);
    }
}

