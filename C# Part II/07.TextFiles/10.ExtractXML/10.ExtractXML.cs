using System;
using System.IO;
using System.Text.RegularExpressions;
class ExtractXML
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\10.xml.xml"))
        {
            string line = string.Empty;
            MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
            while ((line = reader.ReadLine()) != null)
            {
                matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                foreach (var word in matchProtocolAndSiteName)
                {
                    Console.WriteLine(word.ToString().Trim());
                }
            }
        }
    }
}