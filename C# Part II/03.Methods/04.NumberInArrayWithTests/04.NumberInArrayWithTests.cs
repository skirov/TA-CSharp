using System;

public class NumberInArrayWithTests
{
    //more about unit tests
    //Niki's video at http://www.youtube.com/watch?v=nzbh8o8tqJw (1h55min)
    public static decimal numberToCheck;
    public static int counter;

    public static void CountAppearances(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == numberToCheck)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the number which appearance you wish to count:");
        numberToCheck = decimal.Parse(Console.ReadLine());
        decimal[] array = { 1, 2, 5, 2, 6, 7, 3, 2, 7, 8, 2 };
        CountAppearances(array);
        Console.WriteLine("The number {0} appears {1} of times in the array", numberToCheck, counter);
    }
}