// <copyright file="AssertionsDemo.cs" company="Telerik academy">
// Telerik academy homework for Assertions and Exceptions - Task 01.AssertionsHomework
// </copyright>
using System;
using System.Linq;
using System.Diagnostics;

/// <summary>
/// Represents some search and sort algorithms - Binary search and Selection sort.
/// </summary>
public static class AlgorithmUtils
{    
    /// <summary>
    /// Searches an array with the Binary Search algorithm (see more on Wiki).
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="arr">The array to search from.</param>
    /// <param name="value">The value to search for.</param>
    /// <returns>Returns the searched value or -1 if it doesn't exists.</returns>
    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    /// <summary>
    /// Sorts a comparable array.
    /// </summary>
    /// <typeparam name="T">IComparable collection</typeparam>
    /// <param name="arr">Array to sort</param>
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The input array can't be null");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(DebugUtils.IsSorted<T>(arr), "The array is not sorted correctly");
    }

    /// <summary>
    /// Finds the element with the smallest value in a giver range.
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="arr">The array to search from.</param>
    /// <param name="startIndex">Start index of the range.</param>
    /// <param name="endIndex">End index of the range.</param>
    /// <returns></returns>
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        DebugUtils.DebugAsserts(arr, startIndex, endIndex);

        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(
            DebugUtils.IsMinElement<T>(arr, startIndex, endIndex, minElementIndex),
            "The FindMinElementIndex<T>() does not work correctly.");

        return minElementIndex;
    }

    /// <summary>
    /// Swap two values.
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="x">First value.</param>
    /// <param name="y">Second value.</param>
    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    /// <summary>
    /// Searches an array with the Binary Search algorithm (see more on Wiki).
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="arr">The array to search from.</param>
    /// <param name="value">The value to search for.</param>
    /// <param name="startIndex">Start index of the range.</param>
    /// <param name="endIndex">End index of the range.</param>
    /// <returns></returns>
    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        DebugUtils.DebugAsserts(arr, startIndex, endIndex);
        Debug.Assert(value != null, "Search value can't be null.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }
}
