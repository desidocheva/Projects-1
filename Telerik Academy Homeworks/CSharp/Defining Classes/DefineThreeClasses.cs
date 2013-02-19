using System;
class DefineThreeClasses
{
    /*
    Всички задачи са писани на едно. За проверка на дадена част разкоментирайте съответната част от кода.
    */
    static void Main()
    {   
        
        /*
        GSMTest test = new GSMTest();
        test.Print();
        test.PrintIPhone();
         */

        //GSM mobileOne = new GSM("Galaxy Gio", "Samsung", "Toshko", 250); // Конструктор без въвеждане на дисплей и батерия
        Battery battery = new Battery("Boshko's battery", 543, 457);
        Display display = new Display(3.4, 14);
        GSM mobileTwo = new GSM("Galaxy Mini", "Samsung", "Boshko", 200, battery, display); // Конструктор с въвеждане на дисплей и батерия
        mobileTwo.AddCall("0879345234", 66);
        mobileTwo.AddCall("0877777777", 166);
        mobileTwo.AddCall("0879345234", 69);

        Console.WriteLine(mobileTwo.CalcTotalPrice(1)); //извежда сумата на всички проведени разговори
        int max = 0; //променлива за запазване на максимална стойност
        string number = ""; // променлива за запазване на номера, съответстващ на макс. стойност

        //намираме разговора с най-дълъг разговор
        foreach (var item in mobileTwo.CallHistory)
        {
            if (max<item.Duration)
            {
                max = item.Duration;
                number = item.DailedPhone;
            }
        }

        
        mobileTwo.RemoveCall(number, max); //трие разговора с най-дълъг разговор
        Console.WriteLine(mobileTwo.CalcTotalPrice(1)); //отново извежда сумата на всички проведени разговори

        mobileTwo.ClearHistory(); //чисти хронологията
    }
}
