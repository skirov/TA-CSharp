using System;
class SignedUShort
{
    static void Main()
    {
        //Due to the lack of time
        Console.Write("Number in the range -32,768 to 32,767: ");
        short n = short.Parse(Console.ReadLine());
        Console.Write("Binary: ");
        Console.WriteLine(Convert.ToString(n, 2));
    }
}

