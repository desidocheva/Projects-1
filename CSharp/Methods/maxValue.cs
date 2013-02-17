using System;

class maxValue
{
    static int GetMax(int numberOne, int numberTwo)
    {
        if (numberOne >= numberTwo)
        {
            return numberOne;
        }
        else
        {
            return numberTwo;
        }
    }
    static void Main()
    {
        int numberOne, numberTwo, numberThree;
        Console.Write("Number one:");
        numberOne = int.Parse(Console.ReadLine());
        Console.Write("Number two:");
        numberTwo = int.Parse(Console.ReadLine());
        Console.Write("Number three:");
        numberThree = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is " + GetMax(GetMax(numberOne,numberTwo),numberThree));
    }
}