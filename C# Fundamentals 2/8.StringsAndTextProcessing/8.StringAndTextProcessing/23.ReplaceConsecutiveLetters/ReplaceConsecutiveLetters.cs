using System;
using System.Text;

class ReplaceConsecutiveLetters
{
    static void Main()
    {
        string text = "aaaaabbbabbcaaaccb";
        StringBuilder result = new StringBuilder();
        result.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                result.Append(text[i]);
            }
        }
        Console.WriteLine(result);
    }
}

