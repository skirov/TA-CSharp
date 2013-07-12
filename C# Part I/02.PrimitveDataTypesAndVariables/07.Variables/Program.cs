//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and
//assign it with the concatenation of the first two variables (mind adding an interval). Declare a third string 
//variable and initialize it with the value of the object variable (you should perform type casting).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string hello = "Hello ";
        string world = "world!";
        object full = hello + world;
        string convert = (string)full;
        Console.WriteLine(convert);
    }
}