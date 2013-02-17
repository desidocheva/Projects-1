/*
 Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;
class MergeSortedArray
{
    static List<int> MergeSort(List<int> list)
    {
        if (list.Count<=1)
        {
            return list;
        }
        
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }
        right = MergeSort(right);
        left = MergeSort(left);
        return Merge(left, right);

    }
    static List<int> Merge(List<int> left, List<int> Right)
    {
        List<int> result = new List<int>();
        while (left.Count>0 || Right.Count>0)
        {
            if (left.Count>0 && Right.Count>0)
            {
                if (left[0]<=Right[0])
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    result.Add(Right[0]);
                    Right.Remove(Right[0]);
                }
            }
            else
            {
                if (left.Count>0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    result.Add(Right[0]);
                    Right.Remove(Right[0]);
                }
            }
        }
        return result;
    }

    static void Main()
    {
        int n;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }
        List<int> sortedArray = new List<int>();
        sortedArray = MergeSort(array);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Sorted Array:");
        Console.ForegroundColor = ConsoleColor.White;
        foreach (var element in sortedArray)
        {
            Console.WriteLine(element);
        }
    }
}
