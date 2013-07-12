using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class DeleteWordsListedFromFile
{
    static void Main()
    {
        try
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            using (StreamReader readWords = new StreamReader(@"..\..\13.words.txt"))
            {
                string line;
                MatchCollection words;
                string regex;
                while ((line = readWords.ReadLine()) != null)
                {
                    regex = @"\b"+ line +@"\b";
                    words = Regex.Matches(String.Join("", File.ReadAllLines(@"..\..\13.test.txt")), regex);
                    countWords.Add(line, words.Count);
                }
            }

            using (StreamWriter writeFile = new StreamWriter(@"..\..\13.result.txt"))
            {
                foreach (var item in countWords.OrderByDescending(x => x.Value))
                {
                    writeFile.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}