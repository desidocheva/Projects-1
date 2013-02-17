using System;
class BinSearch
{
    static void Sort(ref int[] a, int left, int right)
    {
        int x, k;
        int i, j;
        i = left;
        j = right;
        x = a[(left + right) / 2];
        do
        {
            while (a[i] < x)
            {
                i++;
            }
            while (a[j] > x)
            {
                j--;
            }
            if (i <= j)
            {
                k = a[i];
                a[i] = a[j];
                a[j] = k;
                i++;
                j--;
            }

        } while (i <= j);
        if (left < j) Sort(ref a, left, j);
        if (i < right) Sort(ref a, i, right);
    }
    static void Main()
    {
        int n,index,k;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("element " + i + "=");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number K:");
        k = int.Parse(Console.ReadLine());
        Sort( ref array, 0, (n - 1));
        index = Array.BinarySearch(array, k);
        if (index>=0)
        {
            Console.WriteLine(array[index]);
        }
        else
        {
            if (~index ==0)
            {
                Console.WriteLine("There is no element <=K");
            }
            else
            {
                Console.WriteLine(array[~index -1]);
            }
        }
    }
    
   
}
