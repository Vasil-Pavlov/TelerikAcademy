using System;
using System.Text;

class FillWithAsterisks
{
    static void Main()
    {
        string sentence = Console.ReadLine();

        if (sentence.Length < 20)
        {
            sentence = sentence + new String('*', 20 - sentence.Length);
        }
        Console.WriteLine(sentence);
    }
}

