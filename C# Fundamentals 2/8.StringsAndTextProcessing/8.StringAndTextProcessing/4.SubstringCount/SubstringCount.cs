using System;
using System.Text;

class SubstringCount
{
    static void Main()
    {
        string text = "tova e nqkakuv si string, Ikoito trqbva da ima mnogo dumi4ki";
        string substring = "i";
        int count = 0;
        int index = 0;
        StringComparison caseInsensitive = StringComparison.OrdinalIgnoreCase;
        do
        {
            index = text.IndexOf(substring, index, caseInsensitive);
            index++;
            count++;
        }
        while (index > 0);
        count--;
        Console.WriteLine(count);
    }
}

