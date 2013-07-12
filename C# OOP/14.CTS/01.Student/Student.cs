using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : ICloneable,IComparable<Student>
{

    private string firstName;
    private string middleName;
    private string lastName;
    private string ssn;
    private string permanentAddress;
    private string phone;
    private string eMail;
    private string course;
    private University university;
    private Faculty faculty;
    private Speciality speciality;

    public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string phone, string eMail,
        string course, University university, Faculty faculty, Speciality speciality)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Ssn = ssn;
        this.PermanentAddress = permanentAddress;
        this.Phone = phone;
        this.EMail = eMail;
        this.Course = course;
        this.University = university;
        this.Faculty = faculty;
        this.Speciality = speciality;
    }

    #region Properties

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }
        set
        {
            this.middleName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    public string Ssn
    {
        get
        {
            return this.ssn;
        }
        set
        {
            this.ssn = value;
        }
    }

    public string PermanentAddress
    {
        get
        {
            return this.permanentAddress;
        }
        set
        {
            this.permanentAddress = value;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }
        set
        {
            this.phone = value;
        }
    }

    public string EMail
    {
        get
        {
            return this.eMail;
        }
        set
        {
            this.eMail = value;
        }
    }

    public string Course
    {
        get
        {
            return this.course;
        }
        set
        {
            this.course = value;
        }
    }

    public University University
    {
        get
        {
            return this.university;
        }
        set
        {
            this.university = value;
        }
    }

    public Faculty Faculty
    {
        get
        {
            return this.faculty;
        }
        set
        {
            this.faculty = value;
        }
    }

    public Speciality Speciality
    {
        get
        {
            return this.speciality;
        }
        set
        {
            this.speciality = value;
        }
    }

    #endregion
    
    #region Overrides

    public override bool Equals(object obj)
    {
        Student student = obj as Student;
        if (this.FirstName == student.FirstName && this.LastName == student.LastName && this.Ssn == student.Ssn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.Ssn.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();

        toString.AppendLine("---- Basic Information about Student ----");
        toString.AppendFormat(" Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
        toString.AppendLine();
        toString.AppendFormat(" University: {0}", this.University);
        toString.AppendLine();
        toString.AppendFormat(" Faculty: {0}", this.Faculty);
        toString.AppendLine();
        toString.AppendFormat(" Speciality: {0}", this.Speciality);
        toString.AppendLine();
        toString.AppendFormat("---- Aditional Info about student: ----");
        toString.AppendLine();
        toString.AppendFormat(" Phone: {0}", this.Phone);
        toString.AppendLine();
        toString.AppendFormat(" Permanent address: {0}", this.PermanentAddress);
        toString.AppendLine();
        toString.AppendFormat(" Email: {0}", this.EMail);
        toString.AppendLine();
        toString.AppendFormat(" Course: {0}", this.Course);
        toString.AppendLine();

        return toString.ToString();
    }

    public static bool operator ==(Student first, Student second)
    {
        return Student.Equals(first, second);
    }

    public static bool operator !=(Student first, Student second)
    {
        return !(Student.Equals(first, second));
    }

    #endregion

    #region Interface Methods

    public object Clone()
    {
        Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn,
        this.PermanentAddress, this.Phone, this.EMail, this.Course, this.University, this.Faculty, this.Speciality);

        return clonedStudent;
    }

    public int CompareTo(Student otherStudent)
    {
        if (this.FirstName != otherStudent.FirstName)
        {
            return (this.FirstName.CompareTo(otherStudent.FirstName));
        }

        if (this.MiddleName != otherStudent.MiddleName)
        {
            return (this.MiddleName.CompareTo(otherStudent.MiddleName));
        }

        if (this.LastName != otherStudent.LastName)
        {
            return (this.LastName.CompareTo(otherStudent.LastName));
        }

        if (this.Ssn != otherStudent.Ssn)
        {
            return (this.Ssn.CompareTo(otherStudent.Ssn));
        }

        return 0;
    }

    #endregion

}