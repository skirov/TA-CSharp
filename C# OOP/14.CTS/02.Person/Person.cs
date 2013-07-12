using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int? age;

    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person(string name)
        :this(name, null)
    {
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("You must enter a name value.");
            }
            this.name = value;
        }
    }

    public int? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.AppendLine("---- Information about person:");
        toString.AppendFormat(" Name: {0}", this.Name);
        toString.AppendLine();
        if (this.Age == null)
        {
            toString.AppendFormat("The age of this person is not defined.");
        }
        else
        {
            toString.AppendFormat(" Age: {0}", this.Age);
        }

        return toString.ToString();
    }
}

