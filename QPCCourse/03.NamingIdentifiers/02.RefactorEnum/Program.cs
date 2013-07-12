namespace RefactorEnum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Human human = new Human(14);

            Console.WriteLine("Name: {0}", human.Name);
            Console.WriteLine("Gender: {0}", human.Gender);
            Console.WriteLine("Age: {0}", human.Age);
        }
    }
}