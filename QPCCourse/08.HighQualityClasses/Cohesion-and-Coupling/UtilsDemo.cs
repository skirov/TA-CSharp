// <copyright file="UtilsDemo.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 02.Utils
// </copyright>
namespace Utils
{
    using System;

    /// <summary>
    /// Represents the demo of the second task in the 
    /// homework for high quality classes - 02.Utils
    /// </summary>
    internal class UtilsDemo
    {
        /// <summary>
        /// Represent the Main method for execution of
        /// C# console applications 
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("File extension -> {0}", FileUtils.GetFileExtension("example"));
            Console.WriteLine("File extension -> {0}", FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine("File extension -> {0}", FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine();

            Console.WriteLine("Filename without extension -> {0}", FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine("Filename without extension -> {0}", FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine("Filename without extension -> {0}", FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine();

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                GeometryUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                GeometryUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine();

            RectangularParallelepiped parallelepiped = new RectangularParallelepiped(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", parallelepiped.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", parallelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalcDiagonalYZ());
        }
    }
}
