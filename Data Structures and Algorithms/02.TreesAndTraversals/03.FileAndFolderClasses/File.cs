using System;

public class File
{
    private string name;
    private long size;

    public File(string name, long size) 
    {
        this.Name = name;
        this.Size = size;
    }
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
                throw new ArgumentNullException("Name of the file cannot be null, empty or whitespace.");
            }
            this.name = value;
        }
    }

    public long Size
    {
        get
        {
            return this.size;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentNullException("The size of the file cannot be less than 0.");
            }
            this.size = value;
        }
    }
}