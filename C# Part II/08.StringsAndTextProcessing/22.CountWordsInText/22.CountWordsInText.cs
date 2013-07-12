using System;
using System.Collections.Generic;
class CoutLettersInString
{
    static void Main()
    {
        Dictionary<string, int> letters = new Dictionary<string, int>();

        string input = Console.ReadLine();

        string[] words = input.Split(' ', ',', '-', '.', ':');

        for (int i = 0; i < words.Length; i++)
        {
            if (letters.ContainsKey(words[i]))
            {
                letters[words[i]] += 1;
            }
            else
            {
                letters.Add(words[i], 1);
            }
        }

        foreach (var letter in letters)
        {
            Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
        }
    }
}