/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
*/
using System;

class SequenceOfGivenSum
{
    static void Main()
    {

        int n,  indexEnd = 0, indexStart = 0, j = 0, i, sum = 0;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int sumOfSequence;
        Console.Write("Enter sum:");
        sumOfSequence = int.Parse(Console.ReadLine());
        i = 0;
        while (j != (n - 2))
        {
            if (i == (n - 1))
            {
                j++;
                i = j;
                sum = 0;
            }
            sum += array[i];
            if (sum==sumOfSequence)
            {
                indexEnd = i;
                indexStart = j;
            }
            i++;
        }
        for (i = indexStart; i < indexEnd; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine(array[indexEnd]);
    }
}
