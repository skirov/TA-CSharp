using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
class DeleteWordsListedFromFile
{
    static void Main()
    {
        try
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader readFile = new StreamReader(@"..\..\12.words.txt"))
            {
                string line;
                while ((line = readFile.ReadLine()) != null)
                {
                    text.AppendLine(line);
                }
            }
            using (StreamWriter writeFile = new StreamWriter(@"..\..\12.words.txt"))
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines(@"..\..\12.wordstodelete.txt")) + @")\b";
                writeFile.WriteLine(Regex.Replace(text.ToString(), regex, string.Empty, RegexOptions.IgnoreCase));
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