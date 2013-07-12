using System;
using System.IO;
class ReadAndPrintFileContents
{
    static void Main()
    {
        using (StreamReader file = new StreamReader(@"..\..\01.textfile.txt"))
        {
            string content = file.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}

