using System;

class ParticularSumS
{
    static void Main()
    {
        int[] array = { -1, 12, -31, 12, 3, 5, 32, 52, 2, 4, 3, 7, 2, -5, 11, 2, 4, 3, 5, 121, 16 };
        int maximalLoops = (int)Math.Pow(2, array.Length) - 1;
        int S = int.Parse(Console.ReadLine());
        bool hasSum = false;

        for (int i = 1; i <= maximalLoops; i++)
        {
            int currentSum = 0;
            for (int j = 1; j <= array.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += array[j - 1];
                }
            }
            if (currentSum == S)
            {
                hasSum = true;
            }
        }

        if (hasSum)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}