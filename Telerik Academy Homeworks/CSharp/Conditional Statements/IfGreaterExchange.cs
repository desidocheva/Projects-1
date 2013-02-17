using System;

class IfGreaterExchange
{
    static void Main()
    {
        int numberOne, numberTwo;
        Console.Write("Enter number one:");
        numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number two:");
        numberTwo = int.Parse(Console.ReadLine());
        if (numberOne>numberTwo)
        {
            numberOne += numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne -=numberTwo;

        }
        Console.WriteLine("Number one is {0}\nNumber two is {1}",numberOne,numberTwo);
    }
}
