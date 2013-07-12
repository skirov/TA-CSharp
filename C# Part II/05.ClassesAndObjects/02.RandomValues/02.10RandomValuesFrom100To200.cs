using System;
class TenRandomValuesFrom100To200
{
    static void Main()
    {
        Random number = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", number.Next(100, 201)); //201 to include 200 in the range
        }
    }
}

