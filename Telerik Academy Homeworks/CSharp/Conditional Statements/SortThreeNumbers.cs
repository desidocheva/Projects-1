using System;

class SortThreeNumbers
{
    static void Main()
    {
        double realOne, realTwo, realThree;
        byte which;
        Console.Write("Enter real number:");
        realOne = double.Parse(Console.ReadLine());
        Console.Write("Enter real number:");
        realTwo = double.Parse(Console.ReadLine());
        Console.Write("Enter real number:");
        realThree = double.Parse(Console.ReadLine());
        if (realOne > realTwo)
        {
            if (realTwo > realThree)
            {
                which = 1;
                Console.Write("{0}", realOne);
            }
            else
            {
                if (realOne < realThree)
                {   
                    which=3;
                    Console.Write("{0}", realThree);
                }
                else
                {
                    which = 1;
                    Console.Write("{0}", realOne);
                }
            }
        }
        else
        {
            if (realOne > realThree)
            {
                which = 2;
                Console.Write("{0}", realTwo);
            }
            else
            {
                if (realTwo < realThree)
                {
                    which = 3;
                    Console.Write("{0}", realThree);
                }
                else
                {
                    which = 2;
                    Console.Write("{0}", realTwo);
                }
            }
        }
        switch (which)
        {
            case 1: if (realTwo>realThree)
                {
                    Console.WriteLine(", {0}, {1}", realTwo,realThree);
                }
                else Console.WriteLine(", {0}, {1}", realThree,realTwo);
                break;
            case 2: if (realOne > realThree)
                {
                    Console.WriteLine(", {0}, {1}", realOne, realThree);
                }
                else Console.WriteLine(", {0}, {1}", realThree, realOne);
                break;
            case 3: if (realTwo > realOne)
                {
                    Console.WriteLine(", {0}, {1}", realTwo, realOne);
                }
                else Console.WriteLine(", {0}, {1}", realOne, realTwo);
                break;
        }
    }
}
