// <copyright file="Circle.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 01.Shapes
// </copyright>
namespace Shapes
{
    using System;

    /// <summary>
    /// Represents a circular shape
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The circle radius.</param>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("The radius must be greateer than 0");
            }

            this.Radius = radius;
        }

        /// <summary>
        /// Gets the circle radius.
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Calculates the perimeter of the circle.
        /// </summary>
        /// <returns>Return the perimeter of the circle.</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the circle.
        /// </summary>
        /// <returns>Return the surface of the circle.</returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
