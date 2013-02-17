using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyrightSymbol = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("  " + copyrightSymbol + "  ");
        Console.WriteLine(" " + new string(copyrightSymbol, 3) + " ");
        Console.WriteLine(new string(copyrightSymbol, 5));
    }
}