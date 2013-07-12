using System;
using System.IO;
class ReadFileContent
{
    static void Main()
    {
        string path = @"..\..\..\MyTest.txt";

        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path to file is invalid");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory is not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You are not authorized to view file contents.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in invalid format");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}

