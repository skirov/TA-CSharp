using System;
using System.Collections.Generic;
using System.IO;
class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        string textLines = @".NET - platform for applications from Microsoft
CLR - managed execution environment for .NET
namespace - hierarchical organization of classes
";

        StringReader readLines = new StringReader(textLines);

        string line;
        while ((line = readLines.ReadLine())!=null)
        {
            string[] token = line.Split('-');
            dictionary.Add(token[0].Trim(), token[1]);
        }

        string input = Console.ReadLine();

        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine(dictionary[input]);
        }
        else
        {
            Console.WriteLine("No such term in dictionary");
        }
    }
}

