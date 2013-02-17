using System;

class convertNumber
{
    static void Main()
    {
        int number;
        string result="";
        number = int.Parse(Console.ReadLine());
        if (number==0)
        {
            result="Zero";
        }
        if (number>99 && number<1000)
        {
                switch (number / 100)
                {
                    case 1: result += "One hundred "; break;
                    case 2: result += "Two hundred "; break;
                    case 3: result += "Three hundred "; break;
                    case 4: result += "Four hundred "; break;
                    case 5: result += "Five hundred "; break;
                    case 6: result += "Six hundred "; break;
                    case 7: result += "Seven hundred "; break;
                    case 8: result += "Eight hundred "; break;
                    case 9: result += "Nine hundred "; break;
                }
                if (((number / 10) % 10 == 0 && number % 10 != 0) || (number / 10) % 10 == 1 || ((number/10)%10!=0 && number % 10 == 0))
                {
                    result += "and ";
                }
            
            number = number % 100;
        }
        if (number>9 && number<100)
        {
            switch (number / 10)
            {
                case 1:
                    switch (number%10)
                    {
                        case 0: result += "ten"; break;
                        case 1: result += "eleven"; break;
                        case 2: result += "twelve"; break;
                        case 3: result += "thirteen"; break;
                        case 4: result += "fourteen"; break;
                        case 5: result += "fifteen"; break;
                        case 6: result += "sixteen"; break;
                        case 7: result += "seventeen"; break;
                        case 8: result += "eighteen"; break;
                        case 9: result += "nineteen"; break;
                    }
                    number = 0; break;
                case 2: result += "twenty "; break;
                case 3: result += "thirty "; break;
                case 4: result += "forty "; break;
                case 5: result += "fifty "; break;
                case 6: result += "sixty "; break;
                case 7: result += "seventy "; break;
                case 8: result += "eighty "; break;
                case 9: result += "ninety "; break;

            }
            if (number%10!=0)
            {
                result += "- ";
            }
            number = number % 10;
        }
        switch (number)
        {
            case 1: result += "one"; break;
            case 2: result += "two"; break;
            case 3: result += "three"; break;
            case 4: result += "four"; break;
            case 5: result += "five"; break;
            case 6: result += "six"; break;
            case 7: result += "seven"; break;
            case 8: result += "eight"; break;
            case 9: result += "nine"; break;
        }
        result = char.ToUpper(result[0]) + result.Substring(1);
        Console.WriteLine(result);
    }
}
