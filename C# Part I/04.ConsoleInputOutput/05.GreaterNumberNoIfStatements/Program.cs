//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        //This is the way that first came to mind :)
        while (a>b)
        {
            Console.WriteLine(a);
            break;
        }
        while (b>a)
        {
            Console.WriteLine(b);
            break;
        }
        //You can also do it with Console.WriteLine(Math.Max(a,b));
    }
}