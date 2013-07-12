using System;
class WordsAsUnicodeCharacteLliterals
{
    static void Main()
    {
        string word = Console.ReadLine();

        foreach (var character in word)
        {
            int c = (int)character;
            Console.Write(@"\u{0:X}", c.ToString("X").PadLeft(4,'0'));
        }
    }
}

