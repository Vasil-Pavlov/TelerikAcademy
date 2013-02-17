using System;

class ComputeSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int buffer = 0;

        for (int i = 0; i < n; i++)
        {
            buffer = int.Parse(Console.ReadLine());
            sum = sum + buffer;
        }
        Console.WriteLine(sum);
    }
}


