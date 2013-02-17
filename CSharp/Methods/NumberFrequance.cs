using System;

class NumberFrequance
{
    static int Frequance(int number, int[] array, int n)
    {
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i]==number)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter array's legth:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} element:",i+1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number you want to search for:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} --> {1} times",number,Frequance(number,array,n));
    }
}