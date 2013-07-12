using System;

class Matrix
{
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
        int counter = 1;
        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[n - i + j - 1, j] = counter++;
            }
        }

        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                matrix[i - j, n - j - 1] = counter++;
            }
        }
        PrintMatrix(matrix);
    }
}