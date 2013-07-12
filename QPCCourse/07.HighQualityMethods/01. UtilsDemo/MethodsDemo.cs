// <copyright file="MethodsDemo.cs" company="Telerik Academy">
// Telerik academy homework task 01 from lecture 07. HighQualityMethods 
// </copyright>
using System;
using Methods;

/// <summary>
/// Used to demonstrate the use of methods from the 
/// <see cref="Methods"/> namespace.
/// </summary>
internal class MethodsDemo
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    private static void Main()
    {
        Student ivan = new Student();
        ivan.FirstName = "Ivan";
        ivan.LastName = "Ivanov";
        ivan.DateOfBirth = new DateTime(1992, 03, 17);

        Student ivanka = new Student();
        ivanka.FirstName = "Ivanka";
        ivanka.LastName = "Ivanova";
        ivanka.DateOfBirth = new DateTime(1993, 11, 3);

        Student asd = new Student();

        Console.WriteLine(
            "Is {0} older than {1}? -> {2}",
            ivan.FirstName,
            ivanka.FirstName,
            ivan.DateOfBirth.IsEarlierThan(ivanka.DateOfBirth));

        Console.WriteLine(GeometryMethods.CalcTriangleArea(3, 4, 5));

        Console.WriteLine(LanguageMethods.DigitToText(5));

        Console.WriteLine(StatisticalMethods.Max(5, -1, 3, 2, 14, 2, 3));

        ConsolePrinter.PrintNumber(1.3, 2);
        ConsolePrinter.PrintPercent(0.75, 0);
        ConsolePrinter.PrintAligned(2.30, 8);

        Console.WriteLine(GeometryMethods.CalcDistance(3, -1, 3, 2.5));
        Console.WriteLine("Horizontal? -> " + GeometryMethods.IsLineHorizontal(3, -1, 3, 2.5));
        Console.WriteLine("Vertical? -> " + GeometryMethods.IsLineVertical(3, -1, 3, 2.5));
    }
}
