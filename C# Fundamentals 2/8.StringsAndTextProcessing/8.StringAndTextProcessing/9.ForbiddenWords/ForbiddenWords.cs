using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = "PhP We are living in a yellow submarine. Microsoft  don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string forbiddenWords = "Microsoft Linux PhP";
        string[] forbidden = forbiddenWords.Split(' ', ',', '\t', '\n', ' ');

        foreach (string item in forbidden)
        {
            text = text.Replace(item, new string('*', item.Length));
        }
        Console.WriteLine(text);
    }
}

