namespace RotatingWalkInMatrix
{
    using System;

    class MatrixDemo
    {
        public static void Main()
        {
            Console.Write("Enter the matrix size: ");

            int matrixSize = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(matrixSize);

            Console.WriteLine(matrix);
        }
    }
}
