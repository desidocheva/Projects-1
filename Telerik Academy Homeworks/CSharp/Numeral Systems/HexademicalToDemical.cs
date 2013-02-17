using System;
using System.Collections.Generic;
class HexademicalToDemical
{
    static double Convert(List<char> hexademical)
    {
        double sum = 0;
        int multiplyBy;
        for (int i = 0; i < hexademical.Count - 1; i++)// i is changing until hexademical - 1, because of the pressed 'Enter';
        {

            switch (hexademical[i])
            {

                case 'A': multiplyBy = 10; break;
                case 'B': multiplyBy = 11; break;
                case 'C': multiplyBy = 12; break;
                case 'D': multiplyBy = 13; break;
                case 'E': multiplyBy = 14; break;
                case 'F': multiplyBy = 15; break;
                default:
                    multiplyBy = (int)(hexademical[i] - '0');
                    break;
            }
            sum += multiplyBy*Math.Pow(16, hexademical.Count - i - 2);// again because of the pressed 'Enter';
            
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter hexademical number[with upper-case letters]:");
        ConsoleKeyInfo key;
        List<char> hexademical = new List<char>();
        do
        {
            key = Console.ReadKey();
            hexademical.Add(key.KeyChar);
        }
        while (key.Key != ConsoleKey.Enter);
        Console.WriteLine();
        Console.WriteLine(Convert(hexademical));
    }
}
