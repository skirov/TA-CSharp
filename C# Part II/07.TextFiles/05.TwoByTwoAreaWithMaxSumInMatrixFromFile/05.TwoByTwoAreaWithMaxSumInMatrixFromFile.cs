using System;
using System.IO;
class TwoByTwoAreaWithMaxSumInMatrixFromFile
{
    static void WriteMaxTwoByTwoSumOnFile(int[,] matrix)
    {
        int sum = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] +
                      matrix[row+1, col] + matrix[row+1, col+1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
                sum = 0;
            }
        }

        using (StreamWriter writeFile = new StreamWriter(@"..\..\05.output.txt"))
        {
            writeFile.WriteLine(bestSum);
        }
        Console.WriteLine("Output is written to file");
    }
    static void Main()
    {
        int[,] matrix;
        using (StreamReader file = new StreamReader(@"..\..\05.matrix.txt"))
        {
            int matrixSize = int.Parse(file.ReadLine().Trim());
            matrix = new int[matrixSize,matrixSize];

            string line;
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    line = file.ReadLine();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        string[] numbersOnLine = line.Split(' ');
                        matrix[i, j] = int.Parse(numbersOnLine[j]);
                    }
                }
            
            WriteMaxTwoByTwoSumOnFile(matrix);
        }
    }
}

