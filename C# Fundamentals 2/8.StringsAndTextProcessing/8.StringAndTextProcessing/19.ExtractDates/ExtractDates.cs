using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        string pat = "[0-3]*[0-9][.][0-1]*[0-9]+[.][1-2][0-9][0-9][0-9]";

        foreach (Match m in Regex.Matches(text, pat))
        {
            Console.WriteLine("'{0}' found at index {1}.",
                              m.Value, m.Index);
        }
    }
}

