using System;
using System.Collections.Generic;

class SpiralMatrix
{
    static int[,] FillMatrix(int n, int[,] matrix)
    {
        int counter = 0;
        int direction = 1; //1-right, 2-down, 3-left, 4-right

        int col = 0;
        int row = 0;

        int startColumn = 0;
        int startRow = 0;

        int endColumn = n - 1;
        int endRow = n - 1;

        while (counter < n*n)
        {
            if (direction == 1)
            {
                counter++;
                matrix[row, col] = counter;
                col++;
                if (col == endColumn)
                {
                    direction = 2;
                }
            }
            if (direction == 2)
            {
                counter++;
                matrix[row, col] = counter;
                row++;
                if (row == endRow)
                {
                    direction = 3;
                }
            }
            if (direction == 3)
            {
                counter++;
                matrix[row, col] = counter;
                col--;
                if (col == startColumn)
                {
                    direction = 4;
                }
            }
            if (direction == 4)
            {
                counter++;
                matrix[row, col] = counter;
                row--;
                if (row == startRow)
                {
                    col++;
                    row++;

                    startRow += 1;
                    startColumn += 1;

                    endRow -= 1;
                    endColumn -= 1;

                    direction = 1;
                }
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}",matrix[i, j]);
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