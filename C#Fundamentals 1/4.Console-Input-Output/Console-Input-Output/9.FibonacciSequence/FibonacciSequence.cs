using System;

class FibonacciSequence
{
    static void Main()
    {
        int numbers = 100;
        ulong previousNumber = 0;
        ulong currentNumber = 1;
        ulong buffer = 0;

        Console.Write("{0}",1);

        for (int i = 1; i < numbers; i++)
        {
            buffer = currentNumber;
            currentNumber = currentNumber + previousNumber;
            previousNumber = buffer;
            Console.Write(" {0} ",currentNumber);
        }
    }     
}

