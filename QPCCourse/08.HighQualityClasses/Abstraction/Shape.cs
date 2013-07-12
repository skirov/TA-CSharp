// <copyright file="Shape.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 01.Shapes
// </copyright>
namespace Shapes
{
    using System;

    /// <summary>
    /// Represents a shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Abstract class for calculating the perimeter of a shape
        /// </summary>
        /// <returns>Returns the perimeter of a shape</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Abstract class for calculating the surface of a shape
        /// </summary>
        /// <returns>Returns the surface of a shape</returns>
        public abstract double CalcSurface();
    }
}
