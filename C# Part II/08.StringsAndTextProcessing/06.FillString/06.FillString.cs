using System;
class FillString
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length<20)
        {
            Console.Write(input);
            for (int i = 0; i < 20-input.Length; i++)
            {
                Console.Write("{1}", input, new string('*', 1));
            }
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}

