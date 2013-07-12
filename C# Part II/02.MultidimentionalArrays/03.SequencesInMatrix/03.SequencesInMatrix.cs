using System;
using System.Collections.Generic;

class SequencesInMatrix
{
    public static int sequence = 1;
    public static int maxSequence = 1;
    public static string bestElement = string.Empty;

    static int[,] directions = new int[,] { 
                                            { 1, 0 },
                                            { 0, 1 },
                                            { 1, 1 },
                                            { 1,-1 }
                                          };

    static bool InBoudsOfArray(string[,] matrix, int row, int col)
    {
        if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1)) //if inside the array
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Count(string[,] matrix, int row, int col, string currentValue)
    {
        //start changing directions
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            int newRow = row + directions[direction, 0];
            int newCol = col + directions[direction, 1];
            //if outside the array, continue
            if (InBoudsOfArray(matrix, newRow, newCol) == false)
            {
                continue;
            }
            while (currentValue == matrix[newRow, newCol] && InBoudsOfArray(matrix, newRow, newCol))
            {
                sequence++;
                bestElement = matrix[newRow, newCol];
                newRow = newRow + directions[direction, 0];
                newCol = newCol + directions[direction, 1];
                //if outside the array, break
                if (InBoudsOfArray(matrix, newRow, newCol) == false)
                {
                    break;
                }
            }
            if (sequence>maxSequence)
            {
                maxSequence = sequence;
            }
            sequence = 1;
        }
    }

    static void Main()
    {
        string[,] matrix = {
                        {"hwa","hi","ha","hsi"},
                        {"ma","ha","ho","hsi"},
                        {"ha","si","hsa","hi"}
                    };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string currentValue = matrix[i, j];
                Count(matrix, i, j, currentValue);
            }
        }
        Console.WriteLine(maxSequence);
        Console.WriteLine(bestElement);
    }
}