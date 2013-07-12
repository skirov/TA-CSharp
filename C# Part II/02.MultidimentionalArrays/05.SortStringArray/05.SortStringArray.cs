//You are given an array of strings. Write a method that sorts the array by the length of its elements
//(the number of characters composing them).
using System;
using System.Linq;

class SortStringArray
{
    static void Main()
    {
        string[] array = {"abc", "bcddase", "defgh"};

        var sortByLength = from element in array
                           orderby element.Length descending
                           select element;

        foreach (var element in sortByLength)
        {
            Console.WriteLine("{0} => {1}", element, element.Length);
        }
    }
}