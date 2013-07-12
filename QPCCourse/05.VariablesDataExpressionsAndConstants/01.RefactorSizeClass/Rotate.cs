//should have a rotate method but we don't have to write it. I just separated the classes for looser couppling
namespace RefactorSizeClass
{
    using System;

    /// <summary>
    /// Rotate a point and get bounding box
    /// </summary>
    public class Rotate
    {
        /// <summary>
        /// Gets the bounding box of a rectangle rotated at a specified angle.
        /// </summary>
        /// <param name="rectangle">The rectangle to rotate.</param>
        /// <param name="angleOfRotation">The angle of rotation (measured in radians).</param>
        /// <returns>Returns the boundig box of the figure after rotation</returns>
        public static Rectangle GetBoundingBoxAfterRotation(Rectangle rectangle, double angleOfRotation)
        {
            double width = (rectangle.Width * Math.Abs(Math.Cos(angleOfRotation))) +
                           (rectangle.Height * Math.Abs(Math.Sin(angleOfRotation)));
            double height = (rectangle.Height * Math.Abs(Math.Cos(angleOfRotation))) +
                            (rectangle.Width * Math.Abs(Math.Sin(angleOfRotation)));

            return new Rectangle(width, height);
        }
    }
}
