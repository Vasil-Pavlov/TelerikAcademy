using System;

class DivisibleBy5InAnInterval
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber<secondNumber)
        {
            int storageOfDivisibles=0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i%5==0)
                {
                    storageOfDivisibles++;
                }
            }
            Console.WriteLine(storageOfDivisibles);
        }
    }
}

