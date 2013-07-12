// <copyright file="AssertionsDemo.cs" company="Telerik academy">
// Telerik academy homework for Assertions and Exceptions - Task 01.AssertionsHomework
// </copyright>
using System;

/// <summary>
/// Represents the first task from the AssertionsAndExceptions Homework
/// </summary>
internal class AssertionsDemo
{
    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };

        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        AlgorithmUtils.SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        AlgorithmUtils.SelectionSort(new int[0]); // Test sorting empty array
        AlgorithmUtils.SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(AlgorithmUtils.BinarySearch(arr, -1000));
        Console.WriteLine(AlgorithmUtils.BinarySearch(arr, 0));
        Console.WriteLine(AlgorithmUtils.BinarySearch(arr, 17));
        Console.WriteLine(AlgorithmUtils.BinarySearch(arr, 10));
        Console.WriteLine(AlgorithmUtils.BinarySearch(arr, 1000));
    }
}