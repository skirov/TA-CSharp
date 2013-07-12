using System;
using System.Linq;

namespace Animals
{
    public class TestProgram
    {
        static void Main()
        {
            Animal[] animals = 
            {
                new Cat("Pisana", Sex.Female, 6),
                new Tomcat("Rusty", 10),
                new Kitten("Klucky", 1),
                new Dog("Sharo", Sex.Male, 9),
                new Frog("Frodo?", Sex.Male, 1),

                new Cat("Maca", Sex.Female, 4),
                new Tomcat("Strahil",  12),
                new Kitten("Kotence", 1),
                new Dog("Balkan", Sex.Male, 15),
                new Frog("Frodo2?", Sex.Male, 2)
            };

            var getAllByType = animals.GroupBy(x => x.GetType());

            foreach (var type in getAllByType)
            {
                Console.WriteLine("{0}s -> Average age = {1}", type.Key.Name, type.Average(x => x.Age));
            }
        }
    }
}
