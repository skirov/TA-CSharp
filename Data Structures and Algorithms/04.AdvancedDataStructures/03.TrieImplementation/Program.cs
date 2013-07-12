using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;


class WordOccurance
{
    static void Main(string[] args)
    {

        Stopwatch sw = new Stopwatch();
        TrieNode start = new TrieNode();
        var allWords = SetInputText();

        List<string> wordsToSearch = new List<string>();
        for (int i = 0; i < 50; i++)
        {
            wordsToSearch.Add(allWords[i].ToString());
        }

        sw.Start();

        AddWordsInTrie(start, wordsToSearch);
        IncrementOccuranceCountTrie(start, allWords);
        
        sw.Stop();

        Console.WriteLine("Searched words count trie: ");
        foreach (var word in wordsToSearch)
        {
            Console.WriteLine("{0}: {1}", word, start.CountWords(start, word));
        }
        Console.WriteLine();
        Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
    }

    private static void IncrementOccuranceCountTrie(TrieNode start, MatchCollection allWords)
    {
        foreach (var word in allWords)
        {
            start.AddOccuranceIfExists(start, word.ToString());
        }
    }

    private static void AddWordsInTrie(TrieNode start, List<string> words)
    {
        foreach (var item in words)
        {
            start.AddWord(start, item.ToString());
        }
    }

    static MatchCollection SetInputText()
    {
        string inputText;
        StreamReader sr = new StreamReader("..\\..\\text.txt");
        using (sr)
        {
            inputText = sr.ReadToEnd().ToLower();
        }

        var matches = Regex.Matches(inputText, @"[a-zA-Z]+");
        return matches;
    }
}
