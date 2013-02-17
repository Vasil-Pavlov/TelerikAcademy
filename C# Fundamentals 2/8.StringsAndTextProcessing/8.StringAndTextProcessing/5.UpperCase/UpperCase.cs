using System;
using System.Text;

class UpperCase
{
    static void Main()
    {
        string text = "tova e nqkakuv si <upcase>string</upcase> I koito trqbva da ima <upcase>mnogo</upcase> dumi4ki";
        int startIndex = 0;
        int endIndex = 0;
        StringBuilder str = new StringBuilder();
        StringBuilder now = new StringBuilder();
        do
        {
            startIndex = text.IndexOf("<upcase>", startIndex);
            if (endIndex == 0 && startIndex > 0)
            {
                str.Append(text, endIndex, startIndex - endIndex);
            }
            else if (endIndex != 0 && startIndex > 0)
            {
                str.Append(text, endIndex + 8, startIndex - endIndex - 8);
            }
            else
            {
                str.Append(text, endIndex + 8, text.Length - endIndex - 8);
            }

            endIndex = text.IndexOf("</upcase>", endIndex);
            if (startIndex > 0)
            {
                for (int i = startIndex + 8; i < endIndex; i++)
                {
                    now.Append(text[i]);
                }
                str.Append(now.ToString().ToUpper());
                startIndex++;
                endIndex++;
                now.Clear();
            }
        }
        while (startIndex > 0);
        Console.WriteLine(str.ToString());
    }
}

