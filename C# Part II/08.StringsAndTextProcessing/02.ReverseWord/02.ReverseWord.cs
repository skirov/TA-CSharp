using System;
class ReverseWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] reverseWord = input.ToCharArray();
        Array.Reverse(reverseWord);

        foreach (var letter in reverseWord)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}

