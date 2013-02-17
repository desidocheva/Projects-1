using System;
//using System.Random;

class TenRandomNumbers
{
    static void Main()
    {
        Random number = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(number.Next(100,200));
        }
    }
}
