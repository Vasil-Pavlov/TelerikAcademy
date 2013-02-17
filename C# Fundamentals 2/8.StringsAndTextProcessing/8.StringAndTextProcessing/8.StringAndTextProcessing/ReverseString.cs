using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string word = Console.ReadLine();
        StringBuilder reversedWord = new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }
        Console.WriteLine(reversedWord.ToString());
    }
}

