using System;
using System.Text.RegularExpressions;
class SentencesContainingIn
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        MatchCollection regex = Regex.Matches(text, @"[\w\s'\\/]+\s(\bin\b)\s*?([\w\s\\/]+)*?(\.|\?|!)");

        foreach (var sentence in regex)
        {
            Console.WriteLine(sentence);
        }
    }
}