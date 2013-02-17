using System;

class FourMatrices
{
    static void PrintMatrix(int[,] matrix, int n)
    {
        int row, col;
        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                Console.Write(String.Format("{0,-5:D}", matrix[row, col]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int n,row,col,number;
        Console.Write("Enter matrix's size:");
        n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
       
        
        Console.WriteLine("A:");
        number=1;
         for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {

                matrix[col,row] = number;
                number++;
            }
            
        }
         PrintMatrix(matrix, n);
       
        Console.WriteLine();
        Console.WriteLine("B:");
        number = 1;
        col = 0;
        while (col<n)
        {
            for (row = 0; row < n; row++)
            {
                matrix[row, col] = number;
                number++;   
            }
            col++;
            if (col==n)
            {
                break;
            }
            for (row = n-1; row >=0; row--)
            {
                matrix[row, col] = number;
                number++;  
            }
            col++;
        }
        PrintMatrix(matrix, n);
        Console.WriteLine();
        Console.WriteLine("C:");
        number = 1;
        for (row = n - 1; row >= 0; row--)
        {
            for (col = 0; col < (n - row); col++)
            {
                matrix[row + col, col] = number;
                number++;
            }
        }


        for (col = 1; col < n; col++)
        {
            for (row = 0; row < n - col; row++)
            {
                matrix[row, col + row] = number;
                number++;
            }
        }

        PrintMatrix(matrix, n);


        Console.WriteLine();
        Console.WriteLine("D:");
        int k;
        number = 1;
        int endOfLine = n;
        for (k = n; k >= 2; k -= 2)
        {
            col = n - endOfLine;
            for (row = n - endOfLine; row < endOfLine - 1; row++)
            {
                matrix[row, col] = number;
                number++;
            }


            for (col = n - endOfLine; col < endOfLine - 1; col++)
            {
                matrix[row, col] = number;
                number++;
            }

            for (row = endOfLine - 1; row > n - endOfLine; row--)
            {
                matrix[row, col] = number;
                number++;
            }


            for (col = endOfLine - 1; col > n - endOfLine; col--)
            {
                matrix[row, col] = number;
                number++;
            }
            endOfLine--;
        }

        if (n % 2 != 0)
        {
            matrix[n / 2, n / 2] = number;
        }

        PrintMatrix(matrix, n);

        
    }
}
