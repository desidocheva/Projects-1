using System;

class IsLeapYear
{
    static void Main()
    {
        Console.Write("Enter year:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year));
    }
}