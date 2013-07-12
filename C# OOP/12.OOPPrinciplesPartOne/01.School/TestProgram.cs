using System;
using System.Linq;

namespace School
{
    class TestProgram
    {
        static void Main()
        {
            //define students
            Student firstStudent = new Student("Ivan Ivanov", 26);
            firstStudent.AddComment("I love school.");
            Student secondStudent = new Student("Kiril Stoianov", 21);
            secondStudent.AddComment("I hate school.");
            Student thirdStudent = new Student("Martin Hristov", 25);
            Student[] allStudents = {
                                       firstStudent,
                                       secondStudent,
                                       thirdStudent
                                   };

            //define disciplines
            Discipline math = new Discipline("Math", 4, 4);
            math.AddComment("This is the hardest discipline, but it's very useful.");
            Discipline biology = new Discipline("Biology", 2, 2);
            Discipline chemistry = new Discipline("Chemistry", 1, 2);
            chemistry.AddComment("This is the most useless discipline.");
            Discipline[] allDisciplines = {
                                              math,
                                              biology,
                                              chemistry
                                          };

            //define teachers and add disciplines
            Teacher firstTeacher = new Teacher("Nikolai Nikolov");
            firstTeacher.AddDicipline(math);
            firstTeacher.AddDicipline(chemistry);

            Teacher secondTeacher = new Teacher("Silviq Stefanova");
            secondTeacher.AddComment("She's a great teacher.");
            secondTeacher.AddDicipline(biology);

            Teacher[] allTeachers = {
                                        firstTeacher,
                                        secondTeacher
                                    };

            //create class
            Class firstClassInSchool = new Class("12A");
            //add students in class
            firstClassInSchool.AddStudents(allStudents);
            //add teachers for class
            firstClassInSchool.AddTeachers(allTeachers);
            Class[] allClasses = {
                                        firstClassInSchool
                                    };

            //Define school and display information
            School mySchool = new School("1st Math Highschool");

            //display info
            Console.WriteLine("-------{0}-------", mySchool.Name);
            Console.WriteLine();

            Console.WriteLine("---Teachers---");
            foreach (var teacher in allTeachers)
            {
                foreach (var discipline in teacher.AllDiciplines)
                {
                    Console.WriteLine("{0} -> {1}", teacher, discipline);
                }
            }

            Console.WriteLine();

            Console.WriteLine("---Classes---");
            foreach (var schoolClass in allClasses)
            {
                Console.WriteLine(schoolClass);
            }

            Console.WriteLine();

            //Display Comments
            Console.WriteLine("---Comments---");
            foreach (var schoolClass in allClasses)
            {
                schoolClass.ViewComments();
            }

            Console.WriteLine();

            foreach (var student in allStudents)
            {
                student.ViewComments();
            }

            Console.WriteLine();

            foreach (var teacher in allTeachers)
            {
                teacher.ViewComments();
            }

            Console.WriteLine();

            foreach (var discipline in allDisciplines)
            {
                discipline.ViewComments();
            }
        }
    }
}