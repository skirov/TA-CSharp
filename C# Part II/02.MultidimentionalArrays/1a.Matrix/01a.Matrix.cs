using System;

class Matrix
{
    static int[,] FillMatrix(int n, int[,] matrix)
    {
        int counter = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                counter++;
                matrix[col, row] = counter; //we exchange row and col
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        PrintMatrix(FillMatrix(n, matrix));
    }
}