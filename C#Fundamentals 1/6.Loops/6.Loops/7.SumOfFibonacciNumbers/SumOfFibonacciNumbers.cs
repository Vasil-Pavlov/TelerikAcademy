using System;

class SumOfFibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;
        int previousValue = 0;
        int currentValue = 1;
        int nextValue;

        for (int i = 3; i <= n; i++)
        {
            nextValue = previousValue + currentValue;
            previousValue = currentValue;
            currentValue = nextValue;
            sum += nextValue;
        }
        Console.WriteLine("The sum of the first {0} numbers of Fibonacci sequence is : {1}",n,sum);
    }
}

