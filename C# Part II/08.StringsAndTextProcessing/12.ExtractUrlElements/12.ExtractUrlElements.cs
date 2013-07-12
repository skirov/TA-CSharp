using System;
using System.Text.RegularExpressions;

class ExtractURLElements
{
    static void Main()
    {
        string url = @"http://www.example.com/regex/input";
        MatchCollection matchProtocolAndSiteName = Regex.Matches(url, @"([\da-z_\.-]+)");

        Console.WriteLine("[protocol] -> {0}", matchProtocolAndSiteName[0]);
        Console.WriteLine("[server] -> {0}", matchProtocolAndSiteName[1]);

        Console.Write("[resource] -> ");
        for (int i = 2; i < matchProtocolAndSiteName.Count; i++)
        {
            Console.Write("{0}/", matchProtocolAndSiteName[i]);
        }
    }
}