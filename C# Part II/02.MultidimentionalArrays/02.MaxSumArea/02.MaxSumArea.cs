//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

class MaxSumArea
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M=");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        Random randomGenerator = new Random(); //generate random numbers
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = randomGenerator.Next(10);//insert random number between 0 and 10
            }
        }

        int sum = 0;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row+1, col] + matrix[row+1, col + 1] + matrix[row+1, col + 2] +
                      matrix[row+2, col] + matrix[row+2, col + 1] + matrix[row+2, col + 2];
                if (sum>bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
                sum = 0;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int row = bestRow; row <= bestRow + 2; row++)
        {
            for (int col = bestCol; col <= bestCol + 2; col++)
            {
                Console.Write("{0} ", matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum is {0}", bestSum);
    }
}