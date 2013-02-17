using System;

class ExchangeValues
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        Console.WriteLine("Before exchanging:{0},{1}",firstNumber,secondNumber);
        int exchanger = firstNumber;
        firstNumber = secondNumber;
        secondNumber = exchanger;
        Console.WriteLine("After exchanging:{0},{1}",firstNumber,secondNumber);
    }
}

