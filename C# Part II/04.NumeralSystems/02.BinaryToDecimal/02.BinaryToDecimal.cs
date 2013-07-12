//Write a program to convert binary numbers to their decimal representation.
using System;
class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] binary = input.ToCharArray();
        Array.Reverse(binary);
        int toDecimal = 0;
        for (int i = 0; i < input.Length; i++)
        {
            toDecimal += (binary[i] - '0') * (int)Math.Pow(2, i);
        }
        Console.WriteLine(toDecimal);
    }
}

