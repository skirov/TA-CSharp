//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
using System;

public class ElementBiggerThanNeighboursInArray
{
    public static bool IsBiggerThanNeighbours(int[] array, int positionOfANumber)
    {
        if (positionOfANumber == 0)//if we check the first element
        {
            return false;
        }
        else if (positionOfANumber == array.Length - 1) //if we check the last element
        {
            return false;
        }

        if (positionOfANumber < array.Length - 1 && positionOfANumber > 0)
        {
            if (array[positionOfANumber] > array[positionOfANumber + 1] && array[positionOfANumber - 1] < array[positionOfANumber])
            {
                return true;
            }
        }
        return false;
    }

    public static void CheckPositionAndPrintResult(int[] array, bool checkNumber, int positionOfANumber)
    {
        if (positionOfANumber == 0)//if we check the first element
        {
            Console.WriteLine("{0} has only one neighbour element", array[positionOfANumber]);
        }
        else if (positionOfANumber == array.Length - 1) //if we check the last element
        {
            Console.WriteLine("{0} has only one neighbour element", array[positionOfANumber]);
        }
        else if (positionOfANumber < array.Length - 1 && positionOfANumber > 0 && checkNumber)
        {
            Console.WriteLine("{0} is bigger than {1} and {2}", array[positionOfANumber], array[positionOfANumber + 1], array[positionOfANumber - 1]);
        }
        else
        {
            Console.WriteLine("{0} is not bigger than it's neighbours", array[positionOfANumber]);
        }
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 5, 6, 7 };
        int positionOfANumber = 1;
        bool checkNumber = IsBiggerThanNeighbours(array, positionOfANumber);
        for (int i = 0; i < array.Length; i++)
        {
            if (i == positionOfANumber)//make the number that we search green
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write("{0} ", array[i]);
            Console.ResetColor();
        }
        Console.WriteLine();

        CheckPositionAndPrintResult(array, checkNumber, positionOfANumber);
    }
}