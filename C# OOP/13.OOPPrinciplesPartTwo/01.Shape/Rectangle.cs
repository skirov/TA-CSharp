using System;

namespace Shape
{
    public class Rectangle : Shape
    {
        /// <summary>
        /// Enter width and height of the rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(double width, double height)
            :base(width, height)
        {

        }
        public override double CalculateSerface()
        {
            return base.Width * base.Height;
        }
    }
}
