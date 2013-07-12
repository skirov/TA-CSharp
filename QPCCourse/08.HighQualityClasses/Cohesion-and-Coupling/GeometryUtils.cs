// <copyright file="GeometryUtils.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 02.Utils
// </copyright>
namespace Utils
{
    using System;

    /// <summary>
    /// Represents the Geometry utilities class which
    /// contains methods that are useful when working with geometric objects.
    /// </summary>
    public static class GeometryUtils
    {
        /// <summary>
        /// Calculates the distance between two points in the Euclidean 2D space.
        /// </summary>
        /// <param name="x1">The x coordinate of the first point.</param>
        /// <param name="y1">The y coordinate of the first point.</param>
        /// <param name="x2">The x coordinate of the second point.</param>
        /// <param name="y2">The y coordinate of the second point.</param>
        /// <returns>Returns the distance between two points in the Euclidean 2D space.</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + 
                                        ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Calculates the distance between two points in the Euclidean 3D space.
        /// </summary>
        /// <param name="x1">The x coordinate of the first point.</param>
        /// <param name="y1">The y coordinate of the first point.</param>
        /// <param name="z1">The z coordinate of the first point.</param>
        /// <param name="x2">The x coordinate of the second point.</param>
        /// <param name="y2">The y coordinate of the second point.</param>
        /// <param name="z2">The z coordinate of the second point.</param>
        /// <returns>Returns the distance between two points in the Euclidean 3D space.</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + 
                                        ((y2 - y1) * (y2 - y1)) + 
                                        ((z2 - z1) * (z2 - z1)));
            return distance;
        }
    }
}
