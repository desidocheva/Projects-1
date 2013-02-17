using System;
using System.Collections.Generic;
class BinaryToDecimal
{
    static double Convert(List<char> binary)
    {
        double sum = 0;
        for (int i = 0; i < binary.Count; i++)
        {
            if (binary[i] == '1')
            {
                sum += Math.Pow(2, binary.Count - i - 2);
            }
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter binary number:");
        ConsoleKeyInfo key;
        List<char> binary = new List<char>();
        do
        {
            key = Console.ReadKey();
            binary.Add(key.KeyChar);
        }
        while (key.Key != ConsoleKey.Enter);
        Console.WriteLine();
        Console.WriteLine(Convert(binary));
    }
}
