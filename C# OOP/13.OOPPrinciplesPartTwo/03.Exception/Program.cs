using System;

public class Program
{
    public static void TestIntRange(int value, int startRangeParameter, int endRangeParameter)
    {
        if (value < startRangeParameter || value > endRangeParameter)
        {
            throw new InvalidRangeException<int>(startRangeParameter, endRangeParameter, "The integer is out of range");
        }
    }

    public static void TestDateRange(DateTime value, DateTime startRangeParameter, DateTime endRangeParameter)
    {
        if (value < startRangeParameter || value > endRangeParameter)
        {
            throw new InvalidRangeException<DateTime>(startRangeParameter, endRangeParameter, "The date is out of range");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            TestIntRange(101, 1, 100);
        }
        catch (InvalidRangeException<int> e)
        {
            Console.WriteLine("The integer must be in the range: {0} - {1}", e.StartRange, e.EndRange);
        }

        Console.WriteLine();

        try
        {
            TestDateRange(new DateTime(1979, 1, 1), new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
        }
        catch (InvalidRangeException<DateTime> e)
        {
            Console.WriteLine("The date must be in the range: {0} - {1}", e.StartRange, e.EndRange);
        }


    }
}
