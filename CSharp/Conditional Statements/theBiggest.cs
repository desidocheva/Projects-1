using System;

class theBiggest
{
    static void Main()
    {
        double realOne, realTwo, realThree;
        Console.Write("Enter real number:");
        realOne = double.Parse(Console.ReadLine());
        Console.Write("Enter real number:");
        realTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter real number:");
        realThree = double.Parse(Console.ReadLine());
        if (realOne>realTwo)
        {
            if (realTwo>realThree)
            {
                Console.WriteLine("The biggest one is {0}",realOne);
            }
            else
            {
                if (realOne<realThree)
                {
                    Console.WriteLine("The biggest one is {0}",realThree);
                }
                else
                {
                    Console.WriteLine("The biggest one is {0}", realOne);
                }
            }
        }
        else
        {
            if (realOne > realThree)
            {
                Console.WriteLine("The biggest one is {0}", realTwo);
            }
            else
            {
                if (realTwo < realThree)
                {
                    Console.WriteLine("The biggest one is {0}", realThree);
                }
                else
                {
                    Console.WriteLine("The biggest one is {0}", realTwo);
                }
            }
        }
    }
}