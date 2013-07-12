using System;
using System.Text.RegularExpressions;
class TextToUpperCase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        MatchCollection regex = Regex.Matches(text, @"(?<=<upcase>)[\w\s]+", RegexOptions.IgnoreCase);

        foreach (var word in regex)
        {
            text = Regex.Replace(text, @"(<upcase>)[\w\s]+(</upcase>)", word.ToString().ToUpper(), RegexOptions.IgnoreCase);
        }

        Console.WriteLine(text);
    }
}

