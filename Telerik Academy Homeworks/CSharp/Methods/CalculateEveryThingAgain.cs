using System;

class CalculateEveryThingAgain
{
    static T FindMin<T>(params T[] array)
    {
        dynamic min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;

    }
    static T FindMax<T>(params T[] array)
    {
        dynamic max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;

    }
    static T FindSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;

    }
    static T FindAverage<T>(params T[] array)
    {
        dynamic sum = (FindSum(array));
        return sum / array.Length;

    }
    static T FindProduct<T>(params T[] array)
    {
        dynamic product = 1;
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
        Console.WriteLine("Min is {0}", FindMin(array));
        Console.WriteLine("Max is {0}", FindMax(array));
        Console.WriteLine("Sum is {0}", FindSum(array));
        Console.WriteLine("Average is {0}", FindAverage(array));
        Console.WriteLine("Product is {0}", FindProduct(array));
    }
}
