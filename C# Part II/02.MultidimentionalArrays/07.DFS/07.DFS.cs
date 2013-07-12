using System;

class DepthFirstSearch
{
    public static int sequence = 0;
    public static int maxSequence = 0;
    static int[,] directions = new int[,] { 
    { 1, 0 },
    { 0, 1 }, 
    { -1, 0 }, 
    { 0, -1 } };

    static bool InBoudsOfArray(int[,] matrix, int row, int col)
    {
        if (row>=0 && col>=0 && row<matrix.GetLength(0) && col<matrix.GetLength(1)) //if inside the array
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void DFS(int[,] matrix, int row, int col)
    {
        int currentValue = matrix[row, col];
        matrix[row, col] = 0;
        sequence++;
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int newRow = row + directions[direction, 0];
            int newCol = col + directions[direction, 1];
            if (InBoudsOfArray(matrix, newRow, newCol))
            {
                if (currentValue==matrix[newRow, newCol])
                {
                    DFS(matrix, newRow, newCol);
                }
            }
        }
    }
    static void Main()
    {
        int[,] matrix = { 
                          { 1, 0, 7, 7, 7, 4 }, 
                          { 0, 0, 0, 7, 9, 2 }, 
                          { 3, 0, 1, 7, 0, 0 }, 
                          { 4, 0, 1, 7, 7, 1 }, 
                          { 2, 0, 0, 7, 1, 1 }
                           };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    sequence = 0;
                    DFS(matrix, i, j);
                    maxSequence = Math.Max(sequence, maxSequence);
                }
            }
        }
        Console.WriteLine(maxSequence);
    }
}