using System;
using System.Collections.Generic;
class DecimalToHexademical
{
    static void Convert(int number)
    {
        List<char> notReversedHexademical = new List<char>();
        while (number > 0)
        {
            switch (number%16)
            {
                case 10: notReversedHexademical.Add('A'); break;
                case 11: notReversedHexademical.Add('B'); break;
                case 12: notReversedHexademical.Add('C'); break;
                case 13: notReversedHexademical.Add('D'); break;
                case 14: notReversedHexademical.Add('E'); break;
                case 15: notReversedHexademical.Add('F'); break;
                case 1: notReversedHexademical.Add('1'); break;
                case 2: notReversedHexademical.Add('2'); break;
                case 3: notReversedHexademical.Add('3'); break;
                case 4: notReversedHexademical.Add('4'); break;
                case 5: notReversedHexademical.Add('5'); break;
                case 6: notReversedHexademical.Add('6'); break;
                case 7: notReversedHexademical.Add('7'); break;
                case 8: notReversedHexademical.Add('8'); break;
                case 9: notReversedHexademical.Add('9'); break;

            }
            number /= 16;
        }
        List<char> hexademical = new List<char>();
        for (int i = notReversedHexademical.Count - 1; i >= 0; i--)
        {
            hexademical.Add(notReversedHexademical[i]);
        }
        foreach (var item in hexademical)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter number to convert:");
        int number = int.Parse(Console.ReadLine());
        Convert(number);
    }
}
