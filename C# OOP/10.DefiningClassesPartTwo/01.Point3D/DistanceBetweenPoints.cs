using System;

static class DistanceBetweenPoints
{
    public static double CalculateDistance()
    {
        Point3D pointOne = new Point3D(4, 5, 6);
        Point3D pointTwo = new Point3D(7, 8, 9);

        double distance = 0;

        double powerFirst = Math.Pow((pointOne.X - pointTwo.X), 2);
        double powerSecond = Math.Pow((pointOne.Y - pointTwo.Y), 2);
        double powerThird = Math.Pow((pointOne.Z - pointTwo.Z), 2);

        distance = Math.Sqrt(powerFirst + powerSecond + powerThird);

        return distance;
    }
}
