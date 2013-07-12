//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	//0  "Zero"
	//273  "Two hundred seventy three"
	//400  "Four hundred"
	//501  "Five hundred and one"
	//711  "Seven hundred and eleven"

using System;
using System.Collections.Generic;

class AlphabeticalNumbers999
{
    static int[] DigitsInArray(int number)
    {
        int[] array = new int[3];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number % 10; //If the number is 192, it takes the '2'
            number /= 10; //The number becomes 19
        }
        Array.Reverse(array); //We must revese the array in order for it to be 192, not 291
        return array;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("zero");
            return; //We exit the Main() function
        }

        string[] ones = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        string[] tens = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] special = {"", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};


        if (DigitsInArray(number)[0] != 0 && DigitsInArray(number)[1] != 1) //When we're not using the "special" numbers.
        {
            Console.WriteLine("{0} hundred and {1} {2}",
                ones[DigitsInArray(number)[0]], //If the number is 523, this row will output "five hunded and"
                tens[DigitsInArray(number)[1]], //"twenty"
                ones[DigitsInArray(number)[2]]); //"three"
        }
        else if (DigitsInArray(number)[0] != 0 && DigitsInArray(number)[1] == 1) //If the number ends from 11 to 19, e.g. 715
        {
            Console.WriteLine("{0} hundred and {1}",
                ones[DigitsInArray(number)[0]], //"seven hundred and"
                special[DigitsInArray(number)[2]]);//"fifteen"
        }
        else if (DigitsInArray(number)[0] == 0 && DigitsInArray(number)[1] == 1) //When we have a two digit "special" number, e.g. 15
        {
            Console.WriteLine("{0}",
                special[DigitsInArray(number)[2]]);//"fifteen"
        }
        else if (DigitsInArray(number)[0] == 0 && DigitsInArray(number)[1] == 0 && DigitsInArray(number)[2] != 0) //When we have a one digit "special" number, e.g. 5
        {
            Console.WriteLine("{0}",
                ones[DigitsInArray(number)[2]]);//"five"
        }
    }
}