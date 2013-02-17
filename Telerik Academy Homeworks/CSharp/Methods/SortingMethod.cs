using System;

class SortingMethod
{
    static int findMax(int[] array,int indexStart)
    {
        int max = array[indexStart];
        int indexMax = indexStart;
        for (int i = indexStart; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                indexMax = i;
                max = array[i];
            }
        }
        return indexMax;
    }
    static void DescendingSort(ref int[] array)
    {
        int save;
        int maxFromTheRest;
        for (int i = 0; i < array.Length; i++)
        {
            maxFromTheRest = findMax(array, i);
            save = array[i];
            array[i] = array[maxFromTheRest];
            array[maxFromTheRest] = save;
        }
    }
    static int[] AscendingSort(ref int[] array)
    {
        int[] arrayAscendingOrder = new int[array.Length];
        DescendingSort(ref array);
        for (int i = array.Length - 1; i >= 0; i--)
        {
            arrayAscendingOrder[array.Length - i - 1] = array[i];
        }
        return arrayAscendingOrder;
    }
    static void Main()
    {
        Console.Write("Enter array's length:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Descending order:");
        DescendingSort(ref array);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Ascending order:");
        int[] arrayAscending = AscendingSort(ref array);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arrayAscending[i]);
        }
    }
}
