using System;
using System.Text;

public class Matrix<T>
{
    private T[,] matrix;
    private readonly int rows = 0;
    private int cols = 0;

    #region constructor and properties

    public Matrix(int matrixRowLength, int matrixColLength)
    {
        if (matrixRowLength < 0 || matrixColLength < 0)
        {
            throw new MatrixException("Please enter a positie number for rows and cols");
        }
        this.matrix = new T[matrixRowLength, matrixColLength];
        this.rows = matrixRowLength;
        this.cols = matrixColLength;
    }

    public int Rows
    {
        get { return this.rows; }
    }

    public int Cols
    {
        get { return this.cols; }
    }
    #endregion

    #region indexer and overrides

    public T this[int row, int col]
    {
        get
        {
            if (row < 0 || col < 0)
            {
                throw new MatrixException("Please enter a positie number for rows and cols");
            }
            return this.matrix[row, col];
        }

        set
        {
            if (row < 0 || col < 0)
            {
                throw new MatrixException("Please enter a positie number for rows and cols");
            }
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                toString.AppendFormat(" {0,5} ", matrix[row, col]);
            }
            toString.AppendLine();
        }

        return toString.ToString();
    }

    public static bool operator true(Matrix<T> m)
    {
        int countZeros = 0;
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                if ((dynamic)m[i, j] != 0)
                {
                    countZeros++;
                }
            }
        }

        if (countZeros > 0)
        {
            return false;
        }
        return true;
    }

    public static bool operator false(Matrix<T> m)
    {
        int countZeros = 0;
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                if ((dynamic)m[i, j] != 0)
                {
                    countZeros++;
                }
            }
        }

        if (countZeros > 0)
        {
            return true;
        }
        return false;
    }
    #endregion

    #region overload operators

    public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> matrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                matrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        return matrix;
    }

    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> matrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                matrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
            }
        }

        return matrix;
    }

    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> matrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < matrix.rows; row++)
        {
            for (int col = 0; col < matrix.cols; col++)
            {
                for (int everyCol = 0; everyCol < matrix.cols; everyCol++) //look up matrices multiplication in Google
                {
                    matrix[row, col] += (dynamic)firstMatrix[row, everyCol] * firstMatrix[everyCol, col];
                }
            }
        }

        return matrix;
    }
    #endregion
}