using System;
using System.Collections.Generic;

class MaximumSumOfK
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int K = int.Parse(Console.ReadLine());

        int checkedNumbers = 0;
        List<int> subsetNumbers = new List<int>();
        int maximalLoops = (int)Math.Pow(2, array.Length) - 1;
        int maxSum = int.MinValue;
        int[] maxSumArray = new int[K];

        for (int i = 1; i <= maximalLoops; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= array.Length; j++)
            {
                int check=(i >> (j - 1) & 1);

                if (check== 1)
                {
                    currentSum += array[j - 1];
                    checkedNumbers++;
                    subsetNumbers.Add(array[j - 1]);
                }
            }

            if (checkedNumbers == K && currentSum > maxSum)
            {
                maxSum = currentSum;
                for (int k = 0; k < maxSumArray.Length; k++)
                {
                    maxSumArray[k] = subsetNumbers[k];
                }
            }
            subsetNumbers.Clear();
            checkedNumbers = 0;
        }

        if (maxSum > int.MinValue)
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write(maxSumArray[i] + " ");
            }
        }
        else
        {
            Console.Write("No such subset.");
        }
        Console.WriteLine();
    }
}
