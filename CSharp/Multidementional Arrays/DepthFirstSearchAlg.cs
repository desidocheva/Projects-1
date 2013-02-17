using System;

class DepthFirstSearchAlg
{
    static int n = 5;
    static int m = 6;
    static int[,] matrix =
    {
            {1,3,2,2,2,3},
            {3,3,3,2,4,1},
            {4,3,1,2,3,3},
            {4,3,1,3,3,1},
            {4,3,3,3,1,1},
    };
    static bool[,] checkCell = new bool[n,m];
    static int DepthFirstSearch(int row, int col, int number)
    {
        if (row < 0 || col < 0 || row >= n || col >= m)
        {
            return 0;
        }
        if (checkCell[row,col]==true)
        {
            return 0;
        }
        if (matrix[row,col] == number)
        {
            checkCell[row, col] = true;
            return DepthFirstSearch(row - 1, col, number) + DepthFirstSearch(row, col - 1, number) + DepthFirstSearch(row, col + 1, number)
                + DepthFirstSearch(row + 1, col, number) + 1;
        }
        else
        {
            return 0;
        }
    }
    static void Main()
    {
        int counter = 0;
        int maxCount = 1;
        int number=matrix[0,0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                counter = DepthFirstSearch(i, j, matrix[i, j]);
                if (counter>maxCount)
                {
                    number = matrix[i,j];
                    maxCount = counter;
                }
            }
        }
        Console.WriteLine("{0} --> {1}",number,maxCount );
    }
}
