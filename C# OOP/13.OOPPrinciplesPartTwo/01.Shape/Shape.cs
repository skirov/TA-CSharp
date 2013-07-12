using System;

namespace Shape
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        #region Properties

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("You must enter a value bigger than 0.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("You must enter a value bigger than 0.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        #endregion

        public abstract double CalculateSerface();

    }
}
