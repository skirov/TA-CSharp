using System;

class Matrix
{
    public int rows, cols;
    private int[,] matrix;

    public Matrix(int x, int y)
    {
        rows = x;
        cols = y;
        matrix = new int[rows,cols];
    }

    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        Matrix matrix = new Matrix(mat1.rows, mat1.cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                matrix[row, col] = mat1[row, col] + mat2[row, col];
            }
        }

        return matrix;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        Matrix matrix = new Matrix(mat1.rows, mat1.cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                matrix[row, col] = mat1[row, col] - mat2[row, col];
            }
        }

        return matrix;
    }

    public static Matrix operator *(Matrix mat1, Matrix mat2)
    {
        Matrix matrix = new Matrix(mat1.rows, mat1.cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                for (int everyCol = 0; everyCol < matrix.cols; everyCol++) //look up matrices multiplication in Google
                {
                    matrix[row, col] += mat1[row, everyCol] * mat1[everyCol, col];
                }
            }
        }

        return matrix;
    }
    
    public int this[int x, int y] //here we make the [] indexers work for our class
    {
        get 
        { 
            return matrix[x, y]; 
        }
        set
        { 
            matrix[x, y] = value;
        }
    }

    public override string ToString()
    {
        string printMatrix = string.Empty;
        for (int row = 0; row < this.rows; row++)
        {
            for (int col = 0; col < this.cols; col++)
            {
                printMatrix += "  " + matrix[row,col];
            }
            printMatrix += "\n";
        }
        return printMatrix;
    }

    static void Main()
    {
        Matrix mat1 = new Matrix(4, 4); //we believe that the matrixes are always going to be coherent
        Matrix mat2 = new Matrix(4, 4);
        Random random = new Random();
        
        //Fill the matrix with random number between 1 and 10
        for (int i = 0; i < mat1.rows; i++)
        {
            for (int j = 0; j < mat1.cols; j++)
            {
                mat1[i, j] = random.Next(10);
                mat2[i, j] = random.Next(10);
            }
        }
        Console.WriteLine("Matrix 1");
        Console.WriteLine(mat1);
        Console.WriteLine("Matrix 2");
        Console.WriteLine(mat2);
        Console.WriteLine("Add matrices");
        Console.WriteLine(mat1 + mat2);
        Console.WriteLine("Substract matrices");
        Console.WriteLine(mat1 - mat2);
        Console.WriteLine("Multply matrices");
        Console.WriteLine(mat1 * mat2);
    }
}