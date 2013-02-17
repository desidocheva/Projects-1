using System;

class SumNull
{
    static void Main()
    {
        byte n;
        bool k = false;
        int sum = 0;
        n = 5;
        //n = byte.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += numbers[j];
                if (sum==0)
                {
                    k = true;
                    break;
                }
            }
        }
        Console.WriteLine(k);
    }
}
