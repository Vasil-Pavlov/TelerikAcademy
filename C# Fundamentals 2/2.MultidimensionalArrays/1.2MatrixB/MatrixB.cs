using System;

class MatrixB
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j, i] = count;
                    count++;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    arr[j, i] = count;
                    count++;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
