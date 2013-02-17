//Write a program that finds the maximal increasing sequence in an array. 
using System;

class IncreasingElements
{
    static void Main()
    {
        int count = 0, max = 0, index = 0, i;
        Console.Write("Enter array's length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
                if (max < count)
                {
                    max = count; index = i + 1;
                }
            }
            else
            {
                count = 0;
            }
        }
        if (max != 0)
        {
            
            for (i = index-max; i < index; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine(array[index]);
        }
    }
}