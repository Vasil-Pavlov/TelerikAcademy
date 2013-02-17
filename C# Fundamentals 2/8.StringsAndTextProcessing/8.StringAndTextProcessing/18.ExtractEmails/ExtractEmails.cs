using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string pattern = @"(\w+\S\w+)[@](\w+)[.](\w+\w+\S*\w*)";

        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.",
                              m.Value, m.Index);
        }
    }
}

