using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Teacher : ITeacher
{
    private IList<string> allCourses = new List<string>();
    private string name;

    public Teacher()
    {

    }

    public Teacher(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public void AddCourse(ICourse course)
    {
        allCourses.Add(course.Name);
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        if (allCourses.Count != 0)
        {
            toString.AppendFormat("Teacher: Name={0}; ", this.Name);
            toString.Append("Courses=[");

            for (int i = 0; i < allCourses.Count; i++)
            {
                //TODO: Check if the comma at the end couses problems
                if (i == allCourses.Count - 1)
                {
                    toString.AppendFormat("{0}", allCourses[i]);
                }
                else
                {
                    toString.AppendFormat("{0}, ", allCourses[i]);
                }
            }

            toString.Append("]");
        }
        else
        {
            toString.AppendFormat("Teacher: Name={0}", this.Name);
        }

        return toString.ToString();
    }
}
