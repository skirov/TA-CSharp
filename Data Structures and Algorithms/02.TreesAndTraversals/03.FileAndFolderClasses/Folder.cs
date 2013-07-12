using System;
using System.Collections.Generic;

public class Folder
{
    private string name;
    private List<File> files;
    private List<Folder> folders;

    public Folder(string name)
    {
        this.Name = name;
        this.files = new List<File>();
        this.folders = new List<Folder>();
    }

    #region Properties

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name of the folder cannot be null, empty or whitespace.");
            }
            this.name = value;
        }
    }

    public List<File> Files
    {
        get
        {
            return this.files;
        }
        set
        {
            this.files = value;
        }
    }

    public List<Folder> Folders
    {
        get
        {
            return this.folders;
        }
        set
        {
            this.folders = value;
        }
    }

    #endregion

    public void AddFolder(Folder folder)
    {
        folders.Add(folder);
    }

    public void AddFile(File file)
    {
        files.Add(file);
    }

    public decimal GetSize(){
        decimal folderSize = 0;

        foreach (var file in Files)
        {
            folderSize += file.Size;
        }

        foreach (var folder in Folders)
        {
            decimal childSum = folder.GetSize();
            folderSize += childSum;
        }

        return folderSize;
    }
}
