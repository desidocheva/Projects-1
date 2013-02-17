using System;

class CalculateSurface
{
    static void Main()
    {
        double surface = 0;

        //by  side and altitude
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter altitude:");
        double altitude = double.Parse(Console.ReadLine());
        surface = a * altitude / 2;
        Console.WriteLine("Surface is {0}",surface);

        //by  three sides
        Console.WriteLine("Enter side a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side c:");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2;
        surface = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine("Surface is {0}", surface);

        //by  two sides and angle between them
        Console.WriteLine("Enter side a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter angle:");
        double angle = double.Parse(Console.ReadLine());
        surface = a*b*Math.Sin(angle)/2;
        Console.WriteLine("Surface is {0}", surface);

    }
}
