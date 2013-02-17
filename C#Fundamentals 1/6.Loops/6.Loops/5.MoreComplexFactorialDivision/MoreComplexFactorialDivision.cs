using System;

class MoreComplexFactorialDivision
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
        int K = int.Parse(Console.ReadLine());

        if (N > 1 && K > N)
        {
            Console.WriteLine("N!*K!/(K-N)!={0}",Math.Round((ComputeFactorial(N)*ComputeFactorial(K))/ComputeFactorial(K-N)),2);
        }
        else
        {
            Console.WriteLine("N should be smaller than K.");
        }
    }
}

