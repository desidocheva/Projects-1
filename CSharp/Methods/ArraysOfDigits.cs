using System;
using System.Collections.Generic;
class ArraysOfDigits
{
    static int[] MakeArray()
    {

        List<char> digits = new List<char>();
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == (char)13)
            {
                Console.WriteLine();
                break;
            }
            digits.Add((key.KeyChar));
        }
        int[] array = new int[digits.Count];
        int i = digits.Count - 1;
        foreach (var item in digits)
        {
            array[i] = item & 0x0f;
            i--;
        }
        return array;
    }
    static void Main()
    {

        Console.Write("Enter integer number:");
        int[] numberOne = MakeArray();
        Console.Write("Enter integer number again:");
        int[] numberTwo = MakeArray();
        Console.WriteLine("This is the array made from the first number:");
        for (int i = 0; i < numberOne.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, numberOne[i]);
        }
        Console.WriteLine();
        Console.WriteLine("This is the array made from the second number:");
        for (int i = 0; i < numberTwo.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, numberTwo[i]);
        }
        Console.WriteLine();
    }
}
