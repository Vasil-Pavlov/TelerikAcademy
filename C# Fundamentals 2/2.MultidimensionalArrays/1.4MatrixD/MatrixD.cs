using System;

class MatrixD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int step = n;
        int countStep = 1;
        int i = 0, j = -1;
        int[,] matrix = new int[n, n];

        while (count <= n * n)
        {
            if (countStep % 2 == 0)
                step--;
            for (int k = 0; k < step; k++)
            {

                if (countStep % 4 == 1)
                    j++;
                if (countStep % 4 == 2)
                    i++;
                if (countStep % 4 == 3)
                    j--;
                if (countStep % 4 == 0)
                    i--;
                matrix[j, i] = count;
                count++;
            }
            countStep++;
        }

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

