using System;
using System.IO;
class TextLines
{
    static void Main()
    {
        using (StreamReader readFile = new StreamReader(@"..\..\03.readfile.txt"))
        {
            using (StreamWriter writeFile = new StreamWriter(@"..\..\03.writefile.txt"))
            {
                string line;
                int counter = 1;
                while((line = readFile.ReadLine()) != null)
                {
                    writeFile.WriteLine("{0}. {1}", counter++, line);
                }
            }
        }
        Console.WriteLine("Lines succesfuly added");
    }
}

