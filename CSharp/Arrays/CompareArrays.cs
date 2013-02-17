//Write a program that reads two arrays from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter array's length:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[n];
        int[] arrayTwo = new int[n];
        Console.WriteLine("Enter {0} elements for first array",n);
        for (int i = 0; i < n; i++)
	    {
             arrayOne[i] = int.Parse(Console.ReadLine());
		}
        Console.WriteLine("Enter {0} elements for second array", n);
        for (int i = 0; i < n; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (arrayOne[i]==arrayTwo[i])
            {
                Console.WriteLine("{0} = {1}",arrayOne[i],arrayTwo[i]);
            }
            else
            {
                Console.WriteLine("{0} != {1}", arrayOne[i], arrayTwo[i]);
            }
        }
    }
}

