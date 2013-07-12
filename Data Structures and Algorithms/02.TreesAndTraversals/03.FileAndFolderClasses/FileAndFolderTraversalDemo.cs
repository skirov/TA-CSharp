using System;
using System.IO;

public class FileAndFolderTraversalDemo
{
    public static void Main()
    {
        //Because C:\ takes too long
        Console.WriteLine("--- Cloning C:\\Windows directoy ---");
        Console.WriteLine("This may take a while...");

        Folder masterFolder = new Folder(@"C:\Windows");

        Folder copiedFileSystem = FolderUtils.CopyFileSystem(ref masterFolder);

        Console.WriteLine();
        Console.WriteLine("Cloning of C:\\Windows is finished.");

        Console.Write("Choose a sub folder to check it's size: ");
        string subFolder = Console.ReadLine();

        decimal folderSize = FolderUtils.FindFolder(masterFolder, subFolder).GetSize();

        Console.WriteLine("The folder size is {0:0.00}mb", folderSize.ToMegabytes());

        Console.WriteLine(masterFolder.Folders.Count);

    }
}

