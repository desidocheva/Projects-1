using System;

class Matrix
{
    public int Rows, Cols;
    private int[,] matrix;


    public Matrix(int x, int y)
    {
        matrix = new int[x, y];
        Rows = x;
        Cols = y;
    }

    public int this[int x, int y]
    {
        get { return matrix[x, y]; }
        set { matrix[x, y] = value; }
    }

    public static Matrix operator +(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix m = new Matrix(matrixOne.Rows, matrixOne.Cols);

        for (int i = 0; i < matrixOne.Rows; i++)
            for (int j = 0; j < matrixOne.Cols; j++)
                m[i, j] = matrixOne[i, j] + matrixTwo[i, j];

        return m;
    }

    public static Matrix operator -(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix matrixFinal = new Matrix(matrixOne.Rows, matrixOne.Cols);

        for (int i = 0; i < matrixOne.Rows; i++)
            for (int j = 0; j < matrixOne.Cols; j++)
                matrixFinal[i, j] = matrixOne[i, j] - matrixTwo[i, j];

        return matrixFinal;
    }

    public static Matrix operator *(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix matrixFinal = new Matrix(matrixOne.Rows, matrixTwo.Cols);

        for (int i = 0; i < matrixFinal.Rows; i++)
            for (int j = 0; j < matrixFinal.Cols; j++)
                for (int k = 0; k < matrixOne.Cols; k++)
                    matrixFinal[i, j] += matrixOne[i, k] * matrixTwo[k, j];

        return matrixFinal;
    }

    public override string ToString()
    {
        int max = this.matrix[0, 0];
        foreach (int cell in this.matrix) max = Math.Max(max, cell);
        int cellSize = Convert.ToString(max).Length;

        string s = String.Empty;

        for (int i = 0; i < this.Rows; i++)
            for (int j = 0; j < this.Cols; j++)
                s += (Convert.ToString(this.matrix[i, j]).PadRight(cellSize, ' ') + (j != this.Cols - 1 ? " " : "\n"));

        return s;
    }
}

class ClassMatrix
{
    static void Main()
    {
        Console.Write("Enter matrix's length:");
        int n = int.Parse(Console.ReadLine());
        Matrix matrixOne = new Matrix(n, n);
        Matrix matrixTwo = new Matrix(n, n);
        Console.WriteLine("Matrix one:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter element[{0},{1}]",i,j);
                matrixOne[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix two:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter element[{0},{1}]", i, j);
                matrixTwo[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix one:");
        Console.WriteLine(matrixOne);

        Console.WriteLine("Matrix two:");
        Console.WriteLine(matrixTwo);

        Console.WriteLine("Matrix one + Matrix two");
        Console.WriteLine(matrixOne + matrixTwo);

        Console.WriteLine("Matrix one - Matrix two");
        Console.WriteLine(matrixOne - matrixTwo);

        Console.WriteLine("Matrix one * Matrix two");
        Console.WriteLine(matrixOne * matrixTwo);
    }
}
