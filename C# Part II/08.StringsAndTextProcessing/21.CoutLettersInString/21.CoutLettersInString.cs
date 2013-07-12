using System;
using System.Collections.Generic;
class CoutLettersInString
{
    static void Main()
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (letters.ContainsKey(input[i]))
            {
                letters[input[i]] += 1;
            }
            else
            {
                letters.Add(input[i], 1);
            }
        }

        foreach (var letter in letters)
        {
            Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
        }
    }
}