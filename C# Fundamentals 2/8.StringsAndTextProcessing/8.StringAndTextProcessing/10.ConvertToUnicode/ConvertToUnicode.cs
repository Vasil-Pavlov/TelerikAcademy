using System;
using System.Text;

class ConvertToUnicode
{
    static void Main()
    {
        string word = "Hi!";
        foreach (char character in word)
        {
            Console.Write("\\u{0:x4}", (int)character);
        }
        Console.WriteLine();
    }
}

