using System;
class CircleArea
{
    static double CalculateAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p* (p-a) * (p-b) * (p-c));
    }

    static double CalculateAreaWithSideAndAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double CalculateAreaWithTwoSidesAndAngle(double a, double b, double angle)
    {
        return (Math.Sin(Math.PI * angle / 180) * a * b) / 2;
    }
    static void Main()
    {
        Console.WriteLine("S = {0}", CalculateAreaWithHeron(4, 7, 10));
        Console.WriteLine("S = {0}", CalculateAreaWithSideAndAltitude(8, 4));
        Console.WriteLine("S = {0}", CalculateAreaWithTwoSidesAndAngle(7, 9, 45));
    }
}

