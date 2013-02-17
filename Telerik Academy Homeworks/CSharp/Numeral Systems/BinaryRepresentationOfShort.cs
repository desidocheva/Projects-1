using System;
using System.Collections.Generic;
using System.Text;
class BinaryRepresentationOfShort
{
    static string Convert(short number)
    {
        List<int> notReversedBinary = new List<int>();
        while (number > 0)
        {
            if (number % 2 == 1)
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
        StringBuilder result = new StringBuilder();
        result.Append('0', 16 - binary.Count);
        foreach (var item in binary)
        {
            result.Append(item);
        }
        result.Insert(8, " ");
        return result.ToString();
    }
    static void Main()
    {
        Console.Write("Enter number to represent:");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert(number));
    }
}
