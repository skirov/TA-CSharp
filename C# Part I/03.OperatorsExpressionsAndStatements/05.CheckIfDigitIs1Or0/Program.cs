//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        Console.WriteLine((number&mask)!=0 ? 1 : 0);
    }
}