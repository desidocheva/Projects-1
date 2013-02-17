using System;

class Workdays
{
    public static DateTime[] holiday = 
    {
        new DateTime(2013, 01, 01),
        new DateTime(2013, 03, 03),
        new DateTime(2013, 05, 01),
        new DateTime(2013, 05, 06),
        new DateTime(2013, 09, 09),
        new DateTime(2013, 09, 06),
        new DateTime(2013, 09, 22),
        new DateTime(2013, 12, 25),
        new DateTime(2013, 12, 31)

    };
    
    static int workdays(DateTime day)
    {
        int sum = 0;
        DateTime today = DateTime.Today;
        bool flag = false;
        for (DateTime i = today; i < day; i = i.AddDays(1))
        {
            flag = false;
            if (i.DayOfWeek != DayOfWeek.Sunday &&
                    i.DayOfWeek != DayOfWeek.Saturday)
            {
                foreach (var item in holiday)
                {
                    if (item == i)
                    {
                        flag = true;
                        break;
                        
                    }
                }
                if (flag == false)
                {
                    sum++;
                }
            }
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Starting date[today] --{0}--",DateTime.Today);
        Console.Write("Enter year:");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter day:");
        int day = int.Parse(Console.ReadLine());
        DateTime endDay = new DateTime(year, month, day);

        Console.WriteLine(workdays(endDay));
    }
}
