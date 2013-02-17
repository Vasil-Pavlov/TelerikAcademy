using System;
using System.Text;

class ExtractPalindromes
{
    static void Main()
    {
        string text = "proba 121 fsdghdh asddsa exe ullu fsafsaf Petar fAGSgagasg";
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            bool isTrue = true;
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isTrue = false;
                }
            }
            if (isTrue)
            {
                Console.WriteLine(word);
            }
        }
    }
}

