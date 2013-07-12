using System;

namespace Animals
{
    public class Animal : ISound
    {
        private string sound;
        private string name;
        private Sex sex;
        private int age;

        public Animal(string name, Sex sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        #region Properties

        public string Name
        {
            get { return this.name; }
        }

        public Sex Sex
        {
            get { return this.sex; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public string Sound
        {
            get { return this.sound; }
        }

        #endregion

        public void ProduceSound(string sound)
        {
            this.sound = sound;
        }
    }
}
