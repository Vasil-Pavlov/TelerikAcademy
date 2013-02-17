using System;
using System.Text;

class Encryption
{
    static void Main()
    {
        string cipher = "#%$%#DG$#$";
        string str = "Tova e proba, let's test";
        StringBuilder newStr = new StringBuilder();
        StringBuilder oldStr = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            newStr.Append((char)(str[i] ^ cipher[i % cipher.Length]));
        }
        Console.WriteLine(newStr);

        for (int i = 0; i < newStr.Length; i++)
        {
            oldStr.Append((char)(newStr[i] ^ cipher[i % cipher.Length]));
        }
        Console.WriteLine(oldStr);
    }
}

