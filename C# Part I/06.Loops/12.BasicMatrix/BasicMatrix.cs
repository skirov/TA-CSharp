//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
using System;
using System.Collections.Generic;

class BasicMatrix
{
    static int[,] FillMatrix(int n, int[,] matrix)
    {
        int counter = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                counter++;
                matrix[i, j] = counter;
            }
            counter = i+1; //to set the first value of the next row
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
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