using System;

class HelloMethod
{
    static void PrintFirstName(string name)
    {
        Console.WriteLine("Hello,{0}! ", name);
    }

    static void Main()
    {
        Console.Write("Enter a name:");
        string name = Console.ReadLine();
        PrintFirstName(name);
    }
}

