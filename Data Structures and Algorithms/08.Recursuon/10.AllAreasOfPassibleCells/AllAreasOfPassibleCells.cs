using System;
using System.Collections.Generic;

class LargestConnectedArea
{
    static string[,] matrix = 
        {
            {"-", "-", "-", "*", "-", "-", "-"},
            {"*", "*", "-", "*", "*", "*", "*"},
            {"-", "-", "-", "-", "-", "-", "-"},
            {"-", "*", "*", "*", "*", "*", "-"},
            {"-", "-", "-", "-", "-", "-", "-"},
        };

    static void FindAllPaths(int row, int col)
    {
        if ((col < 0) || (row < 0) || (col >= matrix.GetLength(1))
        || (row >= matrix.GetLength(0)))
        {
            return;
        }
        
        if (matrix[row, col] != "-")
        {
            return;
        }

        matrix[row, col] = "X";

        FindAllPaths(row, col - 1); // left
        FindAllPaths(row - 1, col); // up
        FindAllPaths(row, col + 1); // right
        FindAllPaths(row + 1, col); // down
    }

    static void PrintLabyrinth(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Before search");
        PrintLabyrinth(matrix);
        Console.WriteLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] == "-")
                {
                    FindAllPaths(row, col);
                }
            }
        }

        Console.WriteLine("After search");
        PrintLabyrinth(matrix);
    }
}