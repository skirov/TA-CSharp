//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
class DecimalToHex
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<string> hex = new List<string>();
        while(number>0)
        {
            switch (number%16)
            {
                case 10: hex.Add("A");
                    break;
                case 11: hex.Add("B");
                    break;
                case 12: hex.Add("C");
                    break;
                case 13: hex.Add("D");
                    break;
                case 14: hex.Add("E");
                    break;
                case 15: hex.Add("F");
                    break;
                default: hex.Add((number % 16).ToString());
                    break;
            }
            number /= 16;
        }
        hex.Reverse();
        foreach (var digit in hex)
        {
            Console.Write(digit);
        }
    }
}

