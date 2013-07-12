//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;
class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] hex = input.ToCharArray();
        Array.Reverse(hex);
        int toDecimal = 0;
        for (int i = 0; i < input.Length; i++)
        {
            switch (hex[i])
            {
                case 'A': toDecimal += 10 * (int)Math.Pow(16, i);
                    break;
                case 'B': toDecimal += 11 * (int)Math.Pow(16, i);
                    break;
                case 'C': toDecimal += 12 * (int)Math.Pow(16, i);
                    break;
                case 'D': toDecimal += 13 * (int)Math.Pow(16, i);
                    break;
                case 'E': toDecimal += 14 * (int)Math.Pow(16, i);
                    break;
                case 'F': toDecimal += 15 * (int)Math.Pow(16, i);
                    break;
                default: toDecimal += (hex[i] - '0') * (int)Math.Pow(16, i);
                    break;
            }
        }
        Console.Write(toDecimal);
    }
}

