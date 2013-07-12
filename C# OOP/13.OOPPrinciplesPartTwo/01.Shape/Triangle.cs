using System;

namespace Shape
{
    public class Triangle : Shape
    {
        /// <summary>
        /// Enter width and height of the triangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Triangle(double width, double height)
            :base(width, height)
        {

        }

        public override double CalculateSerface()
        {
            return (base.Width * base.Height) / 2;
        }
    }
}
