using System;
using System.IO;
class ReadFileContent
{
    static void Main()
    {

        string fileContent;
        string filePath = @"C:\test\text.txt";
        try
        {
            fileContent = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {

            Console.WriteLine("File[{0}] was not found ", filePath);
        }
        catch (NullReferenceException)
        {

            Console.WriteLine("Path is NULL");
        }
        catch (UnauthorizedAccessException)
        {

            Console.WriteLine("Occured a problem with the access.\n Possible reasond:\n1. Path specified a file that is read-only.");
            Console.WriteLine("2. This operation is not supported on the current platform.");
            Console.WriteLine("3. Path specified a directory.");
            Console.WriteLine("4. The caller does not have the required permission.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Access Denied.\nThe caller does not have the required permission.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid Path.\nPath contains one or more invalid characters/");
        }
    }
}
