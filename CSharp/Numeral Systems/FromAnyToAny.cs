using System;
using System.Text;

class FromAnyToAny
{
    static int ToDecimal(int system, string str)
    {
        int result = 0;
        int multiplyBy = 0;
        for (int i = 0; i < str.Length; i++)
        {

            switch (str[i])
            {

                case 'A': multiplyBy = 10; break;
                case 'B': multiplyBy = 11; break;
                case 'C': multiplyBy = 12; break;
                case 'D': multiplyBy = 13; break;
                case 'E': multiplyBy = 14; break;
                case 'F': multiplyBy = 15; break;
                default:
                    multiplyBy = (int)(str[i] - '0');
                    break;
            }
            result += Convert.ToInt32( multiplyBy * Math.Pow(system, str.Length - i-1));

        }
        return result;
    }
    static string DecimalToAny(int system, int number)
    {
        StringBuilder result = new StringBuilder();
        while (number>0)
        {
            if (number%system>=10)
            {
                switch (number%system)
                {
                    case 10: result.Append('A'); break;
                    case 11: result.Append('B'); break;
                    case 12: result.Append('C'); break;
                    case 13: result.Append('D'); break;
                    case 14: result.Append('E'); break;
                    case 15: result.Append('F'); break;
                    default:
                        break;
                }
            }
            else
            {
                result.Append(number % system);
            }
            
            number /= system;
        }
        string notReversed = result.ToString();
        StringBuilder reversed = new StringBuilder();
        for (int i = notReversed.Length - 1; i >=0; i--)
        {
            reversed.Append(notReversed[i]);
        }
        return reversed.ToString();
    }
   
    static void Main()
    {
        Console.Write("Choose system[2, 8, 10, 16]:");
        int from = int.Parse(Console.ReadLine());
        Console.Write("Choose system to convert[2, 8, 10, 16]:");
        int to = int.Parse(Console.ReadLine());
        Console.Write("Enter number to convert:");
        string number =Console.ReadLine();
        Console.WriteLine("{0}[{1}] ---> {2}[{3}]", number, from, DecimalToAny(to, ToDecimal(from,number)),to);
    }
}
