using System;

class HelloWorld
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "Word";
        object result = firstWord + " " + secondWord;
        string stringresult = (string)result;
    }
}

