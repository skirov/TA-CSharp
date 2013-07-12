using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Student : Human
    {
        private byte grade;

        public Student(string firstName, string secondName)
            : base(firstName, secondName)
        {

        }

        public byte Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            string firstAndLastName = base.FirstName + " " + base.SecondName;

            return firstAndLastName;
        }
    }
}
