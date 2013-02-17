using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexademical
{
    static string Convert(string foutDigits)
    {
        StringBuilder result = new StringBuilder();
        int j=0, i=0;
        StringBuilder partition = new StringBuilder();
        while(j<foutDigits.Length)
        {
            partition.Append(foutDigits[j]);
            i++;
            j++;
            if (i==4)
            {
                i = 0;
                switch (partition.ToString())
                {
                    case "0000": result.Append('0'); break;
                    case "0001": result.Append('1'); break;
                    case "0010": result.Append('2'); break;
                    case "0011": result.Append('3'); break;
                    case "0100": result.Append('4'); break;
                    case "0101": result.Append('5'); break;
                    case "0110": result.Append('6'); break;
                    case "0111": result.Append('7'); break;
                    case "1000": result.Append('8'); break;
                    case "1001": result.Append('9'); break;
                    case "1010": result.Append('A'); break;
                    case "1011": result.Append('B'); break;
                    case "1100": result.Append('C'); break;
                    case "1101": result.Append('D'); break;
                    case "1110": result.Append('E'); break;
                    case "1111": result.Append('F'); break;
                    default:
                        break;
                }
                partition.Clear();
            }    
        }
        return result.ToString();
    }
    
    static void Main()
    {
        Console.Write("Enter binary number:");
        string binaryNumber = Console.ReadLine();
        StringBuilder fourDigits = new StringBuilder();
        if (binaryNumber.Length%4!=0)
        {
            fourDigits.Append('0', 4 - binaryNumber.Length % 4);
        }
        fourDigits.Append(binaryNumber);
        Console.WriteLine("Hexademical:");
        Console.WriteLine(Convert(fourDigits.ToString()));
    }
}
