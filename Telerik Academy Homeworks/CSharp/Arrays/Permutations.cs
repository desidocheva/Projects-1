using System;
using System.Collections.Generic;
class Permutations
{
    static void ChangePlace(ref int first, ref int second)
    {
        int third;
        third = first;
        first = second;
        second = third;
    }
    static void Permutation(int[] array, int n, int number)
    {
        if (number == n)
        {
            Console.Write("{");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine(array[n-1] + "}" );
        }
        else
        {
            for (int i = number; i <= n; i++)
            {
                ChangePlace(ref array[number], ref array[i]);
                Permutation(array, n, number+1);
                ChangePlace(ref array[number], ref array[i]);
            }
        }
        
    }
    static void Main()
    {
        int n;
        Console.Write("Enter number N:");
        n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;

        }
        Permutation(array, n-1, 0);
    

    }
}
