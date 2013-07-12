using System;
class BinaryPasswords
{
    static void Main()
    {
        string input = Console.ReadLine();
        byte counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '*')
            {
                counter++;
            }
        }

        double result = Math.Pow(2, counter);
        Console.WriteLine((long)result);
    }
}