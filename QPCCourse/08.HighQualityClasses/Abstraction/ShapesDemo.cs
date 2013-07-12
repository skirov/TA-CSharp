// <copyright file="ShapesDemo.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 01.Shapes
// </copyright>
namespace Shapes
{
    using System;

    /// <summary>
    /// Represents the various shapes demo
    /// </summary>
    internal class ShapesDemo
    {
        /// <summary>
        /// Represent the Main method for execution of
        /// C# console applications 
        /// </summary>
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(
                "I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.",
                circle.CalcPerimeter(),
                circle.CalcSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine(
                "I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.",
                rect.CalcPerimeter(),
                rect.CalcSurface());
        }
    }
}
