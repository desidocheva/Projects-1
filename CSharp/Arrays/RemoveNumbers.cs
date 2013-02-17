using System;
using System.Collections.Generic;
class RemoveNumbers
{
    static void Main()
    {
        int n, j = 0, i, count = 0, maxCount = 0;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter {0} elements", n);
        List<int> newArray = new List<int>();
        List<int> maxCountArray = new List<int>();
        for (i = 0; i < n; i++)
        {
            newArray.Add(int.Parse(Console.ReadLine()));
        }

        int k = 1;

        List<int> Subset = new List<int>(); //list for saving the subset's numbers
        int subsets = (int)Math.Pow(2, n) - 1; //all the possible combinations of subsets

        while (k <= subsets)
        {
            count = 0;
            Subset.Clear();
            for (j = 0; j <= n; j++)
            {
                int mask = 1 << j;

                int bit = (k & mask) >> j;
                if (bit == 1)
                {
                    
                    Subset.Add(newArray[j]);
                }
            }
           
                for (i = 0; i < Subset.Count-1; i++)
                {
                    if (Subset[i]<=Subset[i+1])
                    count++;
                    else
                    {
                        count = 0; break;
                    }
                    
                }

            if (maxCount < count)
            {
                maxCountArray.Clear();
                maxCount = count;
                for (int m = 0; m < Subset.Count; m++)
                {
                    maxCountArray.Add(Subset[m]);
                }

            }

            k++;


        }
        Console.Write("{ ");
        foreach (var element in maxCountArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("}");
    }
}