using System;

class FirstBigger
{
    static bool Bigger(int[] array, int n, int position)
    {
        if (position == n - 1)
        {
            if (array[position] > array[position - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        else
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    static int First(int[] array, int n)
    {
        int i;
        bool thereIs = false;
        for (i = 0; i < n; i++)
        {
            if (Bigger(array,n,i))
            {
                thereIs = true;
                break;
            }
        }
        if (!thereIs)
        {
            return -1;
        }
        else
        {
            return array[i];
        }

    }
    static void Main()
    {
        Console.Write("Enter array's legth:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} element:", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(First(array,n));
    }
}
