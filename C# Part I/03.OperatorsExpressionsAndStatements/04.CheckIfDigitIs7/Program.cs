//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
using System;

class Program
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine())) / 100; //if the number is 1732, number equals 17; we make the number with an absolute value in order t work for negative numbers
        Console.WriteLine(number%10 == 7);
    }
}