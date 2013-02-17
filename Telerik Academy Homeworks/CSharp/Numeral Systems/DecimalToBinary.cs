using System;
using System.Collections.Generic;
class DecimalToBinary
{
    static void Convert(int number)
    {
        List<int> notReversedBinary = new List<int>();
        while (number>0)
        {
            if (number%2==1)
            {
                notReversedBinary.Add(1);
            }
            else
            {
                notReversedBinary.Add(0);
            }
            number /= 2;
        }
        List<int> binary = new List<int>();
        for (int i = notReversedBinary.Count - 1; i >= 0; i--)
        {
            binary.Add(notReversedBinary[i]);
        }
        foreach (var item in binary)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Convert(58);
    }
}
