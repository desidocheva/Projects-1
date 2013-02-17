using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class MemoryTest
{
    // From given line number returns the content of that line(string)
    static string GetLine(string fileName, int line)
    {
        using (var sr = new StreamReader(fileName, Encoding.GetEncoding("Windows-1251")))
        {
            for (int i = 1; i < line; i++)
                sr.ReadLine();
            return sr.ReadLine();
        }
    }
    // Makes file with certain number words using the GetLine method
    static void MakeFile(int lineLength)
    {
        StreamWriter writer = new StreamWriter(@"..\..\1.txt", false, Encoding.GetEncoding("Windows-1251"));

        Random randomLine = new Random();
        string someWord;
        using (writer)
        {
            for (int i = 0; i < lineLength; i++)
            {
                someWord = GetLine(@"..\..\All.txt", randomLine.Next(0, 369));
                writer.WriteLine(someWord);
            }
        }


    }
    static void Main()
    {
        
        Console.WriteLine("Проверете силата на вашата памет :))\nКомпютърът ще ви подава произволна дума на всеки 10 секунди");
        Console.WriteLine("Когато думите свършат(в зависимост от избраното ниво) е ваш ред да попълвате.\nРедът на думите има значение.");
        Console.WriteLine();
        int level = 0;
        while (level<1 || level>4)
        {
            Console.Write("1 ниво - 5 думи \n2 ниво - 7 думи\n3 ниво - 10 думи\n4 ниво - 15 думи\nИзберете ниво: ");
            level = int.Parse(Console.ReadLine());
        }
        
        switch (level)
        {
            case 1: MakeFile(5); break;
            case 2: MakeFile(7); break;
            case 3: MakeFile(10); break;
            case 4: MakeFile(15); break;
            default: Console.WriteLine("Некоректен избор!");
                break;
        }
        
        int lineNumber = 0, wordCounter = 0;
        StreamReader reader = new StreamReader(@"..\..\1.txt", Encoding.GetEncoding("Windows-1251"));
        String line = reader.ReadLine();
        while (line != null)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine(10 - i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition((Console.WindowWidth / 2), (Console.WindowHeight / 2) + 3);
                Console.WriteLine(line);
                Thread.Sleep(1000);
                Console.Clear();
            }
            lineNumber++;
            line = reader.ReadLine();
        }
        reader.Close();
        Console.ForegroundColor = ConsoleColor.White;
        StreamReader readerTwo = new StreamReader(@"..\..\1.txt", Encoding.GetEncoding("Windows-1251"));
        using (readerTwo)
        {

            string word;
            bool flag = false; // shows if the previous word is correct or not

            for (int i = 0; i < lineNumber; i++)
            {
                line = readerTwo.ReadLine();
                Console.Write("{0}. ", i + 1);
                word = Console.ReadLine();
                if (word.Equals(line, StringComparison.OrdinalIgnoreCase)) //--> ignores upper-lower difference
                {
                    wordCounter++; //rises the number of correct words
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        Console.WriteLine("Вие имате {0} правилни думи!", wordCounter);
        Console.WriteLine();

    }
}