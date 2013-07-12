using System;

namespace Shape
{
    public class TestProgram
    {
        public static void Main()
        {
            Shape[] shapesArray = 
            {
                new Rectangle(2, 4),
                new Triangle(2.3, 7),
                new Circle(5.5)
            };

            Console.WriteLine("--- Surface of");
            Console.WriteLine("- Rectangle: {0}", shapesArray[0].CalculateSerface());
            Console.WriteLine("- Triangle: {0}", shapesArray[1].CalculateSerface());
            Console.WriteLine("- Circle: {0}", shapesArray[2].CalculateSerface());
        }
    }
}
