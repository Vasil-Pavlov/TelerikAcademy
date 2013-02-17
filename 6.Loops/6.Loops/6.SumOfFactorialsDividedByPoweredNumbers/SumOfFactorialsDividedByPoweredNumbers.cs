using System;

class SumOfFactorialsDividedByPoweredNumbers
{  
    static double ComputeFactorial(int number)
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
        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine("1+N!/X to the nth={0}", 1+(ComputeFactorial(N)/Math.Pow(X,N)));
    }
}

