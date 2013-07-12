using System;

public class CourseFactory : ICourseFactory
{
    public ITeacher CreateTeacher(string name)
    {
        //returns teacher object
        ITeacher newTeacher = new Teacher(name);

        return newTeacher;
    }

    public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
    {
        //returns a localCourse object
        ILocalCourse newLocalCourse = new LocalCourse(name, teacher, lab);

        return newLocalCourse;
    }

    public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
    {
        //returns a offsiteCourse object
        IOffsiteCourse newLocalCourse = new OffsiteCourse(name, teacher, town);

        return newLocalCourse;
    }
}