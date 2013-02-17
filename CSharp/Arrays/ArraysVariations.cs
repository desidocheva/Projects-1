using System;

class ArraysVariations
{
    static void var(int[] array, int k, int n)
    {
        if (k == array.Length)
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
            for (int i = 1; i <= n; i++)
            {
                array[k] = i;
                var(array, k + 1, n);
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
        var(array, 0, n);

    }
}