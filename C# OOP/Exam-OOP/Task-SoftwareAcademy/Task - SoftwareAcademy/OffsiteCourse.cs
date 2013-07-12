using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OffsiteCourse : Courses, IOffsiteCourse
{
    private string town;

    public OffsiteCourse(string name, ITeacher teacher, string town)
        : base(name, teacher)
    {
        this.Town = town;
    }

    public string Town
    {
        get
        {
            return this.town;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.town = value;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.AppendFormat("OffsiteCourse: Name={0}; ", base.Name);

        if (base.Teacher.Name != null)
        {
            toString.AppendFormat("Teacher={0}; ", base.Teacher.Name);
        }

        if (base.allTopics.Count != 0)
        {

            toString.Append("Topics=[");

            for (int i = 0; i < base.allTopics.Count; i++)
            {
                //TODO: Check if the comma at the end couses problems
                if (i == base.allTopics.Count - 1)
                {
                    toString.AppendFormat("{0}", base.allTopics[i]);
                }
                else
                {
                    toString.AppendFormat("{0}, ", base.allTopics[i]);
                }
            }

            toString.Append("]; ");

        }
        toString.AppendFormat("Town={0}", this.Town);

        return toString.ToString();
    }
}

