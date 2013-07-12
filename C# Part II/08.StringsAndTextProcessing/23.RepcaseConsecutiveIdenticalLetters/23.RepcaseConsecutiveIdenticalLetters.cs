using System;
class RepcaseConsecutiveIdenticalLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        char current = ' ';

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]!=current)
            {
                Console.Write(input[i]);
            }
            current = input[i];
        }
        Console.WriteLine();
    }
}

