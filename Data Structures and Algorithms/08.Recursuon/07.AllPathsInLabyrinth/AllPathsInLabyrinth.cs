using System;
using System.Collections.Generic;
class AllPathsInLabyrinth
{
    static string[,] labyrinth = 
        {
            {"s", "-", "-", "*", "-", "-", "-"},
            {"*", "*", "-", "*", "-", "*", "-"},
            {"-", "-", "-", "-", "-", "-", "-"},
            {"-", "*", "*", "*", "*", "*", "-"},
            {"-", "-", "-", "-", "-", "-", "e"},
        };

    static int[,] direction = new int[,]
    { 
        { 1, 0 }, //down
        { 0, 1 }, //right
        { -1, 0 }, //up
        { 0, -1 } //left
    };

    static void FindAllPaths(Point currentPoint, string path)
    {
        for (int i = 0; i < direction.GetLength(0); i++)
        {
            int newRow = currentPoint.Row + direction[i, 0];
            int newCol = currentPoint.Col + direction[i, 1];

            if (InBouds(labyrinth, newRow, newCol))
            {
                if (IsEnd(new Point(newRow, newCol)))
                {
                    Console.WriteLine("Path found: " + path);
                    PrintLabyrinth(labyrinth);
                }
                if (IsFree(labyrinth, newRow, newCol))
                {
                    labyrinth[newRow, newCol] = "X";
                    path += currentPoint.ToString();

                    FindAllPaths(new Point(newRow, newCol), path);
                    labyrinth[newRow, newCol] = "-";
                }
            }
        }
    }

    static Point FindStart()
    {
        for (int row = 0; row < labyrinth.GetLength(0); row++)
        {
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                if (labyrinth[row, col] == "s")
                {
                    return new Point(row, col);
                }
            }
        }
        return new Point();
    }

    static Point FindEnd()
    {
        for (int row = 0; row < labyrinth.GetLength(0); row++)
        {
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                if (labyrinth[row, col] == "e")
                {
                    return new Point(row, col);
                }
            }
        }
        return new Point();
    }

    static bool IsEnd(Point point)
    {
        return labyrinth[point.Row, point.Col] == "e";
    }

    public static bool InBouds(string[,] matrix, int row, int col)
    {
        if (row >= 0 && col >= 0 &&
            row < matrix.GetLength(0) && col < matrix.GetLength(1) &&
            matrix[row, col] != "*")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool IsFree(string[,] matrix, int row, int col)
    {
        if (matrix[row, col] == "-")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void PrintLabyrinth(string[,] matrix)
    {
        for (int row = 0; row < labyrinth.GetLength(0); row++)
        {
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                Console.Write("{0}", labyrinth[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Point start = FindStart();
        Point end = FindEnd();
        FindAllPaths(start, string.Empty);
    }
}

