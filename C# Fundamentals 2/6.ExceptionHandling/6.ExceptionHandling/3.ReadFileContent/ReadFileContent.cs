using System;
using System.IO;

class ReadFileContent
{
    static void Main()
    {
        string text = "C:\\WINDOWS\\win.ini";
        string textReader = "";

        try
        {
            textReader = File.ReadAllText(text);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("TooLongPath");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Don't find directory");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File don't find");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Argument error");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Don't have access");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Not supported");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("Security Exception");
        }
        catch (IOException)
        {
            Console.WriteLine("Error with file");
        }
        Console.WriteLine(textReader);
    }
}

