/*
Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
*/
using System;

class BinarySearch
{
    static int Search(int x, int[] arrayX,int arrayLength)
    {
        int min = 0, max = arrayLength - 1;
        while (min<max)
        {
            int middle = (min + max) / 2;
            if (arrayX[middle]<x)
            {
                min = middle + 1;
            }
            else
            {
                max = middle;
            }
        }
        if (min==max && arrayX[min]==x)
        {
            return min;
        }
        else
        {
            return -1;
        }
    }
    static void Main()
    {
        int n,element,index;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter sorted array with {0} integer elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the element you search:");
        element = int.Parse(Console.ReadLine());

        index=Search(element, array, n);
        if (index==-1)
        {
            Console.WriteLine("Element not found");
        }
        else
        {
            Console.WriteLine(index);
        }
    }
}
