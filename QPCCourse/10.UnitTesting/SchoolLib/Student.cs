using System;

namespace SchoolLib
{
    public class Student
    {
        public Student(string name, int uniqueID)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("The name of the student can't be null or empty");
            }

            if (uniqueID < 10000 || uniqueID > 99999)
            {
                throw new ArgumentOutOfRangeException("The unique id of the student must be between 10000 and 99999.");
            }

            this.Name = name;
            this.UniqueID = uniqueID;
        }

        public string Name
        {
            get;
            private set;
        }

        public int UniqueID
        {
            get;
            private set;
        }
    }
}
