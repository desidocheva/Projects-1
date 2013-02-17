using System;
class MaxSum
{
    static void Main()
    {
        int rows,cols,sum,maxSum,middleElementRow, middleElementCol;
        Console.Write("Rows=");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Cols=");
        cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter {0} elements",rows*cols);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("[{0},{1}] element:",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
        maxSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2];
        maxSum += matrix[1, 0] + matrix[1, 1] + matrix[1, 2];
        maxSum += matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
        middleElementCol = 1;
        middleElementRow = 1;
        for (int row = 1; row < rows-1; row++)
        {
            for (int col = 1; col < cols-1; col++)
            {
                sum = matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1];
                sum += matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1];
                sum += matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum>maxSum)
                {
                    maxSum = sum;
                    middleElementRow = row;
                    middleElementCol = col;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} {1} {2}", matrix[middleElementRow - 1, middleElementCol - 1], matrix[middleElementRow - 1, middleElementCol], matrix[middleElementRow - 1, middleElementCol + 1]);
        Console.WriteLine("{0} {1} {2}", matrix[middleElementRow, middleElementCol - 1], matrix[middleElementRow, middleElementCol], matrix[middleElementRow, middleElementCol + 1]);
        Console.WriteLine("{0} {1} {2}", matrix[middleElementRow + 1, middleElementCol - 1], matrix[middleElementRow + 1, middleElementCol], matrix[middleElementRow + 1, middleElementCol + 1]);
    }
}