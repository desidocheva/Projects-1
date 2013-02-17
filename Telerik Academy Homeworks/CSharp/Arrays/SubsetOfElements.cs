/*
 * We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

*/
using System;
using System.Collections.Generic;
class SubsetOfElements
{
    static void Main()
    {
        int n,sum=0;
        bool thereIsSubset = false;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter Sum:");
        int givenSum = int.Parse(Console.ReadLine());
        int k = 1;
        List<int> Subset = new List<int>();
        int subsets = (int)Math.Pow(2, n) - 1;
        while (k<subsets)
        {
            sum = 0;
            Subset.Clear();
            for (int i = 0; i <= n; i++)
            {
                int mask = 1 << i;
                
                int bit = (k & mask) >> i;
                if (bit==1)
                {
                    sum = sum + array[i];
                    Subset.Add(array[i]);
                }
            }
            k++;
            
            Subset.Sort();
            bool flag = false;
            if (sum == givenSum)
            {
                thereIsSubset = true;
                Console.Write("yes, (");
                foreach (var element in Subset)
                {
                    
                    if (flag==false)
                    {
                        Console.Write(element);
                        flag = true;

                    }
                    else
                    {
                        Console.Write(" + " + element);
                    }
                }
                Console.WriteLine(")");
                break;
            }
            
           
        }
        if (thereIsSubset==false)
        {
            Console.WriteLine("No.");
        }
        Console.WriteLine();
    
    }
}
