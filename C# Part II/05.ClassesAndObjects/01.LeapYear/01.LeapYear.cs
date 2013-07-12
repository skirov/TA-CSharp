using System;
class LeapYear
{
    static void Main()
    {
        ushort year = ushort.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not a leap year");
        }
    }
}

