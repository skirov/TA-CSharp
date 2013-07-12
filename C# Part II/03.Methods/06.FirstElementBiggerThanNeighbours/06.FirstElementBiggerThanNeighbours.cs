//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstElementBiggerThanNeighbours
{
    //I've added reference to exercise 5, in order fo this class to know about the methods in exercise 5
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 6, 5, 6, 7 };
        bool numberIsFound = false;

        for (int i = 0; i < array.Length; i++)
        {
            bool checkNumber = ElementBiggerThanNeighboursInArray.IsBiggerThanNeighbours(array, i);
            if (checkNumber)
            {
                //Print the array and color the position which we're currently on
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == i)//make the number that we search green
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write("{0} ", array[j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine("The index is {0}", i);
                numberIsFound = true;
                break;
            }
        }
        if (numberIsFound==false)
        {
            Console.WriteLine(-1);
        }
    }
}