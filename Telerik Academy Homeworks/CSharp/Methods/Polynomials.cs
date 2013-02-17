using System;
using System.Collections.Generic;
class Polynomials
{
    static void Subtraction(List<int> cofficients, List<int> coefficientsTwo)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < coefficientsTwo.Count; i++)
        {
            result.Add(cofficients[i] - coefficientsTwo[i]);
        }
        RepresentPolonomial(result);
    }
    static void Multiplication(List<int> cofficients, List<int> coefficientsTwo)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < coefficientsTwo.Count; i++)
        {
            result.Add(cofficients[i] * coefficientsTwo[i]);
        }
        RepresentPolonomial(result);
    }
    static void RepresentPolonomial(List<int> coefficients)
    {
        int n = coefficients.Count;
        string polinomial = string.Empty;
        while(n >= 1)
        {
            if ( coefficients[coefficients.Count - n] == 0)
            {
                n--;
            }
            else
            {
                if (n == 1)
                {
                    polinomial += coefficients[coefficients.Count - n];
                    n--;
                }
                if (n == 2)
                {
                    if (coefficients[coefficients.Count - n] == 1)
                    {
                        polinomial += "x + ";
                    }
                    else
                    {
                        polinomial += coefficients[coefficients.Count - n] + "x + ";
                    }

                    n--;
                }
                if (n > 2)
                {
                    if (coefficients[coefficients.Count - n] == 1)
                    {
                        polinomial += "x^" + (n - 1) + " + ";
                    }
                    else
                    {
                        polinomial += coefficients[coefficients.Count - n] + "x^" + (n - 1) + " + ";
                    }

                    n--;
                }
            }
            

        }
        Console.WriteLine(polinomial);
    }
    static void Main()
    {
        List<int> coefficients = new List<int>();
        Console.Write("How much coefficients?");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first polinom's coefficients:");
        for (int i = 0; i < number; i++)
        {
            coefficients.Add(int.Parse(Console.ReadLine()));

        }
        RepresentPolonomial(coefficients);
        List<int> coefficientsTwo = new List<int>();
        Console.WriteLine("Enter the second polinom's coefficients:");
        for (int i = 0; i < number; i++)
        {
            coefficientsTwo.Add(int.Parse(Console.ReadLine()));

        }
        RepresentPolonomial(coefficientsTwo);
        Console.WriteLine("Subtraction:");
        Subtraction(coefficients, coefficientsTwo);
        Console.WriteLine();
        Console.WriteLine("Multiplication:");
        Multiplication(coefficients, coefficientsTwo);
    }
}