using System;
using System.IO;
using System.Text;
class DeleteOddLines
{
    static void Main()
    {
        StringBuilder evenLines = new StringBuilder();
        using (StreamReader readFile = new StreamReader(@"..\..\09.textfile.txt"))
        {
            string line;
            int lineNumber = 1;
            while ((line = readFile.ReadLine()) != null)
            {
                if (lineNumber % 2 == 0)
                {
                    evenLines.AppendLine(line);
                }
                lineNumber++;
            }
        }
        using (StreamWriter writeFile = new StreamWriter(@"..\..\09.textfile.txt"))
        {
            writeFile.WriteLine(evenLines);
        }
        Console.WriteLine("Lines succesfuly deleted");
    }
}

