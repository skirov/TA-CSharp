//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, 
//increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output.
// Use switch statement.
using System;
using System.Collections.Generic;

class ReadUsersChoice
{
    static void Main()
    {
        string userInput = Console.ReadLine(); //We assume that the variable is a string
        double result;
        bool stringValue = Double.TryParse(userInput, out result); //We check if its an integer
        switch (stringValue)
        {
            case true: Console.WriteLine(result + 1); break; // If it is we add 1
            case false: Console.WriteLine("{0}*", userInput); break; // If it's not we add an asterix
            default: Console.WriteLine("Wha?");
                break;
        }
    }
}