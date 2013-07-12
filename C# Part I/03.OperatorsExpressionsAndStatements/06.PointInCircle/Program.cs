using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int radius = 5;
        int x = 2;
        int y = 2;
        if ((x * x) + (y * y) <= radius * radius)
        {
            Console.WriteLine("The point is inside the circle");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}