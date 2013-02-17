using System;
using System.Numerics;

class Factorial_
{
    static BigInteger Factoriel(int number)
    {
        BigInteger factoriel = 1;
        while (true)
        {
            if (number <= 1)
            {
                break;
            }
            factoriel *= (number);
            number--;
        }
        return factoriel;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Factoriel(number));
    }
}

