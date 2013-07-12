//Write an expression that checks if given integer is odd or even.
using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number%2==1 ? "Odd" : "Even");
    }
}