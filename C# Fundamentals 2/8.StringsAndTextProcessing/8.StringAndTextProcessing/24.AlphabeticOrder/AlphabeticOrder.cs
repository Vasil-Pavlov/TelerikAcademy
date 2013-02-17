using System;

class AlphabeticOrder
{
    static void Main()
    {
        string text = "She uchish li she bachkash li? Be kvo she bachkash " +
                      "be? Tui vashto uchene li e? Ia po-hubavo opitai da " +
                      "BACHKASH da se uchish malko! Uchish ne uchish trqbva "+
                      "da bachkash!";
        string[] words = text.Split(' ', '.', ',', '-', '?', '!');

        foreach (string item in words)
        {
            if (!string.IsNullOrEmpty(item.Trim()))
            {
                Console.WriteLine(item);
            }

        }
        Array.Sort(words);
        Console.WriteLine();
        Console.WriteLine("SORTED");
        Console.WriteLine();

        foreach (string item in words)
        {
            if (!string.IsNullOrEmpty(item.Trim()))
            {
                Console.WriteLine(item);
            }
        }
    }
}

