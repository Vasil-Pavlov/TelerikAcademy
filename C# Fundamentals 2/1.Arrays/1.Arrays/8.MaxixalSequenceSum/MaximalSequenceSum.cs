using System;

class MaximalSequenceSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxSum = int.MinValue;
        int sum = 0;
        int start = 0;
        int end = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum < 0)
            {
                sum = 0;
                start = i + 1;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
            }
        }

        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}