//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter array's length:");
        int n = int.Parse(Console.ReadLine());
        int compare = 97,arrayOneLength=0, arrayTwoLength=0;
        char[] arrayOne = new char[n];
        char[] arrayTwo = new char[n];
        Console.WriteLine("Enter {0} letters for first array", n);
        for (int i = 0; i < n; i++)
        {
            arrayOne[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter {0} letters for second array", n);
        for (int i = 0; i < n; i++)
        {
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }
        compare = (int)arrayOne[0];
        for (int i = 0; i < n; i++)
        {
            if (arrayOne[i]==compare)
            {
                arrayOneLength++; compare++;
            }
            else
            {
                break;
            }
        }
        compare = (int)arrayTwo[0];
        for (int i = 0; i < n; i++)
        {
            if (arrayTwo[i] == compare)
            {
                arrayTwoLength++; compare++;
            }
            else
            {
                break;
            }
        }
        if (arrayOneLength>arrayTwoLength)
        {
            Console.WriteLine("First array's lexicographical order is bigger");
        }
        else if (arrayOneLength<arrayTwoLength)
        {
             Console.WriteLine("Second array's lexicographical order is bigger");
        }
        else
        {
            Console.WriteLine("Two arrays have equal length of lexicographical order!");
        }
    }
}
