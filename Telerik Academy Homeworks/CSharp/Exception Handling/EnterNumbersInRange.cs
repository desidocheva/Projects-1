using System;

class EnterNumbersInRange
{
    static int ReadNumber(int start, int end)
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number <= start || number>= end)
            {
                string message = "Number is out of the range (" + start + ", " + end + ")";
                throw new ArgumentOutOfRangeException("Number out of range ", message);

            }
            return number;
        }
        catch(FormatException fe)
        {
            throw new ArgumentOutOfRangeException("Text out of format","The entered text is non-number");

        }

    }
    static void Main()
    {
        int[] array = new int[10];
        int lastNumber = 1;
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter element {0} ", i);
                    array[i] = ReadNumber(lastNumber, 100);
                    lastNumber = array[i];
                    break;
                }
                catch (ArgumentOutOfRangeException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(fe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
        }
    }
}
