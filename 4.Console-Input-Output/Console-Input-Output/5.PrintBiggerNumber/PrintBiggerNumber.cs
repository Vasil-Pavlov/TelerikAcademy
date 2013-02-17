using System;
using System.Linq;

class PrintBiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(firstNumber,secondNumber));
    }
}

