using System;
using System.Collections.Generic;
class PrimeNumbers
{
    static void Main()
    {
        int n;
        Console.Write("You want me to find all the prime number less or equal to:");
        n = int.Parse(Console.ReadLine());
        List<int> primeNumbers = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            primeNumbers.Add(i);
        }
        for (int i = 4; i <= n; i+=2)
        {
            primeNumbers.Remove(i);
        }
        for (int i = 6; i <= n; i+=3)
        {
            primeNumbers.Remove(i);
        }
        for (int i = 10; i <= n; i += 5)
        {
            primeNumbers.Remove(i);
        }
        foreach (var element in primeNumbers)
        {
            Console.Write(element + " ");
        }
    }
}