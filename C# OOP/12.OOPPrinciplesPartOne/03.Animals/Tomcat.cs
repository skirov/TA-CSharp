using System;

namespace Animals
{
    public class Tomcat : Cat
    {
        /// <summary>
        /// You must add only name and age, because Tomcats can be only males
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Tomcat(string name, int age)
            : base(name, Sex.Male, age) //no matter what the user puts for sex, sex will always be male
        {

        }
    }
}
