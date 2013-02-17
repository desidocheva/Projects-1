using System;

class bonusScores
{
    static void Main()
    {
        int digit;
        bool isDigit=true;
        digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                digit = digit * 10; break;
            case 4:
            case 5:
            case 6:
                digit = digit * 100; break;
            case 7:
            case 8:
            case 9:
                digit = digit * 1000; break;

            default:
                Console.WriteLine("Error!!");
                isDigit = false;
                break;
        }
        if (isDigit==true)
        {
            Console.WriteLine("Multiplied number is {0}", digit);
        }
        
    }
}
