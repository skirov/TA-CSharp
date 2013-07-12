using System;
using System.IO;
class ConcatenateTwoFilesInOne
{
    static void Main()
    {
        using(StreamReader firstFile = new StreamReader(@"..\..\02.textfile1.txt"))
        {
            using (StreamReader secondFile = new StreamReader(@"..\..\02.textfile2.txt"))
            {
                using (StreamWriter concatenatedFile = new StreamWriter(@"..\..\02.concatenated.txt"))
                {
                    string fileContentsOne = firstFile.ReadToEnd();
                    string fileContentsTwo = secondFile.ReadToEnd();

                    concatenatedFile.WriteLine(fileContentsOne);
                    concatenatedFile.WriteLine(fileContentsTwo);
                }
            }
        }
        Console.WriteLine("Files succesfuly concatenated");
    }
}

