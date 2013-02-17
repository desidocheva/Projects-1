using System;
using System.Collections.Generic;
class SubsetOfKElements
{
    static void Main()
    {
        int n, sum = 0,i=0,k;
        int bitCounter = 0; //To check if the number's bits are K;
        bool thereIsSubset = false;//To check if there is a k-numbered subset with the given sum. If false -> "No"
        
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        } 
       
        Console.Write("Enter Sum:");
        int givenSum = int.Parse(Console.ReadLine());
        Console.Write("Enter subset's length:");
        k = int.Parse(Console.ReadLine());
        i = 1;

        List<int> Subset = new List<int>(); //list for saving the subset's numbers
        int subsets = (int)Math.Pow(2, n) - 1; //all the possible combinations of subsets
        while (i<subsets)
        {
            bitCounter = 0;
            sum = 0;
            Subset.Clear();
            for (int j = 0; j <= n; j++)
            {
                int mask = 1 << j;

                int bit = (i & mask) >> j;
                if (bit == 1)
                {
                    bitCounter++;
                    sum = sum + array[j];
                    Subset.Add(array[j]);
                }
            }
            i++;

            Subset.Sort(); // sort the current subset
            bool flag = true; // the flag is used to show if the element is first, if true - no "+" will be added before the element
                              // if "false" there will be added "+"; 
            if (sum == givenSum && bitCounter==k) //check if there is a K-numbered subset with the given sum;
            {
                thereIsSubset = true;
                Console.Write("yes, (");
                foreach (var element in Subset)
                {

                    if (flag == true)
                    {
                        Console.Write(element);
                        flag = false;

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
        if (thereIsSubset == false)
        {
            Console.WriteLine("No.");
        }
        Console.WriteLine();
    
    }
}