using System;

class ExchangeNumericalValues
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int exchanger;

        if (firstNumber>secondNumber)
        {
            exchanger = firstNumber;
            firstNumber = secondNumber;
            secondNumber = exchanger;
        }
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}

