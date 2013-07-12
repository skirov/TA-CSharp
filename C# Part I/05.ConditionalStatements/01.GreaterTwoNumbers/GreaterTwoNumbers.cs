//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
using System;
using System.Collections.Generic;

class GreaterTwoNumbers
{
    static void Main()
    {
        int a = 17;
        int b = 171;

        if (a > b)
        {
            Console.WriteLine("{0} is greater than {1}", a, b);
        }
        else if (b > a)
        {
            Console.WriteLine("{0} is greater than {1}", b, a);
        }
    }
}