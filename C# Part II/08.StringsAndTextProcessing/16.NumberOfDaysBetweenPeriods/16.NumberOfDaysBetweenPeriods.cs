using System;
class NumberOfDaysBetweenPeriods
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        int days = 0;

        while (startDate < endDate)
        {
            days++;
            startDate = startDate.AddDays(1);
        }
        Console.WriteLine(days);
    }
}

