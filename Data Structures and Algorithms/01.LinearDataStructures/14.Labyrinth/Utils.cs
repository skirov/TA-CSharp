using System;
using System.Linq;

public static class Utils
{
    public static Point GetStartingPoint(this string[,] matrix)
    {
        Point startingPoint = new Point();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] == "*")
                {
                    startingPoint.Row = row;
                    startingPoint.Col = col;
                    return startingPoint;
                }
            }
        }

        return startingPoint;
    }

    public static bool InBouds(this string[,] matrix, int row, int col)
    {
        if (row >= 0 && col >= 0 &&
            row < matrix.GetLength(0) && col < matrix.GetLength(1) &&
            matrix[row,col] != "X")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void MarkUnreachableSpaces(this string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] == "0")
                {
                    matrix[row, col] = "u";
                }
            }
        }
    }

    public static void PrintLabirynth(this string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
