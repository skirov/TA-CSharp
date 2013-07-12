using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
class DeleteWordsFromFile
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        using (StreamReader readFile = new StreamReader(@"..\..\11.textfile.txt"))
        {
            string line = string.Empty;

            while ((line = readFile.ReadLine()) != null)
            {
                text.AppendLine(line);
            }
        }

        using (StreamWriter writeFile = new StreamWriter(@"..\..\11.textfile.txt"))
        {
            writeFile.WriteLine(Regex.Replace(text.ToString(), @"\btest\w+\b", string.Empty));
        }
        Console.WriteLine("Words succesfuly deleted");
    }
}