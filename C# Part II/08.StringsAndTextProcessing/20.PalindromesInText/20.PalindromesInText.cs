using System;
class PalindromesInText
{
    static bool IsPalindrome(string word)
    {
        bool isPalidrome = true;
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                isPalidrome = false;
            }
        }
        return isPalidrome;
    }
    static void Main()
    {
        string text = "Lorem exe ipsum dolor sit amet, consectetur ABBA adipiscing elit. Proin lamal in rutrum mem.";

        string[] words = text.Split(' ', ',', '-', '.');

        foreach (string word in words)
        {
            if (IsPalindrome(word.Trim()) && word != string.Empty)
            {
                Console.WriteLine(word);
            }
        }
    }
}