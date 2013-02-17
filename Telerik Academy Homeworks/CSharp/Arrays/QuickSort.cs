/*
Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
*/

using System;
class QuickSort
{
    static void Sort(ref int[] a, int left, int right)
    {
        int x, k;
        int i, j;
        i = left;
        j = right;
        x = a[(left + right)/2];
        do
        {
            while (a[i]<x)
            {
                i++;
            }
            while (a[j] > x)
            {
                j--;
            }
            if (i<=j)
            {
                k = a[i];
                a[i] = a[j];
                a[j] = k;
                i++;
                j--;
            }

        } while (i<=j);
        if (left <j) Sort (ref a, left,j);
        if (i<right) Sort (ref a, i, right);  
    }
    static void Main()
    {
        int n;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Sort(ref array, 0, (n - 1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}