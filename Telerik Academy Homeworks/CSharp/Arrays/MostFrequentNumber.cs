/*
   Write a program that finds the most frequent number in an array. 
 */
using System;

class MostFrequentNumber
{
    static void Main()
    {
        int n, maxCount=0, count=0, index = 0,number=0;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        foreach (var element in array)
        {
            count = 0;
            for (int i = 0; i < n; i++)
            {
                
                if (element==array[i])
                {
                    count++;
                   
                }
            }
            if (maxCount<count)
            {
                maxCount = count;
                number = element;
            }
        }
        Console.WriteLine("{0}({1} times)",number,maxCount);
    }
}
