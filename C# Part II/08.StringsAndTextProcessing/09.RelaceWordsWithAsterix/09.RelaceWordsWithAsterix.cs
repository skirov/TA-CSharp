using System;
using System.Text.RegularExpressions;
class RelaceWordsWithAsterix
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] forbidden = { "Microsoft", "PHP", "CLR" };

        string regex = string.Empty;

        for (int i = 0; i < forbidden.Length; i++)
		{
            regex = @"\b(" + forbidden[i] + @")\b";
            text = Regex.Replace(text.ToString(), regex, new string('*', forbidden[i].Length));
		}

        Console.WriteLine(text);
    }
}