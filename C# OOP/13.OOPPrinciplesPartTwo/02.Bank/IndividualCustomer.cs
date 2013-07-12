using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class IndividualCustomer : Customer
    {
        private int age;

        public IndividualCustomer(string name, int age)
            : base(name)
        {
            this.age = age;
        }

        public int Age
        {
            get
            {
                if (this.age > 18)
                {
                    return this.age;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The customer must be over 18 years old");
                }
            }
        }
    }
}
