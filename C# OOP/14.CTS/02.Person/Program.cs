using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person person = new Person("John Doe", 16);
            Person personWithourAge = new Person("John Doe");

            Console.WriteLine("First Person:");
            Console.WriteLine(person);

            Console.WriteLine();

            Console.WriteLine("Second Person withoud age:");
            Console.WriteLine(personWithourAge);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
