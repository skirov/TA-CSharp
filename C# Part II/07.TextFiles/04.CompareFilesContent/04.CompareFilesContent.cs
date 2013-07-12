using System;
using System.IO;
class CompareFilesContent
{
    static void Main()
    {
        int difference = 0;
        using (StreamReader firstFile = new StreamReader(@"..\..\04.textfile1.txt"))
        {
            using (StreamReader secondFile = new StreamReader(@"..\..\04.textfile2.txt"))
            {
                string lineFirsFile;
                string lineSecondFile;
                while ((lineFirsFile = firstFile.ReadLine()) != null)
                {
                    lineSecondFile = secondFile.ReadLine();
                    if (lineFirsFile != lineSecondFile)
                    {
                        difference++;
                    }
                }
            }
        }
        Console.WriteLine("{0} different lines", difference);
    }
}

