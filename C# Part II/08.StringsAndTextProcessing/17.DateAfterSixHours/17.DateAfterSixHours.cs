using System;
using System.Globalization;
using System.Threading;
class DateAfterSixHours
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        DateTime endDate = startDate.AddHours(6).AddMinutes(30);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        Console.WriteLine("CurrentCulture is {0}.", CultureInfo.CurrentCulture.Name);

        Console.WriteLine("{0} -> {1}", endDate, endDate.ToString("dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
    }
}

