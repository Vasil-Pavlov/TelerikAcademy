﻿using System;

class CatalanNumbers
{
    static int ComputeFactorial(int number)
    {
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(ComputeFactorial(2*number)/(ComputeFactorial(number+1)*ComputeFactorial(number)));
    }
}

