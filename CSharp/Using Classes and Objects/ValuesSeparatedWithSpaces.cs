using System;

class ValuesSeparatedWithSpaces
{
    static void Main()
    {
        int sum = 0;
        string separated = "12 345 1 7 58 7";
        string[] str = separated.Split(' ');
        for (int i = 0; i < str.Length; i++)
        {
            sum += int.Parse(str[i]);
        }
        Console.WriteLine(sum);
    }
}