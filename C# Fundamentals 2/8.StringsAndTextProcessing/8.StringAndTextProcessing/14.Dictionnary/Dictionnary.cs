using System;
using System.Text;

class Dictionnary
{
    static void Main()
    {
        string dictionnary = ".NET – platform for applications from Microsoft \nCLR – managed execution environment for .NET \n namespace - hierarchical organization of classes";
        string word = "namespace";
        int begin = dictionnary.IndexOf(word + " -");

        if (begin > 0)
        {
            int end = dictionnary.IndexOf("\n", begin + 1);
            if (end > 0)
            {
                Console.WriteLine(dictionnary.Substring(begin, end));
            }
            else
            {
                Console.WriteLine(dictionnary.Substring(begin, dictionnary.Length - begin));
            }
        }
    }
}

