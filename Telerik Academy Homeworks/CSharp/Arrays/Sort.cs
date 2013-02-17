/*
 Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

 */
using System;

class Sort
{
    static void Main()
    {
        int n, s,min,index=0;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        min = array[0];
        for (int i = 0; i < n; i++)
        {
            min = array[i];
            for (int j = i+1; j < n-1; j++)
            {

                if (min>array[j])
                {
                    min = array[j];
                    index = j;
                }
            }
            s = array[i];
            array[i] = array[index];
            array[index] = s;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}
