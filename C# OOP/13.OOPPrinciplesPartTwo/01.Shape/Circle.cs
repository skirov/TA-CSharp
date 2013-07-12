using System;

namespace Shape
{
    public class Circle : Shape
    {
        /// <summary>
        /// Enter radius of cirlce
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
            : base(radius, radius)
        {

        }

        public override double CalculateSerface()
        {
            return base.Width * Math.PI * Math.PI ;
        }
    }
}
