using System;
using System.Collections.Generic;
class ThreeTasks
{
    static int Reverse(int number)
    {
        if (number<0)
        {
            throw new ArgumentException("Not valid choise. You should enter 1, 2, 3 or 4");
        }
        int reversedNumber = 0;
        while (number >= 1)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number /= 10;
        }

        return reversedNumber;
    }
    static double Average(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new ArgumentException("Empty Sequance!");
        }
        double sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        return sum / numbers.Count;
    }
    static double Equation(int a, double b)
    {
        if (a==0)
        {
            throw new ArgumentException("a should not be equal to zero.");
        }
        return -(b / a);
    }
    static void Main()
    {
        int choise;
        do
        {
            Console.WriteLine("--MENU--");
            Console.WriteLine("1. Reverse digits of a number");
            Console.WriteLine("2. Find the average of a sequance");
            Console.WriteLine("3. Solve equation [ax + b = 0]");
            Console.WriteLine("4. Exit");
            Console.Write("Choose one:");
            choise = int.Parse(Console.ReadLine());
            while (true)
            {
                if (choise<1 || choise>4)
                {
                    Console.WriteLine("Invalid choise!!");
                    break;
                }
                if (choise == 1)
                {
                    try
                    {
                        int numberToReverse;
                        Console.Write("Enter number to reverse:");
                        numberToReverse = int.Parse(Console.ReadLine());
                        Console.WriteLine(Reverse(numberToReverse));
                        break;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number is out of range");
                    }
                    catch (ArgumentException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    break;
                }
                if (choise == 2)
                {
                    try
                    {
                        Console.Write("Enter sequances's length:");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter sequance:");
                        List<int> sequance = new List<int>();
                        for (int i = 0; i < length; i++)
                        {
                            sequance.Add(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine("The average is:{0}",Average(sequance));
                        break;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number is out of range");
                    }
                    catch (ArgumentException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                   
                    break;
                }
                if (choise == 3)
                {
                    try
                    {
                        int a;
                        double b;
                        Console.Write("Enter a:");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Enter b:");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine(Equation(a,b));
                        break;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number is out of range");
                    }
                    catch (ArgumentException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    
                    break;
                }
                if (choise == 4)
                {
                    break;
                }
            }
        }
        while (choise != 4);
       
    }
}
