namespace RefactorSizeClass
{
    using System;

    /// <summary>
    /// Create a rectangle
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// The width of the rectangle
        /// </summary>
        private double width;

        /// <summary>
        /// The height of the rectangle
        /// </summary>
        private double height;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        /// <param name="width">Width of the figure</param>
        /// <param name="height">height of the figure</param>
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Gets or sets the height of the rectangle
        /// </summary>
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
                    throw new ArgumentException("Height must be positive.");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the rectangle
        /// </summary>
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
                    throw new ArgumentException("Width must be positive.");
                }

                this.width = value;
            }
        }
    }
}