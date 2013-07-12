using System;
using System.IO;
using System.Text.RegularExpressions;
class ExtractText
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.html");
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                foreach (var asd in matchProtocolAndSiteName)
                    Console.WriteLine(asd);
            }
        }
    }
}