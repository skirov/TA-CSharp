using System;
using System.Text.RegularExpressions;

class ReplaceAnchorElement
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        MatchCollection urlsInAnchors = Regex.Matches(text, @"(?!<a href=""{1,2})[a-zA-z\.\/:]+(?="")", RegexOptions.IgnoreCase);

        MatchCollection anchorText = Regex.Matches(text, @"(?!<a href=(""{1,2})[a-zA-z\.\/:]+(""{1,2})>)[\w\s\.,]+(?=</a>)", RegexOptions.IgnoreCase);

        for (int i = 0; i < urlsInAnchors.Count; i++)
        {
            text = Regex.Replace(text, @"<a href=(""{1,2})[a-zA-z\.\/:]+(""{1,2})>[\w\s\.,]+</a>",
                                        "[URL=" + urlsInAnchors[i] +"]"+ anchorText[i] +"[/URL]");
        }

        Console.WriteLine(text);
    }
}