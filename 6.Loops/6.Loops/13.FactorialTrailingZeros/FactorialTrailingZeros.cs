using System;
using System.Numerics;

class FactorialTrailingZeros
{
    static BigInteger ComputeFactorial(int number)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 2; i <= n; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
            if (i % 25 == 0)
            {
                count++;
            }
            if (i % 125 == 0)
            {
                count++;
            }
            if (i % 625 == 0)
            {
                count++;
            }
            if (i % (625 * 5) == 0)
            {
                count++;
            }
            if (i % (25 * 625) == 0)
            {
                count++;
            }
        }
        Console.WriteLine("{0}!={1}=>{2}",n,ComputeFactorial(n),count);
    }
}

