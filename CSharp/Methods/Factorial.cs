using System;
using System.Numerics;
class Factorial
{
    static void fact(int n)
    {
        BigInteger calculateFact=1;
        for (int i = 1; i <= n; i++)
        {
            calculateFact *= i;
        }
        Console.WriteLine("{0}! = {1}",n,calculateFact);
    }
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            fact(i);
        }
    }
}
