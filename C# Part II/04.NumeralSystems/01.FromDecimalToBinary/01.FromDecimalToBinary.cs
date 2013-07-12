//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
class FromDecimalToBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<int> binary = new List<int>();
        while(number>0)
        {
            binary.Add(number % 2);
            number /= 2;
        }
        binary.Reverse();
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
    }
}

