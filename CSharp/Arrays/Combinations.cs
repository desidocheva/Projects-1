using System;

class Combinations
{
    static void Comb(int[] array, int k, int n, int number)
    {
        if (k==array.Length)
        {
            Console.Write("{");
            for (int i = 0; i < k - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine(array[k - 1] + "}");
        }

        else
        {
            for (int i = number; i <= n; i++)
            {
                array[k] = i;
                
                Comb(array, k + 1, n,i+1);
            }
        }
    }
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[k];
        Comb(array, 0, n,1);
    }
}
