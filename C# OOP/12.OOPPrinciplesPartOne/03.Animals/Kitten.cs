using System;

namespace Animals
{
    public class Kitten : Cat
    {
        /// <summary>
        /// You must add only name and age, because Kittens can be only females
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Kitten(string name, int age)
            : base(name, Sex.Female, age) //no matter what the user puts for sex, sex will always be female
        {

        }
    }
}
