using System;
class GenericMethods
{
    static T Sum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static T Max<T>(params T[] numbers)
    {
        dynamic max = decimal.MinValue;
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static T Min<T>(params T[] numbers)
    {
        dynamic min = decimal.MaxValue;
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static T Average<T>(params T[] numbers)
    {
        dynamic average = 0.0;
        foreach (var number in numbers)
        {
            if (number > average)
            {
                average = number;
            }
        }
        average /= numbers.Length;
        return average;
    }

    static void Main()
    {
        Console.WriteLine("Sum is {0}", Sum(6, 21, 5, 1, 2));
        Console.WriteLine("Biggest number is {0}", Max(6, 21, 5, 1, 2));
        Console.WriteLine("Smallest number is {0}", Min(6, 21, 5, 1, 2));
        Console.WriteLine("Average of numbers is {0}", Average(6, 21.0, 5, 1, 2)); //21.0 because 1 of the numbers must be double, so the result doesn't get rounded up
    }
}