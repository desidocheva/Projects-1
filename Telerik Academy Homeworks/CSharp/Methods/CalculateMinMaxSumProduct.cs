using System;

class CalculateMinMaxSumProduct
{
    static int FindMin(params int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min>array[i])
            {
                min = array[i];
            }
        }
        return min;
    
    }
    static int FindMax(params int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;

    }
    static int FindSum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;

    }
    static double FindAverage(params int[] array)
    {
        double sum = (FindSum(array));
        return sum/array.Length;

    }
    static int FindProduct(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;

    }
    static void Main()
    {
        Console.Write("Enter array's length:");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Min is {0}",FindMin(array));
        Console.WriteLine("Max is {0}", FindMax(array));
        Console.WriteLine("Sum is {0}", FindSum(array));
        Console.WriteLine("Average is {0}", FindAverage(array));
        Console.WriteLine("Product is {0}", FindProduct(array));
    }
}
