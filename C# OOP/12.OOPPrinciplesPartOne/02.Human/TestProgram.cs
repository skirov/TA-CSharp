using System;
using System.Collections.Generic;
using System.Linq;

namespace Human
{
    public class TestProgram
    {
        static void Main()
        {
            List<Human> studentsList = new List<Human>();
            List<Human> workerList = new List<Human>();

            studentsList.Add(new Student("Kiril", "Ivanov"));
            studentsList.Add(new Student("Stoian", "Mihalev"));
            studentsList.Add(new Student("Martin", "Hristov"));
            studentsList.Add(new Student("Milen", "Dimitrov"));
            studentsList.Add(new Student("Petur", "Georgiev"));
            studentsList.Add(new Student("Ivan", "Ivanov"));
            studentsList.Add(new Student("Georgi", "Pehlivanov"));
            studentsList.Add(new Student("Milen", "Kolev"));
            studentsList.Add(new Student("Asen", "Stoianov"));
            studentsList.Add(new Student("Marian", "Peshev"));

            workerList.Add(new Worker("Angel", "Ivanov"));
            workerList.Add(new Worker("Petko", "Mihalev"));
            workerList.Add(new Worker("Traqn", "Hristov"));
            workerList.Add(new Worker("Cenko", "Dimitrov"));
            workerList.Add(new Worker("Hasan", "Georgiev"));
            workerList.Add(new Worker("Silviq", "Petrove"));
            workerList.Add(new Worker("Kremena", "Kirova"));
            workerList.Add(new Worker("Kaloqn", "Kolev"));
            workerList.Add(new Worker("Hristina", "Stoianova"));
            workerList.Add(new Worker("Petur", "Peshev"));

            var orderStudentsAsc = studentsList.OrderBy(x => x.FirstName).ThenBy(x => x.SecondName);
            var orderWorkersAsc = workerList.OrderByDescending(x => x.FirstName).ThenBy(x => x.SecondName);

            Console.WriteLine("Order students in ascending order");
            foreach (var student in orderStudentsAsc)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            Console.WriteLine("Order workers in descending order");
            foreach (var worker in orderWorkersAsc)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            Console.WriteLine("Merged Lists ordered by descending");
            var mergedLists = workerList.Union(studentsList).OrderBy(x => x.FirstName).ThenBy(x => x.SecondName);

            foreach (var item in mergedLists)
            {
                Console.WriteLine(item);
            }
        }
    }
}