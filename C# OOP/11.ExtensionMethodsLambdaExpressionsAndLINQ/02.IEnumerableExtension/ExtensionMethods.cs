using System;
using System.Collections.Generic;


public static class ExtensionMethods
{
    public static T Sum<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic sum = 0;

        foreach (var item in input)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic product = 1;

        foreach (var item in input)
        {
            product *= item;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic minElement = long.MaxValue;

        foreach (var item in input)
        {
            if (item < minElement)
            {
                minElement = item;
            }
        }

        return minElement;
    }

    public static T Max<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic maxElement = long.MinValue;

        foreach (var item in input)
        {
            if (item > maxElement)
            {
                maxElement = item;
            }
        }

        return maxElement;
    }

    public static T Average<T>(this IEnumerable<T> input) where T : IComparable<T>
    {
        dynamic sum = 0;
        int elementsCount = 0;

        foreach (var item in input)
        {
            sum += item;
            elementsCount++;
        }

        return sum / elementsCount;
    }
}
