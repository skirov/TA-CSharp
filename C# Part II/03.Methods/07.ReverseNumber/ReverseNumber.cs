//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;
class ReverseNumber
{
    static void Reverse(char[] number)
    {
        if (number[0]=='-')
        {
            number[0]=' ';
        }
        Array.Reverse(number);
        string result = String.Join("", number);
        decimal decimalResult = decimal.Parse(result);
        Console.WriteLine(decimalResult);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        char[] number = input.ToCharArray();
        Reverse(number);
    }
}