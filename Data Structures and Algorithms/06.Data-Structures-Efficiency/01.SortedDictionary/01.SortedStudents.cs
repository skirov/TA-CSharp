using System;
using System.Collections.Generic;
using System.IO;

class SortedStudents
{
    static void Main()
    {
        SortedDictionary<string, SortedSet<string>> allStudents = new SortedDictionary<string, SortedSet<string>>();

        StreamReader sr = new StreamReader("..\\..\\text.txt");
        string inputLine;

        using (sr)
        {
            while (!sr.EndOfStream)
            {
                inputLine = sr.ReadLine();
                string[] rawEntries = inputLine.Split('|');

                for (int i = 0; i < rawEntries.Length; i++)
                {
                    rawEntries[i] = rawEntries[i].Trim();
                }

                string studentsName = rawEntries[0] + " " + rawEntries[1];
                string programmingLanguage = rawEntries[2];


                if (allStudents.ContainsKey(programmingLanguage))
                {
                    allStudents[programmingLanguage].Add(studentsName);
                }
                else
                {
                    SortedSet<string> newSet = new SortedSet<string>();
                    newSet.Add(studentsName);

                    allStudents.Add(programmingLanguage, newSet);
                }
            }
        }

        foreach (var language in allStudents)
        {
            Console.Write("{0} -> ", language.Key);

            foreach (var student in language.Value)
            {
                Console.Write("{0}, ", student);
            }
            Console.WriteLine();
        }
    }
}