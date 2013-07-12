using System;
using System.Text.RegularExpressions;
class SubstringIn
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        MatchCollection regex = Regex.Matches(text, "in", RegexOptions.IgnoreCase);

        Console.WriteLine("In occurs {0} times in the text.", regex.Count);
    }
}

