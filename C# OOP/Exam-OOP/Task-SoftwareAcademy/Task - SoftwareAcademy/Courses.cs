using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Courses : ICourse
{
    protected IList<string> allTopics = new List<string>();
    private string name;
    private ITeacher teacherInstance = new Teacher();

    public Courses(string name, ITeacher teacher = null)
    {
        this.Name = name;
        this.Teacher = teacher;
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
                throw new ArgumentNullException();
            }
            else
            {
                this.name = value;
            }
        }
    }

    public ITeacher Teacher
    {
        get
        {
            return this.teacherInstance;
        }
        set
        {
            if (value == null)
            {
                teacherInstance.Name = null;
            }
            else
            {
                teacherInstance = value;
            }
        }
    }

    public void AddTopic(string topic)
    {
        allTopics.Add(topic);
    }
}

