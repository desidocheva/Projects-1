using System;
using System.Collections.Generic;

class SquareRoot
{
    static double Sqrt(int value)
    {
        if (value<0)
        {
            throw new ArgumentOutOfRangeException("Undefined operation for negative number");    
        }
        return Math.Sqrt(value);
    }
    static void Main()
    {
        int number;

        try
        {
            number = int.Parse(Console.ReadLine());
            Sqrt(number);
        }
        catch (ArgumentOutOfRangeException fe)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}
