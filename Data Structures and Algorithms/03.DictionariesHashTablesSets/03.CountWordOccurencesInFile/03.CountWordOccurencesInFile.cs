using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class CountWordOccurencesInFile
{
    static void Main()
    {
        Dictionary<string, int> wordsInFile = new Dictionary<string, int>();
        using (StreamReader reader = new StreamReader("../../text.txt"))
        {
            string[] words = reader.ReadLine().Split(new char[]{ ' ', ',', '.', '?', '!', '-' });

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                if (word == "")
                {
                    continue;
                }
                if (wordsInFile.ContainsKey(word))
                {
                    wordsInFile[word]++;
                }
                else
                {
                    wordsInFile.Add(word, 1);
                }
            }
        }

        var sortedWords = wordsInFile.OrderBy(x => x.Value);

        foreach (var item in sortedWords)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

