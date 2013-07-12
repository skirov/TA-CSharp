using System;
using System.Collections.Generic;
using System.IO;
class SortFromFileAndWriteToFile
{
    static void Main()
    {
        List<string> names = new List<string>();
        using (StreamReader readFile = new StreamReader(@"..\..\06.unsorted.txt"))
        {
            string line;
            while((line = readFile.ReadLine()) != null)
            {
                names.Add(line);
            }
        }

        names.Sort();

        using (StreamWriter writeFile = new StreamWriter(@"..\..\06.sorted.txt"))
        {
            foreach (string name in names)
            {
                writeFile.WriteLine("{0}", name);   
            }
        }

        Console.WriteLine("Sorted names written to file");
    }
}

