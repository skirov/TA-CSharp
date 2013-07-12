using System;
class PrintNumberVariations
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", number.ToString("D").PadLeft(15));
        Console.WriteLine("{0}", number.ToString("X").PadLeft(15));
        Console.WriteLine("{0}%", number.ToString().PadLeft(14));
        Console.WriteLine("{0}", number.ToString("E").PadLeft(15));
    }
}

