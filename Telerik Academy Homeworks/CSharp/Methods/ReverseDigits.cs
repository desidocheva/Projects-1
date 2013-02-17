using System;
using System.Collections.Generic;
class ReverseDigits
{
    static int Reverse(int number)
    {
        int reversedNumber = 0;
        while (number>=1)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }

        return reversedNumber;
    }
    static void Main()
    {

        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} <--> {1}",number,Reverse(number));

    }
}