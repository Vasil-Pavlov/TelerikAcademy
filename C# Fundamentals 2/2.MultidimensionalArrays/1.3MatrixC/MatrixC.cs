using System;

class MatrixC
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int[,] matrix = new int[n, n];

        for (int j = 1; j <= n; j++)
        {
            for (int i = 0; i < j; i++)
            {
                matrix[n - j + i, i] = count;
                count++;
            }
        }
        for (int j = n - 1; j >= 0; j--)
        {
            for (int i = 0; i < j; i++)
            {
                matrix[i, -j + n + i] = count;
                count++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

