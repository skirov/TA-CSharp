using System;

class LettersIndexesInAWord
{
    static void Main()
    {
        char[] letters = new char[26];
        for (int i = 1; i < letters.Length; i++) //97-122 == a-z
        {
            letters[i] = (char)(i + 96);
        }

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)//iterate the letters in the word
        {
            char letterInWord = char.ToLower(word[i]); //make it lowercase
            for (int j = 0; j < letters.Length; j++)//iterate the letters array
            {
                if (letters[j] == letterInWord)//if letters match - print and break
                {
                    Console.WriteLine("{0} -> {1}", word[i], j);
                    break;
                }
            }
        }
    }
}