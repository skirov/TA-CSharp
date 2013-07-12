// <copyright file="Rectangle.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 01.Shapes
// </copyright>
namespace Shapes
{
    using System;

    /// <summary>
    /// Represents a rectangular shape.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width of the rectangle</param>
        /// <param name="height">The height of the rectangle</param>
        public Rectangle(double width, double height)
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be a positive number.");
            }

            if (height < 0)
            {
                throw new ArgumentException("Height must be a positive number.");
            }

            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets the width of the rectangle
        /// </summary>
        public double Width { get; private set; }

        /// <summary>
        /// Gets the height of the rectangle
        /// </summary>
        public double Height { get; private set; }

        /// <summary>
        /// Calculates the perimeter of the rectangle
        /// </summary>
        /// <returns>Returns the perimeter of the rectangle</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the rectangle
        /// </summary>
        /// <returns>Returns the surface of the rectangle</returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
