using System;
using System.Linq;
using System.Text;

class ReverseWords
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        text = text.Remove(text.Length-1,1);
        string[] words = text.Split(' ', ',');

        for (int i = words.Length-1; i >= 0; i--)
        {
            if (i==6)
            {
                Console.Write(words[i]);
                Console.Write(", ");
                continue ;
            }
            if (i == 0)
            {
                Console.Write(words[i]);
                break;

            }
            Console.Write(words[i] + " ");
        }
        Console.Write("!");
        Console.WriteLine();
    }
}

