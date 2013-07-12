using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LocalCourse : Courses, ILocalCourse
{
    public string lab;

    public LocalCourse(string name, ITeacher teacher, string lab)
        : base(name, teacher)
    {
        this.Lab = lab;
    }

    public string Lab
    {
        get
        {
            return this.lab;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.lab = value;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.AppendFormat("LocalCourse: Name={0}; ", base.Name);

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
        toString.AppendFormat("Lab={0}", this.Lab);

        return toString.ToString();
    }
}