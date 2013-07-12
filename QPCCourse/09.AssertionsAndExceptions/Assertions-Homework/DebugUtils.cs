// <copyright file="DebugUtils.cs" company="Telerik academy">
// Telerik academy homework for Assertions and Exceptions - Task 01.AssertionsHomework
// </copyright>
using System;
using System.Diagnostics;

/// <summary>
/// Represents methods for debugging the AlgorithmUtils class.
/// </summary>
public static class DebugUtils
{
    /// <summary>
    /// Common debug asserts for the AlgorithmUtils class.
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="array">Array to assert.</param>
    /// <param name="startIndex">Start index to assert.</param>
    /// <param name="endIndex">End index to assert.</param>
    public static void DebugAsserts<T>(T[] array, int startIndex, int endIndex)
    where T : IComparable<T>
    {
        Debug.Assert(array != null, "The input array can't be null");
        Debug.Assert(endIndex <= array.Length - 1, "The endIndex is bigger than the array length.");
        Debug.Assert(startIndex >= 0, "The startIndex must be 0 or a positive integer.");
    }

    /// <summary>
    /// Checks if an array is sorted.
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="array">Array to assert.</param>
    /// <returns>Returns True if the array is sorted and false if it's not.</returns>
    public static bool IsSorted<T>(T[] array) 
        where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i].CompareTo(array[i + 1]) == 1)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Type that implements IComparable.</typeparam>
    /// <param name="array">Array to assert.</param>
    /// <param name="startIndex">Start index to assert.</param>
    /// <param name="endIndex">End index to assert.</param>
    /// <param name="minElementIndex">The min element index to try to assert.</param>
    /// <returns>Returns True if the elements is ssmallest in the range and false if it's not.</returns>
    public static bool IsMinElement<T>(T[] array, int startIndex, int endIndex, int minElementIndex) 
        where T : IComparable<T>
    {
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (array[i].CompareTo(array[minElementIndex]) < 0)
            {
                return false;
            }
        }
        return true;
    }
}
