using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;
        int count = 1;
        int step = n;
        int countStep = 1;
        int row = 0;
        int column = -1;
        int[,] matrix = new int[n, n];

        while (count <= n * n)
        {
            if (countStep % 2 == 0)
            {
                step--;
            }

            for (int k = 0; k < step; k++)
            {
                if (countStep % 4 == 1)
                {
                    column++;
                }
                if (countStep % 4 == 2)
                {
                    row++;
                }
                if (countStep % 4 == 3)
                {
                    column--;
                }
                if (countStep % 4 == 0)
                {
                    row--;
                }
                matrix[row, column] = count;
                count++;
            }
            countStep++;

        }
        for (row = 0; row < n; row++)
        {
            for (column = 0; column < n; column++)
            {
                Console.Write("{0,4}", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}

