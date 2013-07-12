// <copyright file="RectangularParallelepiped.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 02.Utils
// </copyright>
namespace Utils
{
    using System;

    /// <summary>
    /// Represent a rectangular parallelepiped
    /// </summary>
    public class RectangularParallelepiped
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangularParallelepiped"/> class.
        /// </summary>
        /// <param name="width">The width of the rectangular parallelepiped.</param>
        /// <param name="height">The height of the rectangular parallelepiped.</param>
        /// <param name="depth">The depth of the rectangular parallelepiped.</param>
        public RectangularParallelepiped(double width, double height, double depth)
        {
            if (width < 0 || height < 0 || depth < 0)
            {
                throw new ArgumentOutOfRangeException("The width, height and depth must be greater than 0.");
            }

            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        #region Properties
        /// <summary>
        /// Gets the width of the rectangular parallelepiped.
        /// </summary>
        public double Width { get; private set; }

        /// <summary>
        /// Gets the height of the rectangular parallelepiped.
        /// </summary>
        public double Height { get; private set; }

        /// <summary>
        /// Gets the depth of the rectangular parallelepiped.
        /// </summary>
        public double Depth { get; private set; }
        #endregion

        #region Calculation methods
        /// <summary>
        /// Calculates the volume of the rectangular parallelepiped.
        /// </summary>
        /// <returns>Returns the volume of the rectangular parallelepiped.</returns>
        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        /// <summary>
        /// Calculates the length of the body diagonal of the rectangular parallelepiped.
        /// </summary>
        /// <returns>Returns the length of the body diagonal of the rectangular parallelepiped.</returns>
        public double CalcDiagonalXYZ()
        {
            double distance = GeometryUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal lying n the x-y plane.
        /// </summary>
        /// <returns>Returns the length of the diagonal lying n the x-y plane.</returns>
        public double CalcDiagonalXY()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal lying n the x-z plane.
        /// </summary>
        /// <returns>Returns the length of the diagonal lying n the x-z plane.</returns>
        public double CalcDiagonalXZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the length of the diagonal lying n the y-z plane.
        /// </summary>
        /// <returns>Returns the length of the diagonal lying n the y-z plane.</returns>
        public double CalcDiagonalYZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
        #endregion
    }
}
