using System;
using System.Linq;

class SumOfFractions
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i < n; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum - 1.0 / (i + 1);
            }
            else if (i % 2 == 1)
            {
                sum = sum + 1.0 / (i + 1);
            }
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}

