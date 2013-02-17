using System;

class maxValue
{
    static void Main()
    {
        double[] numbers = new double[5];
        double max=0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number {0}:",i+1);
            numbers[i] = double.Parse(Console.ReadLine());


        }
        max = numbers[0];
        for (int i = 0; i < 5; i++)
        {
            if (max<numbers[i])
            {
                max = numbers[i];
            }

        }
        Console.WriteLine(max);
    }
}
