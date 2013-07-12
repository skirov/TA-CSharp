using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer number: ");
        ulong input = ulong.Parse(Console.ReadLine());

        BitArray64 bits = new BitArray64(input);

        Console.WriteLine("64bit representation of the number {0}", input);

        foreach (var item in bits)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

