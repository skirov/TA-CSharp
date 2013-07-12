using System;
class MainClass
{
    static void Main()
    {
        Matrix<int> matrix = new Matrix<int>(4, 4);

        Matrix<int> secondMatrix = new Matrix<int>(4, 4);

        Random randomNumber = new Random();

        //Fill first and second matrix with random numbers
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                matrix[row, col] = randomNumber.Next(0, 100);
                secondMatrix[row, col] = randomNumber.Next(0, 100);
            }
        }

        //Print the two matrices
        Console.WriteLine("First Matrix");
        Console.WriteLine(matrix);

        Console.WriteLine("Second Matrix");
        Console.WriteLine(secondMatrix);

        //Add matrices
        Console.WriteLine("Add matrices");
        Console.WriteLine(matrix + secondMatrix);

        //Substract matrices
        Console.WriteLine("Substract matrices");
        Console.WriteLine(matrix - secondMatrix);

        //Multiply matrices
        Console.WriteLine("Multiply matrices");
        Console.WriteLine(matrix * secondMatrix);

        //Check if matrices is null
        Console.WriteLine("Check if matrices are empty");
        if (matrix)
        {
            Console.WriteLine("First matrix is empty");
        }
        else
        {
            Console.WriteLine("First matrix is not empty");
        }

        if (secondMatrix)
        {
            Console.WriteLine("Second matrix is empty");
        }
        else
        {
            Console.WriteLine("Second matrix is not empty");
        }
    }
}