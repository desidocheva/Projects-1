using System;

class Name
{

    static void YourName(string name)
    {
        Console.WriteLine("Your name is {0}",name);
    }
    static void Main()
    {

        string name;
        Console.WriteLine("What's your name ");
        name = Console.ReadLine();
        YourName(name);
    }
}
