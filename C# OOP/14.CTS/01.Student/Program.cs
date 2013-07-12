using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Student[] students = 
        {
            new Student("John", "Doe", "Doe", "51251212", "bul. Alexander Malinov 31", "0888888888", "me@me.com", "SomeCource", University.SU, Faculty.Informatics, Speciality.SoftwareEngeneering),
            new Student("John", "Doe", "Doe", "51251212", "bul. Alexander Malinov 31", "0888888888", "me@me.com", "SomeCource", University.SU, Faculty.Informatics, Speciality.SoftwareEngeneering)
        };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();
        Console.WriteLine("Are the students equal?");
        Console.Write("Using Equals(): ");
        Console.WriteLine(students[0].Equals(students[1]));

        Console.WriteLine();

        Console.Write("Using CompareTo(): ");
        Console.WriteLine(students[0].CompareTo(students[1]));

        //I'm not sure how to test if the deep clone works
    }
}

