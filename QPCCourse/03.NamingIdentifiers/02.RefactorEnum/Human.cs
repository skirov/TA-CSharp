namespace RefactorEnum
{
    using System;
    using System.Linq;

    public class Human
    {
        public Human(int uniqueIDNumber)
        {
            if (uniqueIDNumber % 2 == 0)
            {
                Name = "Mister";
                Gender = Gender.Male;
            }
            else
            {
                Name = "Missis";
                Gender = Gender.Female;
            }
        }

        public Gender Gender
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
