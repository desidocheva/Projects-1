using System;

class Sequences 
{
    static void Main()
    {
        int rows, cols, counter=0,maxCount=0,row,col;
        string sequence = string.Empty;
        Console.Write("Rows=");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Cols=");
        cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Enter {0} elements", rows * cols);
        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                Console.Write("[{0},{1}] element:", row, col);
                matrix[row, col] = (Console.ReadLine());
            }
        }
        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        for (row = 0; row < rows; row++)
        {

            for (col = 0;col < cols; col++)
            {
                counter = 1;
                for (int i = col; i < cols-1; i++)
                {
                    if (string.Compare(matrix[row, i + 1],matrix[row, i])==0)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    sequence = matrix[row, col];
                }
                
            }
            

           
        }
        for (col = 0; col < cols; col++)
        
        {

            for (row = 0; row < rows; row++)
            {
                counter = 1;
                for (int i = row; i < rows - 1; i++)
                {
                    if (string.Compare(matrix[i + 1,col], matrix[i,col]) == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    sequence = matrix[row, col];
                }

            }



        }

        for (col = 0; col < cols; col++)
        {
            int i = 0;
            int j = col;
            for (row = i; row < rows - 1; row++)
            {

                counter = 1;
                while (j < cols - 1 && i < rows - 1)
                {
                    if (string.Compare(matrix[i, j], matrix[i + 1, j + 1]) == 0)
                    {
                        Console.WriteLine("{0} = {1}",matrix[i, j],matrix[i+1, j+1]);
                        counter++;
                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                        j++;
                        break;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    sequence = matrix[i-1, j-1];
                }

            }




        }
        for (col = cols-1; col >=0; col--)
        {
            int i = rows-1;
            int j = col;
            for (j = col; j > 0; j--)
            {

                counter = 1;
                while (j < cols-1 && i > 0)
                {
                    if (string.Compare(matrix[i, j], matrix[i - 1, j + 1]) == 0)
                    {
                        Console.WriteLine("{0} = {1}", matrix[i, j], matrix[i - 1, j + 1]);
                        counter++;
                        i--;
                        j++;
                    }
                    else
                    {
                        i--;
                        j++;
                        break;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    sequence = matrix[i + 1, j - 1];
                }

            }

        }
        Console.WriteLine("{0} --> {1}", sequence, maxCount);
    }
}
