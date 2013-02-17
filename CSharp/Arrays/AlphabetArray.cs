/*
 Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

*/
using System;

class AlphabetArray
{
    static void Main()
    {
        string word;
        char[] alphabet = new char [27];
        //Give the for each array's element a value from ASCII table (for (a-z) - numbers from 97 to 122) 
        for (int i = 0; i < 26; i++)
        {
            alphabet[i]=(char)(97+i);

        }
        // alphabet contains all the letters from english's alphabet.
        Console.Write("Enter a word(a-z): ");
        word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (alphabet[j]==word[i])
                {
                    Console.Write(j + " ");
                }
            }
        }
        Console.WriteLine();
    }
}