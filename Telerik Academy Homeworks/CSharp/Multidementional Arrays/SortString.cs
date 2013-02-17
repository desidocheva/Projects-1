using System;

class SortString
{
    static void Sort(ref string[] a, int left, int right)
    {
        string x, k;
        int i, j;
        i = left;
        j = right;
        x = a[(left + right) / 2];
        do
        {
            while (a[i].Length < x.Length)
            {
                i++;
            }
            while (a[j].Length > x.Length)
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
        int n;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("element " + i + "=");
            array[i] = Console.ReadLine();
        }
        Sort( ref array, 0, n - 1);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
